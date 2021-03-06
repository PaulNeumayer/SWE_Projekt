using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Projekt_Neumayer
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Mit Main Form ersetzt Line 37
            //Application.Run(new EditForm());

            //damit Eventhandler auf Methoden der Klassen zugreifen kann
            MainForm MainForm = new MainForm();
            CSVFile CSVFile = new CSVFile();
            CustomerDataList CustomerDataList = new CustomerDataList();
            EditForm EditorForm = new EditForm();
            AddForm AddForm = new AddForm();
            MoneyForm MoneyForm = new MoneyForm();
            PasswordForm PasswordForm = new PasswordForm();

            //Methode an Eventhändler anschließen
            MainForm.OnFileHanldingRequested += new EventHandler(CSVFile.FileHandler);
            CSVFile.OnFileInputRequested += new EventHandler(CustomerDataList.CustomerListHandler);
            MainForm.OnEditRequested += new EventHandler(EditorForm.loadPerson);
            MainForm.OnDeleteRequested += new EventHandler(CustomerDataList.DelteCustomerFromList);
            CustomerDataList.OnListRequested += new EventHandler(MainForm.ListView);
            AddForm.OnRefreshListRequested += new EventHandler(MainForm.RefreshList);
            EditorForm.OnRefreshListRequested += new EventHandler(MainForm.RefreshList);
            MoneyForm.OnRefreshListRequested += new EventHandler(MainForm.RefreshList);
            MoneyForm.OnRefreshListRequested += new EventHandler(MainForm.RefreshList);
            MainForm.RefreshList2 += new EventHandler(MainForm.ListView);
            MainForm.OnMoneyRequested += new EventHandler(MoneyForm.loadPerson);
            MainForm.OnFileSavingRequested += new EventHandler(CSVFile.WriteListToCSV);
            CustomerDataList.OnLogRequested += new EventHandler(CSVFile.LogToCSV);
            MainForm.OnAddCustomerRequested += new EventHandler(CustomerDataList.AddCustomerToList);
            CustomerDataList.OnAddCustomer += new EventHandler(AddForm.addCustomer);
            PasswordForm.OnPasswordCorrect += new EventHandler(MainForm.openMain);
            PasswordForm.OnLogRequestedPassword += new EventHandler(CSVFile.LogToCSVPasswordwrong);
            CustomerDataList.OnDeleteRefreshRequested += new EventHandler(MainForm.RefreshList);

            Application.Run(PasswordForm);
        }
    }
}
