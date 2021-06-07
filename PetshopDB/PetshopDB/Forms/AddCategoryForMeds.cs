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
    public partial class AddCategoryForMeds : Form
    {
        Classes.DAL dal = new Classes.DAL();
        public AddCategoryForMeds()
        {
            InitializeComponent();
            
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            if (dal.SaveNewCategoryForMeds(txbx_categoryName.Text.Trim()))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }
    }
}
