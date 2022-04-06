
namespace FurnitureAssemblyView
{
    partial class FormReportWarehouseComponents
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
            this.buttonSaveToExcel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnWarehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWarehouseComponents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalComponentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveToExcel
            // 
            this.buttonSaveToExcel.Location = new System.Drawing.Point(13, 13);
            this.buttonSaveToExcel.Name = "buttonSaveToExcel";
            this.buttonSaveToExcel.Size = new System.Drawing.Size(247, 57);
            this.buttonSaveToExcel.TabIndex = 0;
            this.buttonSaveToExcel.Text = "Сохранить в Excel";
            this.buttonSaveToExcel.UseVisualStyleBackColor = true;
            this.buttonSaveToExcel.Click += new System.EventHandler(this.buttonSaveToExcel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnWarehouseName,
            this.ColumnWarehouseComponents,
            this.ColumnTotalComponentAmount});
            this.dataGridView.Location = new System.Drawing.Point(13, 93);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(961, 594);
            this.dataGridView.TabIndex = 1;
            // 
            // ColumnWarehouseName
            // 
            this.ColumnWarehouseName.HeaderText = "Склад";
            this.ColumnWarehouseName.MinimumWidth = 8;
            this.ColumnWarehouseName.Name = "ColumnWarehouseName";
            this.ColumnWarehouseName.Width = 300;
            // 
            // ColumnWarehouseComponents
            // 
            this.ColumnWarehouseComponents.HeaderText = "Компонент";
            this.ColumnWarehouseComponents.MinimumWidth = 8;
            this.ColumnWarehouseComponents.Name = "ColumnWarehouseComponents";
            this.ColumnWarehouseComponents.Width = 300;
            // 
            // ColumnTotalComponentAmount
            // 
            this.ColumnTotalComponentAmount.HeaderText = "Количество";
            this.ColumnTotalComponentAmount.MinimumWidth = 8;
            this.ColumnTotalComponentAmount.Name = "ColumnTotalComponentAmount";
            this.ColumnTotalComponentAmount.Width = 300;
            // 
            // FormReportWarehouseComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 691);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonSaveToExcel);
            this.Name = "FormReportWarehouseComponents";
            this.Text = "Загруженность складов";
            this.Load += new System.EventHandler(this.FormReportWarehouseComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveToExcel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWarehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWarehouseComponents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalComponentAmount;
    }
}