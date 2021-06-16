using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
                }
            }

            if (string.IsNullOrEmpty(profileContent))
            {
                // come back to this
                return;
            }

            var characterData = JsonConvert.DeserializeObject<CharacterSheet>(profileContent);

            _actions = characterData.Actions;
            _savingThrows = characterData.SavingThrows;
            _skills = characterData.Skills;
            _character = characterData.Character;

            RefreshDataGridViews();
            LoadCharacterData();
        }

        private void LoadCharacterData()
        {
            tb_Name.Text = _character.Name;
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
            var characterSheet = JsonConvert.SerializeObject(value);

            Stream saveStream;
            // If the user is loading a previously saved profile, then overwrite it
            // Could change this behavior in the future, but this is the most common use case
            if (!string.IsNullOrEmpty(_profileLocation))
            {
                saveStream = new Stream(_profileLocation);
                File.WriteAllText(_profileName, characterSheet);
                saveStream.Close();
            }


            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "json files (*.json)|*.json",             
                FileName = $"{_character.Name} - Level {_character.Level} - {DateTime.Now}",
                RestoreDirectory = true
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if ((saveStream = saveDialog.OpenFile()) != null)
                {
                    File.WriteAllText(saveDialog.FileName, characterSheet);
                    saveStream.Close();
                }
            }           
        }

        private Character GenerateCharacterData()
        {
            var character = new Character
            {
                Name = tb_Name.Text,
                CurrentHP = int.Parse(tb_CurrentHP.Text),
                MaximumHP = int.Parse(tb_MaxHP.Text),
                ArmorClass = int.Parse(tb_ArmorClass.Text),
                WalkingSpeed = int.Parse(tb_WalkingSpeed.Text),
                Initiative = int.Parse(tb_Initiative.Text)
            };

            return character;
        }

        private void GenerateDataGridViewHeaders(object sender, EventArgs e)
        {
            _skills = (BindingList<Skill>)SeedData.GenerateSkillsSeedData();
            _actions = (BindingList<DnD.Objects.Action>)SeedData.GenerateActionsSeedData();
            _savingThrows = (BindingList<SavingThrow>)SeedData.GenerateSavingThrowsSeedData();
        }
    }
}
