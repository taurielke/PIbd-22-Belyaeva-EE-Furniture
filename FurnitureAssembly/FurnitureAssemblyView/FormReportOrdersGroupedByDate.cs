﻿using FurnitureAssemblyContracts.BindingModels;
using FurnitureAssemblyContracts.BusinessLogicsContracts;
using Microsoft.Reporting.WinForms;
using System;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace FurnitureAssemblyView
{
    public partial class FormReportOrdersGroupedByDate : Form
    {
        private readonly ReportViewer reportViewer;
        private readonly IReportLogic _logic;
        public FormReportOrdersGroupedByDate(IReportLogic logic)
        {
            InitializeComponent();
            _logic = logic;
            reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill
            };
            reportViewer.LocalReport.LoadReportDefinition(new FileStream("ReportOrdersGroupedByDate.rdlc", FileMode.Open));
            Controls.Clear();
            Controls.Add(reportViewer);
            Controls.Add(panel);
        }

        private void buttonForm_Click(object sender, EventArgs e)
        {
            try
            {
                MethodInfo method = _logic.GetType().GetMethod("GetOrdersGroupedByDate");
                var dataSource = method.Invoke(_logic, Array.Empty<object>());
                var source = new ReportDataSource("DataSetOrdersGroupedByDate", dataSource);
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(source);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonToPdf_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MethodInfo method = _logic.GetType().GetMethod("SaveOrdersGroupedByDateToPdfFile");
                    method.Invoke(_logic, new object[] {new ReportBindingModel
                    {
                        FileName = dialog.FileName
                    }});
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
