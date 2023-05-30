using MedicalCenter.Users;
using System.Windows.Forms;

namespace MedicalCenter.Verification
{
    internal static class VerificationManager
    {
        public static string KeyWord { get; set; }

        private static UserSelection userSelection = new UserSelection();
        private static ConfirmEmail EmailForm = new ConfirmEmail();
        private static KeyWordConfirmation KeyForm = new KeyWordConfirmation();
        public static Form CurrentEnterForm;

        public static bool VerificationRefused { get; set; }
        public static bool VerificationPassed { get; set; }


        public static void GoBackUserSelection()
        {
            CurrentEnterForm.Hide();
            userSelection.Show();
        }
        public static void ExitFrom(Form currentForm)
        {
            currentForm.Hide();
            userSelection.Show();
        }
        public static void GoEnterForm(Form EnterForm,Form from)
        {
            from.Hide();
            CurrentEnterForm = EnterForm;
            CurrentEnterForm.Show();
        }
       
        public static bool PassRegistrationConfimation(string email, string name)
        {
            SendMessage(email, name, true, false);
            EmailForm.GoToAWordConfirmation.Visible = false;
            EmailForm.ShowDialog();

            while (!VerificationRefused)
                if (VerificationPassed)
                {
                    VerificationPassed = false;
                    CurrentEnterForm.Hide();
                    return true;
                }
            VerificationRefused = false;
            return false;
        }
        public static bool PassConfirmation(string email, string name, string keyWord,bool isNewMachine)
        {
            SendMessage(email, name, false, isNewMachine);

            KeyWord = keyWord;
            EmailForm.ShowDialog();

            while (!VerificationRefused)
            {
                if (EmailForm.changed)
                {
                    EmailForm.changed = false;
                    KeyForm.ShowDialog();
                }

                if (KeyForm.changed)
                {
                    KeyForm.changed = false;
                    EmailForm.ShowDialog();
                }

                if (VerificationPassed)
                {
                    VerificationPassed = false;
                    CurrentEnterForm.Hide();
                    EmailForm.Hide();
                    KeyForm.Hide();
                    return true;
                }
            }
            VerificationRefused = false;
            return false;
        }
       
        private static void SendMessage(string email, string name, bool isNewUser,bool isNewMachineName)
        {
            EmailManager.GenerateNumber();

            if (!isNewUser && !isNewMachineName)
                EmailManager.SendMessage(email, $"{name}, добро пожаловать",
                   $"\nРады вас снова здесь видеть, для подтверждения электронной почты введите число: {EmailManager.numberToConfirmEmail}");
            
            if(!isNewUser&& isNewMachineName)
                EmailManager.SendMessage(email, $"{name}, добро пожаловать",
                    $"\nРады вас снова здесь видеть, вы совершили вход с другого устройства, для подтверждения почты вам необходимо ввести это число: {EmailManager.numberToConfirmEmail}");
            if (isNewUser)
                EmailManager.SendMessage(email, $"{name}, добро пожаловать",
               $"\nСпасибо, что зарегистрировались в нашем медицинском центре, для подтверждения электронной почты введите число: {EmailManager.numberToConfirmEmail}");
        
        }
    }
}
