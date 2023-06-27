using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab_4_5
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
            _application.Resources.Add("Loc_BlueTheme", "INIT");
            _application.Resources.Add("Loc_BlackTheme", "INIT");

            SetLang("Rus");
        }
        public void SetLang(string lang)
        {
            switch (lang)
            {
                case "Rus":
                    _application.Resources["Loc_Tittle"] = "Русский";
                    _application.Resources["Loc_Ru"] = "Русский";
                    _application.Resources["Loc_En"] = "Английский";
                    _application.Resources["Loc_SearchButton"] = "Поиск";
                    _application.Resources["Loc_Change"] = "Редактировать";
                    _application.Resources["Loc_Delete"] = "Удалить";
                    _application.Resources["Loc_Add"] = "Добавить";
                    _application.Resources["Loc_Login"] = "Войти";
                    _application.Resources["Loc_Offer"] = "Интересные предложения";
                    _application.Resources["Loc_BlueTheme"] = "Обычная";
                    _application.Resources["Loc_BlackTheme"] = "Темная";
                    break;
                // Eng
                default:
                    _application.Resources["Loc_Tittle"] = "English";
                    _application.Resources["Loc_Ru"] = "Russian";
                    _application.Resources["Loc_En"] = "English";
                    _application.Resources["Loc_SearchButton"] = "Search";
                    _application.Resources["Loc_Change"] = "Edit";
                    _application.Resources["Loc_Delete"] = "Delete";
                    _application.Resources["Loc_Add"] = "Add";
                    _application.Resources["Loc_Login"] = "Login";
                    _application.Resources["Loc_Offer"] = "Engaging Offers";
                    _application.Resources["Loc_BlueTheme"] = "Normal";
                    _application.Resources["Loc_BlackTheme"] = "Black";
                    break;
            }
        }
    }
}
