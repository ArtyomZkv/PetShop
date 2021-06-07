
namespace PetshopDB.Forms
{
    partial class NewFeed
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
            this.категорииТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.зоомагазинDataSet2 = new PetshopDB.ЗоомагазинDataSet2();
            this.chckbx_allegric = new System.Windows.Forms.CheckBox();
            this.btn_addData = new System.Windows.Forms.Button();
            this.txbx_weight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbx_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_keysOf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_temp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_feedName = new System.Windows.Forms.TextBox();
            this.txbx_consistency = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_allergic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.зоомагазинDataSet = new PetshopDB.ЗоомагазинDataSet();
            this.зоомагазинDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.зоомагазинDataSet1 = new PetshopDB.ЗоомагазинDataSet1();
            this.товарыИКатегорииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товары_и_категорииTableAdapter = new PetshopDB.ЗоомагазинDataSet1TableAdapters.Товары_и_категорииTableAdapter();
            this.категории_товаровTableAdapter = new PetshopDB.ЗоомагазинDataSet2TableAdapters.Категории_товаровTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категорииТоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыИКатегорииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbbx_category);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.chckbx_allegric);
            this.groupBox1.Controls.Add(this.btn_addData);
            this.groupBox1.Controls.Add(this.txbx_weight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbx_price);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbx_keysOf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbx_temp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbx_feedName);
            this.groupBox1.Controls.Add(this.txbx_consistency);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_allergic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 441);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
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
            // категорииТоваровBindingSource
            // 
            this.категорииТоваровBindingSource.DataMember = "Категории товаров";
            this.категорииТоваровBindingSource.DataSource = this.зоомагазинDataSet2;
            // 
            // зоомагазинDataSet2
            // 
            this.зоомагазинDataSet2.DataSetName = "ЗоомагазинDataSet2";
            this.зоомагазинDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btn_addData.Location = new System.Drawing.Point(241, 396);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(294, 39);
            this.btn_addData.TabIndex = 3;
            this.btn_addData.Text = "Добавить новый корм";
            this.btn_addData.UseVisualStyleBackColor = true;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // txbx_weight
            // 
            this.txbx_weight.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_weight.Location = new System.Drawing.Point(241, 341);
            this.txbx_weight.Multiline = true;
            this.txbx_weight.Name = "txbx_weight";
            this.txbx_weight.Size = new System.Drawing.Size(529, 27);
            this.txbx_weight.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(8, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Вес";
            // 
            // txbx_price
            // 
            this.txbx_price.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_price.Location = new System.Drawing.Point(241, 297);
            this.txbx_price.Multiline = true;
            this.txbx_price.Name = "txbx_price";
            this.txbx_price.Size = new System.Drawing.Size(529, 27);
            this.txbx_price.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(8, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Цена";
            // 
            // txbx_keysOf
            // 
            this.txbx_keysOf.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_keysOf.Location = new System.Drawing.Point(241, 254);
            this.txbx_keysOf.Multiline = true;
            this.txbx_keysOf.Name = "txbx_keysOf";
            this.txbx_keysOf.Size = new System.Drawing.Size(529, 27);
            this.txbx_keysOf.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(8, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ключевые вещества";
            // 
            // txbx_temp
            // 
            this.txbx_temp.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_temp.Location = new System.Drawing.Point(241, 205);
            this.txbx_temp.Multiline = true;
            this.txbx_temp.Name = "txbx_temp";
            this.txbx_temp.Size = new System.Drawing.Size(529, 27);
            this.txbx_temp.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(8, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Температура";
            // 
            // txbx_feedName
            // 
            this.txbx_feedName.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_feedName.Location = new System.Drawing.Point(241, 21);
            this.txbx_feedName.Multiline = true;
            this.txbx_feedName.Name = "txbx_feedName";
            this.txbx_feedName.Size = new System.Drawing.Size(529, 27);
            this.txbx_feedName.TabIndex = 0;
            // 
            // txbx_consistency
            // 
            this.txbx_consistency.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_consistency.Location = new System.Drawing.Point(241, 111);
            this.txbx_consistency.Multiline = true;
            this.txbx_consistency.Name = "txbx_consistency";
            this.txbx_consistency.ReadOnly = true;
            this.txbx_consistency.Size = new System.Drawing.Size(529, 27);
            this.txbx_consistency.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(8, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Консистенция";
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
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категория товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название корма";
            // 
            // зоомагазинDataSet
            // 
            this.зоомагазинDataSet.DataSetName = "ЗоомагазинDataSet";
            this.зоомагазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // зоомагазинDataSetBindingSource
            // 
            this.зоомагазинDataSetBindingSource.DataSource = this.зоомагазинDataSet;
            this.зоомагазинDataSetBindingSource.Position = 0;
            // 
            // зоомагазинDataSet1
            // 
            this.зоомагазинDataSet1.DataSetName = "ЗоомагазинDataSet1";
            this.зоомагазинDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыИКатегорииBindingSource
            // 
            this.товарыИКатегорииBindingSource.DataMember = "Товары и категории";
            this.товарыИКатегорииBindingSource.DataSource = this.зоомагазинDataSet1;
            // 
            // товары_и_категорииTableAdapter
            // 
            this.товары_и_категорииTableAdapter.ClearBeforeFill = true;
            // 
            // категории_товаровTableAdapter
            // 
            this.категории_товаровTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(437, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Сухой - ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.Location = new System.Drawing.Point(663, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Сырой - ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(517, 163);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(748, 164);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // NewFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewFeed";
            this.Text = "NewFeed";
            this.Load += new System.EventHandler(this.NewFeed_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категорииТоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыИКатегорииBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chckbx_allegric;
        private System.Windows.Forms.Button btn_addData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbx_category;
        private System.Windows.Forms.TextBox txbx_weight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbx_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_keysOf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_temp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_feedName;
        private System.Windows.Forms.TextBox txbx_consistency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_allergic;
        private System.Windows.Forms.BindingSource зоомагазинDataSetBindingSource;
        private ЗоомагазинDataSet зоомагазинDataSet;
        private ЗоомагазинDataSet1 зоомагазинDataSet1;
        private System.Windows.Forms.BindingSource товарыИКатегорииBindingSource;
        private ЗоомагазинDataSet1TableAdapters.Товары_и_категорииTableAdapter товары_и_категорииTableAdapter;
        private ЗоомагазинDataSet2 зоомагазинDataSet2;
        private System.Windows.Forms.BindingSource категорииТоваровBindingSource;
        private ЗоомагазинDataSet2TableAdapters.Категории_товаровTableAdapter категории_товаровTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}