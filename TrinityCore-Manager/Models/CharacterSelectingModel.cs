using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;

namespace TrinityCore_Manager.Models
{
    public class CharacterSelectingModel : ModelBase
    {
        public CharacterSelectingModel()
        {
            //Themes = new ObservableCollection<string>();
        }

        //public ObservableCollection<string> Themes
        //{
        //    get
        //    {
        //        return GetValue<ObservableCollection<string>>(ThemesProperty);
        //    }
        //    set
        //    {
        //        SetValue(ThemesProperty, value);
        //    }
        //}

        //public static readonly PropertyData ThemesProperty = RegisterProperty("Themes", typeof(ObservableCollection<string>));

        //public string SelectedTheme
        //{
        //    get
        //    {
        //        return GetValue<string>(SelectedThemeProperty);
        //    }
        //    set
        //    {
        //        SetValue(SelectedThemeProperty, value);
        //    }
        //}

        //public static readonly PropertyData SelectedThemeProperty = RegisterProperty("SelectedTheme", typeof(string), "Silver");

    }
}
