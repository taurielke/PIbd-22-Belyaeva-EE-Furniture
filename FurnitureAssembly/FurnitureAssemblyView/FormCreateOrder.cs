using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.BusinessLogicsContracts;
using FurnitureAssemblyContracts.ViewModels;

namespace FurnitureAssemblyView
{
    public partial class FormCreateOrder : Form
    {
        private readonly IFurnitureLogic _logicF;
        private readonly IOrderLogic _logicO;
        private readonly IClientLogic _logicC;

        public FormCreateOrder(IFurnitureLogic logicF, IOrderLogic logicO, IClientLogic logicC)
        {
            InitializeComponent();
            _logicF = logicF;
            _logicO = logicO;
            _logicC = logicC;
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<FurnitureViewModel> list = _logicF.Read(null);
                if (list != null)
                {
                    comboBoxFurniture.DisplayMember = "FurnitureName";
                    comboBoxFurniture.ValueMember = "Id";
                    comboBoxFurniture.DataSource = list;
                    comboBoxFurniture.SelectedItem = null;
                }
                List<ClientViewModel> listC = _logicC.Read(null);
                if (listC != null)
                {
                    comboBoxClient.DisplayMember = "ClientFIO";
                    comboBoxClient.ValueMember = "Id";
                    comboBoxClient.DataSource = listC;
                    comboBoxClient.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcSum()
        {
            if (comboBoxFurniture.SelectedValue != null && !string.IsNullOrEmpty(textBoxAmount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxFurniture.SelectedValue);
                    FurnitureViewModel furniture = _logicF.Read(new FurnitureBindingModel
                    {
                        Id = id
                    })?[0];
                    int count = Convert.ToInt32(textBoxAmount.Text);
                    textBoxResPrice.Text = (count * furniture?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxFurniture_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAmount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxFurniture.SelectedValue == null)
            {
                MessageBox.Show("Выберите изделие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите клента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicO.CreateOrder(new CreateOrderBindingModel
                {
                    ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
                    FurnitureId = Convert.ToInt32(comboBoxFurniture.SelectedValue),
                    Count = Convert.ToInt32(textBoxAmount.Text),
                    Sum = Convert.ToDecimal(textBoxResPrice.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
