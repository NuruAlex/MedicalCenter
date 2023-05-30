
namespace MedicalCenter
{
    public static class EmailManager
    {
        private static string _from = "", _password = "";
        public static int numberToConfirmEmail = 0;
        private static System.Net.Mail.SmtpClient _client = new System.Net.Mail.SmtpClient("smtp.yandex.ru", 587);

        private static System.Random random = new System.Random();
        public static void GenerateNumber() =>  numberToConfirmEmail = random.Next(10000);

        public static void SetCredentials(string from, string paswword)
        {
            _from = from;
            _password = paswword;
            _client.Credentials = new System.Net.NetworkCredential(_from, _password);
            _client.EnableSsl = true;
        }

        public static void SendMessage(string to, string title, string body)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(_from, to);
            message.Subject = title;
            message.Body = body;
            message.IsBodyHtml = true;
            try
            {
                _client.Send(message);

            }catch(System.Net.Mail.SmtpException ex)
            {
                System.Windows.MessageBox.Show($"К сожалению произошла ошибка: { ex.Message } \nВы можете попробовать снова");
            }
        }
    }
}