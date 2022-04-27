using System;
using System.Collections.Generic;
using System.Text;
using FurnitureAssemblyBusinessLogic.OfficePackage.HelperEnums;
using FurnitureAssemblyBusinessLogic.OfficePackage.HelperModels;

namespace FurnitureAssemblyBusinessLogic.OfficePackage
{
    public abstract class AbstractSaveToWord
    {
        public void CreateDoc(WordInfo info)
        {
            CreateWord(info);
            CreateParagraph(new WordParagraph
            {
                Texts = new List<(string, WordTextProperties)> { (info.Title, new WordTextProperties { Bold = true, Size = "24"}) },
                TextProperties = new WordTextProperties
                {
                    Size = "24",
                    JustificationType = WordJustificationType.Center
                }
            });
            foreach (var furniture in info.Furnitures)
            {
                CreateParagraph(new WordParagraph
                {
                    Texts = new List<(string, WordTextProperties)> {
                        (furniture.FurnitureName + ": ", new WordTextProperties {Size = "24", Bold = true}),
                        (Convert.ToInt32(furniture.Price).ToString(), new WordTextProperties {
                        Size = "24"
                        })
                    },
                    TextProperties = new WordTextProperties
                    {
                        Size = "24",
                        JustificationType = WordJustificationType.Both
                    }
                });
            }
            SaveWord(info);
        }
        public void CreateDocWarehouse(WordInfo info)
        {
            CreateWord(info);
            CreateParagraph(new WordParagraph
            {
                Texts = new List<(string, WordTextProperties)> {(info.Title, new WordTextProperties { Bold = true, Size = "24"}) },
                TextProperties = new WordTextProperties
                {
                    Size = "24",
                    JustificationType = WordJustificationType.Center
                }
            });
            CreateTable(new List<string>() { "Название", "ФИО ответственного", "Дата создания" });
            foreach (var warehouse in info.Warehouses)
            {
                CreateRow(new List<string>() {
                    warehouse.WarehouseName,
                    warehouse.ResponsiblePerson,
                    warehouse.DateCreate.ToShortDateString()
                });
            }
            SaveWord(info);
        }
        protected abstract void CreateWord(WordInfo info);
        protected abstract void CreateParagraph(WordParagraph paragraph);
        protected abstract void SaveWord(WordInfo info);
        protected abstract void CreateTable(List<string> tableHeaderInfo);
        protected abstract void CreateRow(List<string> tableRowInfo);
    }
}
