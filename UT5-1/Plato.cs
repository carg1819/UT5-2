using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace UT5_1
{
    class Plato : INotifyPropertyChanged
    {
        private String _nombre;
        private String _imagen;
        private String _tipo;
        private bool _gluten;
        private bool _soja;
        private bool _leche;
        private bool _sulfitos;

        public string Nombre
        {
            get { return this._nombre; }
            set
            {
                if (this._nombre != value)
                {
                    this._nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }

        public string Imagen
        {
            get { return this._imagen; }
            set
            {
                if (this._imagen != value)
                {
                    this._imagen = value;
                    this.NotifyPropertyChanged("Imagen");
                }
            }
        }
        public string Tipo
        {
            get { return this._tipo; }
            set
            {
                if (this._tipo != value)
                {
                    this._tipo = value;
                    this.NotifyPropertyChanged("Tipo");
                }
            }
        }
        public bool Gluten
        {
            get { return this._gluten; }
            set
            {
                if (this._gluten != value)
                {
                    this._gluten = value;
                    this.NotifyPropertyChanged("Gluten");
                }
            }
        }
        public bool Soja
        {
            get { return this._soja; }
            set
            {
                if (this._soja != value)
                {
                    this._soja = value;
                    this.NotifyPropertyChanged("Soja");
                }
            }
        }
        public bool Leche
        {
            get { return this._leche; }
            set
            {
                if (this._leche != value)
                {
                    this._leche = value;
                    this.NotifyPropertyChanged("Leche");
                }
            }
        }
        public bool Sulfitos
        {
            get { return this._sulfitos; }
            set
            {
                if (this._sulfitos != value)
                {
                    this._sulfitos = value;
                    this.NotifyPropertyChanged("Sulfitos");
                }
            }
        }


        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Plato()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static List<Plato> GetSamples(string rutaImagenes)
        {
            List<Plato> lista = new List<Plato>();

            lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
            lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

            return lista;
        }
    }
}
