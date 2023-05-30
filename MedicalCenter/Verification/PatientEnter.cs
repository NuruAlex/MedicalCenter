using System;
using System.Windows.Forms;
using MedicalCenter.Verification;

namespace MedicalCenter
{
    public partial class PatientEnter : Form
    {
        public PatientEnter() => InitializeComponent();
        private void EnterForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void Home_Click(object sender, EventArgs e) => VerificationManager.GoBackUserSelection();
        private void GoToRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => VerificationManager.GoEnterForm(new PatientRegistration(), this);

        private void LoadTheme()
        {
            Theme.Set.FormStyle(this);

            if (Theme.CurrentThemeType == Theme.ThemesTypes.Dark)
            {
                HomePicture.Image = Properties.Resources.HomeDark;
                DeniedPicture.Image = Properties.Resources.DeniedDark;
                SuccessPicture.Image = Properties.Resources.SuccessDark;
                unlockPicture.Image = Properties.Resources.UnlockDark;
                lockPicture.Image = Properties.Resources.LockDark;
            }
            if (Theme.CurrentThemeType == Theme.ThemesTypes.Light)
            {
                HomePicture.Image = Properties.Resources.HomeLight;
                DeniedPicture.Image = Properties.Resources.DeniedLight;
                SuccessPicture.Image = Properties.Resources.SuccessLight;
                unlockPicture.Image = Properties.Resources.UnlockLight;
                lockPicture.Image = Properties.Resources.LockLight;
            }
        }

        private void PatientEnter_Load(object sender, EventArgs e)
        {
            LoadTheme();
            password.UseSystemPasswordChar = true;
            lockPicture.Visible = true;
            unlockPicture.Visible = false;
            SuccessPicture.Visible = false;

            string lastEmail = DataBase.Get.LastPatientEntered();
           
            if(!Validator.IsEmptyStrings(lastEmail))
            {
                email.Text = lastEmail;
                SuccessPicture.Visible = true;
                email.TabIndex = 1;
                password.TabIndex = 0;
            }

            DeniedPicture.Visible = false;
        }
        
        private bool ValidateData()
        {
            if (Validator.IsEmptyStrings(email.Text, password.Text))
            {
                MessageBox.Show("Все данные должны быть введены");
                return false;
            }
            if (Validator.IsNumbers(email.Text))
            {
                MessageBox.Show("Почта не может быть числом!");
                return false;
            }
            return true;
        }
        
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(!ValidateData()) return;

            if (!UserManager.UserIsExist(email.Text, password.Text))
            {
                MessageBox.Show("такого пациента не существует!");
                return;
            }

            if(!UserManager.UserHasEntered())
            {
                if(UserManager.PassConfirmation(false))
                {
                    UserManager.Enter();
                    UserManager.AddMachine(email.Text);
                }
                return;
            }

            if(!UserManager.IsCorrectMachineName(email.Text))
            {
                if(UserManager.PassConfirmation(true))
                {
                    UserManager.Enter();
                    UserManager.AddMachine(email.Text);
                }
                return;
            }
            VerificationManager.CurrentEnterForm.Hide();
            UserManager.Enter();
        }
        private void email_TextChanged(object sender, EventArgs e)
        {
            if(email.Text == "")
            {
                SuccessPicture.Visible = false;
                DeniedPicture.Visible = false;
                return;
            }
            if(UserManager.EmailIsExist(email.Text))
            {
                SuccessPicture.Visible = true;
                DeniedPicture.Visible = false;
                return;
            }
            DeniedPicture.Visible = true;
            SuccessPicture.Visible = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Enter: EnterButton_Click(msg, new EventArgs());break;
                case Keys.Escape: Home_Click(msg, new EventArgs());break;
                case Keys.CapsLock: MessageLine.Text = UIHelper.CapsOnOff();break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void lockOrUnlockPicture_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
            lockPicture.Visible = !lockPicture.Visible;
            unlockPicture.Visible = !unlockPicture.Visible;
        }
    }
}
