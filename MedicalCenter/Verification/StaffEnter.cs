using System;
using System.Windows.Forms;
using MedicalCenter.Staffs;
using MedicalCenter.Verification;

namespace MedicalCenter
{
    public partial class StaffEnter : Form
    {
        public StaffEnter() =>  InitializeComponent();
        private void StuffEnterForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void Home_Click(object sender, EventArgs e) => VerificationManager.GoBackUserSelection();

        private void LoadTheme()
        {
            Theme.Set.FormStyle(this);
           
            if(Theme.CurrentThemeType == Theme.ThemesTypes.Dark)
            {
                HomePicture.Image    = Properties.Resources.HomeDark;
                DeniedPicture.Image  = Properties.Resources.DeniedDark;
                SuccessPicture.Image = Properties.Resources.SuccessDark;
                unlockPicture1.Image = Properties.Resources.UnlockDark;
                unlockPicture2.Image = Properties.Resources.UnlockDark;
                lockPicture1.Image   = Properties.Resources.LockDark;
                lockPicture2.Image   = Properties.Resources.LockDark;
            }
            if(Theme.CurrentThemeType == Theme.ThemesTypes.Light)
            {
                HomePicture.Image = Properties.Resources.HomeLight;
                DeniedPicture.Image = Properties.Resources.DeniedLight;
                SuccessPicture.Image = Properties.Resources.SuccessLight;
                unlockPicture1.Image = Properties.Resources.UnlockLight;
                unlockPicture2.Image = Properties.Resources.UnlockLight;
                lockPicture1.Image = Properties.Resources.LockLight;
                lockPicture2.Image = Properties.Resources.LockLight;
            }
        }
        private void StuffEnterForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
            states.Items.AddRange(DataBase.Get.States().ToArray());
            SuccessPicture.Visible = false;
            
            int lastId = DataBase.Get.LastStaffEntered();
            
            if(lastId != -1)
            {
                email.Text = StaffManager.GetStaffById(lastId).sEmail;
                SuccessPicture.Visible = true;
                states.SelectedItem = StaffManager.GetStaffById(lastId).sState;
            }
            
            DeniedPicture.Visible = false;
            password.UseSystemPasswordChar = true;
            secondPassword.UseSystemPasswordChar = true;
            lockPicture1.Visible = true;
            lockPicture2.Visible = true;
            unlockPicture1.Visible = false;
            unlockPicture2.Visible = false;
        }

        private bool ValidateData() 
        {
            if(Validator.IsEmptyStrings(email.Text,password.Text,secondPassword.Text))
            {
                MessageBox.Show("Все данные должны быть введены!");
                return false;
            }
            if(Validator.IsNulls(states.SelectedItem))
            {
                MessageBox.Show("Выберите должность");
                return false;
            }
            if(Validator.IsNumbers(email.Text))
            {
                MessageBox.Show("Почта не может быть числом");
                return false;
            }
            return true;
        }
       
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            if (!StaffManager.StaffIsExist(email.Text, states.SelectedItem.ToString(), password.Text, secondPassword.Text))
            {
                MessageBox.Show("такого персонала не существует");
                return;
            }
            if (!StaffManager.StaffHasEntered())
            {
                if (StaffManager.PassConfirmation(false))
                {
                    StaffManager.Enter();
                    StaffManager.AddMachine(email.Text, states.SelectedItem.ToString());
                }
                return;
            }

            if (!StaffManager.IsCorrectMachineName(email.Text,states.SelectedItem.ToString()))
            {
                if (StaffManager.PassConfirmation(true))
                {
                    StaffManager.Enter();
                    StaffManager.AddMachine(email.Text,states.SelectedItem.ToString());
                }
                return;
            }
            VerificationManager.CurrentEnterForm.Hide();
            StaffManager.Enter();
        }
        private void email_TextChanged(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                SuccessPicture.Visible = false;
                DeniedPicture.Visible = false;
                return;
            }
            if (UserManager.EmailIsExist(email.Text))
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
            switch (keyData)
            {
                case Keys.Enter: EnterButton_Click(msg, new EventArgs()); break;
                case Keys.Escape: Home_Click(msg, new EventArgs()); break;
                case Keys.CapsLock: MessageLine.Text = UIHelper.CapsOnOff();break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
       
        private void lockPicture1_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
            lockPicture1.Visible = !lockPicture1.Visible;
            unlockPicture1.Visible = !unlockPicture1.Visible;
        }
        private void lockPicture2_Click(object sender, EventArgs e)
        {
            secondPassword.UseSystemPasswordChar = !secondPassword.UseSystemPasswordChar;
            lockPicture2.Visible = !lockPicture2.Visible;
            unlockPicture2.Visible = !unlockPicture2.Visible;
        }



    }
}
