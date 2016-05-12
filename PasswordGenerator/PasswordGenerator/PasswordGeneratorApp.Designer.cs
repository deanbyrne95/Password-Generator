namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            this.PasswordGenerationBox = new System.Windows.Forms.TextBox();
            this.IntroductionLabel = new System.Windows.Forms.Label();
            this.HowToUseLabel1 = new System.Windows.Forms.Label();
            this.HowToUseLabel2 = new System.Windows.Forms.Label();
            this.GeneratePasswordButton = new System.Windows.Forms.Button();
            this.SavePasswordButton = new System.Windows.Forms.Button();
            this.MaximumPasswordLengthList = new System.Windows.Forms.ComboBox();
            this.MaximumPasswordLengthLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenPasswordButton = new System.Windows.Forms.Button();
            this.CopyTextButton = new System.Windows.Forms.Button();
            this.SuccessfulLabel = new System.Windows.Forms.Label();
            this.CheckUpperCase = new System.Windows.Forms.CheckBox();
            this.CheckLowerCase = new System.Windows.Forms.CheckBox();
            this.TypeCharacterLabel = new System.Windows.Forms.Label();
            this.CheckNumbers = new System.Windows.Forms.CheckBox();
            this.CheckSymbols = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PasswordGenerationBox
            // 
            resources.ApplyResources(this.PasswordGenerationBox, "PasswordGenerationBox");
            this.PasswordGenerationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordGenerationBox.Name = "PasswordGenerationBox";
            this.PasswordGenerationBox.ReadOnly = true;
            this.PasswordGenerationBox.TabStop = false;
            // 
            // IntroductionLabel
            // 
            resources.ApplyResources(this.IntroductionLabel, "IntroductionLabel");
            this.IntroductionLabel.Name = "IntroductionLabel";
            // 
            // HowToUseLabel1
            // 
            resources.ApplyResources(this.HowToUseLabel1, "HowToUseLabel1");
            this.HowToUseLabel1.Name = "HowToUseLabel1";
            // 
            // HowToUseLabel2
            // 
            resources.ApplyResources(this.HowToUseLabel2, "HowToUseLabel2");
            this.HowToUseLabel2.Name = "HowToUseLabel2";
            // 
            // GeneratePasswordButton
            // 
            resources.ApplyResources(this.GeneratePasswordButton, "GeneratePasswordButton");
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click);
            // 
            // SavePasswordButton
            // 
            resources.ApplyResources(this.SavePasswordButton, "SavePasswordButton");
            this.SavePasswordButton.Name = "SavePasswordButton";
            this.SavePasswordButton.UseVisualStyleBackColor = true;
            this.SavePasswordButton.Click += new System.EventHandler(this.SavePasswordButton_Click);
            // 
            // MaximumPasswordLengthList
            // 
            this.MaximumPasswordLengthList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaximumPasswordLengthList.Items.AddRange(new object[] {
            resources.GetString("MaximumPasswordLengthList.Items"),
            resources.GetString("MaximumPasswordLengthList.Items1"),
            resources.GetString("MaximumPasswordLengthList.Items2"),
            resources.GetString("MaximumPasswordLengthList.Items3"),
            resources.GetString("MaximumPasswordLengthList.Items4"),
            resources.GetString("MaximumPasswordLengthList.Items5"),
            resources.GetString("MaximumPasswordLengthList.Items6"),
            resources.GetString("MaximumPasswordLengthList.Items7"),
            resources.GetString("MaximumPasswordLengthList.Items8"),
            resources.GetString("MaximumPasswordLengthList.Items9"),
            resources.GetString("MaximumPasswordLengthList.Items10")});
            resources.ApplyResources(this.MaximumPasswordLengthList, "MaximumPasswordLengthList");
            this.MaximumPasswordLengthList.Name = "MaximumPasswordLengthList";
            // 
            // MaximumPasswordLengthLabel
            // 
            resources.ApplyResources(this.MaximumPasswordLengthLabel, "MaximumPasswordLengthLabel");
            this.MaximumPasswordLengthLabel.Name = "MaximumPasswordLengthLabel";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Password File";
            // 
            // OpenPasswordButton
            // 
            resources.ApplyResources(this.OpenPasswordButton, "OpenPasswordButton");
            this.OpenPasswordButton.Name = "OpenPasswordButton";
            this.OpenPasswordButton.UseVisualStyleBackColor = true;
            this.OpenPasswordButton.Click += new System.EventHandler(this.OpenPasswordButton_Click);
            // 
            // CopyTextButton
            // 
            resources.ApplyResources(this.CopyTextButton, "CopyTextButton");
            this.CopyTextButton.Name = "CopyTextButton";
            this.CopyTextButton.UseVisualStyleBackColor = true;
            this.CopyTextButton.Click += new System.EventHandler(this.CopyTextButton_Click);
            // 
            // SuccessfulLabel
            // 
            resources.ApplyResources(this.SuccessfulLabel, "SuccessfulLabel");
            this.SuccessfulLabel.Name = "SuccessfulLabel";
            // 
            // CheckUpperCase
            // 
            resources.ApplyResources(this.CheckUpperCase, "CheckUpperCase");
            this.CheckUpperCase.Checked = true;
            this.CheckUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUpperCase.Name = "CheckUpperCase";
            this.CheckUpperCase.UseVisualStyleBackColor = true;
            // 
            // CheckLowerCase
            // 
            resources.ApplyResources(this.CheckLowerCase, "CheckLowerCase");
            this.CheckLowerCase.Checked = true;
            this.CheckLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckLowerCase.Name = "CheckLowerCase";
            this.CheckLowerCase.UseVisualStyleBackColor = true;
            // 
            // TypeCharacterLabel
            // 
            resources.ApplyResources(this.TypeCharacterLabel, "TypeCharacterLabel");
            this.TypeCharacterLabel.Name = "TypeCharacterLabel";
            // 
            // CheckNumbers
            // 
            resources.ApplyResources(this.CheckNumbers, "CheckNumbers");
            this.CheckNumbers.Checked = true;
            this.CheckNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckNumbers.Name = "CheckNumbers";
            this.CheckNumbers.UseVisualStyleBackColor = true;
            // 
            // CheckSymbols
            // 
            resources.ApplyResources(this.CheckSymbols, "CheckSymbols");
            this.CheckSymbols.Checked = true;
            this.CheckSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckSymbols.Name = "CheckSymbols";
            this.CheckSymbols.UseVisualStyleBackColor = true;
            // 
            // PasswordGenerator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CheckSymbols);
            this.Controls.Add(this.CheckNumbers);
            this.Controls.Add(this.TypeCharacterLabel);
            this.Controls.Add(this.CheckLowerCase);
            this.Controls.Add(this.CheckUpperCase);
            this.Controls.Add(this.SuccessfulLabel);
            this.Controls.Add(this.CopyTextButton);
            this.Controls.Add(this.OpenPasswordButton);
            this.Controls.Add(this.MaximumPasswordLengthLabel);
            this.Controls.Add(this.MaximumPasswordLengthList);
            this.Controls.Add(this.SavePasswordButton);
            this.Controls.Add(this.GeneratePasswordButton);
            this.Controls.Add(this.HowToUseLabel2);
            this.Controls.Add(this.HowToUseLabel1);
            this.Controls.Add(this.IntroductionLabel);
            this.Controls.Add(this.PasswordGenerationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PasswordGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordGenerationBox;
        private System.Windows.Forms.Label IntroductionLabel;
        private System.Windows.Forms.Label HowToUseLabel1;
        private System.Windows.Forms.Label HowToUseLabel2;
        private System.Windows.Forms.Button GeneratePasswordButton;
        private System.Windows.Forms.Button SavePasswordButton;
        private System.Windows.Forms.ComboBox MaximumPasswordLengthList;
        private System.Windows.Forms.Label MaximumPasswordLengthLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OpenPasswordButton;
        private System.Windows.Forms.Button CopyTextButton;
        private System.Windows.Forms.Label SuccessfulLabel;
        private System.Windows.Forms.CheckBox CheckUpperCase;
        private System.Windows.Forms.CheckBox CheckLowerCase;
        private System.Windows.Forms.Label TypeCharacterLabel;
        private System.Windows.Forms.CheckBox CheckNumbers;
        private System.Windows.Forms.CheckBox CheckSymbols;
    }
}

