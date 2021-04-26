using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SWE_Projekt_Neumayer
{
    class CSVFile
    {
        //public event EventHandler FileHanlding;
        public event EventHandler OnFileInputRequested;

        OpenFileDialog PathOpen = new OpenFileDialog();
        SaveFileDialog PathSave = new SaveFileDialog();
        string PathOpened = string.Empty;

        public CSVFile()
        {

        }

        public void FileHandler(object sender, EventArgs args)
        {
            if (((Button)sender).Tag.ToString() == "OpenFile")
            {
                FileOpen(sender, args);
            }
        }

        private void FileOpen(object sender, EventArgs args)
        {
            PathOpen.Filter = "(*.csv;)|";
            PathOpen.ShowDialog();
            PathOpened = PathOpen.FileName;
            CreateCustomerList();


        }

        private string[] FileRead()
        {
            string[] Lines = File.ReadAllLines(PathOpened);
            return Lines;
        }

        public void WriteListToCSV(object sender, EventArgs args)
        {

            CustomEvents myCustomerList = (CustomEvents)args;
            FileStream fos = File.OpenWrite(PathOpened);
            StreamWriter streamWriter = new StreamWriter(fos);
            string Spliter = ";";



            streamWriter.WriteLine          //Für die erste Zeile in der Datei
                (
                "firstName" + Spliter
                + "lastName" + Spliter
                + "iD" + Spliter
                + "eMail" + Spliter
                + "balance" + Spliter
                + "myDate" + Spliter
                + "street" + Spliter
                + "code"
                );

            foreach (CustomerDataObj Customer in myCustomerList.Customers) // für jedes Object der Liste
            {
                streamWriter.WriteLine(Customer.Save()); // Methode der Klasse Person in welcher reihenfolge abgespeichert wird
            }

            streamWriter.Close();


            //LF = (CustomEvents)args;
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //sb.AppendLine("firstName;LastName;iD;eMail;balance;myDate");
            //foreach (var item in LF.Customers)
            //{
            //    sb.AppendLine(LF.CustomerDataObj.firstName + LF.CustomerDataObj.lastName + LF.CustomerDataObj.iD + LF.CustomerDataObj.eMail + LF.CustomerDataObj.balance + LF.CustomerDataObj.myDate);
            //}

            //Console.WriteLine(sb.ToString());
            //System.IO.File.WriteAllText(
            //    System.IO.Path.Combine(
            //    AppDomain.CurrentDomain.BaseDirectory, "List1.csv"),
            //    sb.ToString());
            //Console.ReadLine();

        }

        public void LogToCSV(object sender, EventArgs args)
        {
            DateTime localDate = DateTime.Now;

            PathOpened = "C:\\Users\\lukas\\source\\repos\\SWEProj\\SWE_Projekt_Neumayer\\SWE_Projekt_Neumayer\\LogFile.csv";

            StreamWriter streamWriterLog = new StreamWriter(PathOpened, append: true);
            string Spliter = ";";
            streamWriterLog.WriteLine(localDate + Spliter + " Deleted Person");
            streamWriterLog.Close();
        }

        private string[] CreateCustomer(string Line)
        {
            char Split = ';';
            List<string> Customer = new List<string>();
            StringBuilder Word = new StringBuilder();
            string Temp = string.Empty;

            try
            {
                foreach (char item in Line)
                {

                    if (item == Split)
                    {
                        Customer.Add(Word.ToString());
                        Word.Clear();
                    }
                    else if (item != Split)
                    {
                        Word.Append(item);
                    }
                }
            }
            finally //Damit das letzte Wort auch noch in die Liste kommt
            {
                Customer.Add(Word.ToString());
                Word.Clear();
            }

            return Customer.ToArray();
        }

        private void CreateCustomerList()
        {
            string[] Data = FileRead();

            string[,] SeperatedData = new string[FileRead().GetLength(0), 8];
            string[] Temp = new string[7];


            for (int i = 0; i < Data.GetLength(0); i++)
            {
                Temp = CreateCustomer(Data[i]);

                for (int k = 0; k < 8; k++)
                {
                    SeperatedData[i, k] = Temp[k];
                }
            }

            OnFileInputRequested(this, new CustomEvents(SeperatedData));

        }

        

    }
}

