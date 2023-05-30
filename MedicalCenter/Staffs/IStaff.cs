namespace MedicalCenter.Staffs
{
    internal interface IStaff
    {
        int id { get; set; }
        string sEmail { get; set; }
        string sName { get; set; }
        string sPassword { get; set; }
        string sSecondPassword { get; set; }
        string sKeyWord { get; set; }
        string sPost { get; set; }
        string sLicence { get; set; }
        string sState { get; set; }
        bool HasEntered { get; set; }
        void GoNext();

    }

}
