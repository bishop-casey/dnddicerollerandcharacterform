namespace WinFormsApp1
{
    partial class DiceRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRoller));
            this.label1 = new System.Windows.Forms.Label();
            this.D20Text = new System.Windows.Forms.TextBox();
            this.D12Text = new System.Windows.Forms.TextBox();
            this.D10Text = new System.Windows.Forms.TextBox();
            this.D8Text = new System.Windows.Forms.TextBox();
            this.D6Text = new System.Windows.Forms.TextBox();
            this.D4Text = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.RollD20 = new System.Windows.Forms.Button();
            this.RollD12 = new System.Windows.Forms.Button();
            this.RollD10 = new System.Windows.Forms.Button();
            this.RollD8 = new System.Windows.Forms.Button();
            this.RollD6 = new System.Windows.Forms.Button();
            this.RollD4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(184, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "DnD Dice Roller";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // D20Text
            // 
            this.D20Text.Location = new System.Drawing.Point(63, 173);
            this.D20Text.Name = "D20Text";
            this.D20Text.Size = new System.Drawing.Size(125, 27);
            this.D20Text.TabIndex = 1;
            this.D20Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.D20Text.TextChanged += new System.EventHandler(this.D20Text_TextChanged);
            // 
            // D12Text
            // 
            this.D12Text.Location = new System.Drawing.Point(319, 173);
            this.D12Text.Name = "D12Text";
            this.D12Text.Size = new System.Drawing.Size(125, 27);
            this.D12Text.TabIndex = 2;
            this.D12Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // D10Text
            // 
            this.D10Text.Location = new System.Drawing.Point(597, 173);
            this.D10Text.Name = "D10Text";
            this.D10Text.Size = new System.Drawing.Size(125, 27);
            this.D10Text.TabIndex = 3;
            this.D10Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // D8Text
            // 
            this.D8Text.Location = new System.Drawing.Point(63, 347);
            this.D8Text.Name = "D8Text";
            this.D8Text.Size = new System.Drawing.Size(125, 27);
            this.D8Text.TabIndex = 4;
            this.D8Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // D6Text
            // 
            this.D6Text.Location = new System.Drawing.Point(319, 347);
            this.D6Text.Name = "D6Text";
            this.D6Text.Size = new System.Drawing.Size(125, 27);
            this.D6Text.TabIndex = 5;
            this.D6Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // D4Text
            // 
            this.D4Text.Location = new System.Drawing.Point(597, 347);
            this.D4Text.Name = "D4Text";
            this.D4Text.Size = new System.Drawing.Size(125, 27);
            this.D4Text.TabIndex = 6;
            this.D4Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(319, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(597, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(63, 246);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(125, 84);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(319, 246);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(125, 84);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(597, 246);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(125, 84);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // RollD20
            // 
            this.RollD20.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RollD20.Location = new System.Drawing.Point(63, 206);
            this.RollD20.Name = "RollD20";
            this.RollD20.Size = new System.Drawing.Size(125, 29);
            this.RollD20.TabIndex = 13;
            this.RollD20.Text = "Roll D20";
            this.RollD20.UseVisualStyleBackColor = true;
            this.RollD20.Click += new System.EventHandler(this.RollD20_Click);
            // 
            // RollD12
            // 
            this.RollD12.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RollD12.Location = new System.Drawing.Point(319, 206);
            this.RollD12.Name = "RollD12";
            this.RollD12.Size = new System.Drawing.Size(125, 29);
            this.RollD12.TabIndex = 14;
            this.RollD12.Text = "Roll D12";
            this.RollD12.UseVisualStyleBackColor = true;
            this.RollD12.Click += new System.EventHandler(this.RollD12_Click);
            // 
            // RollD10
            // 
            this.RollD10.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RollD10.ForeColor = System.Drawing.Color.Black;
            this.RollD10.Location = new System.Drawing.Point(597, 206);
            this.RollD10.Name = "RollD10";
            this.RollD10.Size = new System.Drawing.Size(125, 29);
            this.RollD10.TabIndex = 15;
            this.RollD10.Text = "Roll D10";
            this.RollD10.UseVisualStyleBackColor = true;
            this.RollD10.Click += new System.EventHandler(this.button3_Click);
            // 
            // RollD8
            // 
            this.RollD8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RollD8.Location = new System.Drawing.Point(63, 380);
            this.RollD8.Name = "RollD8";
            this.RollD8.Size = new System.Drawing.Size(125, 29);
            this.RollD8.TabIndex = 16;
            this.RollD8.Text = "Roll D8";
            this.RollD8.UseVisualStyleBackColor = true;
            this.RollD8.Click += new System.EventHandler(this.RollD8_Click);
            // 
            // RollD6
            // 
            this.RollD6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RollD6.Location = new System.Drawing.Point(319, 380);
            this.RollD6.Name = "RollD6";
            this.RollD6.Size = new System.Drawing.Size(125, 29);
            this.RollD6.TabIndex = 17;
            this.RollD6.Text = "Roll D6";
            this.RollD6.UseVisualStyleBackColor = true;
            this.RollD6.Click += new System.EventHandler(this.button5_Click);
            // 
            // RollD4
            // 
            this.RollD4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RollD4.Location = new System.Drawing.Point(597, 380);
            this.RollD4.Name = "RollD4";
            this.RollD4.Size = new System.Drawing.Size(125, 29);
            this.RollD4.TabIndex = 18;
            this.RollD4.Text = "Roll D4";
            this.RollD4.UseVisualStyleBackColor = true;
            this.RollD4.Click += new System.EventHandler(this.RollD4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RollD4);
            this.Controls.Add(this.RollD6);
            this.Controls.Add(this.RollD8);
            this.Controls.Add(this.RollD10);
            this.Controls.Add(this.RollD12);
            this.Controls.Add(this.RollD20);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.D4Text);
            this.Controls.Add(this.D6Text);
            this.Controls.Add(this.D8Text);
            this.Controls.Add(this.D10Text);
            this.Controls.Add(this.D12Text);
            this.Controls.Add(this.D20Text);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox D20Text;
        private TextBox D12Text;
        private TextBox D10Text;
        private TextBox D8Text;
        private TextBox D6Text;
        private TextBox D4Text;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button RollD20;
        private Button RollD12;
        private Button RollD10;
        private Button RollD8;
        private Button RollD6;
        private Button RollD4;
    }
}