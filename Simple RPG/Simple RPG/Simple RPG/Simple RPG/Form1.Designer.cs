namespace Simple_RPG
{
    partial class Menu
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCharacter = new System.Windows.Forms.Button();
            this.btnDice = new System.Windows.Forms.Button();
            this.LblSimpleRPG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCharacter
            // 
            this.BtnCharacter.Location = new System.Drawing.Point(268, 156);
            this.BtnCharacter.Name = "BtnCharacter";
            this.BtnCharacter.Size = new System.Drawing.Size(218, 29);
            this.BtnCharacter.TabIndex = 0;
            this.BtnCharacter.Text = "Character Create";
            this.BtnCharacter.UseVisualStyleBackColor = true;
            this.BtnCharacter.Click += new System.EventHandler(this.BtnCharacter_Click);
            // 
            // btnDice
            // 
            this.btnDice.Location = new System.Drawing.Point(268, 277);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(218, 29);
            this.btnDice.TabIndex = 2;
            this.btnDice.Text = "Dice";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // LblSimpleRPG
            // 
            this.LblSimpleRPG.AutoSize = true;
            this.LblSimpleRPG.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSimpleRPG.Location = new System.Drawing.Point(268, 40);
            this.LblSimpleRPG.Name = "LblSimpleRPG";
            this.LblSimpleRPG.Size = new System.Drawing.Size(275, 44);
            this.LblSimpleRPG.TabIndex = 3;
            this.LblSimpleRPG.Text = "Simple RPG";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(730, 360);
            this.Controls.Add(this.LblSimpleRPG);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.BtnCharacter);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCharacter;
        private Button btnDice;
        private Label LblSimpleRPG;
    }
}