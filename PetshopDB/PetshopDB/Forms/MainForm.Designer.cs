
namespace PetshopDB
{
    partial class frm_MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_productList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_animalsList = new System.Windows.Forms.DataGridView();
            this.btn_showMeds = new System.Windows.Forms.Button();
            this.btn_showFood = new System.Windows.Forms.Button();
            this.btn_showOther = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.животныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗверяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лекарствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЛекарствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кормToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКормToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animalsList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_productList);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 361);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список товаров";
            // 
            // dgv_productList
            // 
            this.dgv_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productList.Location = new System.Drawing.Point(6, 29);
            this.dgv_productList.Name = "dgv_productList";
            this.dgv_productList.RowHeadersWidth = 51;
            this.dgv_productList.RowTemplate.Height = 24;
            this.dgv_productList.Size = new System.Drawing.Size(1051, 326);
            this.dgv_productList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_animalsList);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox2.Location = new System.Drawing.Point(12, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1212, 297);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Животные";
            // 
            // dgv_animalsList
            // 
            this.dgv_animalsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_animalsList.Location = new System.Drawing.Point(6, 29);
            this.dgv_animalsList.Name = "dgv_animalsList";
            this.dgv_animalsList.RowHeadersWidth = 51;
            this.dgv_animalsList.RowTemplate.Height = 24;
            this.dgv_animalsList.Size = new System.Drawing.Size(1200, 262);
            this.dgv_animalsList.TabIndex = 0;
            // 
            // btn_showMeds
            // 
            this.btn_showMeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_showMeds.Location = new System.Drawing.Point(-1, 57);
            this.btn_showMeds.Name = "btn_showMeds";
            this.btn_showMeds.Size = new System.Drawing.Size(138, 78);
            this.btn_showMeds.TabIndex = 4;
            this.btn_showMeds.Text = "Лекарства";
            this.btn_showMeds.UseVisualStyleBackColor = true;
            this.btn_showMeds.Click += new System.EventHandler(this.btn_showMeds_Click);
            // 
            // btn_showFood
            // 
            this.btn_showFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_showFood.Location = new System.Drawing.Point(-1, 154);
            this.btn_showFood.Name = "btn_showFood";
            this.btn_showFood.Size = new System.Drawing.Size(145, 78);
            this.btn_showFood.TabIndex = 4;
            this.btn_showFood.Text = "Корм";
            this.btn_showFood.UseVisualStyleBackColor = true;
            this.btn_showFood.Click += new System.EventHandler(this.btn_showFood_Click);
            // 
            // btn_showOther
            // 
            this.btn_showOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_showOther.Location = new System.Drawing.Point(0, 254);
            this.btn_showOther.Name = "btn_showOther";
            this.btn_showOther.Size = new System.Drawing.Size(138, 78);
            this.btn_showOther.TabIndex = 4;
            this.btn_showOther.Text = "Другие товары";
            this.btn_showOther.UseVisualStyleBackColor = true;
            this.btn_showOther.Click += new System.EventHandler(this.btn_showOther_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_showMeds);
            this.groupBox3.Controls.Add(this.btn_showFood);
            this.groupBox3.Controls.Add(this.btn_showOther);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(1086, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 355);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор категории";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТоварToolStripMenuItem});
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.товарыToolStripMenuItem.Text = "Товары";
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьТоварToolStripMenuItem.Text = "Добавить товар";
            this.добавитьТоварToolStripMenuItem.Click += new System.EventHandler(this.добавитьТоварToolStripMenuItem_Click);
            // 
            // животныеToolStripMenuItem
            // 
            this.животныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗверяToolStripMenuItem});
            this.животныеToolStripMenuItem.Name = "животныеToolStripMenuItem";
            this.животныеToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.животныеToolStripMenuItem.Text = "Животные";
            // 
            // добавитьЗверяToolStripMenuItem
            // 
            this.добавитьЗверяToolStripMenuItem.Name = "добавитьЗверяToolStripMenuItem";
            this.добавитьЗверяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьЗверяToolStripMenuItem.Text = "Добавить зверя";
            this.добавитьЗверяToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗверяToolStripMenuItem_Click);
            // 
            // лекарствоToolStripMenuItem
            // 
            this.лекарствоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЛекарствоToolStripMenuItem});
            this.лекарствоToolStripMenuItem.Name = "лекарствоToolStripMenuItem";
            this.лекарствоToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.лекарствоToolStripMenuItem.Text = "Лекарство";
            // 
            // добавитьЛекарствоToolStripMenuItem
            // 
            this.добавитьЛекарствоToolStripMenuItem.Name = "добавитьЛекарствоToolStripMenuItem";
            this.добавитьЛекарствоToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.добавитьЛекарствоToolStripMenuItem.Text = "Добавить лекарство";
            this.добавитьЛекарствоToolStripMenuItem.Click += new System.EventHandler(this.добавитьЛекарствоToolStripMenuItem_Click);
            // 
            // кормToolStripMenuItem
            // 
            this.кормToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКормToolStripMenuItem});
            this.кормToolStripMenuItem.Name = "кормToolStripMenuItem";
            this.кормToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.кормToolStripMenuItem.Text = "Корм";
            // 
            // добавитьКормToolStripMenuItem
            // 
            this.добавитьКормToolStripMenuItem.Name = "добавитьКормToolStripMenuItem";
            this.добавитьКормToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьКормToolStripMenuItem.Text = "Добавить корм";
            this.добавитьКормToolStripMenuItem.Click += new System.EventHandler(this.добавитьКормToolStripMenuItem_Click);
            // 
            // категорииToolStripMenuItem
            // 
            this.категорииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКатегориюToolStripMenuItem,
            this.изменитьКатегориюToolStripMenuItem});
            this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            this.категорииToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.категорииToolStripMenuItem.Text = "Категории";
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            this.добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            this.добавитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.добавитьКатегориюToolStripMenuItem.Text = "Добавить категорию для товаров";
            this.добавитьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.добавитьКатегориюToolStripMenuItem_Click);
            // 
            // изменитьКатегориюToolStripMenuItem
            // 
            this.изменитьКатегориюToolStripMenuItem.Name = "изменитьКатегориюToolStripMenuItem";
            this.изменитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.изменитьКатегориюToolStripMenuItem.Text = "Добавить категорию для лекарств";
            this.изменитьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.изменитьКатегориюToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыToolStripMenuItem,
            this.животныеToolStripMenuItem,
            this.лекарствоToolStripMenuItem,
            this.кормToolStripMenuItem,
            this.категорииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frm_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 691);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animalsList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_productList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_animalsList;
        private System.Windows.Forms.Button btn_showMeds;
        private System.Windows.Forms.Button btn_showFood;
        private System.Windows.Forms.Button btn_showOther;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem животныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗверяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лекарствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЛекарствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кормToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКормToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

