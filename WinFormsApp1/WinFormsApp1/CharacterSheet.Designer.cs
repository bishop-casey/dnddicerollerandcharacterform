<<<<<<< HEAD
﻿namespace WinFormsApp1
{
    partial class CharacterSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSheet));
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.txtInitiative = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtCurrentHP = new System.Windows.Forms.TextBox();
            this.txtHitDice = new System.Windows.Forms.TextBox();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtWis = new System.Windows.Forms.TextBox();
            this.txtCha = new System.Windows.Forms.TextBox();
            this.txtProfBonus = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.txtGp = new System.Windows.Forms.TextBox();
            this.txtEp = new System.Windows.Forms.TextBox();
            this.txtPP = new System.Windows.Forms.TextBox();
            this.txtBackground = new System.Windows.Forms.TextBox();
            this.txtFeaturesTraits = new System.Windows.Forms.TextBox();
            this.txtAttackSpells = new System.Windows.Forms.TextBox();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.txtProficiences = new System.Windows.Forms.TextBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.strmod = new System.Windows.Forms.ComboBox();
            this.lblBackground = new System.Windows.Forms.Label();
            this.chamod = new System.Windows.Forms.ComboBox();
            this.dexmod = new System.Windows.Forms.ComboBox();
            this.conmod = new System.Windows.Forms.ComboBox();
            this.intmod = new System.Windows.Forms.ComboBox();
            this.wismod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCharacterName.Location = new System.Drawing.Point(138, 26);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(282, 24);
            this.txtCharacterName.TabIndex = 0;
            // 
            // txtRace
            // 
            this.txtRace.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRace.Location = new System.Drawing.Point(138, 56);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(282, 24);
            this.txtRace.TabIndex = 1;
            // 
            // txtAC
            // 
            this.txtAC.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAC.Location = new System.Drawing.Point(476, 49);
            this.txtAC.Name = "txtAC";
            this.txtAC.Size = new System.Drawing.Size(48, 33);
            this.txtAC.TabIndex = 2;
            // 
            // txtInitiative
            // 
            this.txtInitiative.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInitiative.Location = new System.Drawing.Point(622, 49);
            this.txtInitiative.Name = "txtInitiative";
            this.txtInitiative.Size = new System.Drawing.Size(48, 33);
            this.txtInitiative.TabIndex = 3;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSpeed.Location = new System.Drawing.Point(768, 49);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(48, 33);
            this.txtSpeed.TabIndex = 4;
            // 
            // txtLevel
            // 
            this.txtLevel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLevel.Location = new System.Drawing.Point(61, 50);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(48, 33);
            this.txtLevel.TabIndex = 5;
            this.txtLevel.TextChanged += new System.EventHandler(this.txtLevel_TextChanged);
            // 
            // txtHP
            // 
            this.txtHP.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHP.Location = new System.Drawing.Point(466, 138);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(48, 33);
            this.txtHP.TabIndex = 6;
            // 
            // txtCurrentHP
            // 
            this.txtCurrentHP.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCurrentHP.Location = new System.Drawing.Point(586, 138);
            this.txtCurrentHP.Name = "txtCurrentHP";
            this.txtCurrentHP.Size = new System.Drawing.Size(95, 33);
            this.txtCurrentHP.TabIndex = 7;
            // 
            // txtHitDice
            // 
            this.txtHitDice.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHitDice.Location = new System.Drawing.Point(787, 138);
            this.txtHitDice.Name = "txtHitDice";
            this.txtHitDice.Size = new System.Drawing.Size(48, 33);
            this.txtHitDice.TabIndex = 8;
            // 
            // txtStr
            // 
            this.txtStr.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStr.Location = new System.Drawing.Point(92, 205);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(48, 33);
            this.txtStr.TabIndex = 9;
            // 
            // txtDex
            // 
            this.txtDex.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDex.Location = new System.Drawing.Point(92, 265);
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(48, 33);
            this.txtDex.TabIndex = 10;
            // 
            // txtCon
            // 
            this.txtCon.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCon.Location = new System.Drawing.Point(92, 324);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(48, 33);
            this.txtCon.TabIndex = 11;
            // 
            // txtInt
            // 
            this.txtInt.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInt.Location = new System.Drawing.Point(92, 385);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(48, 33);
            this.txtInt.TabIndex = 12;
            // 
            // txtWis
            // 
            this.txtWis.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWis.Location = new System.Drawing.Point(92, 445);
            this.txtWis.Name = "txtWis";
            this.txtWis.Size = new System.Drawing.Size(48, 33);
            this.txtWis.TabIndex = 13;
            // 
            // txtCha
            // 
            this.txtCha.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCha.Location = new System.Drawing.Point(92, 505);
            this.txtCha.Name = "txtCha";
            this.txtCha.Size = new System.Drawing.Size(48, 33);
            this.txtCha.TabIndex = 14;
            // 
            // txtProfBonus
            // 
            this.txtProfBonus.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProfBonus.Location = new System.Drawing.Point(349, 205);
            this.txtProfBonus.Name = "txtProfBonus";
            this.txtProfBonus.Size = new System.Drawing.Size(48, 33);
            this.txtProfBonus.TabIndex = 15;
            // 
            // txtCP
            // 
            this.txtCP.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCP.Location = new System.Drawing.Point(463, 380);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(48, 24);
            this.txtCP.TabIndex = 16;
            // 
            // txtSP
            // 
            this.txtSP.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSP.Location = new System.Drawing.Point(463, 412);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(48, 24);
            this.txtSP.TabIndex = 17;
            // 
            // txtGp
            // 
            this.txtGp.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGp.Location = new System.Drawing.Point(463, 445);
            this.txtGp.Name = "txtGp";
            this.txtGp.Size = new System.Drawing.Size(48, 24);
            this.txtGp.TabIndex = 18;
            // 
            // txtEp
            // 
            this.txtEp.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEp.Location = new System.Drawing.Point(463, 479);
            this.txtEp.Name = "txtEp";
            this.txtEp.Size = new System.Drawing.Size(48, 24);
            this.txtEp.TabIndex = 19;
            // 
            // txtPP
            // 
            this.txtPP.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPP.Location = new System.Drawing.Point(463, 512);
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(48, 24);
            this.txtPP.TabIndex = 20;
            // 
            // txtBackground
            // 
            this.txtBackground.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBackground.Location = new System.Drawing.Point(55, 112);
            this.txtBackground.Multiline = true;
            this.txtBackground.Name = "txtBackground";
            this.txtBackground.Size = new System.Drawing.Size(349, 59);
            this.txtBackground.TabIndex = 21;
            // 
            // txtFeaturesTraits
            // 
            this.txtFeaturesTraits.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFeaturesTraits.Location = new System.Drawing.Point(900, 56);
            this.txtFeaturesTraits.Multiline = true;
            this.txtFeaturesTraits.Name = "txtFeaturesTraits";
            this.txtFeaturesTraits.Size = new System.Drawing.Size(349, 482);
            this.txtFeaturesTraits.TabIndex = 22;
            // 
            // txtAttackSpells
            // 
            this.txtAttackSpells.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAttackSpells.Location = new System.Drawing.Point(453, 224);
            this.txtAttackSpells.Multiline = true;
            this.txtAttackSpells.Name = "txtAttackSpells";
            this.txtAttackSpells.Size = new System.Drawing.Size(396, 113);
            this.txtAttackSpells.TabIndex = 23;
            // 
            // txtEquipment
            // 
            this.txtEquipment.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEquipment.Location = new System.Drawing.Point(528, 385);
            this.txtEquipment.Multiline = true;
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(317, 153);
            this.txtEquipment.TabIndex = 24;
            // 
            // txtProficiences
            // 
            this.txtProficiences.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProficiences.Location = new System.Drawing.Point(186, 278);
            this.txtProficiences.Multiline = true;
            this.txtProficiences.Name = "txtProficiences";
            this.txtProficiences.Size = new System.Drawing.Size(221, 258);
            this.txtProficiences.TabIndex = 25;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterName.Location = new System.Drawing.Point(138, 3);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(149, 16);
            this.lblCharacterName.TabIndex = 26;
            this.lblCharacterName.Text = "Character Name";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRace.Location = new System.Drawing.Point(138, 83);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(49, 16);
            this.lblRace.TabIndex = 27;
            this.lblRace.Text = "Race";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLevel.Location = new System.Drawing.Point(58, 27);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(57, 16);
            this.lblLevel.TabIndex = 28;
            this.lblLevel.Text = "Level";
            // 
            // strmod
            // 
            this.strmod.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.strmod.FormattingEnabled = true;
            this.strmod.Items.AddRange(new object[] {
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.strmod.Location = new System.Drawing.Point(37, 216);
            this.strmod.Name = "strmod";
            this.strmod.Size = new System.Drawing.Size(45, 22);
            this.strmod.TabIndex = 29;
            // 
            // lblBackground
            // 
            this.lblBackground.AutoSize = true;
            this.lblBackground.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBackground.Location = new System.Drawing.Point(37, 174);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(113, 16);
            this.lblBackground.TabIndex = 30;
            this.lblBackground.Text = "Background";
            // 
            // chamod
            // 
            this.chamod.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chamod.FormattingEnabled = true;
            this.chamod.Items.AddRange(new object[] {
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.chamod.Location = new System.Drawing.Point(35, 517);
            this.chamod.Name = "chamod";
            this.chamod.Size = new System.Drawing.Size(45, 22);
            this.chamod.TabIndex = 31;
            // 
            // dexmod
            // 
            this.dexmod.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dexmod.FormattingEnabled = true;
            this.dexmod.Items.AddRange(new object[] {
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.dexmod.Location = new System.Drawing.Point(35, 276);
            this.dexmod.Name = "dexmod";
            this.dexmod.Size = new System.Drawing.Size(45, 22);
            this.dexmod.TabIndex = 32;
            // 
            // conmod
            // 
            this.conmod.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conmod.FormattingEnabled = true;
            this.conmod.Items.AddRange(new object[] {
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.conmod.Location = new System.Drawing.Point(37, 335);
            this.conmod.Name = "conmod";
            this.conmod.Size = new System.Drawing.Size(45, 22);
            this.conmod.TabIndex = 33;
            // 
            // intmod
            // 
            this.intmod.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.intmod.FormattingEnabled = true;
            this.intmod.Items.AddRange(new object[] {
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.intmod.Location = new System.Drawing.Point(35, 396);
            this.intmod.Name = "intmod";
            this.intmod.Size = new System.Drawing.Size(45, 22);
            this.intmod.TabIndex = 34;
            // 
            // wismod
            // 
            this.wismod.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wismod.FormattingEnabled = true;
            this.wismod.Items.AddRange(new object[] {
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.wismod.Location = new System.Drawing.Point(35, 456);
            this.wismod.Name = "wismod";
            this.wismod.Size = new System.Drawing.Size(45, 22);
            this.wismod.TabIndex = 35;
            // 
            // CharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1301, 574);
            this.Controls.Add(this.wismod);
            this.Controls.Add(this.intmod);
            this.Controls.Add(this.conmod);
            this.Controls.Add(this.dexmod);
            this.Controls.Add(this.chamod);
            this.Controls.Add(this.lblBackground);
            this.Controls.Add(this.strmod);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.txtProficiences);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.txtAttackSpells);
            this.Controls.Add(this.txtFeaturesTraits);
            this.Controls.Add(this.txtBackground);
            this.Controls.Add(this.txtPP);
            this.Controls.Add(this.txtEp);
            this.Controls.Add(this.txtGp);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtProfBonus);
            this.Controls.Add(this.txtCha);
            this.Controls.Add(this.txtWis);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtDex);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.txtHitDice);
            this.Controls.Add(this.txtCurrentHP);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtInitiative);
            this.Controls.Add(this.txtAC);
            this.Controls.Add(this.txtRace);
            this.Controls.Add(this.txtCharacterName);
            this.Name = "CharacterSheet";
            this.Text = "CharacterSheet";
            this.Load += new System.EventHandler(this.CharacterSheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCharacterName;
        private TextBox txtRace;
        private TextBox txtAC;
        private TextBox txtInitiative;
        private TextBox txtSpeed;
        private TextBox txtLevel;
        private TextBox txtHP;
        private TextBox txtCurrentHP;
        private TextBox txtHitDice;
        private TextBox txtStr;
        private TextBox txtDex;
        private TextBox txtCon;
        private TextBox txtInt;
        private TextBox txtWis;
        private TextBox txtCha;
        private TextBox txtProfBonus;
        private TextBox txtCP;
        private TextBox txtSP;
        private TextBox txtGp;
        private TextBox txtEp;
        private TextBox txtPP;
        private TextBox txtBackground;
        private TextBox txtFeaturesTraits;
        private TextBox txtAttackSpells;
        private TextBox txtEquipment;
        private TextBox txtProficiences;
        private Label lblCharacterName;
        private Label lblRace;
        private Label lblLevel;
        private ComboBox strmod;
        private Label lblBackground;
        private ComboBox chamod;
        private ComboBox dexmod;
        private ComboBox conmod;
        private ComboBox intmod;
        private ComboBox wismod;
    }
=======
﻿namespace WinFormsApp1
{
    partial class CharacterSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.SuspendLayout();
            // 
            // CharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CharacterSheet";
            this.Text = "CharacterSheet";
            this.ResumeLayout(false);

        }

        #endregion
    }
>>>>>>> 8afa7d4ddaa720656a251fed05001709bb3ba9e2
}