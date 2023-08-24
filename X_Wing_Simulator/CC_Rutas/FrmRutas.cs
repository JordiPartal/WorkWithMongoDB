using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CC_Planetas;

namespace CC_Rutas
{
    public partial class FrmRutas : UserControl
    {
        FrmPlaneta.ProcesadoDeImagen ImportarImagen = new FrmPlaneta.ProcesadoDeImagen();
        private string _nombre_region;

        public new string Region
        {
            get { return _nombre_region; }
            set { 
                _nombre_region = value;
                lbl_nombre_region.Text = _nombre_region;
            }
        }

        private string _tipo_ruta;

        public string Tipo
        {
            get { return _tipo_ruta; }
            set { 
                _tipo_ruta = value;
                lbl_tipo_ruta.Text = _tipo_ruta;
            }
        }

        private string _inicio;

        public string Inicio
        {
            get { return _inicio; }
            set { 
                _inicio = value;
                lbl_incio.Text = _inicio;
            }
        }

        private string _final;

        public string Final
        {
            get { return _final; }
            set { 
                _final = value;
                lbl_final.Text = _final;
            }
        }

        private string _imagen;

        public string Imagen
        {
            get { return _imagen; }
            set 
            {
                _imagen = value;
                string[] _nombre_dividido = _imagen.Split(' ');
                string imagen_ruta = string.Join("", _nombre_dividido);
                pic_imagen.ImageLocation = ImportarImagen.CargarFicheros(imagen_ruta);
            }
        }


        public FrmRutas()
        {
            InitializeComponent();
        }
    }
}
