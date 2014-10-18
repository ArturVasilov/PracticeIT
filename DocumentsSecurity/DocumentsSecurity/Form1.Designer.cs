namespace DocumentsSecurity
{
    partial class DocumentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentsForm));
            this.ShowChosenDocumentButton = new System.Windows.Forms.Button();
            this.RemoveChosenDocumentButton = new System.Windows.Forms.Button();
            this.AddDocumentButton = new System.Windows.Forms.Button();
            this.AddProgrammerDocumentButton = new System.Windows.Forms.Button();
            this.AddProjectDocumentButton = new System.Windows.Forms.Button();
            this.AddFinanceDocumentButton = new System.Windows.Forms.Button();
            this.EditChosenDocumentButton = new System.Windows.Forms.Button();
            this.DocumentsListBox = new System.Windows.Forms.ListBox();
            this.serializeDocumentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowChosenDocumentButton
            // 
            this.ShowChosenDocumentButton.Location = new System.Drawing.Point(10, 407);
            this.ShowChosenDocumentButton.Name = "ShowChosenDocumentButton";
            this.ShowChosenDocumentButton.Size = new System.Drawing.Size(160, 41);
            this.ShowChosenDocumentButton.TabIndex = 5;
            this.ShowChosenDocumentButton.Text = "Посмотреть";
            this.ShowChosenDocumentButton.UseVisualStyleBackColor = true;
            this.ShowChosenDocumentButton.Click += new System.EventHandler(this.ShowChosenDocumentButton_Click);
            // 
            // RemoveChosenDocumentButton
            // 
            this.RemoveChosenDocumentButton.Location = new System.Drawing.Point(350, 407);
            this.RemoveChosenDocumentButton.Name = "RemoveChosenDocumentButton";
            this.RemoveChosenDocumentButton.Size = new System.Drawing.Size(163, 41);
            this.RemoveChosenDocumentButton.TabIndex = 7;
            this.RemoveChosenDocumentButton.Text = "Удалить";
            this.RemoveChosenDocumentButton.UseVisualStyleBackColor = true;
            this.RemoveChosenDocumentButton.Click += new System.EventHandler(this.RemoveChosenDocumentButton_Click);
            // 
            // AddDocumentButton
            // 
            this.AddDocumentButton.Location = new System.Drawing.Point(543, 17);
            this.AddDocumentButton.Name = "AddDocumentButton";
            this.AddDocumentButton.Size = new System.Drawing.Size(240, 50);
            this.AddDocumentButton.TabIndex = 1;
            this.AddDocumentButton.Text = "Добавить отчет";
            this.AddDocumentButton.UseVisualStyleBackColor = true;
            this.AddDocumentButton.Click += new System.EventHandler(this.AddReportButton_Click);
            // 
            // AddProgrammerDocumentButton
            // 
            this.AddProgrammerDocumentButton.Location = new System.Drawing.Point(543, 90);
            this.AddProgrammerDocumentButton.Name = "AddProgrammerDocumentButton";
            this.AddProgrammerDocumentButton.Size = new System.Drawing.Size(240, 50);
            this.AddProgrammerDocumentButton.TabIndex = 2;
            this.AddProgrammerDocumentButton.Text = "Добавить информацию о сотруднике";
            this.AddProgrammerDocumentButton.UseVisualStyleBackColor = true;
            this.AddProgrammerDocumentButton.Click += new System.EventHandler(this.AddProgrammerDocumentButton_Click);
            // 
            // AddProjectDocumentButton
            // 
            this.AddProjectDocumentButton.Location = new System.Drawing.Point(543, 166);
            this.AddProjectDocumentButton.Name = "AddProjectDocumentButton";
            this.AddProjectDocumentButton.Size = new System.Drawing.Size(240, 50);
            this.AddProjectDocumentButton.TabIndex = 3;
            this.AddProjectDocumentButton.Text = "Добавить проектный договор";
            this.AddProjectDocumentButton.UseVisualStyleBackColor = true;
            this.AddProjectDocumentButton.Click += new System.EventHandler(this.AddProjectDocumentButton_Click);
            // 
            // AddFinanceDocumentButton
            // 
            this.AddFinanceDocumentButton.Location = new System.Drawing.Point(543, 236);
            this.AddFinanceDocumentButton.Name = "AddFinanceDocumentButton";
            this.AddFinanceDocumentButton.Size = new System.Drawing.Size(240, 50);
            this.AddFinanceDocumentButton.TabIndex = 4;
            this.AddFinanceDocumentButton.Text = "Добавить финансовую декларацию";
            this.AddFinanceDocumentButton.UseVisualStyleBackColor = true;
            this.AddFinanceDocumentButton.Click += new System.EventHandler(this.AddFinanceDocumentButton_Click);
            // 
            // EditChosenDocumentButton
            // 
            this.EditChosenDocumentButton.Location = new System.Drawing.Point(180, 407);
            this.EditChosenDocumentButton.Name = "EditChosenDocumentButton";
            this.EditChosenDocumentButton.Size = new System.Drawing.Size(160, 41);
            this.EditChosenDocumentButton.TabIndex = 6;
            this.EditChosenDocumentButton.Text = "Редактировать";
            this.EditChosenDocumentButton.UseVisualStyleBackColor = true;
            this.EditChosenDocumentButton.Click += new System.EventHandler(this.EditChosenDocumentButton_Click);
            // 
            // DocumentsListBox
            // 
            this.DocumentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentsListBox.FormattingEnabled = true;
            this.DocumentsListBox.ItemHeight = 20;
            this.DocumentsListBox.Location = new System.Drawing.Point(10, 17);
            this.DocumentsListBox.Name = "DocumentsListBox";
            this.DocumentsListBox.Size = new System.Drawing.Size(500, 384);
            this.DocumentsListBox.TabIndex = 0;
            // 
            // serializeDocumentButton
            // 
            this.serializeDocumentButton.Location = new System.Drawing.Point(543, 351);
            this.serializeDocumentButton.Name = "serializeDocumentButton";
            this.serializeDocumentButton.Size = new System.Drawing.Size(240, 50);
            this.serializeDocumentButton.TabIndex = 11;
            this.serializeDocumentButton.Text = "Сериализовать";
            this.serializeDocumentButton.UseVisualStyleBackColor = true;
            this.serializeDocumentButton.Click += new System.EventHandler(this.serializeDocumentButton_Click);
            // 
            // DocumentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 453);
            this.Controls.Add(this.serializeDocumentButton);
            this.Controls.Add(this.DocumentsListBox);
            this.Controls.Add(this.EditChosenDocumentButton);
            this.Controls.Add(this.AddFinanceDocumentButton);
            this.Controls.Add(this.AddProjectDocumentButton);
            this.Controls.Add(this.AddProgrammerDocumentButton);
            this.Controls.Add(this.AddDocumentButton);
            this.Controls.Add(this.RemoveChosenDocumentButton);
            this.Controls.Add(this.ShowChosenDocumentButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentsForm";
            this.Text = "Система обработки документов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocumentsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowChosenDocumentButton;
        private System.Windows.Forms.Button RemoveChosenDocumentButton;
        private System.Windows.Forms.Button AddDocumentButton;
        private System.Windows.Forms.Button AddProgrammerDocumentButton;
        private System.Windows.Forms.Button AddProjectDocumentButton;
        private System.Windows.Forms.Button AddFinanceDocumentButton;
        private System.Windows.Forms.Button EditChosenDocumentButton;
        private System.Windows.Forms.ListBox DocumentsListBox;
        private System.Windows.Forms.Button serializeDocumentButton;
    }
}

