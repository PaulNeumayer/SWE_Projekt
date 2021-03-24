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
        //Test 15:58 Uhr
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

            string[,] SeperatedData = new string[FileRead().GetLength(0), 5];
            string[] Temp = new string[5];


            for (int i = 0; i < Data.GetLength(0); i++)
            {
                Temp = CreateCustomer(Data[i]);

                for (int k = 0; k < 5; k++)
                {
                    SeperatedData[i, k] = Temp[k];
                }
            }

            OnFileInputRequested(this, new CustomEvents(SeperatedData));

        }
    }
}

