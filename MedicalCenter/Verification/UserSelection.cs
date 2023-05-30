using System;
using System.Windows.Forms;
using MedicalCenter.Verification;

namespace MedicalCenter
{
    public partial class UserSelection : Form
    {
        public UserSelection() => InitializeComponent();
        private void UserSelection_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void IamStaff_Click(object sender, EventArgs e) =>  VerificationManager.GoEnterForm(new StaffEnter(), this);
        private void IamPatient_Click(object sender, EventArgs e) => VerificationManager.GoEnterForm(new PatientEnter(), this);

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape: Application.Exit(); break;
                case Keys.CapsLock: MessageLine.Text = UIHelper.CapsOnOff(); break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UserSelection_Load(object sender, EventArgs e)
        {
            Theme.Set.FormStyle(this);
            SetLightTheme.Visible = false;
            SetDarkTheme.Visible = false;

            if (Theme.CurrentThemeType == Theme.ThemesTypes.Dark)
                SetLightTheme.Visible = true;
            if (Theme.CurrentThemeType == Theme.ThemesTypes.Light)
                SetDarkTheme.Visible = true;
        }
        private void SetDarkTheme_Click(object sender, EventArgs e)
        {
            if(Theme.CurrentThemeType == Theme.ThemesTypes.Light)
            {
                Theme.Set.CurrentTheme(Theme.ThemesTypes.Dark);
                Theme.Set.FormStyle(this);
                SetDarkTheme.Visible = false;
                SetLightTheme.Visible = true;
            }
        }

        private void SetLightTheme_Click(object sender, EventArgs e)
        {
            if (Theme.CurrentThemeType == Theme.ThemesTypes.Dark)
            {
                Theme.Set.CurrentTheme(Theme.ThemesTypes.Light);
                Theme.Set.FormStyle(this);
                SetDarkTheme.Visible = true;
                SetLightTheme.Visible = false;
            }
        }

        private void ShowProgramInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbountProgramForm abountProgramForm = new AbountProgramForm();
            abountProgramForm.ShowDialog();
        }
    }
}
