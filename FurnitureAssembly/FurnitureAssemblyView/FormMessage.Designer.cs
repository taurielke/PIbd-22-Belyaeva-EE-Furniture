namespace FurnitureAssemblyView
{
    partial class FormMessage
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
            this.textBoxReply = new System.Windows.Forms.TextBox();
            this.buttonReply = new System.Windows.Forms.Button();
            this.labelSenderName = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.labelDateDelivery = new System.Windows.Forms.Label();
            this.textBoxReplySubject = new System.Windows.Forms.TextBox();
            this.labelReplySubject = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxReply
            // 
            this.textBoxReply.Location = new System.Drawing.Point(8, 477);
            this.textBoxReply.Name = "textBoxReply";
            this.textBoxReply.Size = new System.Drawing.Size(1164, 31);
            this.textBoxReply.TabIndex = 0;
            // 
            // buttonReply
            // 
            this.buttonReply.Location = new System.Drawing.Point(1000, 514);
            this.buttonReply.Name = "buttonReply";
            this.buttonReply.Size = new System.Drawing.Size(172, 45);
            this.buttonReply.TabIndex = 1;
            this.buttonReply.Text = "Отправить ответ";
            this.buttonReply.UseVisualStyleBackColor = true;
            this.buttonReply.Click += new System.EventHandler(this.buttonReply_Click);
            // 
            // labelSenderName
            // 
            this.labelSenderName.AutoSize = true;
            this.labelSenderName.Location = new System.Drawing.Point(7, 9);
            this.labelSenderName.Name = "labelSenderName";
            this.labelSenderName.Size = new System.Drawing.Size(121, 25);
            this.labelSenderName.TabIndex = 2;
            this.labelSenderName.Text = "Отправитель:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(8, 52);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(108, 25);
            this.labelSubject.TabIndex = 3;
            this.labelSubject.Text = "Заголовок: ";
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(8, 90);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(63, 25);
            this.labelBody.TabIndex = 4;
            this.labelBody.Text = "Текст: ";
            // 
            // labelDateDelivery
            // 
            this.labelDateDelivery.AutoSize = true;
            this.labelDateDelivery.Location = new System.Drawing.Point(7, 125);
            this.labelDateDelivery.Name = "labelDateDelivery";
            this.labelDateDelivery.Size = new System.Drawing.Size(117, 25);
            this.labelDateDelivery.TabIndex = 5;
            this.labelDateDelivery.Text = "Доставлено: ";
            // 
            // textBoxReplySubject
            // 
            this.textBoxReplySubject.Location = new System.Drawing.Point(129, 427);
            this.textBoxReplySubject.Name = "textBoxReplySubject";
            this.textBoxReplySubject.Size = new System.Drawing.Size(1043, 31);
            this.textBoxReplySubject.TabIndex = 6;
            // 
            // labelReplySubject
            // 
            this.labelReplySubject.AutoSize = true;
            this.labelReplySubject.Location = new System.Drawing.Point(8, 427);
            this.labelReplySubject.Name = "labelReplySubject";
            this.labelReplySubject.Size = new System.Drawing.Size(103, 25);
            this.labelReplySubject.TabIndex = 7;
            this.labelReplySubject.Text = "Заголовок:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(822, 514);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(172, 45);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 574);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelReplySubject);
            this.Controls.Add(this.textBoxReplySubject);
            this.Controls.Add(this.labelDateDelivery);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelSenderName);
            this.Controls.Add(this.buttonReply);
            this.Controls.Add(this.textBoxReply);
            this.Name = "FormMessage";
            this.Text = "Письмо";
            this.Load += new System.EventHandler(this.FormMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReply;
        private System.Windows.Forms.Button buttonReply;
        private System.Windows.Forms.Label labelSenderName;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.Label labelDateDelivery;
        private System.Windows.Forms.TextBox textBoxReplySubject;
        private System.Windows.Forms.Label labelReplySubject;
        private System.Windows.Forms.Button buttonCancel;
    }
}