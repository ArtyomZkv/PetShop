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
    public partial class NewAnimal : Form
    {
        Classes.DAL dal = new Classes.DAL();
        public NewAnimal()
        {
            InitializeComponent();
            
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            if (dal.SaveNewAnimal(txbx_animalFamily.Text.Trim(), chckbx_breedOrNot.Checked, txbx_animalBreed.Text.Trim(), decimal.Parse(txbx_price.Text.Trim())))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
            
        }

        private void chckbx_breedOrNot_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbx_breedOrNot.Checked == false)
                txbx_animalBreed.Enabled = false;
            else
                txbx_animalBreed.Enabled = true;
        }

        private void NewAnimal_Load(object sender, EventArgs e)
        {
            chckbx_breedOrNot_CheckedChanged(sender, e);
        }
    }
}
