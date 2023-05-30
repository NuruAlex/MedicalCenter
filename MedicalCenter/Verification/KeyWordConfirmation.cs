using System;
using System.Windows.Forms;

namespace MedicalCenter.Verification
{
    public partial class KeyWordConfirmation : Form
    {
        public bool changed = false;
        public KeyWordConfirmation() => InitializeComponent();

        private void СancellationButton_Click(object sender, EventArgs e)
        {
            VerificationManager.VerificationRefused = true;
            Hide();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmptyStrings(KeyWord.Text))
            {
                MessageBox.Show("Введите слово!");
                return;
            }
            if (KeyWord.Text != VerificationManager.KeyWord)
            {
                MessageBox.Show("Неправильное слово!");
                return;
            }
            VerificationManager.VerificationPassed = true;
            Hide();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                 case Keys.CapsLock: MessageLine.Text = UIHelper.CapsOnOff(); break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void GoToEmailConfirmation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changed = true;
            Hide();
        }

        private void KeyWordConfirmation_FormClosed(object sender, FormClosedEventArgs e)
        {
            VerificationManager.VerificationRefused = true;
            Application.Exit();
        }
    }
}
