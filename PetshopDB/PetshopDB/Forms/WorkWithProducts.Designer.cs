
namespace PetshopDB.Forms
{
    partial class WorkWithProducts
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
            this.txbx_productName = new System.Windows.Forms.TextBox();
            this.cmbx_productCategory = new System.Windows.Forms.ComboBox();
            this.категорииТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.зоомагазинDataSet = new PetshopDB.ЗоомагазинDataSet();
            this.txbx_productPriсe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addData = new System.Windows.Forms.Button();
            this.категории_товаровTableAdapter = new PetshopDB.ЗоомагазинDataSetTableAdapters.Категории_товаровTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.категорииТоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbx_productName
            // 
            this.txbx_productName.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_productName.Location = new System.Drawing.Point(245, 19);
            this.txbx_productName.Multiline = true;
            this.txbx_productName.Name = "txbx_productName";
            this.txbx_productName.Size = new System.Drawing.Size(474, 27);
            this.txbx_productName.TabIndex = 0;
            // 
            // cmbx_productCategory
            // 
            this.cmbx_productCategory.DataSource = this.категорииТоваровBindingSource;
            this.cmbx_productCategory.DisplayMember = "Наименование категории";
            this.cmbx_productCategory.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbx_productCategory.FormattingEnabled = true;
            this.cmbx_productCategory.Location = new System.Drawing.Point(241, 64);
            this.cmbx_productCategory.Name = "cmbx_productCategory";
            this.cmbx_productCategory.Size = new System.Drawing.Size(474, 31);
            this.cmbx_productCategory.TabIndex = 1;
            this.cmbx_productCategory.ValueMember = "id категории";
            this.cmbx_productCategory.SelectedIndexChanged += new System.EventHandler(this.cmbx_productCategory_SelectedIndexChanged);
            // 
            // категорииТоваровBindingSource
            // 
            this.категорииТоваровBindingSource.DataMember = "Категории товаров";
            this.категорииТоваровBindingSource.DataSource = this.зоомагазинDataSet;
            // 
            // зоомагазинDataSet
            // 
            this.зоомагазинDataSet.DataSetName = "ЗоомагазинDataSet";
            this.зоомагазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txbx_productPriсe
            // 
            this.txbx_productPriсe.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_productPriсe.Location = new System.Drawing.Point(241, 114);
            this.txbx_productPriсe.Multiline = true;
            this.txbx_productPriсe.Name = "txbx_productPriсe";
            this.txbx_productPriсe.Size = new System.Drawing.Size(474, 27);
            this.txbx_productPriсe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категория товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(8, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addData);
            this.groupBox1.Controls.Add(this.cmbx_productCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbx_productPriсe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 213);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_addData
            // 
            this.btn_addData.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_addData.Location = new System.Drawing.Point(241, 168);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(242, 39);
            this.btn_addData.TabIndex = 3;
            this.btn_addData.Text = "Добавить товар";
            this.btn_addData.UseVisualStyleBackColor = true;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // категории_товаровTableAdapter
            // 
            this.категории_товаровTableAdapter.ClearBeforeFill = true;
            // 
            // WorkWithProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 227);
            this.Controls.Add(this.txbx_productName);
            this.Controls.Add(this.groupBox1);
            this.Name = "WorkWithProducts";
            this.Text = "WorkWithProducts";
            this.Load += new System.EventHandler(this.WorkWithProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.категорииТоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоомагазинDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_productName;
        private System.Windows.Forms.ComboBox cmbx_productCategory;
        private System.Windows.Forms.TextBox txbx_productPriсe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addData;
        private ЗоомагазинDataSet зоомагазинDataSet;
        private System.Windows.Forms.BindingSource категорииТоваровBindingSource;
        private ЗоомагазинDataSetTableAdapters.Категории_товаровTableAdapter категории_товаровTableAdapter;
    }
}