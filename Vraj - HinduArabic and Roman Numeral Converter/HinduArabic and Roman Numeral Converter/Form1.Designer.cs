namespace HinduArabic_and_Roman_Numeral_Converter
{
    partial class Form1
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
            this.InputHAOrRomanTextbox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OutputHAOrRomanTextbox = new System.Windows.Forms.TextBox();
            this.HAToRomanRadioButton = new System.Windows.Forms.RadioButton();
            this.RomanToHARadioButton = new System.Windows.Forms.RadioButton();
            this.drawRomanNumberPictureBox = new System.Windows.Forms.PictureBox();
            this.TextbookViewLabel = new System.Windows.Forms.Label();
            this.EnterNumberLabel = new System.Windows.Forms.Label();
            this.ConvertedNumberLabel = new System.Windows.Forms.Label();
            this.ChooseConversionTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawRomanNumberPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InputHAOrRomanTextbox
            // 
            this.InputHAOrRomanTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.InputHAOrRomanTextbox.Enabled = false;
            this.InputHAOrRomanTextbox.Location = new System.Drawing.Point(323, 30);
            this.InputHAOrRomanTextbox.Name = "InputHAOrRomanTextbox";
            this.InputHAOrRomanTextbox.ShortcutsEnabled = false;
            this.InputHAOrRomanTextbox.Size = new System.Drawing.Size(201, 20);
            this.InputHAOrRomanTextbox.TabIndex = 0;
            this.InputHAOrRomanTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextbox_KeyPress);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(367, 55);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(113, 39);
            this.ConvertButton.TabIndex = 1;
            this.ConvertButton.Text = "Convert ";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // OutputHAOrRomanTextbox
            // 
            this.OutputHAOrRomanTextbox.Enabled = false;
            this.OutputHAOrRomanTextbox.Location = new System.Drawing.Point(323, 98);
            this.OutputHAOrRomanTextbox.Name = "OutputHAOrRomanTextbox";
            this.OutputHAOrRomanTextbox.ReadOnly = true;
            this.OutputHAOrRomanTextbox.ShortcutsEnabled = false;
            this.OutputHAOrRomanTextbox.Size = new System.Drawing.Size(201, 20);
            this.OutputHAOrRomanTextbox.TabIndex = 2;
            // 
            // HAToRomanRadioButton
            // 
            this.HAToRomanRadioButton.AutoSize = true;
            this.HAToRomanRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HAToRomanRadioButton.Location = new System.Drawing.Point(16, 52);
            this.HAToRomanRadioButton.Name = "HAToRomanRadioButton";
            this.HAToRomanRadioButton.Size = new System.Drawing.Size(163, 25);
            this.HAToRomanRadioButton.TabIndex = 3;
            this.HAToRomanRadioButton.TabStop = true;
            this.HAToRomanRadioButton.Text = "Hindu Arabic To Roman";
            this.HAToRomanRadioButton.UseVisualStyleBackColor = true;
            this.HAToRomanRadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HAToRomanRadioButton_MouseClick);
            // 
            // RomanToHARadioButton
            // 
            this.RomanToHARadioButton.AutoSize = true;
            this.RomanToHARadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomanToHARadioButton.Location = new System.Drawing.Point(16, 83);
            this.RomanToHARadioButton.Name = "RomanToHARadioButton";
            this.RomanToHARadioButton.Size = new System.Drawing.Size(163, 25);
            this.RomanToHARadioButton.TabIndex = 4;
            this.RomanToHARadioButton.TabStop = true;
            this.RomanToHARadioButton.Text = "Roman To Hindu Arabic";
            this.RomanToHARadioButton.UseVisualStyleBackColor = true;
            this.RomanToHARadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RomanToHARadioButton_MouseClick);
            // 
            // drawRomanNumberPictureBox
            // 
            this.drawRomanNumberPictureBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.drawRomanNumberPictureBox.Location = new System.Drawing.Point(12, 147);
            this.drawRomanNumberPictureBox.Name = "drawRomanNumberPictureBox";
            this.drawRomanNumberPictureBox.Size = new System.Drawing.Size(600, 222);
            this.drawRomanNumberPictureBox.TabIndex = 5;
            this.drawRomanNumberPictureBox.TabStop = false;
            // 
            // TextbookViewLabel
            // 
            this.TextbookViewLabel.AutoSize = true;
            this.TextbookViewLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextbookViewLabel.Location = new System.Drawing.Point(12, 120);
            this.TextbookViewLabel.Name = "TextbookViewLabel";
            this.TextbookViewLabel.Size = new System.Drawing.Size(109, 19);
            this.TextbookViewLabel.TabIndex = 6;
            this.TextbookViewLabel.Text = "Textbook View";
            // 
            // EnterNumberLabel
            // 
            this.EnterNumberLabel.AutoSize = true;
            this.EnterNumberLabel.Location = new System.Drawing.Point(217, 33);
            this.EnterNumberLabel.Name = "EnterNumberLabel";
            this.EnterNumberLabel.Size = new System.Drawing.Size(100, 13);
            this.EnterNumberLabel.TabIndex = 7;
            this.EnterNumberLabel.Text = "Enter Your Number:";
            // 
            // ConvertedNumberLabel
            // 
            this.ConvertedNumberLabel.AutoSize = true;
            this.ConvertedNumberLabel.Location = new System.Drawing.Point(217, 100);
            this.ConvertedNumberLabel.Name = "ConvertedNumberLabel";
            this.ConvertedNumberLabel.Size = new System.Drawing.Size(99, 13);
            this.ConvertedNumberLabel.TabIndex = 8;
            this.ConvertedNumberLabel.Text = "Converted Number:";
            // 
            // ChooseConversionTypeLabel
            // 
            this.ChooseConversionTypeLabel.AutoSize = true;
            this.ChooseConversionTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseConversionTypeLabel.ForeColor = System.Drawing.Color.Red;
            this.ChooseConversionTypeLabel.Location = new System.Drawing.Point(21, 24);
            this.ChooseConversionTypeLabel.Name = "ChooseConversionTypeLabel";
            this.ChooseConversionTypeLabel.Size = new System.Drawing.Size(152, 13);
            this.ChooseConversionTypeLabel.TabIndex = 9;
            this.ChooseConversionTypeLabel.Text = "Choose Conversion Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input \"#\" For a Bar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(638, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseConversionTypeLabel);
            this.Controls.Add(this.ConvertedNumberLabel);
            this.Controls.Add(this.EnterNumberLabel);
            this.Controls.Add(this.TextbookViewLabel);
            this.Controls.Add(this.drawRomanNumberPictureBox);
            this.Controls.Add(this.RomanToHARadioButton);
            this.Controls.Add(this.HAToRomanRadioButton);
            this.Controls.Add(this.OutputHAOrRomanTextbox);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.InputHAOrRomanTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawRomanNumberPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputHAOrRomanTextbox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox OutputHAOrRomanTextbox;
        private System.Windows.Forms.RadioButton HAToRomanRadioButton;
        private System.Windows.Forms.RadioButton RomanToHARadioButton;
        private System.Windows.Forms.PictureBox drawRomanNumberPictureBox;
        private System.Windows.Forms.Label TextbookViewLabel;
        private System.Windows.Forms.Label EnterNumberLabel;
        private System.Windows.Forms.Label ConvertedNumberLabel;
        private System.Windows.Forms.Label ChooseConversionTypeLabel;
        private System.Windows.Forms.Label label1;
    }
}

