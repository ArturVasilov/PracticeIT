namespace DocumentsSecurity
{
    partial class AddReportDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReportDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentReportAuthorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DocumentReportContentTextBox = new System.Windows.Forms.RichTextBox();
            this.DocumentReportOKButton = new System.Windows.Forms.Button();
            this.DocumentReportCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Автор:";
            // 
            // DocumentReportAuthorComboBox
            // 
            this.DocumentReportAuthorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentReportAuthorComboBox.FormattingEnabled = true;
            this.DocumentReportAuthorComboBox.Location = new System.Drawing.Point(78, 9);
            this.DocumentReportAuthorComboBox.Name = "DocumentReportAuthorComboBox";
            this.DocumentReportAuthorComboBox.Size = new System.Drawing.Size(282, 28);
            this.DocumentReportAuthorComboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчёт:";
            // 
            // DocumentReportContentTextBox
            // 
            this.DocumentReportContentTextBox.Location = new System.Drawing.Point(5, 75);
            this.DocumentReportContentTextBox.Name = "DocumentReportContentTextBox";
            this.DocumentReportContentTextBox.Size = new System.Drawing.Size(355, 195);
            this.DocumentReportContentTextBox.TabIndex = 8;
            this.DocumentReportContentTextBox.Text = "";
            // 
            // DocumentReportOKButton
            // 
            this.DocumentReportOKButton.Location = new System.Drawing.Point(5, 277);
            this.DocumentReportOKButton.Name = "DocumentReportOKButton";
            this.DocumentReportOKButton.Size = new System.Drawing.Size(170, 32);
            this.DocumentReportOKButton.TabIndex = 9;
            this.DocumentReportOKButton.Text = "Готово";
            this.DocumentReportOKButton.UseVisualStyleBackColor = true;
            this.DocumentReportOKButton.Click += new System.EventHandler(this.DocumentReportOKButton_Click);
            // 
            // DocumentReportCancelButton
            // 
            this.DocumentReportCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DocumentReportCancelButton.Location = new System.Drawing.Point(190, 277);
            this.DocumentReportCancelButton.Name = "DocumentReportCancelButton";
            this.DocumentReportCancelButton.Size = new System.Drawing.Size(170, 32);
            this.DocumentReportCancelButton.TabIndex = 10;
            this.DocumentReportCancelButton.Text = "Отмена";
            this.DocumentReportCancelButton.UseVisualStyleBackColor = true;
            // 
            // AddReportDialog
            // 
            this.AcceptButton = this.DocumentReportOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DocumentReportCancelButton;
            this.ClientSize = new System.Drawing.Size(365, 313);
            this.Controls.Add(this.DocumentReportCancelButton);
            this.Controls.Add(this.DocumentReportOKButton);
            this.Controls.Add(this.DocumentReportContentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DocumentReportAuthorComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddReportDialog";
            this.ShowInTaskbar = false;
            this.Text = "Добавление отчета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DocumentReportAuthorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox DocumentReportContentTextBox;
        private System.Windows.Forms.Button DocumentReportOKButton;
        private System.Windows.Forms.Button DocumentReportCancelButton;
    }
}