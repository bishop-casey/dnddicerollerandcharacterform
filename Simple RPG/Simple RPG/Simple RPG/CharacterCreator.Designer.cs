namespace Simple_RPG
{
    partial class CharacterCreator
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
            this.LblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.GbGender = new System.Windows.Forms.GroupBox();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.RbMale = new System.Windows.Forms.RadioButton();
            this.CbClass = new System.Windows.Forms.ComboBox();
            this.LblClass = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.GbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(0, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 20);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 1;
            // 
            // GbGender
            // 
            this.GbGender.Controls.Add(this.RbFemale);
            this.GbGender.Controls.Add(this.RbMale);
            this.GbGender.Location = new System.Drawing.Point(12, 33);
            this.GbGender.Name = "GbGender";
            this.GbGender.Size = new System.Drawing.Size(244, 60);
            this.GbGender.TabIndex = 2;
            this.GbGender.TabStop = false;
            this.GbGender.Text = "Gender";
            // 
            // RbFemale
            // 
            this.RbFemale.AutoSize = true;
            this.RbFemale.Location = new System.Drawing.Point(138, 26);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(78, 24);
            this.RbFemale.TabIndex = 1;
            this.RbFemale.TabStop = true;
            this.RbFemale.Text = "Female";
            this.RbFemale.UseVisualStyleBackColor = true;
            // 
            // RbMale
            // 
            this.RbMale.AutoSize = true;
            this.RbMale.Location = new System.Drawing.Point(15, 26);
            this.RbMale.Name = "RbMale";
            this.RbMale.Size = new System.Drawing.Size(63, 24);
            this.RbMale.TabIndex = 0;
            this.RbMale.TabStop = true;
            this.RbMale.Text = "Male";
            this.RbMale.UseVisualStyleBackColor = true;
            // 
            // CbClass
            // 
            this.CbClass.FormattingEnabled = true;
            this.CbClass.Items.AddRange(new object[] {
            "Cleric",
            "Paladen",
            "Chicken"});
            this.CbClass.Location = new System.Drawing.Point(27, 145);
            this.CbClass.Name = "CbClass";
            this.CbClass.Size = new System.Drawing.Size(151, 28);
            this.CbClass.TabIndex = 3;
            // 
            // LblClass
            // 
            this.LblClass.AutoSize = true;
            this.LblClass.Location = new System.Drawing.Point(23, 122);
            this.LblClass.Name = "LblClass";
            this.LblClass.Size = new System.Drawing.Size(42, 20);
            this.LblClass.TabIndex = 4;
            this.LblClass.Text = "Class";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 200);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(213, 78);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save Character";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblClass);
            this.Controls.Add(this.CbClass);
            this.Controls.Add(this.GbGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.LblName);
            this.Name = "CharacterCreator";
            this.Text = "CharacterCreator";
            this.GbGender.ResumeLayout(false);
            this.GbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblName;
        private TextBox txtName;
        private GroupBox GbGender;
        private RadioButton RbFemale;
        private RadioButton RbMale;
        private ComboBox CbClass;
        private Label LblClass;
        private Button BtnSave;
    }
}