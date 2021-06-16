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

        public Form1()
        {
            InitializeComponent();
            //GenerateDataGridViewHeaders();
            BindDataGridViews();
        }

        private void GenerateDataGridViewHeaders()
        {
        //    _skills = SeedData.GenerateSkillsSeedData();
       //     _actions = SeedData.GenerateActionsSeedData();
      //      _savingThrows = SeedData.GenerateSavingThrowsSeedData();
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
            DGV_Actions.Refresh();
            DGV_SavingThrows.Refresh();
            DGV_Skills.Refresh();
        }

        private void LoadProfile(object sender, EventArgs e)
        {
            var profileJSON = File.ReadAllText("character.json");
            var characterData = JsonConvert.DeserializeObject<CharacterSheet>(profileJSON);

            _actions = characterData.Actions;
            _savingThrows = characterData.SavingThrows;
            _skills = characterData.Skills;
            _character = characterData.Character;

            RefreshDataGridViews();
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
            var output = JsonConvert.SerializeObject(value);
            File.WriteAllText("character.json", output);
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
    }
}
