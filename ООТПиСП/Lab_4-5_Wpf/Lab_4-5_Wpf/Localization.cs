using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab_4_5_Wpf
{
   public class Localization
    {
        private App _application;
        public App application { get { return _application; } }
        public Localization() 
        {
            _application = (App)Application.Current;
            _application.Resources.Add("Loc_Tittle", "INIT");
            _application.Resources.Add("Loc_SearchButton", "INIT");
            _application.Resources.Add("Loc_DataGridColumn_Description", "INIT");
            _application.Resources.Add("Loc_DataGridColumn_ID_Title", "INIT");
            _application.Resources.Add("Loc_DataGridColumn_Price", "INIT");
            _application.Resources.Add("Loc_DataGridColumn_Type", "INIT");
            _application.Resources.Add("Loc_DataGridColumn_Operations", "INIT");
            _application.Resources.Add("Loc_AddMainButton", "INIT");

            SetLang("Eng");
        }
        public void SetLang(string lang)
        {
            switch (lang)
            {
                case "Rus":
                    _application.Resources["Loc_Tittle"] = "Русский";
                    _application.Resources["Loc_SearchButton"] = "Поиск";
                    _application.Resources["Loc_DataGridColumn_Description"] = "Описание";
                    _application.Resources["Loc_DataGridColumn_ID_Title"] = "ID \\ Название";
                    _application.Resources["Loc_DataGridColumn_Price"] = "Цена";
                    _application.Resources["Loc_DataGridColumn_Type"] = "Тип";
                    _application.Resources["Loc_DataGridColumn_Operations"] = "Операции";
                    _application.Resources["Loc_AddMainButton"] = "Добавить";
                    break;
                // Eng
                default:
                    _application.Resources["Loc_Tittle"] = "Eng";
                    _application.Resources["Loc_SearchButton"] = "Search";
                    _application.Resources["Loc_DataGridColumn_Description"] = "Description";
                    _application.Resources["Loc_DataGridColumn_ID_Title"] = "ID \\ Title";
                    _application.Resources["Loc_DataGridColumn_Price"] = "Price";
                    _application.Resources["Loc_DataGridColumn_Type"] = "Type";
                    _application.Resources["Loc_DataGridColumn_Operations"] = "Operations";
                    _application.Resources["Loc_AddMainButton"] = "Add";
                    break;
            }
        }
    }
}
