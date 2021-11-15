using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DnD.Objects;
using System.Text.Json;
using DnD.Rolls;
using Smyers.Extensions;
using DnD.Models.Models;

namespace DnD_Hub
{
    public partial class Form1 : Form
    {
        private BindingList<SavingThrow> _savingThrows = new BindingList<SavingThrow>();

        private BindingList<Skill> _skills = new BindingList<Skill>();

        private BindingList<DnD.Objects.Action> _actions = new BindingList<DnD.Objects.Action>();

        private Character _character;

        private string _profileLocation = string.Empty;
        private string _profileName = string.Empty;

        private int _actionDgvRollCellIndex = 1;
        private int _savingThrowsDvgRollCellIndex = 1;

        public Form1()
        {
            InitializeComponent();
            BindDataGridViews();
        }

        private void BindDataGridViews()
        {
            // Skills
            DGV_Skills.AutoGenerateColumns = true;
            BindingSource bs_Skills = new BindingSource
            {
                DataSource = _skills
            };

            DGV_Skills.DataSource = bs_Skills;

            // Actions
            DGV_Actions.AutoGenerateColumns = true;
            BindingSource bs_Actions = new BindingSource
            {
                DataSource = _actions
            };

            DGV_Actions.DataSource = bs_Actions;

            // Saving throws
            DGV_SavingThrows.AutoGenerateColumns = true;
            BindingSource bs_SavingThrows = new BindingSource
            {
                DataSource = _savingThrows
            };

            DGV_SavingThrows.DataSource = bs_SavingThrows;
        }

        private void ApplyDataGridViewBindings()
        {
            DGV_Skills.DataSource = _skills;
            DGV_Actions.DataSource = _actions;
            DGV_SavingThrows.DataSource = _savingThrows;
        }

        private void RefreshDataGridViews()
        {
            // This does not work
            DGV_Actions.Refresh();
            DGV_SavingThrows.Refresh();
            DGV_Skills.Refresh();
        }

        private void LoadProfile(object sender, EventArgs e)
        {
            var profileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    _profileLocation = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    // Store file name for saving use
                    _profileName = openFileDialog.FileName;
                    using StreamReader reader = new StreamReader(fileStream);
                    profileContent = reader.ReadToEnd();
                    reader.Close();
                }
            }

            if (string.IsNullOrEmpty(profileContent))
            {
                // come back to this
                return;
            }

            var characterData = JsonSerializer.Deserialize<CharacterSheet>(profileContent);//JsonConvert.DeserializeObject<CharacterSheet>(profileContent);

            _actions = characterData.Actions;
            _savingThrows = characterData.SavingThrows;
            _skills = characterData.Skills;
            _character = characterData.Character;

            RefreshDataGridViews();
            LoadCharacterData();
            ApplyDataGridViewBindings();
        }

        private void LoadCharacterData()
        {
            tb_Name.Text = _character.Name;
            tb_Level.Text = _character.Level.ToString();
            tb_CurrentHP.Text = _character.CurrentHP.ToString();
            tb_MaxHP.Text = _character.MaximumHP.ToString();
            tb_ArmorClass.Text = _character.ArmorClass.ToString();
            tb_Initiative.Text = _character.Initiative.ToString();
            tb_WalkingSpeed.Text = _character.WalkingSpeed.ToString();
        }

        private void SaveProfile(object sender, EventArgs e)
        {
            _character = GenerateCharacterData();

            var value = new CharacterSheet
            {
                Character = _character,
                Actions = _actions,
                Skills = _skills,
                SavingThrows = _savingThrows
            };
            //   var characterSheet = JsonConvert.SerializeObject(value);
            string json = JsonSerializer.Serialize(value);
            // If the user is loading a previously saved profile, then overwrite it
            // Could change this behavior in the future, but this is the most common use case
            if (!string.IsNullOrEmpty(_profileLocation))
            {
                File.WriteAllText(_profileName, json);
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "json files (*.json)|*.json",
                FileName = $"{_character.Name} - Level {_character.Level}",
                RestoreDirectory = true
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveDialog.FileName))
                {
                    File.Delete(saveDialog.FileName);
                }

                // if ((saveStream = saveDialog.OpenFile()) != null)
                // {
                try
                {
                    // using FileStream createStream = File.Create(saveDialog.FileName);

                    File.WriteAllText(saveDialog.FileName, json);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // }
            }
        }

        private Character GenerateCharacterData()
        {
            var character = new Character
            {
                Name = tb_Name.Text
            };

            if (int.TryParse(tb_Level.Text, out int level))
            {
                character.Level = level;
            }
            if (int.TryParse(tb_CurrentHP.Text, out int currentHp))
            {
                character.CurrentHP = currentHp;
            }
            if (int.TryParse(tb_MaxHP.Text, out int maxHp))
            {
                character.MaximumHP = maxHp;
            }
            if (int.TryParse(tb_ArmorClass.Text, out int armorClass))
            {
                character.ArmorClass = armorClass;
            }
            if (int.TryParse(tb_WalkingSpeed.Text, out int walkingSpeed))
            {
                character.WalkingSpeed = walkingSpeed;
            }
            if (int.TryParse(tb_Initiative.Text, out int initiative))
            {
                character.Initiative = initiative;
            }

            return character;
        }

        private void GenerateDataGridViewHeaders(object sender, EventArgs e)
        {
            _skills = new BindingList<Skill>(SeedData.GenerateSkillsSeedData());
            _actions = new BindingList<DnD.Objects.Action>(SeedData.GenerateActionsSeedData());
            _savingThrows = new BindingList<SavingThrow>(SeedData.GenerateSavingThrowsSeedData());
            ApplyDataGridViewBindings();
        }

        private void DGV_Actions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProcessDgvRowForRoll(DGV_Actions.Rows[e.RowIndex], _actionDgvRollCellIndex);
        }

        private void ManualRoll(object sender, EventArgs e)
        {
            var rollResults = ParseRoll.GetRollResultsFromString(tb_manualRollString.Text);
            UpdateRollResultsOnUI(rollResults);
        }

        private void UpdateRollResultsOnUI(RollResults rollResults)
        {
            lbl_individualRolls.Text = rollResults.IndividualRolls.CommaDelimitAndSpace();
            lbl_rollResult.Text = rollResults.Total.ToString();
        }

        private void ProcessDgvRowForRoll(DataGridViewRow row, int columnIndex)
        {
            var rollResults = ParseRoll.GetRollResultsFromString(row.Cells[columnIndex].Value.ToString());
            UpdateRollResultsOnUI(rollResults);
        }

        private void DGV_SavingThrows_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProcessDgvRowForRoll(DGV_SavingThrows.Rows[e.RowIndex], _savingThrowsDvgRollCellIndex);
        }

        private void DGV_Abilities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProcessDvgValueForD20Roll(DGV_Abilities.Rows[e.RowIndex], _abilitiesDvgRollCellIndex);
        }

        private void ProcessDvgValueForD20Roll(DataGridViewRow row, int columnIndex)
        {
            var rollString = $"1d20{ProcessRollValue(row.Cells[columnIndex].Value.ToString())}";
            var rollResults = ParseRoll.GetRollResultsFromString(rollString);
            UpdateRollResultsOnUI(rollResults);
        }

        private string ProcessRollValue(string rollValue)
        {
            var isParseable = int.TryParse(rollValue, out var value);
            if (isParseable)
            {
                if (value == 0)
                {
                    return string.Empty;
                }
                return value > 0 ? $"+{value}" : $"-{value}";
            }

            return string.Empty;
        }

        private void btn_OpenListOfThings_Click(object sender, EventArgs e)
        {
            lb_Links.Items.Clear();
            string[] files = FileIO.openListOfThings();
            foreach (string file in files)
            {
                openedItemsListBox.Items.Add(file);
            }
        }
    }
}
