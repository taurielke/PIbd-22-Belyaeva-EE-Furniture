using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureAssemblyBusinessLogic.MailWorker;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.BusinessLogicsContracts;
using FurnitureAssemblyContracts.StoragesContracts;
using FurnitureAssemblyContracts.ViewModels;

namespace FurnitureAssemblyView
{
    public partial class FormMessage : Form
    {
        public string messageId;
        public string MessageId { set { messageId = value; } }
        private readonly IMessageInfoLogic _messageLogic;
        private readonly AbstractMailWorker _mailWorker;
        private readonly IClientStorage _clientStorage;
        public FormMessage(IMessageInfoLogic messageLogic, AbstractMailWorker mailWorker, IClientStorage clientStorage)
        {
            InitializeComponent();
            _messageLogic = messageLogic;
            _mailWorker = mailWorker;
            _clientStorage = clientStorage;
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {
            if (messageId != null)
            {
                try
                {
                    MessageInfoViewModel mes = _messageLogic.Read(new MessageInfoBindingModel { MessageId = messageId })?[0];
                    if (mes != null)
                    {
                        if (!mes.IsRead)
                        {
                            _messageLogic.CreateOrUpdate(new MessageInfoBindingModel
                            {
                                MessageId = messageId,
                                FromMailAddress = mes.SenderName,
                                Subject = mes.Subject,
                                Body = mes.Body,
                                DateDelivery = mes.DateDelivery,
                                IsRead = true,
                                Reply = mes.Reply
                            });
                        }
                        labelSenderName.Text = "Отправитель: " + mes.SenderName;
                        labelSubject.Text = "Заголовок письма: " + mes.Subject;
                        labelBody.Text = "Текст письма: " + mes.Body;
                        labelDateDelivery.Text = mes.DateDelivery.ToString();
                        textBoxReplySubject.Text = "Re: " + mes.Subject;
                        if (!string.IsNullOrEmpty(mes.Reply))
                        {
                            buttonReply.Enabled = false;
                            textBoxReply.Text = mes.Reply;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonReply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxReply.Text))
            {
                MessageBox.Show("Введите ответ на письмо", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _messageLogic.CreateOrUpdate(new MessageInfoBindingModel
                {
                    ClientId = _clientStorage.GetElement(new ClientBindingModel { Email = labelSenderName.Text })?.Id,
                    MessageId = messageId,
                    FromMailAddress = labelSenderName.Text,
                    Subject = labelSubject.Text,
                    Body = labelBody.Text,
                    DateDelivery = DateTime.Parse(labelDateDelivery.Text),
                    IsRead = true,
                    Reply = textBoxReply.Text
                });

                _mailWorker.MailSendAsync(new MailSendInfoBindingModel
                {
                    MailAddress = labelSenderName.Text,
                    Subject = "Ответ: <" + labelSubject.Text + ">",
                    Text = textBoxReply.Text
                });
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
