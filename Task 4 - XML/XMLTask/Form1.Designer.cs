namespace XMLTask
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelOfCreateXml = new System.Windows.Forms.Panel();
            this.PanelOfChangingXml = new System.Windows.Forms.Panel();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.SelectedFileEdit = new System.Windows.Forms.TextBox();
            this.itemsAtXmlFile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstNameEdit = new System.Windows.Forms.TextBox();
            this.AgeEdit = new System.Windows.Forms.TextBox();
            this.IdEdit = new System.Windows.Forms.TextBox();
            this.LastNameEdit = new System.Windows.Forms.TextBox();
            this.SecondNameEdit = new System.Windows.Forms.TextBox();
            this.SaveFile = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.NameOfCreatingXml = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AddPeopleToListOfCreatingButton = new System.Windows.Forms.Button();
            this.CreateXmlFileButton = new System.Windows.Forms.Button();
            this.FirstNameEditN = new System.Windows.Forms.TextBox();
            this.LastNameEditN = new System.Windows.Forms.TextBox();
            this.SecondNameEditN = new System.Windows.Forms.TextBox();
            this.AgeEditN = new System.Windows.Forms.TextBox();
            this.IdEditN = new System.Windows.Forms.TextBox();
            this.PanelOfCreateXml.SuspendLayout();
            this.PanelOfChangingXml.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOfCreateXml
            // 
            this.PanelOfCreateXml.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PanelOfCreateXml.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelOfCreateXml.Controls.Add(this.IdEditN);
            this.PanelOfCreateXml.Controls.Add(this.AgeEditN);
            this.PanelOfCreateXml.Controls.Add(this.SecondNameEditN);
            this.PanelOfCreateXml.Controls.Add(this.LastNameEditN);
            this.PanelOfCreateXml.Controls.Add(this.FirstNameEditN);
            this.PanelOfCreateXml.Controls.Add(this.CreateXmlFileButton);
            this.PanelOfCreateXml.Controls.Add(this.AddPeopleToListOfCreatingButton);
            this.PanelOfCreateXml.Controls.Add(this.label13);
            this.PanelOfCreateXml.Controls.Add(this.label11);
            this.PanelOfCreateXml.Controls.Add(this.label10);
            this.PanelOfCreateXml.Controls.Add(this.label9);
            this.PanelOfCreateXml.Controls.Add(this.label8);
            this.PanelOfCreateXml.Location = new System.Drawing.Point(13, 39);
            this.PanelOfCreateXml.Name = "PanelOfCreateXml";
            this.PanelOfCreateXml.Size = new System.Drawing.Size(269, 290);
            this.PanelOfCreateXml.TabIndex = 0;
            // 
            // PanelOfChangingXml
            // 
            this.PanelOfChangingXml.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PanelOfChangingXml.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelOfChangingXml.Controls.Add(this.SaveChangesButton);
            this.PanelOfChangingXml.Controls.Add(this.SaveFile);
            this.PanelOfChangingXml.Controls.Add(this.SecondNameEdit);
            this.PanelOfChangingXml.Controls.Add(this.LastNameEdit);
            this.PanelOfChangingXml.Controls.Add(this.IdEdit);
            this.PanelOfChangingXml.Controls.Add(this.AgeEdit);
            this.PanelOfChangingXml.Controls.Add(this.FirstNameEdit);
            this.PanelOfChangingXml.Controls.Add(this.label6);
            this.PanelOfChangingXml.Controls.Add(this.label4);
            this.PanelOfChangingXml.Controls.Add(this.label3);
            this.PanelOfChangingXml.Controls.Add(this.label2);
            this.PanelOfChangingXml.Controls.Add(this.label1);
            this.PanelOfChangingXml.Controls.Add(this.itemsAtXmlFile);
            this.PanelOfChangingXml.Enabled = false;
            this.PanelOfChangingXml.Location = new System.Drawing.Point(305, 39);
            this.PanelOfChangingXml.Name = "PanelOfChangingXml";
            this.PanelOfChangingXml.Size = new System.Drawing.Size(324, 290);
            this.PanelOfChangingXml.TabIndex = 1;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(305, 13);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(113, 23);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "Выбрать файл";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // SelectedFileEdit
            // 
            this.SelectedFileEdit.Location = new System.Drawing.Point(424, 14);
            this.SelectedFileEdit.Name = "SelectedFileEdit";
            this.SelectedFileEdit.Size = new System.Drawing.Size(194, 22);
            this.SelectedFileEdit.TabIndex = 1;
            this.SelectedFileEdit.Text = "file.xml";
            // 
            // itemsAtXmlFile
            // 
            this.itemsAtXmlFile.FormattingEnabled = true;
            this.itemsAtXmlFile.Location = new System.Drawing.Point(3, 3);
            this.itemsAtXmlFile.Name = "itemsAtXmlFile";
            this.itemsAtXmlFile.Size = new System.Drawing.Size(313, 24);
            this.itemsAtXmlFile.TabIndex = 2;
            this.itemsAtXmlFile.SelectionChangeCommitted += new System.EventHandler(this.itemsAtXmlFile_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Возраст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Уникальный номер";
            // 
            // FirstNameEdit
            // 
            this.FirstNameEdit.Location = new System.Drawing.Point(137, 43);
            this.FirstNameEdit.Name = "FirstNameEdit";
            this.FirstNameEdit.Size = new System.Drawing.Size(179, 22);
            this.FirstNameEdit.TabIndex = 9;
            // 
            // AgeEdit
            // 
            this.AgeEdit.Location = new System.Drawing.Point(137, 144);
            this.AgeEdit.Name = "AgeEdit";
            this.AgeEdit.Size = new System.Drawing.Size(179, 22);
            this.AgeEdit.TabIndex = 10;
            // 
            // IdEdit
            // 
            this.IdEdit.Location = new System.Drawing.Point(137, 172);
            this.IdEdit.Name = "IdEdit";
            this.IdEdit.Size = new System.Drawing.Size(179, 22);
            this.IdEdit.TabIndex = 12;
            // 
            // LastNameEdit
            // 
            this.LastNameEdit.Location = new System.Drawing.Point(138, 73);
            this.LastNameEdit.Name = "LastNameEdit";
            this.LastNameEdit.Size = new System.Drawing.Size(179, 22);
            this.LastNameEdit.TabIndex = 13;
            // 
            // SecondNameEdit
            // 
            this.SecondNameEdit.Location = new System.Drawing.Point(137, 101);
            this.SecondNameEdit.Name = "SecondNameEdit";
            this.SecondNameEdit.Size = new System.Drawing.Size(179, 22);
            this.SecondNameEdit.TabIndex = 14;
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(3, 229);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(313, 52);
            this.SaveFile.TabIndex = 15;
            this.SaveFile.Text = "Сохранить файл";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(4, 198);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(313, 23);
            this.SaveChangesButton.TabIndex = 16;
            this.SaveChangesButton.Text = "Сохранить изменения";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Имя файла";
            // 
            // NameOfCreatingXml
            // 
            this.NameOfCreatingXml.Location = new System.Drawing.Point(110, 13);
            this.NameOfCreatingXml.Name = "NameOfCreatingXml";
            this.NameOfCreatingXml.Size = new System.Drawing.Size(172, 22);
            this.NameOfCreatingXml.TabIndex = 3;
            this.NameOfCreatingXml.Text = "file.xml";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Фамилия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-1, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Отчество";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-1, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Возраст";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Уникальный номер";
            // 
            // AddPeopleToListOfCreatingButton
            // 
            this.AddPeopleToListOfCreatingButton.Location = new System.Drawing.Point(1, 198);
            this.AddPeopleToListOfCreatingButton.Name = "AddPeopleToListOfCreatingButton";
            this.AddPeopleToListOfCreatingButton.Size = new System.Drawing.Size(261, 23);
            this.AddPeopleToListOfCreatingButton.TabIndex = 6;
            this.AddPeopleToListOfCreatingButton.Text = "Добавить человека";
            this.AddPeopleToListOfCreatingButton.UseVisualStyleBackColor = true;
            this.AddPeopleToListOfCreatingButton.Click += new System.EventHandler(this.AddPeopleToListOfCreatingButton_Click);
            // 
            // CreateXmlFileButton
            // 
            this.CreateXmlFileButton.Location = new System.Drawing.Point(2, 227);
            this.CreateXmlFileButton.Name = "CreateXmlFileButton";
            this.CreateXmlFileButton.Size = new System.Drawing.Size(260, 54);
            this.CreateXmlFileButton.TabIndex = 7;
            this.CreateXmlFileButton.Text = "Создать файл";
            this.CreateXmlFileButton.UseVisualStyleBackColor = true;
            this.CreateXmlFileButton.Click += new System.EventHandler(this.CreateXmlFileButton_Click);
            // 
            // FirstNameEditN
            // 
            this.FirstNameEditN.Location = new System.Drawing.Point(140, 10);
            this.FirstNameEditN.Name = "FirstNameEditN";
            this.FirstNameEditN.Size = new System.Drawing.Size(122, 22);
            this.FirstNameEditN.TabIndex = 8;
            this.FirstNameEditN.Text = "Artur";
            // 
            // LastNameEditN
            // 
            this.LastNameEditN.Location = new System.Drawing.Point(140, 42);
            this.LastNameEditN.Name = "LastNameEditN";
            this.LastNameEditN.Size = new System.Drawing.Size(122, 22);
            this.LastNameEditN.TabIndex = 9;
            this.LastNameEditN.Text = "Vasilov";
            // 
            // SecondNameEditN
            // 
            this.SecondNameEditN.Location = new System.Drawing.Point(140, 72);
            this.SecondNameEditN.Name = "SecondNameEditN";
            this.SecondNameEditN.Size = new System.Drawing.Size(122, 22);
            this.SecondNameEditN.TabIndex = 10;
            this.SecondNameEditN.Text = "Ras";
            // 
            // AgeEditN
            // 
            this.AgeEditN.Location = new System.Drawing.Point(140, 126);
            this.AgeEditN.Name = "AgeEditN";
            this.AgeEditN.Size = new System.Drawing.Size(122, 22);
            this.AgeEditN.TabIndex = 11;
            this.AgeEditN.Text = "18";
            // 
            // IdEditN
            // 
            this.IdEditN.Location = new System.Drawing.Point(140, 167);
            this.IdEditN.Name = "IdEditN";
            this.IdEditN.Size = new System.Drawing.Size(122, 22);
            this.IdEditN.TabIndex = 13;
            this.IdEditN.Text = "4353";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(641, 341);
            this.Controls.Add(this.NameOfCreatingXml);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SelectedFileEdit);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.PanelOfChangingXml);
            this.Controls.Add(this.PanelOfCreateXml);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelOfCreateXml.ResumeLayout(false);
            this.PanelOfCreateXml.PerformLayout();
            this.PanelOfChangingXml.ResumeLayout(false);
            this.PanelOfChangingXml.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelOfCreateXml;
        private System.Windows.Forms.Panel PanelOfChangingXml;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.TextBox SecondNameEdit;
        private System.Windows.Forms.TextBox LastNameEdit;
        private System.Windows.Forms.TextBox IdEdit;
        private System.Windows.Forms.TextBox AgeEdit;
        private System.Windows.Forms.TextBox FirstNameEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemsAtXmlFile;
        private System.Windows.Forms.TextBox SelectedFileEdit;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TextBox IdEditN;
        private System.Windows.Forms.TextBox AgeEditN;
        private System.Windows.Forms.TextBox SecondNameEditN;
        private System.Windows.Forms.TextBox LastNameEditN;
        private System.Windows.Forms.TextBox FirstNameEditN;
        private System.Windows.Forms.Button CreateXmlFileButton;
        private System.Windows.Forms.Button AddPeopleToListOfCreatingButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameOfCreatingXml;

    }
}

