using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        private readonly string UpperCaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string LowerCaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
        private readonly string Numbers = "0123456789";
        private readonly string Symbols = "!@£$%^&*()_-#?/+=~|";
        private string GeneratedPassword = "";
        private char[] PossibleChars;
        private bool UpperCaseEnabled;
        private bool LowerCaseEnabled;
        private bool NumbersEnabled;
        private bool SymbolsEnabled;

        public PasswordGenerator()
        {
            InitializeComponent();
            MaximumPasswordLengthList.SelectedIndex = 0;
            PasswordGenerationBox.Text = "Generated Password";
            CheckPossibleChars();
        }

        private void GetPossibleChars()
        {
            //1
            if (UpperCaseEnabled && LowerCaseEnabled && NumbersEnabled && SymbolsEnabled)
            {
                string charChars = UpperCaseAlphabet + LowerCaseAlphabet + Numbers + Symbols;
                PossibleChars = charChars.ToCharArray();
            }
            //2
            else if (!UpperCaseEnabled && LowerCaseEnabled && NumbersEnabled && SymbolsEnabled)
            {
                string charChars = LowerCaseAlphabet + Numbers + Symbols;
                PossibleChars = charChars.ToCharArray();
            }
            //3
            else if (UpperCaseEnabled && !LowerCaseEnabled && NumbersEnabled && SymbolsEnabled)
            {
                string charChars = UpperCaseAlphabet + Numbers + Symbols;
                PossibleChars = charChars.ToCharArray();
            }
            //4
            else if (UpperCaseEnabled && LowerCaseEnabled && !NumbersEnabled && SymbolsEnabled)
            {
                string charChars = UpperCaseAlphabet + LowerCaseAlphabet + Symbols;
                PossibleChars = charChars.ToCharArray();
            }
            //5
            else if (UpperCaseEnabled && LowerCaseEnabled && NumbersEnabled && !SymbolsEnabled)
            {
                string charChars = UpperCaseAlphabet + LowerCaseAlphabet + Numbers;
                PossibleChars = charChars.ToCharArray();
            }
            //6
            else if (!UpperCaseEnabled && !LowerCaseEnabled && NumbersEnabled && SymbolsEnabled)
            {
                string charChars = Numbers + Symbols;
                PossibleChars = charChars.ToCharArray();
            }
            //7
            else if (!UpperCaseEnabled && LowerCaseEnabled && !NumbersEnabled && SymbolsEnabled)
            {
                string charChars = LowerCaseAlphabet + Symbols;
                PossibleChars = charChars.ToCharArray();
            }
            //8
            else if (!UpperCaseEnabled && LowerCaseEnabled && NumbersEnabled && !SymbolsEnabled)
            {
                string charChars = LowerCaseAlphabet + Numbers;
                PossibleChars = charChars.ToCharArray();
            }
            //9
            else if (UpperCaseEnabled && !LowerCaseEnabled && !NumbersEnabled && SymbolsEnabled)
            {
                string charChars = UpperCaseAlphabet + Symbols;
                PossibleChars = charChars.ToCharArray();
            }
            //10
            else if (UpperCaseEnabled && !LowerCaseEnabled && NumbersEnabled && !SymbolsEnabled)
            {
                string charChars = UpperCaseAlphabet + Numbers;
                PossibleChars = charChars.ToCharArray();
            }
            //11
            else if (UpperCaseEnabled && LowerCaseEnabled && !NumbersEnabled && !SymbolsEnabled)
            {
                string charChars = UpperCaseAlphabet + LowerCaseAlphabet;
                PossibleChars = charChars.ToCharArray();
            }
            //12
            else if (!UpperCaseEnabled && !LowerCaseEnabled && !NumbersEnabled && SymbolsEnabled)
            {
                string charChars = Symbols;
                PossibleChars = charChars.ToCharArray();
            }
            //13
            else if (!UpperCaseEnabled && !LowerCaseEnabled && NumbersEnabled && !SymbolsEnabled)
            {
                string charChars = Numbers;
                PossibleChars = charChars.ToCharArray();
            }
            //14
            else if (!UpperCaseEnabled && LowerCaseEnabled && !NumbersEnabled && !SymbolsEnabled)
            {
                string charChars = LowerCaseAlphabet;
                PossibleChars = charChars.ToCharArray();
            }
            //15
            else if (UpperCaseEnabled && !LowerCaseEnabled && !NumbersEnabled && !SymbolsEnabled)
            {
                string charChars = UpperCaseAlphabet;
                PossibleChars = charChars.ToCharArray();
            }
            //16
            else
            {
                string charChars = "";
                PossibleChars = charChars.ToCharArray();
            }
        }

        private void CheckPossibleChars()
        {
            //Upper Case
            if (CheckUpperCase.CheckState == CheckState.Checked)
            {
                UpperCaseEnabled = true;
            }
            else
            {
                UpperCaseEnabled = false;
            }
            //Lower Case
            if (CheckLowerCase.CheckState == CheckState.Checked)
            {
                LowerCaseEnabled = true;
            }
            else
            {
                LowerCaseEnabled = false;
            }
            //Numbers
            if (CheckNumbers.CheckState == CheckState.Checked)
            {
                NumbersEnabled = true;
            }
            else
            {
                NumbersEnabled = false;
            }
            //Symbols
            if (CheckSymbols.CheckState == CheckState.Checked)
            {
                SymbolsEnabled = true;
            }
            else
            {
                SymbolsEnabled = false;
            }

            GetPossibleChars();
        }

        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
            CheckPossibleChars();
            string s = new string(PossibleChars);
            Debug.WriteLine(s);
            Random range = new Random();
            StringBuilder builder = new StringBuilder();
            if (PossibleChars.Length > 0)
            {
                if (MaximumPasswordLengthList.SelectedIndex >= 0)
                {
                    for (int i = 0; i < Int32.Parse(MaximumPasswordLengthList.Text); i++)
                    {
                        builder.Append(PossibleChars[range.Next(PossibleChars.Length)]);
                    }
                }
            }
            else
            {
                PasswordGenerationBox.Text = "";
                SuccessfulLabel.Text = "You must check a set of characters to include in your password!";
                SuccessfulLabel.ForeColor = Color.Red;
            }
            GeneratedPassword = builder.ToString();
            PasswordGenerationBox.Text = GeneratedPassword;
            Debug.WriteLine(PasswordGenerationBox.Text);
        }

        private void SavePasswordButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString("d2") + "-" + DateTime.Now.Day.ToString("d2") + " - [Site] Password";
            saveFileDialog1.Filter = "Password Files|*.pass|Text Files|*.txt";
            saveFileDialog1.Title = "Save your Password";

            if (saveFileDialog1.FileName != "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = File.Open(saveFileDialog1.FileName, FileMode.Append, FileAccess.Write))
                    using (StreamWriter streamWriter = new StreamWriter(stream))
                    {
                        streamWriter.Write(PasswordGenerationBox.Text);
                    }
                    SuccessfulLabel.Text = "Saved '" + Path.GetFileName(saveFileDialog1.FileName) + "' Successfully!";
                    SuccessfulLabel.ForeColor = Color.Green;
                }
            }
        }

        private void CopyTextButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordGenerationBox.Text);
            if (Clipboard.GetText() == PasswordGenerationBox.Text)
            {
                SuccessfulLabel.Text = "Successfully Copied Password!";
                SuccessfulLabel.ForeColor = Color.Red;
            }
        }

        private void OpenPasswordButton_Click(object sender, EventArgs e)
        {
            Stream stream;
            openFileDialog1.Filter = "Password Files|*.pass|Text Files|*.txt";
            openFileDialog1.Title = "Open your Password";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((stream = openFileDialog1.OpenFile()) != null)
                {
                    string stringFileName = openFileDialog1.FileName;
                    string fileText = File.ReadAllText(stringFileName);
                    PasswordGenerationBox.Text = fileText;
                    if (PasswordGenerationBox.Text == fileText)
                    {
                        SuccessfulLabel.Text = "Successfully Opened '" + Path.GetFileName(stringFileName) + "'!";
                        SuccessfulLabel.ForeColor = Color.Blue;
                    }
                }
            }
        }
    }
}
