
namespace PetshopDB.Forms
{
    partial class NewCategoryForProducts
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
            this.txbx_categoryName = new System.Windows.Forms.TextBox();
            this.btn_addData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbx_categoryName
            // 
            this.txbx_categoryName.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_categoryName.Location = new System.Drawing.Point(259, 25);
            this.txbx_categoryName.Multiline = true;
            this.txbx_categoryName.Name = "txbx_categoryName";
            this.txbx_categoryName.Size = new System.Drawing.Size(529, 27);
            this.txbx_categoryName.TabIndex = 7;
            // 
            // btn_addData
            // 
            this.btn_addData.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_addData.Location = new System.Drawing.Point(259, 76);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(294, 39);
            this.btn_addData.TabIndex = 6;
            this.btn_addData.Text = "Добавить новую категорию";
            this.btn_addData.UseVisualStyleBackColor = true;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование категории";
            // 
            // NewCategoryForProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 127);
            this.Controls.Add(this.txbx_categoryName);
            this.Controls.Add(this.btn_addData);
            this.Controls.Add(this.label1);
            this.Name = "NewCategoryForProducts";
            this.Text = "NewCategoryForProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_categoryName;
        private System.Windows.Forms.Button btn_addData;
        private System.Windows.Forms.Label label1;
    }
}