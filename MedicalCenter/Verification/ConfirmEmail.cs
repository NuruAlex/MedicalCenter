using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MedicalCenter.Verification
{
    public partial class ConfirmEmail : Form
    {
        public bool changed = false;
        public ConfirmEmail() => InitializeComponent();

        private void ConfirmEmail_FormClosed(object sender, FormClosedEventArgs e) => СancellationButton_Click(sender, new EventArgs());

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmptyStrings(numberInput.Text))
            {
                MessageBox.Show("Введите число!");
                return;
            }
            if(!Validator.IsNumbers(numberInput.Text))
            {
                MessageBox.Show("Введите число, а не текст");
                return;
            }
            if (EmailManager.numberToConfirmEmail != Convert.ToInt32(numberInput.Text))
            {
                MessageBox.Show("Неправильное число, попробуйте снова!");
                return;
            }

            VerificationManager.VerificationPassed = true;
            Hide();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.CapsLock: MessageLine.Text = UIHelper.CapsOnOff(); break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void СancellationButton_Click(object sender, EventArgs e)
        {
            VerificationManager.VerificationRefused = true;
            Hide();
        }

        private void GoToAWordConfirmation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           changed = true;
           Hide();
        }

        private void ConfirmEmail_Load(object sender, EventArgs e)
        {
            Theme.Set.FormStyle(this);
        }
    }
}
