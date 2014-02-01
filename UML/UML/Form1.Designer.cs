namespace UML
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
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.GenerateCodeButton = new System.Windows.Forms.Button();
            this.AddClassButton = new System.Windows.Forms.Button();
            this.ElementsPanel = new System.Windows.Forms.Panel();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ControlPanel.Controls.Add(this.AddClassButton);
            this.ControlPanel.Controls.Add(this.GenerateCodeButton);
            this.ControlPanel.Location = new System.Drawing.Point(-1, -1);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(848, 37);
            this.ControlPanel.TabIndex = 0;
            // 
            // GenerateCodeButton
            // 
            this.GenerateCodeButton.Location = new System.Drawing.Point(714, 3);
            this.GenerateCodeButton.Name = "GenerateCodeButton";
            this.GenerateCodeButton.Size = new System.Drawing.Size(117, 27);
            this.GenerateCodeButton.TabIndex = 0;
            this.GenerateCodeButton.Text = "Generate code";
            this.GenerateCodeButton.UseVisualStyleBackColor = true;
            this.GenerateCodeButton.Click += new System.EventHandler(this.GenerateCodeButton_Click);
            // 
            // AddClassButton
            // 
            this.AddClassButton.Location = new System.Drawing.Point(4, 4);
            this.AddClassButton.Name = "AddClassButton";
            this.AddClassButton.Size = new System.Drawing.Size(84, 23);
            this.AddClassButton.TabIndex = 1;
            this.AddClassButton.Text = "Add class";
            this.AddClassButton.UseVisualStyleBackColor = true;
            this.AddClassButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // ElementsPanel
            // 
            this.ElementsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ElementsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ElementsPanel.Location = new System.Drawing.Point(13, 43);
            this.ElementsPanel.Name = "ElementsPanel";
            this.ElementsPanel.Size = new System.Drawing.Size(819, 232);
            this.ElementsPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 287);
            this.Controls.Add(this.ElementsPanel);
            this.Controls.Add(this.ControlPanel);
            this.Name = "MainForm";
            this.Text = "UML";
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button AddClassButton;
        private System.Windows.Forms.Button GenerateCodeButton;
        private System.Windows.Forms.Panel ElementsPanel;
    }
}

