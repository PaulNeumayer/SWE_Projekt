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
            //Editor Editor1 = new Editor();

            //Methode an Eventhändler anschließen
            MainForm.OnFileHanldingRequested += new EventHandler(CSVFile.FileHandler);
            CSVFile.OnFileInputRequested += new EventHandler(CustomerDataList.CustomerListHandler);
            //MainForm.OnEditRequested += new EventHandler(Editor1.loadPerson);
            CustomerDataList.OnListRequested += new EventHandler(MainForm.ListView);
            //Editor1.OnRefreshListRequested += new EventHandler(PersonListAdmin.ChangePerson);
            //Editor1.OnRefreshListRequested += new EventHandler(PersonListAdmin.RefreshList);
            MainForm.RefreshList2 += new EventHandler(MainForm.ListView);

            Application.Run(MainForm);
        }
    }
}
