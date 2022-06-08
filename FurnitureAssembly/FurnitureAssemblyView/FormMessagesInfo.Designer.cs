namespace FurnitureAssemblyView
{
    partial class FormMessagesInfo
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonOpenMessage = new System.Windows.Forms.Button();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.labelMaxPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(11, 20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(939, 315);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(770, 383);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(180, 71);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 380);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(180, 71);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(198, 379);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(180, 71);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Вперед";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonOpenMessage
            // 
            this.buttonOpenMessage.Location = new System.Drawing.Point(584, 383);
            this.buttonOpenMessage.Name = "buttonOpenMessage";
            this.buttonOpenMessage.Size = new System.Drawing.Size(180, 71);
            this.buttonOpenMessage.TabIndex = 4;
            this.buttonOpenMessage.Text = "Открыть письмо";
            this.buttonOpenMessage.UseVisualStyleBackColor = true;
            this.buttonOpenMessage.Click += new System.EventHandler(this.buttonOpenMessage_Click);
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Location = new System.Drawing.Point(422, 406);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(123, 25);
            this.labelCurrentPage.TabIndex = 5;
            this.labelCurrentPage.Text = "Страница | 1 |";
            // 
            // labelMaxPage
            // 
            this.labelMaxPage.AutoSize = true;
            this.labelMaxPage.Location = new System.Drawing.Point(555, 605);
            this.labelMaxPage.Name = "labelMaxPage";
            this.labelMaxPage.Size = new System.Drawing.Size(12, 25);
            this.labelMaxPage.TabIndex = 6;
            this.labelMaxPage.Text = "\r\n";
            // 
            // FormMessagesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 477);
            this.Controls.Add(this.labelMaxPage);
            this.Controls.Add(this.labelCurrentPage);
            this.Controls.Add(this.buttonOpenMessage);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormMessagesInfo";
            this.Text = "Информация об электронных письмах";
            this.Load += new System.EventHandler(this.FormMessagesInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonOpenMessage;
        private System.Windows.Forms.Label labelCurrentPage;
        private System.Windows.Forms.Label labelMaxPage;
    }
}