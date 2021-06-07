
namespace PetshopDB.Forms
{
    partial class NewAnimal
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
            this.txbx_animalFamily = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_animalBreed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_price = new System.Windows.Forms.TextBox();
            this.chckbx_breedOrNot = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbx_animalFamily
            // 
            this.txbx_animalFamily.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_animalFamily.Location = new System.Drawing.Point(253, 29);
            this.txbx_animalFamily.Multiline = true;
            this.txbx_animalFamily.Name = "txbx_animalFamily";
            this.txbx_animalFamily.Size = new System.Drawing.Size(529, 27);
            this.txbx_animalFamily.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckbx_breedOrNot);
            this.groupBox1.Controls.Add(this.btn_addData);
            this.groupBox1.Controls.Add(this.txbx_price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbx_animalBreed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 270);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btn_addData
            // 
            this.btn_addData.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_addData.Location = new System.Drawing.Point(241, 215);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(294, 39);
            this.btn_addData.TabIndex = 3;
            this.btn_addData.Text = "Добавить нового животного";
            this.btn_addData.UseVisualStyleBackColor = true;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Породистость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Семейство животного";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Порода";
            // 
            // txbx_animalBreed
            // 
            this.txbx_animalBreed.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_animalBreed.Location = new System.Drawing.Point(241, 111);
            this.txbx_animalBreed.Multiline = true;
            this.txbx_animalBreed.Name = "txbx_animalBreed";
            this.txbx_animalBreed.Size = new System.Drawing.Size(529, 27);
            this.txbx_animalBreed.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(8, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Цена";
            // 
            // txbx_price
            // 
            this.txbx_price.Font = new System.Drawing.Font("Arial", 12F);
            this.txbx_price.Location = new System.Drawing.Point(241, 158);
            this.txbx_price.Multiline = true;
            this.txbx_price.Name = "txbx_price";
            this.txbx_price.Size = new System.Drawing.Size(529, 27);
            this.txbx_price.TabIndex = 0;
            this.txbx_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chckbx_breedOrNot
            // 
            this.chckbx_breedOrNot.AutoSize = true;
            this.chckbx_breedOrNot.Location = new System.Drawing.Point(241, 71);
            this.chckbx_breedOrNot.Name = "chckbx_breedOrNot";
            this.chckbx_breedOrNot.Size = new System.Drawing.Size(18, 17);
            this.chckbx_breedOrNot.TabIndex = 4;
            this.chckbx_breedOrNot.UseVisualStyleBackColor = true;
            this.chckbx_breedOrNot.CheckedChanged += new System.EventHandler(this.chckbx_breedOrNot_CheckedChanged);
            // 
            // NewAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 294);
            this.Controls.Add(this.txbx_animalFamily);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewAnimal";
            this.Text = "Добавление нового животного";
            this.Load += new System.EventHandler(this.NewAnimal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_animalFamily;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_animalBreed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chckbx_breedOrNot;
        private System.Windows.Forms.TextBox txbx_price;
        private System.Windows.Forms.Label label5;
    }
}