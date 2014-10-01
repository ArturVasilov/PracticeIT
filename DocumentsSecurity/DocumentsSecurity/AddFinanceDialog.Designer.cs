namespace DocumentsSecurity
{
    partial class AddFinanceDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFinanceDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DocumentFinanceIncomeTextBox = new System.Windows.Forms.TextBox();
            this.DocumentFinanceExpenseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DocumentFinanceDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.DocumentFinanceOKButton = new System.Windows.Forms.Button();
            this.DocumentFinanceCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Доход (руб.) - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Расход (руб.) - ";
            // 
            // DocumentFinanceIncomeTextBox
            // 
            this.DocumentFinanceIncomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentFinanceIncomeTextBox.Location = new System.Drawing.Point(152, 24);
            this.DocumentFinanceIncomeTextBox.Name = "DocumentFinanceIncomeTextBox";
            this.DocumentFinanceIncomeTextBox.Size = new System.Drawing.Size(228, 27);
            this.DocumentFinanceIncomeTextBox.TabIndex = 1;
            // 
            // DocumentFinanceExpenseTextBox
            // 
            this.DocumentFinanceExpenseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentFinanceExpenseTextBox.Location = new System.Drawing.Point(150, 68);
            this.DocumentFinanceExpenseTextBox.Name = "DocumentFinanceExpenseTextBox";
            this.DocumentFinanceExpenseTextBox.Size = new System.Drawing.Size(228, 27);
            this.DocumentFinanceExpenseTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дополнительно:";
            // 
            // DocumentFinanceDescriptionTextBox
            // 
            this.DocumentFinanceDescriptionTextBox.Location = new System.Drawing.Point(12, 141);
            this.DocumentFinanceDescriptionTextBox.Name = "DocumentFinanceDescriptionTextBox";
            this.DocumentFinanceDescriptionTextBox.Size = new System.Drawing.Size(368, 164);
            this.DocumentFinanceDescriptionTextBox.TabIndex = 3;
            this.DocumentFinanceDescriptionTextBox.Text = "";
            // 
            // DocumentFinanceOKButton
            // 
            this.DocumentFinanceOKButton.Location = new System.Drawing.Point(12, 311);
            this.DocumentFinanceOKButton.Name = "DocumentFinanceOKButton";
            this.DocumentFinanceOKButton.Size = new System.Drawing.Size(175, 32);
            this.DocumentFinanceOKButton.TabIndex = 4;
            this.DocumentFinanceOKButton.Text = "Готово";
            this.DocumentFinanceOKButton.UseVisualStyleBackColor = true;
            this.DocumentFinanceOKButton.Click += new System.EventHandler(this.DocumentFinanceOKButton_Click);
            // 
            // DocumentFinanceCancelButton
            // 
            this.DocumentFinanceCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DocumentFinanceCancelButton.Location = new System.Drawing.Point(205, 311);
            this.DocumentFinanceCancelButton.Name = "DocumentFinanceCancelButton";
            this.DocumentFinanceCancelButton.Size = new System.Drawing.Size(173, 32);
            this.DocumentFinanceCancelButton.TabIndex = 5;
            this.DocumentFinanceCancelButton.Text = "Отмена";
            this.DocumentFinanceCancelButton.UseVisualStyleBackColor = true;
            // 
            // AddFinanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.DocumentFinanceCancelButton);
            this.Controls.Add(this.DocumentFinanceOKButton);
            this.Controls.Add(this.DocumentFinanceDescriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DocumentFinanceExpenseTextBox);
            this.Controls.Add(this.DocumentFinanceIncomeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFinanceDialog";
            this.ShowInTaskbar = false;
            this.Text = "Финансовая декларация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DocumentFinanceIncomeTextBox;
        private System.Windows.Forms.TextBox DocumentFinanceExpenseTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox DocumentFinanceDescriptionTextBox;
        private System.Windows.Forms.Button DocumentFinanceOKButton;
        private System.Windows.Forms.Button DocumentFinanceCancelButton;
    }
}