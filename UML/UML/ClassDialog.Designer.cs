namespace UML
{
    partial class ClassDialog
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
            this.ClassDialogNameLabel = new System.Windows.Forms.Label();
            this.ClassDialogStaticLabel = new System.Windows.Forms.Label();
            this.ClassDialogAbstractLabel = new System.Windows.Forms.Label();
            this.ClassDialogAccessLabel = new System.Windows.Forms.Label();
            this.ClassDialogOKButton = new System.Windows.Forms.Button();
            this.ClassDialogCancelButton = new System.Windows.Forms.Button();
            this.ClassDialogNameTB = new System.Windows.Forms.TextBox();
            this.ClassDialogStaticCB = new System.Windows.Forms.ComboBox();
            this.ClassDialogAbstractCB = new System.Windows.Forms.ComboBox();
            this.ClassDialogAccessCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ClassDialogNameLabel
            // 
            this.ClassDialogNameLabel.AutoSize = true;
            this.ClassDialogNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassDialogNameLabel.Location = new System.Drawing.Point(13, 13);
            this.ClassDialogNameLabel.Name = "ClassDialogNameLabel";
            this.ClassDialogNameLabel.Size = new System.Drawing.Size(108, 20);
            this.ClassDialogNameLabel.TabIndex = 0;
            this.ClassDialogNameLabel.Text = "Class name";
            // 
            // ClassDialogStaticLabel
            // 
            this.ClassDialogStaticLabel.AutoSize = true;
            this.ClassDialogStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassDialogStaticLabel.Location = new System.Drawing.Point(13, 57);
            this.ClassDialogStaticLabel.Name = "ClassDialogStaticLabel";
            this.ClassDialogStaticLabel.Size = new System.Drawing.Size(58, 20);
            this.ClassDialogStaticLabel.TabIndex = 1;
            this.ClassDialogStaticLabel.Text = "Static";
            // 
            // ClassDialogAbstractLabel
            // 
            this.ClassDialogAbstractLabel.AutoSize = true;
            this.ClassDialogAbstractLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassDialogAbstractLabel.Location = new System.Drawing.Point(13, 99);
            this.ClassDialogAbstractLabel.Name = "ClassDialogAbstractLabel";
            this.ClassDialogAbstractLabel.Size = new System.Drawing.Size(80, 20);
            this.ClassDialogAbstractLabel.TabIndex = 2;
            this.ClassDialogAbstractLabel.Text = "Abstract";
            // 
            // ClassDialogAccessLabel
            // 
            this.ClassDialogAccessLabel.AutoSize = true;
            this.ClassDialogAccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassDialogAccessLabel.Location = new System.Drawing.Point(13, 142);
            this.ClassDialogAccessLabel.Name = "ClassDialogAccessLabel";
            this.ClassDialogAccessLabel.Size = new System.Drawing.Size(112, 20);
            this.ClassDialogAccessLabel.TabIndex = 3;
            this.ClassDialogAccessLabel.Text = "Access type";
            // 
            // ClassDialogOKButton
            // 
            this.ClassDialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ClassDialogOKButton.Location = new System.Drawing.Point(16, 193);
            this.ClassDialogOKButton.Name = "ClassDialogOKButton";
            this.ClassDialogOKButton.Size = new System.Drawing.Size(164, 30);
            this.ClassDialogOKButton.TabIndex = 4;
            this.ClassDialogOKButton.Text = "OK";
            this.ClassDialogOKButton.UseVisualStyleBackColor = true;
            // 
            // ClassDialogCancelButton
            // 
            this.ClassDialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClassDialogCancelButton.Location = new System.Drawing.Point(197, 193);
            this.ClassDialogCancelButton.Name = "ClassDialogCancelButton";
            this.ClassDialogCancelButton.Size = new System.Drawing.Size(159, 30);
            this.ClassDialogCancelButton.TabIndex = 5;
            this.ClassDialogCancelButton.Text = "Cancel";
            this.ClassDialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // ClassDialogNameTB
            // 
            this.ClassDialogNameTB.Location = new System.Drawing.Point(136, 13);
            this.ClassDialogNameTB.Name = "ClassDialogNameTB";
            this.ClassDialogNameTB.Size = new System.Drawing.Size(220, 22);
            this.ClassDialogNameTB.TabIndex = 6;
            // 
            // ClassDialogStaticCB
            // 
            this.ClassDialogStaticCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDialogStaticCB.FormattingEnabled = true;
            this.ClassDialogStaticCB.Items.AddRange(new object[] {
            "true",
            "false"});
            this.ClassDialogStaticCB.Location = new System.Drawing.Point(136, 57);
            this.ClassDialogStaticCB.Name = "ClassDialogStaticCB";
            this.ClassDialogStaticCB.Size = new System.Drawing.Size(220, 24);
            this.ClassDialogStaticCB.TabIndex = 7;
            // 
            // ClassDialogAbstractCB
            // 
            this.ClassDialogAbstractCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDialogAbstractCB.FormattingEnabled = true;
            this.ClassDialogAbstractCB.Items.AddRange(new object[] {
            "true",
            "false"});
            this.ClassDialogAbstractCB.Location = new System.Drawing.Point(136, 99);
            this.ClassDialogAbstractCB.Name = "ClassDialogAbstractCB";
            this.ClassDialogAbstractCB.Size = new System.Drawing.Size(220, 24);
            this.ClassDialogAbstractCB.TabIndex = 8;
            // 
            // ClassDialogAccessCB
            // 
            this.ClassDialogAccessCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDialogAccessCB.FormattingEnabled = true;
            this.ClassDialogAccessCB.Items.AddRange(new object[] {
            "default",
            "public",
            "protected",
            "private"});
            this.ClassDialogAccessCB.Location = new System.Drawing.Point(136, 142);
            this.ClassDialogAccessCB.Name = "ClassDialogAccessCB";
            this.ClassDialogAccessCB.Size = new System.Drawing.Size(220, 24);
            this.ClassDialogAccessCB.TabIndex = 9;
            // 
            // ClassDialog
            // 
            this.AcceptButton = this.ClassDialogOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ClassDialogCancelButton;
            this.ClientSize = new System.Drawing.Size(368, 235);
            this.Controls.Add(this.ClassDialogAccessCB);
            this.Controls.Add(this.ClassDialogAbstractCB);
            this.Controls.Add(this.ClassDialogStaticCB);
            this.Controls.Add(this.ClassDialogNameTB);
            this.Controls.Add(this.ClassDialogCancelButton);
            this.Controls.Add(this.ClassDialogOKButton);
            this.Controls.Add(this.ClassDialogAccessLabel);
            this.Controls.Add(this.ClassDialogAbstractLabel);
            this.Controls.Add(this.ClassDialogStaticLabel);
            this.Controls.Add(this.ClassDialogNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClassDialog";
            this.ShowInTaskbar = false;
            this.Text = "ClassDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClassDialogNameLabel;
        private System.Windows.Forms.Label ClassDialogStaticLabel;
        private System.Windows.Forms.Label ClassDialogAbstractLabel;
        private System.Windows.Forms.Label ClassDialogAccessLabel;
        private System.Windows.Forms.Button ClassDialogOKButton;
        private System.Windows.Forms.Button ClassDialogCancelButton;
        private System.Windows.Forms.TextBox ClassDialogNameTB;
        private System.Windows.Forms.ComboBox ClassDialogStaticCB;
        private System.Windows.Forms.ComboBox ClassDialogAbstractCB;
        private System.Windows.Forms.ComboBox ClassDialogAccessCB;
    }
}