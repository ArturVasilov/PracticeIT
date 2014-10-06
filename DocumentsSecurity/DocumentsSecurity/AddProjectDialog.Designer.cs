namespace DocumentsSecurity
{
    partial class AddProjectDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProjectDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentProjectCustomerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DocumentProjectCostTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DocumentProjectDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.DocumentProjectOKButton = new System.Windows.Forms.Button();
            this.DocumentProjectCancelButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DocumentProjectDateTextBox = new System.Windows.Forms.TextBox();
            this.DocumentProjectPerformersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Заказчик - ";
            // 
            // DocumentProjectCustomerTextBox
            // 
            this.DocumentProjectCustomerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentProjectCustomerTextBox.Location = new System.Drawing.Point(117, 9);
            this.DocumentProjectCustomerTextBox.Name = "DocumentProjectCustomerTextBox";
            this.DocumentProjectCustomerTextBox.Size = new System.Drawing.Size(335, 27);
            this.DocumentProjectCustomerTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Стоимость (руб.) - ";
            // 
            // DocumentProjectCostTextBox
            // 
            this.DocumentProjectCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentProjectCostTextBox.Location = new System.Drawing.Point(191, 53);
            this.DocumentProjectCostTextBox.Name = "DocumentProjectCostTextBox";
            this.DocumentProjectCostTextBox.Size = new System.Drawing.Size(261, 27);
            this.DocumentProjectCostTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(468, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Исполнители:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дополнительно:";
            // 
            // DocumentProjectDescriptionTextBox
            // 
            this.DocumentProjectDescriptionTextBox.Location = new System.Drawing.Point(16, 187);
            this.DocumentProjectDescriptionTextBox.Name = "DocumentProjectDescriptionTextBox";
            this.DocumentProjectDescriptionTextBox.Size = new System.Drawing.Size(436, 139);
            this.DocumentProjectDescriptionTextBox.TabIndex = 5;
            this.DocumentProjectDescriptionTextBox.Text = "";
            // 
            // DocumentProjectOKButton
            // 
            this.DocumentProjectOKButton.Location = new System.Drawing.Point(16, 332);
            this.DocumentProjectOKButton.Name = "DocumentProjectOKButton";
            this.DocumentProjectOKButton.Size = new System.Drawing.Size(212, 32);
            this.DocumentProjectOKButton.TabIndex = 6;
            this.DocumentProjectOKButton.Text = "Готово";
            this.DocumentProjectOKButton.UseVisualStyleBackColor = true;
            this.DocumentProjectOKButton.Click += new System.EventHandler(this.DocumentProjectOKButton_Click);
            // 
            // DocumentProjectCancelButton
            // 
            this.DocumentProjectCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DocumentProjectCancelButton.Location = new System.Drawing.Point(234, 332);
            this.DocumentProjectCancelButton.Name = "DocumentProjectCancelButton";
            this.DocumentProjectCancelButton.Size = new System.Drawing.Size(218, 32);
            this.DocumentProjectCancelButton.TabIndex = 7;
            this.DocumentProjectCancelButton.Text = "Отмена";
            this.DocumentProjectCancelButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата сдачи (ДД/ММ/ГГГГ) - ";
            // 
            // DocumentProjectDateTextBox
            // 
            this.DocumentProjectDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentProjectDateTextBox.Location = new System.Drawing.Point(270, 105);
            this.DocumentProjectDateTextBox.Name = "DocumentProjectDateTextBox";
            this.DocumentProjectDateTextBox.Size = new System.Drawing.Size(182, 27);
            this.DocumentProjectDateTextBox.TabIndex = 3;
            // 
            // DocumentProjectPerformersListBox
            // 
            this.DocumentProjectPerformersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentProjectPerformersListBox.FormattingEnabled = true;
            this.DocumentProjectPerformersListBox.ItemHeight = 20;
            this.DocumentProjectPerformersListBox.Location = new System.Drawing.Point(472, 36);
            this.DocumentProjectPerformersListBox.Name = "DocumentProjectPerformersListBox";
            this.DocumentProjectPerformersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DocumentProjectPerformersListBox.Size = new System.Drawing.Size(251, 324);
            this.DocumentProjectPerformersListBox.TabIndex = 16;
            // 
            // AddProjectDialog
            // 
            this.AcceptButton = this.DocumentProjectOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DocumentProjectCancelButton;
            this.ClientSize = new System.Drawing.Size(735, 368);
            this.Controls.Add(this.DocumentProjectPerformersListBox);
            this.Controls.Add(this.DocumentProjectDateTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DocumentProjectCancelButton);
            this.Controls.Add(this.DocumentProjectOKButton);
            this.Controls.Add(this.DocumentProjectDescriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DocumentProjectCostTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocumentProjectCustomerTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProjectDialog";
            this.ShowInTaskbar = false;
            this.Text = "Добавление проектного договора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DocumentProjectCustomerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DocumentProjectCostTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox DocumentProjectDescriptionTextBox;
        private System.Windows.Forms.Button DocumentProjectOKButton;
        private System.Windows.Forms.Button DocumentProjectCancelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DocumentProjectDateTextBox;
        private System.Windows.Forms.ListBox DocumentProjectPerformersListBox;
    }
}