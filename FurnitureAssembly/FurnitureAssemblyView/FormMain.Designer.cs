
namespace FurnitureAssemblyView
{
    partial class FormMain
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonIssuedOrder = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemComponents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFurniture = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClients = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemImplementers = new System.Windows.Forms.ToolStripMenuItem();
            this.электронныеПисьмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReports = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFurnitureList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFurnituresComponents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOrderList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLaunchWork = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWarehouseReports = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWarehouseList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWarehouseComponents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOrdersGroupedByDate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFillWarehouses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWarehouses = new System.Windows.Forms.ToolStripMenuItem();
            this.электронныеПисьмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateBackup = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 36);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(960, 507);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(985, 141);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(327, 62);
            this.buttonCreateOrder.TabIndex = 2;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonIssuedOrder
            // 
            this.buttonIssuedOrder.Location = new System.Drawing.Point(985, 259);
            this.buttonIssuedOrder.Name = "buttonIssuedOrder";
            this.buttonIssuedOrder.Size = new System.Drawing.Size(327, 62);
            this.buttonIssuedOrder.TabIndex = 5;
            this.buttonIssuedOrder.Text = "Заказ выдан";
            this.buttonIssuedOrder.UseVisualStyleBackColor = true;
            this.buttonIssuedOrder.Click += new System.EventHandler(this.buttonIssuedOrder_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(985, 379);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(327, 62);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Обновить список";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp,
            this.toolStripMenuItemFillWarehouses,
            this.toolStripMenuItemReports,
            this.toolStripMenuItemWarehouseReports,
            this.ToolStripMenuItemLaunchWork,
            this.ToolStripMenuItemCreateBackup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1324, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemComponents,
            this.toolStripMenuItemFurniture,
            this.ToolStripMenuItemClients,
            this.ToolStripMenuItemImplementers,
            this.toolStripMenuItemWarehouses,
            this.электронныеПисьмаToolStripMenuItem});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(139, 29);
            this.toolStripMenuItemHelp.Text = "Справочники";
            // 
            // toolStripMenuItemComponents
            // 
            this.toolStripMenuItemComponents.Name = "toolStripMenuItemComponents";
            this.toolStripMenuItemComponents.Size = new System.Drawing.Size(287, 34);
            this.toolStripMenuItemComponents.Text = "Компоненты";
            this.toolStripMenuItemComponents.Click += new System.EventHandler(this.toolStripMenuItemComponents_Click);
            // 
            // toolStripMenuItemFurniture
            // 
            this.toolStripMenuItemFurniture.Name = "toolStripMenuItemFurniture";
            this.toolStripMenuItemFurniture.Size = new System.Drawing.Size(287, 34);
            this.toolStripMenuItemFurniture.Text = "Изделия";
            this.toolStripMenuItemFurniture.Click += new System.EventHandler(this.toolStripMenuItemFurniture_Click);
            // 
            // ToolStripMenuItemClients
            // 
            this.ToolStripMenuItemClients.Name = "ToolStripMenuItemClients";
            this.ToolStripMenuItemClients.Size = new System.Drawing.Size(287, 34);
            this.ToolStripMenuItemClients.Text = "Клиенты";
            this.ToolStripMenuItemClients.Click += new System.EventHandler(this.toolStripMenuItemClients_Click);
            // 
            // ToolStripMenuItemImplementers
            // 
            this.ToolStripMenuItemImplementers.Name = "ToolStripMenuItemImplementers";
            this.ToolStripMenuItemImplementers.Size = new System.Drawing.Size(270, 34);
            this.ToolStripMenuItemImplementers.Text = "Исполнители";
            this.ToolStripMenuItemImplementers.Click += new System.EventHandler(this.ToolStripMenuItemImplementers_Click);
            // 
            // ToolStripMenuItemImplementers
            // 
            this.ToolStripMenuItemImplementers.Name = "ToolStripMenuItemImplementers";
            this.ToolStripMenuItemImplementers.Size = new System.Drawing.Size(287, 34);
            this.ToolStripMenuItemImplementers.Text = "Исполнители";
            this.ToolStripMenuItemImplementers.Click += new System.EventHandler(this.ToolStripMenuItemImplementers_Click);
            // 
            // электронныеПисьмаToolStripMenuItem
            // 
            this.электронныеПисьмаToolStripMenuItem.Name = "электронныеПисьмаToolStripMenuItem";
            this.электронныеПисьмаToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.электронныеПисьмаToolStripMenuItem.Text = "Электронные письма";
            this.электронныеПисьмаToolStripMenuItem.Click += new System.EventHandler(this.электронныеПисьмаToolStripMenuItem_Click);
            // 
            // toolStripMenuItemReports
            // 
            this.toolStripMenuItemReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFurnitureList,
            this.toolStripMenuItemFurnituresComponents,
            this.toolStripMenuItemOrderList});
            this.toolStripMenuItemReports.Name = "toolStripMenuItemReports";
            this.toolStripMenuItemReports.Size = new System.Drawing.Size(88, 29);
            this.toolStripMenuItemReports.Text = "Отчеты";
            // 
            // toolStripMenuItemFurnitureList
            // 
            this.toolStripMenuItemFurnitureList.Name = "toolStripMenuItemFurnitureList";
            this.toolStripMenuItemFurnitureList.Size = new System.Drawing.Size(328, 34);
            this.toolStripMenuItemFurnitureList.Text = "Список изделий";
            this.toolStripMenuItemFurnitureList.Click += new System.EventHandler(this.toolStripMenuItemFurnitureList_Click);
            // 
            // toolStripMenuItemFurnituresComponents
            // 
            this.toolStripMenuItemFurnituresComponents.Name = "toolStripMenuItemFurnituresComponents";
            this.toolStripMenuItemFurnituresComponents.Size = new System.Drawing.Size(328, 34);
            this.toolStripMenuItemFurnituresComponents.Text = "Изделия и их компоненты";
            this.toolStripMenuItemFurnituresComponents.Click += new System.EventHandler(this.toolStripMenuItemFurnituresComponents_Click);
            // 
            // toolStripMenuItemOrderList
            // 
            this.toolStripMenuItemOrderList.Name = "toolStripMenuItemOrderList";
            this.toolStripMenuItemOrderList.Size = new System.Drawing.Size(328, 34);
            this.toolStripMenuItemOrderList.Text = "Список заказов";
            this.toolStripMenuItemOrderList.Click += new System.EventHandler(this.toolStripMenuItemOrderList_Click);
            // 
            // ToolStripMenuItemLaunchWork
            // 
            this.ToolStripMenuItemLaunchWork.Name = "ToolStripMenuItemLaunchWork";
            this.ToolStripMenuItemLaunchWork.Size = new System.Drawing.Size(136, 29);
            this.ToolStripMenuItemLaunchWork.Text = "Запуск работ";
            this.ToolStripMenuItemLaunchWork.Click += new System.EventHandler(this.ToolStripMenuItemLaunchWork_Click);
            // 
            // toolStripMenuItemWarehouseReports
            // 
            this.toolStripMenuItemWarehouseReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemWarehouseList,
            this.toolStripMenuItemWarehouseComponents,
            this.toolStripMenuItemOrdersGroupedByDate});
            this.toolStripMenuItemWarehouseReports.Name = "toolStripMenuItemWarehouseReports";
            this.toolStripMenuItemWarehouseReports.Size = new System.Drawing.Size(186, 29);
            this.toolStripMenuItemWarehouseReports.Text = "Отчеты по складам";
            // 
            // toolStripMenuItemWarehouseList
            // 
            this.toolStripMenuItemWarehouseList.Name = "toolStripMenuItemWarehouseList";
            this.toolStripMenuItemWarehouseList.Size = new System.Drawing.Size(363, 34);
            this.toolStripMenuItemWarehouseList.Text = "Список складов";
            this.toolStripMenuItemWarehouseList.Click += new System.EventHandler(this.toolStripMenuItemWarehouseList_Click);
            // 
            // toolStripMenuItemWarehouseComponents
            // 
            this.toolStripMenuItemWarehouseComponents.Name = "toolStripMenuItemWarehouseComponents";
            this.toolStripMenuItemWarehouseComponents.Size = new System.Drawing.Size(363, 34);
            this.toolStripMenuItemWarehouseComponents.Text = "Загруженность складов";
            this.toolStripMenuItemWarehouseComponents.Click += new System.EventHandler(this.toolStripMenuItemWarehouseComponents_Click);
            // 
            // toolStripMenuItemOrdersGroupedByDate
            // 
            this.toolStripMenuItemOrdersGroupedByDate.Name = "toolStripMenuItemOrdersGroupedByDate";
            this.toolStripMenuItemOrdersGroupedByDate.Size = new System.Drawing.Size(363, 34);
            this.toolStripMenuItemOrdersGroupedByDate.Text = "Общий отчет по всем заказам";
            this.toolStripMenuItemOrdersGroupedByDate.Click += new System.EventHandler(this.toolStripMenuItemOrdersGroupedByDate_Click);
            // 
            // toolStripMenuItemFillWarehouses
            // 
            this.toolStripMenuItemFillWarehouses.Name = "toolStripMenuItemFillWarehouses";
            this.toolStripMenuItemFillWarehouses.Size = new System.Drawing.Size(181, 29);
            this.toolStripMenuItemFillWarehouses.Text = "Пополнить склады";
            this.toolStripMenuItemFillWarehouses.Click += new System.EventHandler(this.toolStripMenuItemFillWarehouses_Click);
            // 
            // toolStripMenuItemWarehouses
            // электронныеПисьмаToolStripMenuItem
            // ToolStripMenuItemCreateBackup
            // 
            this.toolStripMenuItemWarehouses.Name = "toolStripMenuItemWarehouses";
            this.toolStripMenuItemWarehouses.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItemWarehouses.Text = "Склады";
            this.toolStripMenuItemWarehouses.Click += new System.EventHandler(this.toolStripMenuItemWarehouses_Click);
            this.электронныеПисьмаToolStripMenuItem.Name = "электронныеПисьмаToolStripMenuItem";
            this.электронныеПисьмаToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.электронныеПисьмаToolStripMenuItem.Text = "Электронные письма";
            this.электронныеПисьмаToolStripMenuItem.Click += new System.EventHandler(this.электронныеПисьмаToolStripMenuItem_Click);
            this.ToolStripMenuItemCreateBackup.Name = "ToolStripMenuItemCreateBackup";
            this.ToolStripMenuItemCreateBackup.Size = new System.Drawing.Size(145, 29);
            this.ToolStripMenuItemCreateBackup.Text = "Создать бекап";
            this.ToolStripMenuItemCreateBackup.Click += new System.EventHandler(this.ToolStripMenuItemCreateBackup_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 542);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonIssuedOrder);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Сборка мебели под заказ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonIssuedOrder;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFurniture;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemComponents;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReports;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFurnitureList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFurnituresComponents;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrderList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClients;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemImplementers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLaunchWork;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFillWarehouses;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWarehouseReports;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWarehouseList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWarehouseComponents;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrdersGroupedByDate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWarehouses;
        private System.Windows.Forms.ToolStripMenuItem электронныеПисьмаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCreateBackup;
    }
}