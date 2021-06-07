
namespace PetshopDB.Forms
{
    partial class AddNewMed
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbbx_category = new System.Windows.Forms.ComboBox();
            this.chckbx_allegric = new System.Windows.Forms.CheckBox();
            this.btn_addData = new System.Windows.Forms.Button();
            this.txbx_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_medName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_allergic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbx_symptom = new System.Windows.Forms.ComboBox();
            this.chckbx_recipe = new System.Windows.Forms.CheckBox();
            this.chckbx_haveOrNot = new System.Windows.Forms.CheckBox();
            this.Наличие = new System.Windows.Forms.Label();
            this.зоомагазинDataSet3 = new PetshopDB.ЗоомагазинDataSet3();
            this.категорииЛекарствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категории_лекарствTableAdapter = new PetshopDB.ЗоомагазинDataSet3TableAdapters.Категории_лекарствTableAdapter();
            this.зоомагазинDataSet4 = new PetshopDB.ЗоомагазинDataSet4();
            this.категорииТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категории_товаровTableAdapter = new PetshopDB.ЗоомагазинDataSet4TableAdapters.Категории_товаровTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииЛекарствBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииТоваровBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckbx_haveOrNot);
            this.groupBox1.Controls.Add(this.Наличие);
            this.groupBox1.Controls.Add(this.cmbbx_symptom);
            this.groupBox1.Controls.Add(this.cmbbx_category);
            this.groupBox1.Controls.Add(this.chckbx_recipe);
            this.groupBox1.Controls.Add(this.chckbx_allegric);
            this.groupBox1.Controls.Add(this.btn_addData);
            this.groupBox1.Controls.Add(this.txbx_price);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbx_medName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_allergic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 398);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbbx_category
            // 
            this.cmbbx_category.DataSource = this.категорииТоваровBindingSource;
            this.cmbbx_category.DisplayMember = "Наименование категории";
            this.cmbbx_category.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbbx_category.FormattingEnabled = true;
            this.cmbbx_category.Location = new System.Drawing.Point(241, 67);
            this.cmbbx_category.Name = "cmbbx_category";
            this.cmbbx_category.Size = new System.Drawing.Size(529, 31);
            this.cmbbx_category.TabIndex = 5;
            this.cmbbx_category.ValueMember = "id категории";
            this.cmbbx_category.SelectedIndexChanged += new System.EventHandler(this.cmbbx_category_SelectedIndexChanged);
            // 
            // chckbx_allegric
            // 
            this.chckbx_allegric.AutoSize = true;
            this.chckbx_allegric.Location = new System.Drawing.Point(241, 164);
            this.chckbx_allegric.Name = "chckbx_allegric";
            this.chckbx_allegric.Size = new System.Drawing.Size(18, 17);
            this.chckbx_allegric.TabIndex = 4;
            this.chckbx_allegric.UseVisualStyleBackColor = true;
            // 
            // btn_addData
            // 
            this.btn_addData.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_addData.Location = new System.Drawing.Point(241, 353);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(294, 39);
            this.btn_addData.TabIndex = 3;
            this.btn_addData.Text = "Добавить новое лекарство";
            this.btn_addData.UseVisualStyleBackColor = true;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // txbx_price
            // 
            this.txbx_price.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_price.Location = new System.Drawing.Point(241, 308);
            this.txbx_price.Multiline = true;
            this.txbx_price.Name = "txbx_price";
            this.txbx_price.Size = new System.Drawing.Size(529, 27);
            this.txbx_price.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(8, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(8, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Отпуск с рецептом";
            // 
            // txbx_medName
            // 
            this.txbx_medName.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_medName.Location = new System.Drawing.Point(241, 21);
            this.txbx_medName.Multiline = true;
            this.txbx_medName.Name = "txbx_medName";
            this.txbx_medName.Size = new System.Drawing.Size(529, 27);
            this.txbx_medName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(8, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Симптом";
            // 
            // lbl_allergic
            // 
            this.lbl_allergic.AutoSize = true;
            this.lbl_allergic.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_allergic.Location = new System.Drawing.Point(8, 158);
            this.lbl_allergic.Name = "lbl_allergic";
            this.lbl_allergic.Size = new System.Drawing.Size(195, 23);
            this.lbl_allergic.TabIndex = 2;
            this.lbl_allergic.Text = "Гиппоаллергенность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категория";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название лекарства";
            // 
            // cmbbx_symptom
            // 
            this.cmbbx_symptom.DataSource = this.категорииЛекарствBindingSource;
            this.cmbbx_symptom.DisplayMember = "Название";
            this.cmbbx_symptom.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbbx_symptom.FormattingEnabled = true;
            this.cmbbx_symptom.Location = new System.Drawing.Point(241, 111);
            this.cmbbx_symptom.Name = "cmbbx_symptom";
            this.cmbbx_symptom.Size = new System.Drawing.Size(529, 31);
            this.cmbbx_symptom.TabIndex = 5;
            this.cmbbx_symptom.ValueMember = "id_Категории_лекарства";
            this.cmbbx_symptom.SelectedIndexChanged += new System.EventHandler(this.cmbbx_symptom_SelectedIndexChanged);
            // 
            // chckbx_recipe
            // 
            this.chckbx_recipe.AutoSize = true;
            this.chckbx_recipe.Location = new System.Drawing.Point(241, 212);
            this.chckbx_recipe.Name = "chckbx_recipe";
            this.chckbx_recipe.Size = new System.Drawing.Size(18, 17);
            this.chckbx_recipe.TabIndex = 4;
            this.chckbx_recipe.UseVisualStyleBackColor = true;
            // 
            // chckbx_haveOrNot
            // 
            this.chckbx_haveOrNot.AutoSize = true;
            this.chckbx_haveOrNot.Location = new System.Drawing.Point(241, 261);
            this.chckbx_haveOrNot.Name = "chckbx_haveOrNot";
            this.chckbx_haveOrNot.Size = new System.Drawing.Size(18, 17);
            this.chckbx_haveOrNot.TabIndex = 7;
            this.chckbx_haveOrNot.UseVisualStyleBackColor = true;
            // 
            // Наличие
            // 
            this.Наличие.AutoSize = true;
            this.Наличие.Font = new System.Drawing.Font("Arial", 12F);
            this.Наличие.Location = new System.Drawing.Point(8, 254);
            this.Наличие.Name = "Наличие";
            this.Наличие.Size = new System.Drawing.Size(86, 23);
            this.Наличие.TabIndex = 6;
            this.Наличие.Text = "Наличие";
            // 
            // зоомагазинDataSet3
            // 
            this.зоомагазинDataSet3.DataSetName = "ЗоомагазинDataSet3";
            this.зоомагазинDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // категорииЛекарствBindingSource
            // 
            this.категорииЛекарствBindingSource.DataMember = "Категории лекарств";
            this.категорииЛекарствBindingSource.DataSource = this.зоомагазинDataSet3;
            // 
            // категории_лекарствTableAdapter
            // 
            this.категории_лекарствTableAdapter.ClearBeforeFill = true;
            // 
            // зоомагазинDataSet4
            // 
            this.зоомагазинDataSet4.DataSetName = "ЗоомагазинDataSet4";
            this.зоомагазинDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // категорииТоваровBindingSource
            // 
            this.категорииТоваровBindingSource.DataMember = "Категории товаров";
            this.категорииТоваровBindingSource.DataSource = this.зоомагазинDataSet4;
            // 
            // категории_товаровTableAdapter
            // 
            this.категории_товаровTableAdapter.ClearBeforeFill = true;
            // 
            // AddNewMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewMed";
            this.Text = "AddNewMed";
            this.Load += new System.EventHandler(this.AddNewMed_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииЛекарствBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииТоваровBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbbx_category;
        private System.Windows.Forms.CheckBox chckbx_allegric;
        private System.Windows.Forms.Button btn_addData;
        private System.Windows.Forms.TextBox txbx_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_medName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_allergic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbx_symptom;
        private System.Windows.Forms.CheckBox chckbx_recipe;
        private System.Windows.Forms.CheckBox chckbx_haveOrNot;
        private System.Windows.Forms.Label Наличие;
        private ЗоомагазинDataSet3 зоомагазинDataSet3;
        private System.Windows.Forms.BindingSource категорииЛекарствBindingSource;
        private ЗоомагазинDataSet3TableAdapters.Категории_лекарствTableAdapter категории_лекарствTableAdapter;
        private ЗоомагазинDataSet4 зоомагазинDataSet4;
        private System.Windows.Forms.BindingSource категорииТоваровBindingSource;
        private ЗоомагазинDataSet4TableAdapters.Категории_товаровTableAdapter категории_товаровTableAdapter;
    }
}