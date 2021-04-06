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

            //Methode an Eventhändler anschließen
            MainForm.OnFileHanldingRequested += new EventHandler(CSVFile.FileHandler);
            CSVFile.OnFileInputRequested += new EventHandler(CustomerDataList.CustomerListHandler);
            MainForm.OnEditRequested += new EventHandler(EditorForm.loadPerson);
            CustomerDataList.OnListRequested += new EventHandler(MainForm.ListView);
            MainForm.OnAddRequested += new EventHandler(AddForm.addPerson);
            AddForm.OnRefreshListRequested += new EventHandler(MainForm.RefreshList);
            EditorForm.OnRefreshListRequested += new EventHandler(MainForm.RefreshList);
            MoneyForm.OnRefreshListRequested += new EventHandler(MainForm.RefreshList);
            MainForm.RefreshList2 += new EventHandler(MainForm.ListView);
            MainForm.OnMoneyRequested += new EventHandler(MoneyForm.loadPerson);
            MainForm.OnFileSavingRequested += new EventHandler(MainForm.WriteListToCSV);

            Application.Run(MainForm);
        }
    }
}
