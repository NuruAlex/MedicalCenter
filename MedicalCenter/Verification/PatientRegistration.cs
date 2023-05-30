using System;
using MedicalCenter.Users;
using System.Windows.Forms;
using MedicalCenter.Verification;

namespace MedicalCenter
{
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()  => InitializeComponent();

        private void HomePicture_Click(object sender, EventArgs e) => VerificationManager.GoBackUserSelection();
        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void GoToEnter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => VerificationManager.GoEnterForm(new PatientEnter(), this);

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

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            LoadTheme();
            SuccessPicture.Visible = false;
            DeniedPicture.Visible = false;
            password.UseSystemPasswordChar = true;
            lockPicture.Visible = true;
            unlockPicture.Visible = false;
        }

        private bool ValidateData()
        {
            if (Validator.IsEmptyStrings(email.Text, name.Text, password.Text, phoneNumber.Text, KeyWord.Text))
            {
                MessageBox.Show("Все данные должны быть введены");
                return false;
            }
            if(Validator.IsNumbers(email.Text,name.Text))
            {
                MessageBox.Show("Имя или почта не могут быть числом");
                return false;
            }
            return true;
        }
        
        private void RegistrateButton_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            if (UserManager.EmailIsExist(email.Text))
            {
                MessageBox.Show("Пользователь с такой почтой уже существует в системе");
                return;
            }

            if(UserManager.PassRegistationConfirmation(new Patient
            {
                pEmail = email.Text,
                pName = name.Text,
                pBirth = Birth.Value,
                pPhoneNumber = phoneNumber.Text,
                pPassword = password.Text,
                KeyWord = KeyWord.Text,
                HasEntered = false
            }))
            {
                UserManager.Enter();
                MessageBox.Show("Вы успешно зарегистровались");
            }
        }
        private void email_TextChanged(object sender, EventArgs e)
        {
            if(email.Text == "")
            {
                DeniedPicture.Visible = false;
                SuccessPicture.Visible = false;
                return;
            }
            if (UserManager.EmailIsExist(email.Text))
            {
                DeniedPicture.Visible = true;
                SuccessPicture.Visible = false;
                return;
            }
            DeniedPicture.Visible = false;
            SuccessPicture.Visible = true;
        }
       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter: RegistrateButton_Click(msg, new EventArgs()); break;
                case Keys.Escape: HomePicture_Click(msg, new EventArgs()); break;
                case Keys.CapsLock: MessageLine.Text = UIHelper.CapsOnOff(); break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LockOrUnlockPicture_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
            lockPicture.Visible = !lockPicture.Visible;
            unlockPicture.Visible = !unlockPicture.Visible;
        }
    }
}
