using System;
using MedicalCenter.Users;
using System.Windows.Forms;
using MedicalCenter.Verification;

namespace MedicalCenter.Reseptionists
{
    public partial class ReseptionistForm : Form
    {
        public ReseptionistForm() => InitializeComponent();

        private bool ValidateData()
        {
            if (Validator.IsEmptyStrings(email.Text, name.Text, password.Text, phoneNumber.Text, KeyWord.Text))
            {
                MessageBox.Show("Все данные должны быть введены");
                return false;
            }
            if (Validator.IsNumbers(email.Text, name.Text))
            {
                MessageBox.Show("Имя или почта не могут быть числом");
                return false;
            }
            return true;
        }
        private void RegistraeButton_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            if (UserManager.EmailIsExist(email.Text))
            {
                MessageBox.Show("Пользователь с такой почтой уже существует в системе");
                return;
            }

            if (UserManager.PassRegistationConfirmation(new Patient
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
                MessageBox.Show("Вы успешно зарегистровали пациента");
            }
        }

        private void ReseptionistForm_FormClosed(object sender, FormClosedEventArgs e)  => Application.Exit();

        private void ExitButton_Click(object sender, EventArgs e) => VerificationManager.ExitFrom(this);

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (email.Text == "")
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
    }
}
