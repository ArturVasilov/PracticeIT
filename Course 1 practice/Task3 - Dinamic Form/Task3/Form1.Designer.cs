namespace Task3
{
    partial class MyDinamicForm
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
            this.CreatingComponentsPanel = new System.Windows.Forms.Panel();
            this.ChangingObjectL = new System.Windows.Forms.Label();
            this.EnterItemsLV = new System.Windows.Forms.RichTextBox();
            this.EnterElementsL = new System.Windows.Forms.Label();
            this.TextEditOrProgBarValue = new System.Windows.Forms.TextBox();
            this.YSize = new System.Windows.Forms.TextBox();
            this.XSize = new System.Windows.Forms.TextBox();
            this.YKoord = new System.Windows.Forms.TextBox();
            this.XKoord = new System.Windows.Forms.TextBox();
            this.ChooseObjectL = new System.Windows.Forms.Label();
            this.ChooseCreateObjectCB = new System.Windows.Forms.ComboBox();
            this.CreateComponents = new System.Windows.Forms.Button();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.InfLabel = new System.Windows.Forms.Label();
            this.DeleteComponentB = new System.Windows.Forms.Button();
            this.CreatingComponentsPanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatingComponentsPanel
            // 
            this.CreatingComponentsPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CreatingComponentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreatingComponentsPanel.Controls.Add(this.DeleteComponentB);
            this.CreatingComponentsPanel.Controls.Add(this.ChangingObjectL);
            this.CreatingComponentsPanel.Controls.Add(this.EnterItemsLV);
            this.CreatingComponentsPanel.Controls.Add(this.EnterElementsL);
            this.CreatingComponentsPanel.Controls.Add(this.TextEditOrProgBarValue);
            this.CreatingComponentsPanel.Controls.Add(this.YSize);
            this.CreatingComponentsPanel.Controls.Add(this.XSize);
            this.CreatingComponentsPanel.Controls.Add(this.YKoord);
            this.CreatingComponentsPanel.Controls.Add(this.XKoord);
            this.CreatingComponentsPanel.Controls.Add(this.ChooseObjectL);
            this.CreatingComponentsPanel.Controls.Add(this.ChooseCreateObjectCB);
            this.CreatingComponentsPanel.Controls.Add(this.CreateComponents);
            this.CreatingComponentsPanel.Location = new System.Drawing.Point(608, 0);
            this.CreatingComponentsPanel.Name = "CreatingComponentsPanel";
            this.CreatingComponentsPanel.Size = new System.Drawing.Size(239, 329);
            this.CreatingComponentsPanel.TabIndex = 0;
            // 
            // ChangingObjectL
            // 
            this.ChangingObjectL.AutoSize = true;
            this.ChangingObjectL.Location = new System.Drawing.Point(3, 0);
            this.ChangingObjectL.Name = "ChangingObjectL";
            this.ChangingObjectL.Size = new System.Drawing.Size(93, 17);
            this.ChangingObjectL.TabIndex = 12;
            this.ChangingObjectL.Text = "Изм. объект:";
            this.ChangingObjectL.Visible = false;
            // 
            // EnterItemsLV
            // 
            this.EnterItemsLV.Location = new System.Drawing.Point(6, 171);
            this.EnterItemsLV.Name = "EnterItemsLV";
            this.EnterItemsLV.Size = new System.Drawing.Size(222, 85);
            this.EnterItemsLV.TabIndex = 11;
            this.EnterItemsLV.Text = "";
            this.EnterItemsLV.Visible = false;
            // 
            // EnterElementsL
            // 
            this.EnterElementsL.AutoSize = true;
            this.EnterElementsL.Location = new System.Drawing.Point(3, 151);
            this.EnterElementsL.Name = "EnterElementsL";
            this.EnterElementsL.Size = new System.Drawing.Size(192, 17);
            this.EnterElementsL.TabIndex = 10;
            this.EnterElementsL.Text = "Введите элементы в список";
            this.EnterElementsL.Visible = false;
            // 
            // TextEditOrProgBarValue
            // 
            this.TextEditOrProgBarValue.Location = new System.Drawing.Point(0, 126);
            this.TextEditOrProgBarValue.Name = "TextEditOrProgBarValue";
            this.TextEditOrProgBarValue.Size = new System.Drawing.Size(228, 22);
            this.TextEditOrProgBarValue.TabIndex = 7;
            this.TextEditOrProgBarValue.Visible = false;
            // 
            // YSize
            // 
            this.YSize.Location = new System.Drawing.Point(115, 98);
            this.YSize.Name = "YSize";
            this.YSize.Size = new System.Drawing.Size(113, 22);
            this.YSize.TabIndex = 6;
            this.YSize.Visible = false;
            // 
            // XSize
            // 
            this.XSize.Location = new System.Drawing.Point(2, 98);
            this.XSize.Name = "XSize";
            this.XSize.Size = new System.Drawing.Size(107, 22);
            this.XSize.TabIndex = 5;
            this.XSize.Visible = false;
            // 
            // YKoord
            // 
            this.YKoord.Location = new System.Drawing.Point(115, 70);
            this.YKoord.Name = "YKoord";
            this.YKoord.Size = new System.Drawing.Size(113, 22);
            this.YKoord.TabIndex = 4;
            this.YKoord.Visible = false;
            // 
            // XKoord
            // 
            this.XKoord.Location = new System.Drawing.Point(3, 70);
            this.XKoord.Name = "XKoord";
            this.XKoord.Size = new System.Drawing.Size(106, 22);
            this.XKoord.TabIndex = 3;
            this.XKoord.Visible = false;
            // 
            // ChooseObjectL
            // 
            this.ChooseObjectL.AutoSize = true;
            this.ChooseObjectL.Location = new System.Drawing.Point(3, 20);
            this.ChooseObjectL.Name = "ChooseObjectL";
            this.ChooseObjectL.Size = new System.Drawing.Size(219, 17);
            this.ChooseObjectL.TabIndex = 2;
            this.ChooseObjectL.Text = "Выберите объект для создания";
            // 
            // ChooseCreateObjectCB
            // 
            this.ChooseCreateObjectCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseCreateObjectCB.FormattingEnabled = true;
            this.ChooseCreateObjectCB.Items.AddRange(new object[] {
            "Кнопка",
            "Надпись",
            "Список",
            "Строка состояния"});
            this.ChooseCreateObjectCB.Location = new System.Drawing.Point(3, 40);
            this.ChooseCreateObjectCB.Name = "ChooseCreateObjectCB";
            this.ChooseCreateObjectCB.Size = new System.Drawing.Size(229, 24);
            this.ChooseCreateObjectCB.TabIndex = 1;
            this.ChooseCreateObjectCB.SelectionChangeCommitted += new System.EventHandler(this.ChooseCreateObjectCB_SelectionChangeCommitted);
            // 
            // CreateComponents
            // 
            this.CreateComponents.Location = new System.Drawing.Point(3, 262);
            this.CreateComponents.Name = "CreateComponents";
            this.CreateComponents.Size = new System.Drawing.Size(225, 29);
            this.CreateComponents.TabIndex = 0;
            this.CreateComponents.Text = "Создать/изменить компонент";
            this.CreateComponents.UseVisualStyleBackColor = true;
            this.CreateComponents.Click += new System.EventHandler(this.CreateComponents_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AddPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddPanel.Controls.Add(this.InfLabel);
            this.AddPanel.Location = new System.Drawing.Point(0, 0);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(602, 329);
            this.AddPanel.TabIndex = 2;
            // 
            // InfLabel
            // 
            this.InfLabel.AutoSize = true;
            this.InfLabel.Location = new System.Drawing.Point(3, 0);
            this.InfLabel.Name = "InfLabel";
            this.InfLabel.Size = new System.Drawing.Size(354, 17);
            this.InfLabel.TabIndex = 0;
            this.InfLabel.Text = "На этой панели будут создаваться все компоненты.";
            // 
            // DeleteComponentB
            // 
            this.DeleteComponentB.Location = new System.Drawing.Point(3, 294);
            this.DeleteComponentB.Name = "DeleteComponentB";
            this.DeleteComponentB.Size = new System.Drawing.Size(225, 28);
            this.DeleteComponentB.TabIndex = 13;
            this.DeleteComponentB.Text = "Удалить";
            this.DeleteComponentB.UseVisualStyleBackColor = true;
            this.DeleteComponentB.Click += new System.EventHandler(this.DeleteComponentB_Click);
            // 
            // MyDinamicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 331);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.CreatingComponentsPanel);
            this.Name = "MyDinamicForm";
            this.Text = "Моя Форма";
            this.CreatingComponentsPanel.ResumeLayout(false);
            this.CreatingComponentsPanel.PerformLayout();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CreatingComponentsPanel;
        private System.Windows.Forms.Button CreateComponents;
        private System.Windows.Forms.Label ChooseObjectL;
        private System.Windows.Forms.ComboBox ChooseCreateObjectCB;
        private System.Windows.Forms.TextBox YSize;
        private System.Windows.Forms.TextBox XSize;
        private System.Windows.Forms.TextBox YKoord;
        private System.Windows.Forms.TextBox XKoord;
        private System.Windows.Forms.TextBox TextEditOrProgBarValue;
        private System.Windows.Forms.Label EnterElementsL;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Label InfLabel;
        private System.Windows.Forms.RichTextBox EnterItemsLV;
        private System.Windows.Forms.Label ChangingObjectL;
        private System.Windows.Forms.Button DeleteComponentB;
    }
}

