using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CC_Planetas
{
    public partial class FrmPlaneta : UserControl
    {
        ProcesadoDeImagen ImportarImagen = new ProcesadoDeImagen();
        private string _planeta;

        public string Planeta
        {
            get { return _planeta; }
            set
            {
                _planeta = value;
                lbl_planeta.Text = _planeta;
            }
        }

        private string _nativos;

        public string Nativos
        {
            get { return _nativos; }
            set 
            {
                _nativos = value;
                lbl_nativos.Text = _nativos;
            }
        }

        private string _alianza;

        public string Alianza
        {
            get { return _alianza; }
            set 
            {
                _alianza = value;
                lbl_alianza.Text = _alianza;
            }
        }

        private string _longitud;

        public string Longitud
        {
            get { return _longitud; }
            set
            {
                _longitud = value;
                lbl_longitud.Text = _longitud;
            }
        }

        private string _latitud;

        public string Latitud
        {
            get { return _latitud; }
            set
            {
                _latitud = value;
                lbl_latitud.Text = _latitud;
            }
        }

        private string _parsecs;

        public string Parsecs
        {
            get { return _parsecs; }
            set
            {
                _parsecs = value;
                lbl_parsecs.Text = _parsecs;
            }
        }

        private string _sector;

        public string Sector
        {
            get { return _sector; }
            set
            {
                _sector = value;
                lbl_sector.Text = _sector;
            }
        }


        private string _ruta_a;

        public string Ruta_A
        {
            get { return _ruta_a; }
            set 
            { 
                _ruta_a = value;
                lbl_ruta_a.Text = _ruta_a;
            }
        }

        private string _ruta_b;

        public string Ruta_B
        {
            get { return _ruta_b; }
            set 
            { 
                _ruta_b = value;
                lbl_ruta_b.Text = _ruta_b;
            }
        }



        private string _imagen;

        public string Imagen
        {
            get { return _imagen; }
            set 
            { 
                _imagen = value;
                pic_planeta.ImageLocation = ImportarImagen.CargarFicheros(_imagen);
            }
        }


        public FrmPlaneta()
        {
            InitializeComponent();
        }

        public class ProcesadoDeImagen
        {
            public string CargarFicheros(string fichero)
            {
                bool fichero_ok;
                string imagen, ruta, ubicacion;
                ubicacion = "";
                ruta = "planetes";
                DirectoryInfo Ficheros = new DirectoryInfo(ruta);
                FileInfo[] ficheros = Ficheros.GetFiles();

                foreach (var item in ficheros)
                {
                    fichero_ok = item.Name.Substring(0, item.Name.Length - 4) == fichero;
                    
                    if (fichero_ok)
                    {
                        imagen = item.Name;
                        ubicacion = string.Format("{0}/{1}", ruta, imagen);
                        break;
                    }
                    else
                    {
                        imagen = "Error.png";
                        ubicacion = string.Format("{0}/{1}", ruta, imagen);
                    }
                }

                return ubicacion;
            }
        }
    }
}
