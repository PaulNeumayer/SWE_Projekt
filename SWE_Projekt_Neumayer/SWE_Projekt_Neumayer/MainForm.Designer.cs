namespace MyCode
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(94, 52);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 40);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMoney
            // 
            this.buttonMoney.Location = new System.Drawing.Point(342, 52);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(129, 40);
            this.buttonMoney.TabIndex = 1;
            this.buttonMoney.Text = "MONEY";
            this.buttonMoney.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(586, 52);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(129, 40);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseCompatibleTextRendering = true;
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(481, 405);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(159, 22);
            this.textBoxSearch.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(94, 235);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 164);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(587, 161);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(128, 23);
            this.openFile.TabIndex = 6;
            this.openFile.Tag = "OpenFile";
            this.openFile.Text = "OPEN FILE";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(661, 405);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(481, 235);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(280, 164);
            this.listBox2.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonMoney);
            this.Controls.Add(this.buttonAdd);
            this.Name = "MainForm";
            this.Tag = "OpenFile";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBox2;
    }
}