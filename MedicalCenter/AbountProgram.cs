using System;
using System.Windows.Forms;

namespace MedicalCenter
{
    public partial class AbountProgramForm : Form
    {
        public AbountProgramForm() => InitializeComponent();

        private void AbountProgramForm_Load(object sender, EventArgs e)
        {
            label1.Text = DataBase.ConvertToList<AbountProgram>
            (DataBase.SelectRequestExecute("select * from ProgramInformation"))[0].ToString();
            Theme.Set.FormStyle(this);
            FormClosed += (s, ev) => Hide();
        }
    }
}
