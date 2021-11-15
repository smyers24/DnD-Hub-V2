
namespace DnD_Hub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_SavingThrows = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Links = new System.Windows.Forms.ListBox();
            this.btn_OpenListOfThings = new System.Windows.Forms.Button();
            this.DGV_Skills = new System.Windows.Forms.DataGridView();
            this.DGV_Actions = new System.Windows.Forms.DataGridView();
            this.btn_LoadProfile = new System.Windows.Forms.Button();
            this.btn_SaveProfile = new System.Windows.Forms.Button();
            this.gb_Skills = new System.Windows.Forms.GroupBox();
            this.gb_Actions = new System.Windows.Forms.GroupBox();
            this.gb_SavingThrows = new System.Windows.Forms.GroupBox();
            this.gb_Character = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MaxHP = new System.Windows.Forms.TextBox();
            this.tb_WalkingSpeed = new System.Windows.Forms.TextBox();
            this.tb_Initiative = new System.Windows.Forms.TextBox();
            this.tb_ArmorClass = new System.Windows.Forms.TextBox();
            this.tb_CurrentHP = new System.Windows.Forms.TextBox();
            this.tb_Level = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_SeedData = new System.Windows.Forms.Button();
            this.tb_manualRollString = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_saveManualRoll = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_manualRollResult = new System.Windows.Forms.Label();
            this.btn_manualRoll = new System.Windows.Forms.Button();
            this.lbl_rollResult = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_individualRolls = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_Abilities = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SavingThrows)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Skills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Actions)).BeginInit();
            this.gb_Skills.SuspendLayout();
            this.gb_Actions.SuspendLayout();
            this.gb_SavingThrows.SuspendLayout();
            this.gb_Character.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Abilities)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_SavingThrows
            // 
            this.DGV_SavingThrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SavingThrows.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DGV_SavingThrows.Location = new System.Drawing.Point(6, 22);
            this.DGV_SavingThrows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGV_SavingThrows.Name = "DGV_SavingThrows";
            this.DGV_SavingThrows.RowTemplate.Height = 25;
            this.DGV_SavingThrows.Size = new System.Drawing.Size(262, 320);
            this.DGV_SavingThrows.TabIndex = 0;
            this.DGV_SavingThrows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_SavingThrows_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Links);
            this.groupBox1.Controls.Add(this.btn_OpenListOfThings);
            this.groupBox1.Location = new System.Drawing.Point(379, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(223, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lb_Links
            // 
            this.lb_Links.FormattingEnabled = true;
            this.lb_Links.ItemHeight = 15;
            this.lb_Links.Location = new System.Drawing.Point(18, 61);
            this.lb_Links.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lb_Links.Name = "lb_Links";
            this.lb_Links.Size = new System.Drawing.Size(179, 49);
            this.lb_Links.TabIndex = 1;
            // 
            // btn_OpenListOfThings
            // 
            this.btn_OpenListOfThings.Location = new System.Drawing.Point(42, 22);
            this.btn_OpenListOfThings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_OpenListOfThings.Name = "btn_OpenListOfThings";
            this.btn_OpenListOfThings.Size = new System.Drawing.Size(122, 23);
            this.btn_OpenListOfThings.TabIndex = 0;
            this.btn_OpenListOfThings.Text = "Open List of Things";
            this.btn_OpenListOfThings.UseVisualStyleBackColor = true;
            this.btn_OpenListOfThings.Click += new System.EventHandler(this.btn_OpenListOfThings_Click);
            // 
            // DGV_Skills
            // 
            this.DGV_Skills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Skills.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DGV_Skills.Location = new System.Drawing.Point(6, 22);
            this.DGV_Skills.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGV_Skills.Name = "DGV_Skills";
            this.DGV_Skills.RowTemplate.Height = 25;
            this.DGV_Skills.Size = new System.Drawing.Size(603, 528);
            this.DGV_Skills.TabIndex = 0;
            // 
            // DGV_Actions
            // 
            this.DGV_Actions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Actions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DGV_Actions.Location = new System.Drawing.Point(6, 22);
            this.DGV_Actions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGV_Actions.Name = "DGV_Actions";
            this.DGV_Actions.RowTemplate.Height = 25;
            this.DGV_Actions.Size = new System.Drawing.Size(240, 320);
            this.DGV_Actions.TabIndex = 0;
            this.DGV_Actions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Actions_CellContentClick);
            // 
            // btn_LoadProfile
            // 
            this.btn_LoadProfile.Location = new System.Drawing.Point(14, 20);
            this.btn_LoadProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_LoadProfile.Name = "btn_LoadProfile";
            this.btn_LoadProfile.Size = new System.Drawing.Size(102, 23);
            this.btn_LoadProfile.TabIndex = 2;
            this.btn_LoadProfile.Text = "Load Profile";
            this.btn_LoadProfile.UseVisualStyleBackColor = true;
            this.btn_LoadProfile.Click += new System.EventHandler(this.LoadProfile);
            // 
            // btn_SaveProfile
            // 
            this.btn_SaveProfile.Location = new System.Drawing.Point(14, 63);
            this.btn_SaveProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SaveProfile.Name = "btn_SaveProfile";
            this.btn_SaveProfile.Size = new System.Drawing.Size(102, 23);
            this.btn_SaveProfile.TabIndex = 2;
            this.btn_SaveProfile.Text = "Save Profile";
            this.btn_SaveProfile.UseVisualStyleBackColor = true;
            this.btn_SaveProfile.Click += new System.EventHandler(this.SaveProfile);
            // 
            // gb_Skills
            // 
            this.gb_Skills.Controls.Add(this.DGV_Skills);
            this.gb_Skills.Location = new System.Drawing.Point(609, 20);
            this.gb_Skills.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Skills.Name = "gb_Skills";
            this.gb_Skills.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Skills.Size = new System.Drawing.Size(617, 557);
            this.gb_Skills.TabIndex = 3;
            this.gb_Skills.TabStop = false;
            this.gb_Skills.Text = "Skills";
            // 
            // gb_Actions
            // 
            this.gb_Actions.Controls.Add(this.DGV_Actions);
            this.gb_Actions.Location = new System.Drawing.Point(14, 236);
            this.gb_Actions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Actions.Name = "gb_Actions";
            this.gb_Actions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Actions.Size = new System.Drawing.Size(261, 334);
            this.gb_Actions.TabIndex = 4;
            this.gb_Actions.TabStop = false;
            this.gb_Actions.Text = "Actions";
            // 
            // gb_SavingThrows
            // 
            this.gb_SavingThrows.Controls.Add(this.DGV_SavingThrows);
            this.gb_SavingThrows.Location = new System.Drawing.Point(326, 236);
            this.gb_SavingThrows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_SavingThrows.Name = "gb_SavingThrows";
            this.gb_SavingThrows.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_SavingThrows.Size = new System.Drawing.Size(276, 334);
            this.gb_SavingThrows.TabIndex = 5;
            this.gb_SavingThrows.TabStop = false;
            this.gb_SavingThrows.Text = "Saving Throws";
            // 
            // gb_Character
            // 
            this.gb_Character.Controls.Add(this.label2);
            this.gb_Character.Controls.Add(this.label6);
            this.gb_Character.Controls.Add(this.label5);
            this.gb_Character.Controls.Add(this.label4);
            this.gb_Character.Controls.Add(this.label3);
            this.gb_Character.Controls.Add(this.label7);
            this.gb_Character.Controls.Add(this.label1);
            this.gb_Character.Controls.Add(this.tb_MaxHP);
            this.gb_Character.Controls.Add(this.tb_WalkingSpeed);
            this.gb_Character.Controls.Add(this.tb_Initiative);
            this.gb_Character.Controls.Add(this.tb_ArmorClass);
            this.gb_Character.Controls.Add(this.tb_CurrentHP);
            this.gb_Character.Controls.Add(this.tb_Level);
            this.gb_Character.Controls.Add(this.tb_Name);
            this.gb_Character.Location = new System.Drawing.Point(122, 20);
            this.gb_Character.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Character.Name = "gb_Character";
            this.gb_Character.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Character.Size = new System.Drawing.Size(250, 196);
            this.gb_Character.TabIndex = 6;
            this.gb_Character.TabStop = false;
            this.gb_Character.Text = "Character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Walking Speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Initiative:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Armor Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "HP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Level:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // tb_MaxHP
            // 
            this.tb_MaxHP.Location = new System.Drawing.Point(162, 77);
            this.tb_MaxHP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_MaxHP.Name = "tb_MaxHP";
            this.tb_MaxHP.Size = new System.Drawing.Size(64, 23);
            this.tb_MaxHP.TabIndex = 0;
            // 
            // tb_WalkingSpeed
            // 
            this.tb_WalkingSpeed.Location = new System.Drawing.Point(104, 164);
            this.tb_WalkingSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_WalkingSpeed.Name = "tb_WalkingSpeed";
            this.tb_WalkingSpeed.Size = new System.Drawing.Size(66, 23);
            this.tb_WalkingSpeed.TabIndex = 0;
            // 
            // tb_Initiative
            // 
            this.tb_Initiative.Location = new System.Drawing.Point(90, 135);
            this.tb_Initiative.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Initiative.Name = "tb_Initiative";
            this.tb_Initiative.Size = new System.Drawing.Size(66, 23);
            this.tb_Initiative.TabIndex = 0;
            // 
            // tb_ArmorClass
            // 
            this.tb_ArmorClass.Location = new System.Drawing.Point(90, 106);
            this.tb_ArmorClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_ArmorClass.Name = "tb_ArmorClass";
            this.tb_ArmorClass.Size = new System.Drawing.Size(66, 23);
            this.tb_ArmorClass.TabIndex = 0;
            // 
            // tb_CurrentHP
            // 
            this.tb_CurrentHP.Location = new System.Drawing.Point(54, 77);
            this.tb_CurrentHP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_CurrentHP.Name = "tb_CurrentHP";
            this.tb_CurrentHP.Size = new System.Drawing.Size(66, 23);
            this.tb_CurrentHP.TabIndex = 0;
            // 
            // tb_Level
            // 
            this.tb_Level.Location = new System.Drawing.Point(54, 50);
            this.tb_Level.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Level.Name = "tb_Level";
            this.tb_Level.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_Level.Size = new System.Drawing.Size(42, 23);
            this.tb_Level.TabIndex = 0;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(54, 23);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_Name.Size = new System.Drawing.Size(172, 23);
            this.tb_Name.TabIndex = 0;
            // 
            // btn_SeedData
            // 
            this.btn_SeedData.Location = new System.Drawing.Point(12, 107);
            this.btn_SeedData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SeedData.Name = "btn_SeedData";
            this.btn_SeedData.Size = new System.Drawing.Size(102, 41);
            this.btn_SeedData.TabIndex = 2;
            this.btn_SeedData.Text = "Generate Seed Data";
            this.btn_SeedData.UseVisualStyleBackColor = true;
            this.btn_SeedData.Click += new System.EventHandler(this.GenerateDataGridViewHeaders);
            // 
            // tb_manualRollString
            // 
            this.tb_manualRollString.Location = new System.Drawing.Point(88, 644);
            this.tb_manualRollString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_manualRollString.Name = "tb_manualRollString";
            this.tb_manualRollString.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_manualRollString.Size = new System.Drawing.Size(222, 23);
            this.tb_manualRollString.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 626);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Roll String";
            // 
            // cb_saveManualRoll
            // 
            this.cb_saveManualRoll.AutoSize = true;
            this.cb_saveManualRoll.Location = new System.Drawing.Point(317, 648);
            this.cb_saveManualRoll.Name = "cb_saveManualRoll";
            this.cb_saveManualRoll.Size = new System.Drawing.Size(75, 19);
            this.cb_saveManualRoll.TabIndex = 8;
            this.cb_saveManualRoll.Text = "Save roll?";
            this.cb_saveManualRoll.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 670);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Total: ";
            // 
            // lbl_manualRollResult
            // 
            this.lbl_manualRollResult.AutoSize = true;
            this.lbl_manualRollResult.Location = new System.Drawing.Point(130, 670);
            this.lbl_manualRollResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_manualRollResult.Name = "lbl_manualRollResult";
            this.lbl_manualRollResult.Size = new System.Drawing.Size(0, 15);
            this.lbl_manualRollResult.TabIndex = 7;
            // 
            // btn_manualRoll
            // 
            this.btn_manualRoll.Location = new System.Drawing.Point(88, 688);
            this.btn_manualRoll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_manualRoll.Name = "btn_manualRoll";
            this.btn_manualRoll.Size = new System.Drawing.Size(102, 23);
            this.btn_manualRoll.TabIndex = 2;
            this.btn_manualRoll.Text = "Manual Roll";
            this.btn_manualRoll.UseVisualStyleBackColor = true;
            this.btn_manualRoll.Click += new System.EventHandler(this.ManualRoll);
            // 
            // lbl_rollResult
            // 
            this.lbl_rollResult.AutoSize = true;
            this.lbl_rollResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_rollResult.Location = new System.Drawing.Point(544, 632);
            this.lbl_rollResult.Name = "lbl_rollResult";
            this.lbl_rollResult.Size = new System.Drawing.Size(0, 37);
            this.lbl_rollResult.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(453, 688);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Individual Rolls:";
            // 
            // lbl_individualRolls
            // 
            this.lbl_individualRolls.AutoSize = true;
            this.lbl_individualRolls.Location = new System.Drawing.Point(551, 688);
            this.lbl_individualRolls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_individualRolls.Name = "lbl_individualRolls";
            this.lbl_individualRolls.Size = new System.Drawing.Size(0, 15);
            this.lbl_individualRolls.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 581);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(466, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Actions, Saving Throws, and Skills can be edited by pressing F2 in their respecti" +
    "ve boxes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_Abilities);
            this.groupBox2.Location = new System.Drawing.Point(609, 603);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 241);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abilities";
            // 
            // DGV_Abilities
            // 
            this.DGV_Abilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Abilities.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DGV_Abilities.Location = new System.Drawing.Point(14, 22);
            this.DGV_Abilities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGV_Abilities.Name = "DGV_Abilities";
            this.DGV_Abilities.RowTemplate.Height = 25;
            this.DGV_Abilities.Size = new System.Drawing.Size(785, 197);
            this.DGV_Abilities.TabIndex = 0;
            this.DGV_Abilities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Abilities_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 1044);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_rollResult);
            this.Controls.Add(this.cb_saveManualRoll);
            this.Controls.Add(this.gb_Character);
            this.Controls.Add(this.gb_SavingThrows);
            this.Controls.Add(this.gb_Actions);
            this.Controls.Add(this.gb_Skills);
            this.Controls.Add(this.btn_manualRoll);
            this.Controls.Add(this.btn_SaveProfile);
            this.Controls.Add(this.lbl_manualRollResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_SeedData);
            this.Controls.Add(this.lbl_individualRolls);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_LoadProfile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_manualRollString);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SavingThrows)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Skills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Actions)).EndInit();
            this.gb_Skills.ResumeLayout(false);
            this.gb_Actions.ResumeLayout(false);
            this.gb_SavingThrows.ResumeLayout(false);
            this.gb_Character.ResumeLayout(false);
            this.gb_Character.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Abilities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_SavingThrows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_Links;
        private System.Windows.Forms.Button btn_OpenListOfThings;
        private System.Windows.Forms.DataGridView DGV_Skills;
        private System.Windows.Forms.DataGridView DGV_Actions;
        private System.Windows.Forms.Button btn_LoadProfile;
        private System.Windows.Forms.Button btn_SaveProfile;
        private System.Windows.Forms.GroupBox gb_Skills;
        private System.Windows.Forms.GroupBox gb_Actions;
        private System.Windows.Forms.GroupBox gb_SavingThrows;
        private System.Windows.Forms.GroupBox gb_Character;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MaxHP;
        private System.Windows.Forms.TextBox tb_CurrentHP;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_WalkingSpeed;
        private System.Windows.Forms.TextBox tb_Initiative;
        private System.Windows.Forms.TextBox tb_ArmorClass;
        private System.Windows.Forms.Button btn_SeedData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Level;
        private System.Windows.Forms.TextBox tb_manualRollString;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_saveManualRoll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_manualRollResult;
        private System.Windows.Forms.Button btn_manualRoll;
        private System.Windows.Forms.Label lbl_rollResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_individualRolls;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_Abilities;
    }
}

