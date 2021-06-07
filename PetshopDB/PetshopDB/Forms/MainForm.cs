using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetshopDB
{
    public partial class frm_MainForm : Form
    {
        Classes.DAL dal = new Classes.DAL();
        public string queryForOther = "select [Название],[Наименование категории],[Цена] from dbo.[Другие товары], dbo.[Категории товаров], dbo.[Товары и категории] where dbo.[Другие товары].id_Товара = dbo.[Товары и категории].[id товара] and dbo.[Категории товаров].[id категории] = dbo.[Товары и категории].[id категории] order by dbo.[Другие товары].Название";
        public string queryForMeds = "select dbo.Лекарства.*,dbo.[Категории лекарств].[Название], dbo.[Категории товаров].[Наименование категории] from dbo.Лекарства, dbo.[Категории лекарств], dbo.[Лекарства и симптомы],dbo.[Категории товаров], dbo.[Лекарства и категории] where id_Категории_лекарства = dbo.[Лекарства и симптомы].[id категории] and dbo.[Лекарства].id_Лекарства = dbo.[Лекарства и симптомы].[id лекарства] and dbo.[Категории товаров].[id категории] = dbo.[Лекарства и категории].[Id категории] and dbo.Лекарства.id_Лекарства = dbo.[Лекарства и категории].[id лекарства] order by dbo.Лекарства.[Название лекарства]";
        public string queryForFeed = "select Название, dbo.[Категории товаров].[Наименование категории], Консистенция, Гиппоаллергенность, Температура, Цена, [Вес(кг)] from dbo.Корм, dbo.[Категории товаров], dbo.[Корм и категории] where dbo.Корм.id_Корма = dbo.[Корм и категории].[id корма] and dbo.[Категории товаров].[id категории] = dbo.[Корм и категории].[id категории] order by dbo.Корм.Название";
        public string queryForAnimal = "select * from dbo.Животные order by Семейство";
        public frm_MainForm()
        {
            InitializeComponent();
            ArrayList allProducts = dal.GetAllRecords(queryForOther);
            ArrayList allAnimals = dal.GetAllRecords(queryForAnimal);
            dgv_productList.DataSource = allProducts;
            dgv_animalsList.DataSource = allAnimals;
            SettingsDGV_Products();
            SettingDGV_Animals();


        }
        private void SettingsDGV_Products()
        {
            dgv_productList.Columns[0].HeaderCell.Value = "Название товара";
            dgv_productList.Columns[1].HeaderCell.Value = "Категория";
            dgv_productList.Columns[2].HeaderCell.Value = "Цена товара";
            dgv_productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_showOther_Click(object sender, EventArgs e)
        {
            
            ArrayList allProducts = dal.GetAllRecords(queryForOther);
            dgv_productList.DataSource = allProducts;
            SettingsDGV_Products();
        }

        private void btn_showMeds_Click(object sender, EventArgs e)
        {
            ArrayList empty = new ArrayList();
            dgv_productList.DataSource = empty;
            ArrayList allMeds = dal.GetAllRecords(queryForMeds);
            dgv_productList.DataSource = allMeds;
            SettingsDGV_Meds();
        }
        private void SettingsDGV_Meds()
        {
            dgv_productList.Columns[0].Visible = false;
            dgv_productList.Columns[1].HeaderCell.Value = "Название лекарства";
            dgv_productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_showFood_Click(object sender, EventArgs e)
        {
            ArrayList allFeed = dal.GetAllRecords(queryForFeed);
            dgv_productList.DataSource = allFeed;
        }
        private void SettingDGV_Feed()
        {

        }
        private void SettingDGV_Animals()
        {
            dgv_animalsList.Columns[0].Visible = false;
            dgv_animalsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frm_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (MessageBox.Show("Вы действительно желаете закрыть приложение?", "Закрытие приложения", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.WorkWithProducts workWithProducts = new Forms.WorkWithProducts();
            if (workWithProducts.ShowDialog()==DialogResult.OK)
            {
                dgv_productList.DataSource = dal.GetAllRecords(queryForOther);
                MessageBox.Show("Новый товар успешно добавлен", "Подтверждение",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Новый товар не удалось добавить!", "Подтверждение", MessageBoxButtons.OK);
            }
        }

        private void добавитьЗверяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.NewAnimal newAnimal = new Forms.NewAnimal();
            if (newAnimal.ShowDialog() == DialogResult.OK)
            {
                dgv_animalsList.DataSource = dal.GetAllRecords(queryForAnimal);
                MessageBox.Show("Новое животное успешно добавлено", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Новое животное не удалить добавить!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void добавитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.NewCategoryForProducts newCategoryForProducts = new Forms.NewCategoryForProducts();
            if (newCategoryForProducts.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Новая категория успешно добавлена", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Новое животное не удалить добавить!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void добавитьКормToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.NewFeed newFeed = new Forms.NewFeed();
            if (newFeed.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show("Новый корм успешно добавлен", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Новый корм не удалось добавить!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void изменитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AddCategoryForMeds addCategoryForMeds = new Forms.AddCategoryForMeds();
            if (addCategoryForMeds.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Новая категория для лекарств успешно добавлена", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Новая категория для лекарств не добавлена!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьЛекарствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AddNewMed addNewMed = new Forms.AddNewMed();
            if (addNewMed.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Новое лекарство успешно добавлено", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Новое лекарство не добавлено!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
