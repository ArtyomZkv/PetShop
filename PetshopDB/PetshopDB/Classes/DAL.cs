using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace PetshopDB.Classes
{
    class DAL
    {
        //строка соединения
        string connectionString = @"Data Source=DESKTOP-HKUF1MT\SQLEXPRESS; Initial Catalog = Зоомагазин;Integrated Security = True;";
        public ArrayList GetAllRecords(string query)
        {
            ArrayList allRecords = new ArrayList();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        foreach (DbDataRecord result in dataReader)
                        {
                            allRecords.Add(result);
                        }
                    }
                }
                catch
                {
                }
            }
            return allRecords;
        }
        public bool SaveNewProduct(Guid ID, Guid CategoryID, string Name, decimal Price)
        {

            string queryForAddInProduct = string.Format("Insert into dbo.[Другие товары] ([id_Товара], [Название], [Цена]) VALUES ('{0}', '{1}', '{2}')", ID, Name, Price);
            string queryForAddInProductAndCategory = string.Format("Insert into dbo.[Товары и категории] ([id товара], [id категории]) VALUES ('{0}', '{1}')", ID, CategoryID);
            bool flagresult = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command1 = new SqlCommand(queryForAddInProduct, connection);
                SqlCommand command2 = new SqlCommand(queryForAddInProductAndCategory, connection);
                try
                {
                    connection.Open();
                    if ((command1.ExecuteNonQuery() == 1) && (command2.ExecuteNonQuery() == 1))
                        flagresult = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Dispose();
                }
                return flagresult;
            }
        }
        public Guid GetCategoryID(ComboBox combobox)
        {
            Guid CategoryID = new Guid();
            string queryForCategoryID = string.Format("select [id категории] from dbo.[Категории товаров] where [Наименование категории] like '{0}'", combobox.Text.ToString());
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryForCategoryID, connection);
                try
                {
                    connection.Open();
                    CategoryID = (Guid)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Dispose();
                }
            }
            return CategoryID;
        }
        public bool SaveNewAnimal(string AnimalFamily, bool IsItBreedOrNot, string AnimalBreed, decimal Price)
        {
            bool flagresult = false;
            Guid ID = Guid.NewGuid();
            string queryForAddNewAniaml = string.Format("insert into dbo.Животные ([id_Животного], [Семейство], [Породистость], [Порода], [Цена]) VALUES ('{0}', '{1}','{2}','{3}', '{4}')", ID, AnimalFamily, IsItBreedOrNot, AnimalBreed, Price);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryForAddNewAniaml, connection);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                        flagresult = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Dispose();
                }
            }
            return flagresult;
        }
        public bool SaveNewCategory(string NameOfCategory)
        {
            bool flagresult = false;
            Guid id = Guid.NewGuid();
            string queryForAddNewCategory = string.Format("insert into dbo.[Категории товаров] ([id категории], [Наименование категории]) VALUES ('{0}', '{1}')", id, NameOfCategory);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryForAddNewCategory, connection);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                        flagresult = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Dispose();
                }
            }
            return flagresult;
        }
        public bool SaveNewFeed(string FeedName, string Consistency, bool Allegric, int Temp, string KeysOf, decimal Price, string Weight, Guid CategoryID)
        {
            bool flagresult = false;
            Guid ID = Guid.NewGuid();
            string queryForAddFeed = string.Format("insert into dbo.Корм ([id_Корма], [Название], [Консистенция], [Гиппоаллергенность], [Температура], [Ключевые_питательные_вещества], [Цена], [Вес(кг)]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}','{5}', '{6}', cast('{7}' as float))", ID, FeedName, Consistency, Allegric, Temp, KeysOf, Price, Weight);
            string queryForAddFeedAndCategory = string.Format("Insert into dbo.[Корм и категории] ([id корма], [id категории]) VALUES ('{0}', '{1}')", ID, CategoryID);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command1 = new SqlCommand(queryForAddFeed, connection);
                SqlCommand command2 = new SqlCommand(queryForAddFeedAndCategory, connection);
                try
                {
                    connection.Open();
                    if ((command1.ExecuteNonQuery() == 1) && (command2.ExecuteNonQuery() == 1))
                        flagresult = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Dispose();
                }
                return flagresult;
            }
        }
        public bool SaveNewCategoryForMeds(string NameOfCategory)
        {
            bool flagresult = false;
            Guid id = Guid.NewGuid();
            string queryForAddNewCategory = string.Format("insert into dbo.[Категории лекарств] ([id_Категории_лекарства], [Название]) VALUES ('{0}', '{1}')", id, NameOfCategory);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryForAddNewCategory, connection);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                        flagresult = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Dispose();
                }
            }
            return flagresult;
        }
        public bool AddNewMed(string medName, bool haveOrNot, bool allergic, bool recipe, decimal price, Guid categoryID, Guid symptomID)
        {
            bool flagresult = false;
            Guid ID = Guid.NewGuid();
            string queryForAddFeed = string.Format("insert into dbo.Лекарства ([id_Лекарства], [Название лекарства], [Наличие], [Гиппераллергенность], [Отпуск с рецептом], [Цена]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}','{5}')", ID, medName, haveOrNot, allergic, recipe, price);
            string queryForAddFeedAndCategory = string.Format("Insert into dbo.[Лекарства и категории] ([id лекарства], [id категории]) VALUES ('{0}', '{1}')", ID, categoryID);
            string queryForAddMedAndSymptom = string.Format("Insert into dbo.[Лекарства и симптомы] ([id лекарства], [id категории]) VALUES ('{0}', '{1}')", ID, symptomID);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command1 = new SqlCommand(queryForAddFeed, connection);
                SqlCommand command2 = new SqlCommand(queryForAddFeedAndCategory, connection);
                SqlCommand command3 = new SqlCommand(queryForAddMedAndSymptom, connection);
                try
                {
                    connection.Open();
                    if ((command1.ExecuteNonQuery() == 1) && (command2.ExecuteNonQuery() == 1) && (command3.ExecuteNonQuery() == 1))
                        flagresult = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Dispose();
                }
                return flagresult;
            }
        }
        public Guid GetSymptomID(ComboBox combobox)
        {
            Guid CategoryID = new Guid();
            string queryForCategoryID = string.Format("select [id_Категории_лекарства] from dbo.[Категории лекарств] where [Название] like '{0}'", combobox.Text.ToString());
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryForCategoryID, connection);
                try
                {
                    connection.Open();
                    CategoryID = (Guid)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Dispose();
                }
            }
            return CategoryID;
        }
    }
}


