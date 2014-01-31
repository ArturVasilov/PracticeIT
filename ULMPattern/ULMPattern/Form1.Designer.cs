namespace ULMPattern
{
    partial class MainForm
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
            this.KeyButton = new System.Windows.Forms.Button();
            this.ClassPanel = new System.Windows.Forms.Panel();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.Attr1TB = new System.Windows.Forms.TextBox();
            this.AttributesLabel = new System.Windows.Forms.Label();
            this.AddAttributeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Method1TB = new System.Windows.Forms.TextBox();
            this.AddMethodButton = new System.Windows.Forms.Button();
            this.ClassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyButton
            // 
            this.KeyButton.Location = new System.Drawing.Point(556, 239);
            this.KeyButton.Name = "KeyButton";
            this.KeyButton.Size = new System.Drawing.Size(215, 42);
            this.KeyButton.TabIndex = 1;
            this.KeyButton.Text = "Сгенерировать код";
            this.KeyButton.UseVisualStyleBackColor = true;
            this.KeyButton.Click += new System.EventHandler(this.KeyButton_Click);
            // 
            // ClassPanel
            // 
            this.ClassPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClassPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClassPanel.Controls.Add(this.AddMethodButton);
            this.ClassPanel.Controls.Add(this.Method1TB);
            this.ClassPanel.Controls.Add(this.label1);
            this.ClassPanel.Controls.Add(this.AddAttributeButton);
            this.ClassPanel.Controls.Add(this.AttributesLabel);
            this.ClassPanel.Controls.Add(this.Attr1TB);
            this.ClassPanel.Controls.Add(this.ClassName);
            this.ClassPanel.Location = new System.Drawing.Point(13, 13);
            this.ClassPanel.Name = "ClassPanel";
            this.ClassPanel.Size = new System.Drawing.Size(274, 268);
            this.ClassPanel.TabIndex = 2;
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(49, 3);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(171, 22);
            this.ClassName.TabIndex = 0;
            this.ClassName.Text = "Название класса";
            this.ClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Attr1TB
            // 
            this.Attr1TB.Location = new System.Drawing.Point(3, 61);
            this.Attr1TB.Name = "Attr1TB";
            this.Attr1TB.Size = new System.Drawing.Size(263, 22);
            this.Attr1TB.TabIndex = 1;
            this.Attr1TB.Text = "Аттрибут 1";
            // 
            // AttributesLabel
            // 
            this.AttributesLabel.AutoSize = true;
            this.AttributesLabel.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttributesLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AttributesLabel.Location = new System.Drawing.Point(4, 38);
            this.AttributesLabel.Name = "AttributesLabel";
            this.AttributesLabel.Size = new System.Drawing.Size(103, 20);
            this.AttributesLabel.TabIndex = 2;
            this.AttributesLabel.Text = "Поля класса:";
            // 
            // AddAttributeButton
            // 
            this.AddAttributeButton.Location = new System.Drawing.Point(108, 89);
            this.AddAttributeButton.Name = "AddAttributeButton";
            this.AddAttributeButton.Size = new System.Drawing.Size(158, 23);
            this.AddAttributeButton.TabIndex = 3;
            this.AddAttributeButton.Text = "Добавить аттрибут";
            this.AddAttributeButton.UseVisualStyleBackColor = true;
            this.AddAttributeButton.Click += new System.EventHandler(this.AddAttributeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(5, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Методы класса:";
            // 
            // Method1TB
            // 
            this.Method1TB.Location = new System.Drawing.Point(3, 145);
            this.Method1TB.Name = "Method1TB";
            this.Method1TB.Size = new System.Drawing.Size(263, 22);
            this.Method1TB.TabIndex = 5;
            this.Method1TB.Text = "Метод 1";
            // 
            // AddMethodButton
            // 
            this.AddMethodButton.Location = new System.Drawing.Point(108, 173);
            this.AddMethodButton.Name = "AddMethodButton";
            this.AddMethodButton.Size = new System.Drawing.Size(158, 23);
            this.AddMethodButton.TabIndex = 6;
            this.AddMethodButton.Text = "Добавить метод";
            this.AddMethodButton.UseVisualStyleBackColor = true;
            this.AddMethodButton.Click += new System.EventHandler(this.AddMethodButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 293);
            this.Controls.Add(this.ClassPanel);
            this.Controls.Add(this.KeyButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ClassPanel.ResumeLayout(false);
            this.ClassPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KeyButton;
        private System.Windows.Forms.Panel ClassPanel;
        private System.Windows.Forms.TextBox Attr1TB;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Button AddMethodButton;
        private System.Windows.Forms.TextBox Method1TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAttributeButton;
        private System.Windows.Forms.Label AttributesLabel;
    }
}

