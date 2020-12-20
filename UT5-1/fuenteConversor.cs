using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace UT5_1
{
    class fuenteConversor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            FontFamily fuente;
            switch (value) 
            {
                case "Americana":
                    fuente = new FontFamily("Slim Summer");
                    return fuente;
                case "Mexicana":
                    fuente = new FontFamily("Taco Salad");
                    return fuente;
                case "China":
                    fuente = new FontFamily("Chinese Wok Food St");
                    return fuente;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
