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
    public partial class AddNewMed : Form
    {
        Classes.DAL dal = new Classes.DAL();
        Guid symptomID = new Guid();
        Guid categoryID = new Guid();

        public AddNewMed()
        {
            InitializeComponent();
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {

            if (dal.AddNewMed(txbx_medName.Text.Trim(), chckbx_haveOrNot.Checked, chckbx_allegric.Checked, chckbx_recipe.Checked, decimal.Parse(txbx_price.Text.Trim()), categoryID, symptomID)) 
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }    
        }

        private void AddNewMed_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "зоомагазинDataSet4.Категории_товаров". При необходимости она может быть перемещена или удалена.
            this.категории_товаровTableAdapter.Fill(this.зоомагазинDataSet4.Категории_товаров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "зоомагазинDataSet3.Категории_лекарств". При необходимости она может быть перемещена или удалена.
            this.категории_лекарствTableAdapter.Fill(this.зоомагазинDataSet3.Категории_лекарств);
            dal.GetCategoryID(cmbbx_category);
            dal.GetSymptomID(cmbbx_symptom);

        }

        private void cmbbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
           categoryID = dal.GetCategoryID(cmbbx_category);
        }

        private void cmbbx_symptom_SelectedIndexChanged(object sender, EventArgs e)
        {
            symptomID = dal.GetSymptomID(cmbbx_symptom);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            cmbbx_category_SelectedIndexChanged(sender, e);
            cmbbx_symptom_SelectedIndexChanged(sender, e);
        }
    }
}
