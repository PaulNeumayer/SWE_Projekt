namespace SWE_Projekt_Neumayer
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.Button();
            this.button_saveFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(62, 124);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 32);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMoney
            // 
            this.buttonMoney.Location = new System.Drawing.Point(306, 124);
            this.buttonMoney.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(97, 32);
            this.buttonMoney.TabIndex = 1;
            this.buttonMoney.Text = "MONEY";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(432, 124);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(97, 32);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseCompatibleTextRendering = true;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(51, 191);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(485, 134);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(51, 27);
            this.openFile.Margin = new System.Windows.Forms.Padding(2);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(96, 19);
            this.openFile.TabIndex = 6;
            this.openFile.Tag = "OpenFile";
            this.openFile.Text = "OPEN FILE";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // button_saveFile
            // 
            this.button_saveFile.Location = new System.Drawing.Point(51, 60);
            this.button_saveFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_saveFile.Name = "button_saveFile";
            this.button_saveFile.Size = new System.Drawing.Size(96, 19);
            this.button_saveFile.TabIndex = 9;
            this.button_saveFile.Tag = "OpenFile";
            this.button_saveFile.Text = "SAVE FILE";
            this.button_saveFile.UseVisualStyleBackColor = true;
            this.button_saveFile.Click += new System.EventHandler(this.button_saveFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_saveFile);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonMoney);
            this.Controls.Add(this.buttonAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Tag = "OpenFile";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button button_saveFile;
        private System.Windows.Forms.Button button1;
    }
}