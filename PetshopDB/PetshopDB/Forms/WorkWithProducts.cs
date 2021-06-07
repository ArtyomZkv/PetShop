using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetshopDB.Forms
{
    public partial class WorkWithProducts : Form
    {
        Classes.DAL dal = new Classes.DAL();
        Guid productID = Guid.NewGuid();
        Guid categoryID = new Guid();

        public WorkWithProducts()
        {
            
            InitializeComponent();
            //txbx_hideIDCategory.Text = dal.GetCategoryID(cmbx_productCategory);
        }

        private void WorkWithProducts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "зоомагазинDataSet.Категории_товаров". При необходимости она может быть перемещена или удалена.
            this.категории_товаровTableAdapter.Fill(this.зоомагазинDataSet.Категории_товаров);
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            if (dal.SaveNewProduct(productID, categoryID, txbx_productName.Text.Trim(), decimal.Parse(txbx_productPriсe.Text)))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        private void cmbx_productCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryID = dal.GetCategoryID(cmbx_productCategory);
        }
    }
}
