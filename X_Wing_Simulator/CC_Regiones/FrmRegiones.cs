using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CC_Planetas;

namespace CC_Region
{
    public partial class FrmRegiones : UserControl
    {
        FrmPlaneta.ProcesadoDeImagen ImportarImagen = new FrmPlaneta.ProcesadoDeImagen();
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set 
            {
                _nombre = value;
                lbl_nombre_region.Text = _nombre;  
            }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set 
            {
                _descripcion = value;
                lbl_descripcion.Text = _descripcion;
            }
        }

        private string _imagen;

        public string Imagen
        {
            get { return _imagen; }
            set 
            { 
                _imagen = value.Substring(0, value.Length - 4);
                pic_imagen.ImageLocation = ImportarImagen.CargarFicheros(_imagen);
            }
        }


        public FrmRegiones()
        {
            InitializeComponent();
        }
    }
}
