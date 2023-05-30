using System;
using System.Windows.Forms;
using MedicalCenter.Staffs;
using MedicalCenter.Verification;

namespace MedicalCenter.Admins
{
    public partial class AdminForm : Form
    {
        
        public AdminForm() => InitializeComponent();
       
        private void AdminForm_Load(object sender, EventArgs e)
        {
            Theme.Set.FormStyle(this);
            UIHelper.Show.StaffData(aEmail, aName, aPassword, aSecondPassword);
            posts.Items.AddRange(DataBase.Get.Posts().ToArray());
            states.Items.AddRange(DataBase.Get.States().ToArray());
            states.Items.Remove("Главврач");
        }
        private bool ValidateData()
        {
            if(Validator.IsNulls(states.SelectedItem,posts.SelectedItem))
            {
                MessageBox.Show("Введите все данные");
                return false;
            }
            if (Validator.IsEmptyStrings(email.Text, name.Text, password.Text, secondPassword.Text, KeyWord.Text, licence.Text))
            {
                MessageBox.Show("Введите все данные");
                return false;
            }
            if (StaffManager.EmailAndStateIsExist(email.Text, states.SelectedItem.ToString()))
            {
                MessageBox.Show("Такой персонал уже существует!");
                return false;
            }
            return true;
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            if(StaffManager.PassRegistrationConfirmation(new Doctor
            {
                sEmail = email.Text,
                sName = name.Text,
                sPassword = password.Text,
                sSecondPassword = secondPassword.Text,
                sKeyWord = KeyWord.Text,
                sLicence = licence.Text,
                sState = states.SelectedItem.ToString(),
                sPost = posts.SelectedItem.ToString(),
                HasEntered = false
            }))
            {
                MessageBox.Show("Сотрудник успешно зарегистрирован");
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
      
        private void ExitButton_Click(object sender, EventArgs e) => VerificationManager.ExitFrom(this);

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (states.SelectedItem == null)
                return;
            if(email.Text == "")
            {
                SuccessPicture.Visible = false;
                DeniedPicture.Visible = false;
            }

            if(StaffManager.EmailAndStateIsExist(email.Text,states.SelectedItem.ToString()))
            {
                DeniedPicture.Visible = true;
                SuccessPicture.Visible = false;
                RegistrationState.Text = "Такой персонал уже существует!";
                return;
            }
            DeniedPicture.Visible = false;
            SuccessPicture.Visible = true;
        }

        private void states_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(states.SelectedItem.ToString() == "Врач")
            {
                UIHelper.Clear.Comboboxes(posts);
                posts.Items.AddRange(DataBase.Get.Posts().ToArray());
                posts.Items.Remove("Не врач");
                posts.Enabled = true;
                licence.Text = "";
                licence.Enabled = true;
            }    
            if(states.SelectedItem.ToString() != "Врач")
            {
                UIHelper.Clear.Comboboxes(posts);
                posts.Items.Add("Не врач");
                posts.SelectedItem = "Не врач";
                posts.Enabled = false;
                licence.Text = "Нет";
                licence.Enabled = false;
            }
        }

        private void licence_TextChanged(object sender, EventArgs e)
        {
            if(Validator.IsNulls(states.SelectedItem))
                return;

            if(licence.Text.ToLower().Trim() == "нет" && states.SelectedItem.ToString() == "Врач")
            {
                MessageBox.Show("так нельзя:)");
                licence.Text = "";
                return;
            }
        }
    }
}
