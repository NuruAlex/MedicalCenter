using System;
using System.Windows.Forms;
namespace MedicalCenter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EmailManager.SetCredentials("nurualeksej@yandex.ru", "ldcnmmtepsfufepi");
            DataBase.InitConnection();
            Theme.Set.CurrentTheme(Theme.ThemesTypes.Dark);
            Application.Run(new UserSelection());
        }
    }
}
