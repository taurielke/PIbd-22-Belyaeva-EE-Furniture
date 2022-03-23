
namespace FurnitureAssemblyView
{
    partial class FormCreateOrder
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
            this.labelFurniture = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelResPrice = new System.Windows.Forms.Label();
            this.comboBoxFurniture = new System.Windows.Forms.ComboBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxResPrice = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFurniture
            // 
            this.labelFurniture.AutoSize = true;
            this.labelFurniture.Location = new System.Drawing.Point(12, 16);
            this.labelFurniture.Name = "labelFurniture";
            this.labelFurniture.Size = new System.Drawing.Size(84, 25);
            this.labelFurniture.TabIndex = 0;
            this.labelFurniture.Text = "Изделие:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 68);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(111, 25);
            this.labelAmount.TabIndex = 1;
            this.labelAmount.Text = "Количество:";
            // 
            // labelResPrice
            // 
            this.labelResPrice.AutoSize = true;
            this.labelResPrice.Location = new System.Drawing.Point(12, 119);
            this.labelResPrice.Name = "labelResPrice";
            this.labelResPrice.Size = new System.Drawing.Size(71, 25);
            this.labelResPrice.TabIndex = 2;
            this.labelResPrice.Text = "Сумма:";
            // 
            // comboBoxFurniture
            // 
            this.comboBoxFurniture.FormattingEnabled = true;
            this.comboBoxFurniture.Location = new System.Drawing.Point(137, 13);
            this.comboBoxFurniture.Name = "comboBoxFurniture";
            this.comboBoxFurniture.Size = new System.Drawing.Size(452, 33);
            this.comboBoxFurniture.TabIndex = 3;
            this.comboBoxFurniture.SelectedIndexChanged += new System.EventHandler(this.comboBoxFurniture_SelectedIndexChanged);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(137, 65);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(452, 31);
            this.textBoxAmount.TabIndex = 4;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // textBoxResPrice
            // 
            this.textBoxResPrice.Location = new System.Drawing.Point(137, 116);
            this.textBoxResPrice.Name = "textBoxResPrice";
            this.textBoxResPrice.Size = new System.Drawing.Size(452, 31);
            this.textBoxResPrice.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(203, 174);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(190, 56);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(399, 174);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(190, 56);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 247);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxResPrice);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.comboBoxFurniture);
            this.Controls.Add(this.labelResPrice);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelFurniture);
            this.Name = "FormCreateOrder";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFurniture;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelResPrice;
        private System.Windows.Forms.ComboBox comboBoxFurniture;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxResPrice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}