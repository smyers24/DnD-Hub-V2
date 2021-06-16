
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MaxHP = new System.Windows.Forms.TextBox();
            this.tb_WalkingSpeed = new System.Windows.Forms.TextBox();
            this.tb_Initiative = new System.Windows.Forms.TextBox();
            this.tb_ArmorClass = new System.Windows.Forms.TextBox();
            this.tb_CurrentHP = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_SeedData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SavingThrows)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Skills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Actions)).BeginInit();
            this.gb_Skills.SuspendLayout();
            this.gb_Actions.SuspendLayout();
            this.gb_SavingThrows.SuspendLayout();
            this.gb_Character.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_SavingThrows
            // 
            this.DGV_SavingThrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SavingThrows.Location = new System.Drawing.Point(6, 22);
            this.DGV_SavingThrows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGV_SavingThrows.Name = "DGV_SavingThrows";
            this.DGV_SavingThrows.RowTemplate.Height = 25;
            this.DGV_SavingThrows.Size = new System.Drawing.Size(262, 320);
            this.DGV_SavingThrows.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(379, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(223, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(18, 61);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 49);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open List of Things";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DGV_Skills
            // 
            this.DGV_Skills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.DGV_Actions.Location = new System.Drawing.Point(6, 22);
            this.DGV_Actions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGV_Actions.Name = "DGV_Actions";
            this.DGV_Actions.RowTemplate.Height = 25;
            this.DGV_Actions.Size = new System.Drawing.Size(240, 320);
            this.DGV_Actions.TabIndex = 0;
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
            this.gb_Actions.Location = new System.Drawing.Point(14, 222);
            this.gb_Actions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Actions.Name = "gb_Actions";
            this.gb_Actions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Actions.Size = new System.Drawing.Size(261, 348);
            this.gb_Actions.TabIndex = 4;
            this.gb_Actions.TabStop = false;
            this.gb_Actions.Text = "Actions";
            // 
            // gb_SavingThrows
            // 
            this.gb_SavingThrows.Controls.Add(this.DGV_SavingThrows);
            this.gb_SavingThrows.Location = new System.Drawing.Point(326, 222);
            this.gb_SavingThrows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_SavingThrows.Name = "gb_SavingThrows";
            this.gb_SavingThrows.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_SavingThrows.Size = new System.Drawing.Size(276, 348);
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
            this.gb_Character.Controls.Add(this.label1);
            this.gb_Character.Controls.Add(this.tb_MaxHP);
            this.gb_Character.Controls.Add(this.tb_WalkingSpeed);
            this.gb_Character.Controls.Add(this.tb_Initiative);
            this.gb_Character.Controls.Add(this.tb_ArmorClass);
            this.gb_Character.Controls.Add(this.tb_CurrentHP);
            this.gb_Character.Controls.Add(this.tb_Name);
            this.gb_Character.Location = new System.Drawing.Point(122, 20);
            this.gb_Character.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Character.Name = "gb_Character";
            this.gb_Character.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Character.Size = new System.Drawing.Size(250, 183);
            this.gb_Character.TabIndex = 6;
            this.gb_Character.TabStop = false;
            this.gb_Character.Text = "Character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Walking Speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Initiative:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Armor Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "HP:";
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
            this.tb_MaxHP.Location = new System.Drawing.Point(162, 52);
            this.tb_MaxHP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_MaxHP.Name = "tb_MaxHP";
            this.tb_MaxHP.Size = new System.Drawing.Size(64, 23);
            this.tb_MaxHP.TabIndex = 0;
            // 
            // tb_WalkingSpeed
            // 
            this.tb_WalkingSpeed.Location = new System.Drawing.Point(104, 139);
            this.tb_WalkingSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_WalkingSpeed.Name = "tb_WalkingSpeed";
            this.tb_WalkingSpeed.Size = new System.Drawing.Size(66, 23);
            this.tb_WalkingSpeed.TabIndex = 0;
            // 
            // tb_Initiative
            // 
            this.tb_Initiative.Location = new System.Drawing.Point(90, 110);
            this.tb_Initiative.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Initiative.Name = "tb_Initiative";
            this.tb_Initiative.Size = new System.Drawing.Size(66, 23);
            this.tb_Initiative.TabIndex = 0;
            // 
            // tb_ArmorClass
            // 
            this.tb_ArmorClass.Location = new System.Drawing.Point(90, 81);
            this.tb_ArmorClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_ArmorClass.Name = "tb_ArmorClass";
            this.tb_ArmorClass.Size = new System.Drawing.Size(66, 23);
            this.tb_ArmorClass.TabIndex = 0;
            // 
            // tb_CurrentHP
            // 
            this.tb_CurrentHP.Location = new System.Drawing.Point(54, 52);
            this.tb_CurrentHP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_CurrentHP.Name = "tb_CurrentHP";
            this.tb_CurrentHP.Size = new System.Drawing.Size(66, 23);
            this.tb_CurrentHP.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 591);
            this.Controls.Add(this.gb_Character);
            this.Controls.Add(this.gb_SavingThrows);
            this.Controls.Add(this.gb_Actions);
            this.Controls.Add(this.gb_Skills);
            this.Controls.Add(this.btn_SaveProfile);
            this.Controls.Add(this.btn_SeedData);
            this.Controls.Add(this.btn_LoadProfile);
            this.Controls.Add(this.groupBox1);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_SavingThrows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
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
    }
}

