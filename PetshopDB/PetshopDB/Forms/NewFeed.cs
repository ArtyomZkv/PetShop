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
    public partial class NewFeed : Form
    {
        Classes.DAL dal = new Classes.DAL();
        Guid categoryID = new Guid();
        public NewFeed()
        {
            InitializeComponent();
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            if (dal.SaveNewFeed(txbx_feedName.Text.Trim(), txbx_consistency.Text.Trim(), chckbx_allegric.Checked, Int16.Parse(txbx_temp.Text), txbx_keysOf.Text.Trim(), decimal.Parse(txbx_price.Text.Trim()), txbx_weight.Text.Trim(), categoryID))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        private void cmbbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
           categoryID = dal.GetCategoryID(cmbbx_category);
        }

        private void NewFeed_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "зоомагазинDataSet2.Категории_товаров". При необходимости она может быть перемещена или удалена.
            this.категории_товаровTableAdapter.Fill(this.зоомагазинDataSet2.Категории_товаров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "зоомагазинDataSet1.Товары_и_категории". При необходимости она может быть перемещена или удалена.
            this.товары_и_категорииTableAdapter.Fill(this.зоомагазинDataSet1.Товары_и_категории);
            cmbbx_category_SelectedIndexChanged(sender, e);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            txbx_consistency.Text = "Сухой корм";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            txbx_consistency.Text = "Сырой корм";
        }
    }
}
