using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsSecurity
{
    public partial class AddFinanceDialog : Form
    {
        private Finance finance;

        public AddFinanceDialog()
        {
            InitializeComponent();
        }

        public Finance getFinance
        {
            get { return finance; }
        }

        private void DocumentFinanceOKButton_Click(object sender, EventArgs e)
        {
            bool isAllOk = true;
            //id isn't important, it's generating at runtime
            int id = DatabaseConstants.IdsKeeper.FINANCE_ID;

            long income = -1;
            #region getting income
            try
            {
                income = long.Parse(DocumentFinanceIncomeTextBox.Text);
                DocumentFinanceIncomeTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                DocumentFinanceIncomeTextBox.BackColor = Color.Red;
                isAllOk = false;
            }
            catch (Exception)
            {
                DocumentFinanceIncomeTextBox.BackColor = Color.Red;
                isAllOk = false;
            }
            #endregion

            long expense = -1;
            #region getting expense
            try
            {
                expense = long.Parse(DocumentFinanceExpenseTextBox.Text);
                DocumentFinanceIncomeTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                DocumentFinanceExpenseTextBox.BackColor = Color.Red;
                isAllOk = false;
            }
            catch (Exception)
            {
                DocumentFinanceExpenseTextBox.BackColor = Color.Red;
                isAllOk = false;
            }
            #endregion

            if (!isAllOk)
            {
                return;
            }

            string description = DocumentFinanceDescriptionTextBox.Text;
            description = description == null ? "" : description;

            finance = new Finance(id, description, income, expense);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        internal Finance changeFinance(int id)
        {
            finance.Id = id;
            return finance;
        }

        internal void setFields(long income, long expense, string description)
        {
            DocumentFinanceIncomeTextBox.Text = income.ToString();
            DocumentFinanceExpenseTextBox.Text = expense.ToString();
            DocumentFinanceDescriptionTextBox.Text = description;
        }
    }
}
