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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ShowChosenDocumentButton = new System.Windows.Forms.Button();
            this.RemoveChosenDocumentButton = new System.Windows.Forms.Button();
            this.AddDocumentButton = new System.Windows.Forms.Button();
            this.AddProgrammerDocumentButton = new System.Windows.Forms.Button();
            this.AddProjectDocumentButton = new System.Windows.Forms.Button();
            this.AddFinanceDocumentButton = new System.Windows.Forms.Button();
            this.EditChosenDocumentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(10, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 400);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ShowChosenDocumentButton
            // 
            this.ShowChosenDocumentButton.Location = new System.Drawing.Point(10, 418);
            this.ShowChosenDocumentButton.Name = "ShowChosenDocumentButton";
            this.ShowChosenDocumentButton.Size = new System.Drawing.Size(160, 30);
            this.ShowChosenDocumentButton.TabIndex = 5;
            this.ShowChosenDocumentButton.Text = "Посмотреть";
            this.ShowChosenDocumentButton.UseVisualStyleBackColor = true;
            // 
            // RemoveChosenDocumentButton
            // 
            this.RemoveChosenDocumentButton.Location = new System.Drawing.Point(350, 418);
            this.RemoveChosenDocumentButton.Name = "RemoveChosenDocumentButton";
            this.RemoveChosenDocumentButton.Size = new System.Drawing.Size(160, 30);
            this.RemoveChosenDocumentButton.TabIndex = 7;
            this.RemoveChosenDocumentButton.Text = "Удалить";
            this.RemoveChosenDocumentButton.UseVisualStyleBackColor = true;
            // 
            // AddDocumentButton
            // 
            this.AddDocumentButton.Location = new System.Drawing.Point(635, 100);
            this.AddDocumentButton.Name = "AddDocumentButton";
            this.AddDocumentButton.Size = new System.Drawing.Size(240, 50);
            this.AddDocumentButton.TabIndex = 1;
            this.AddDocumentButton.Text = "Добавить документ";
            this.AddDocumentButton.UseVisualStyleBackColor = true;
            this.AddDocumentButton.Click += new System.EventHandler(this.AddDocumentButton_Click);
            // 
            // AddProgrammerDocumentButton
            // 
            this.AddProgrammerDocumentButton.Location = new System.Drawing.Point(635, 170);
            this.AddProgrammerDocumentButton.Name = "AddProgrammerDocumentButton";
            this.AddProgrammerDocumentButton.Size = new System.Drawing.Size(240, 50);
            this.AddProgrammerDocumentButton.TabIndex = 2;
            this.AddProgrammerDocumentButton.Text = "Добавить информацию о сотруднике";
            this.AddProgrammerDocumentButton.UseVisualStyleBackColor = true;
            this.AddProgrammerDocumentButton.Click += new System.EventHandler(this.AddProgrammerDocumentButton_Click);
            // 
            // AddProjectDocumentButton
            // 
            this.AddProjectDocumentButton.Location = new System.Drawing.Point(635, 240);
            this.AddProjectDocumentButton.Name = "AddProjectDocumentButton";
            this.AddProjectDocumentButton.Size = new System.Drawing.Size(240, 50);
            this.AddProjectDocumentButton.TabIndex = 3;
            this.AddProjectDocumentButton.Text = "Добавить проектный договор";
            this.AddProjectDocumentButton.UseVisualStyleBackColor = true;
            this.AddProjectDocumentButton.Click += new System.EventHandler(this.AddProjectDocumentButton_Click);
            // 
            // AddFinanceDocumentButton
            // 
            this.AddFinanceDocumentButton.Location = new System.Drawing.Point(635, 310);
            this.AddFinanceDocumentButton.Name = "AddFinanceDocumentButton";
            this.AddFinanceDocumentButton.Size = new System.Drawing.Size(240, 50);
            this.AddFinanceDocumentButton.TabIndex = 4;
            this.AddFinanceDocumentButton.Text = "Добавить финансовую декларацию";
            this.AddFinanceDocumentButton.UseVisualStyleBackColor = true;
            this.AddFinanceDocumentButton.Click += new System.EventHandler(this.AddFinanceDocumentButton_Click);
            // 
            // EditChosenDocumentButton
            // 
            this.EditChosenDocumentButton.Location = new System.Drawing.Point(180, 418);
            this.EditChosenDocumentButton.Name = "EditChosenDocumentButton";
            this.EditChosenDocumentButton.Size = new System.Drawing.Size(160, 30);
            this.EditChosenDocumentButton.TabIndex = 6;
            this.EditChosenDocumentButton.Text = "Редактировать";
            this.EditChosenDocumentButton.UseVisualStyleBackColor = true;
            // 
            // DocumentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.EditChosenDocumentButton);
            this.Controls.Add(this.AddFinanceDocumentButton);
            this.Controls.Add(this.AddProjectDocumentButton);
            this.Controls.Add(this.AddProgrammerDocumentButton);
            this.Controls.Add(this.AddDocumentButton);
            this.Controls.Add(this.RemoveChosenDocumentButton);
            this.Controls.Add(this.ShowChosenDocumentButton);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentsForm";
            this.Text = "Система обработки документов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ShowChosenDocumentButton;
        private System.Windows.Forms.Button RemoveChosenDocumentButton;
        private System.Windows.Forms.Button AddDocumentButton;
        private System.Windows.Forms.Button AddProgrammerDocumentButton;
        private System.Windows.Forms.Button AddProjectDocumentButton;
        private System.Windows.Forms.Button AddFinanceDocumentButton;
        private System.Windows.Forms.Button EditChosenDocumentButton;
    }
}

