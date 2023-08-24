using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_Wing_Simulator
{
    public partial class FrmPrincipal : Form
    {
        string opcion, nodo;
        Procedimientos Proceso = new Procedimientos();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmCarga(object sender, EventArgs e)
        {
            Proceso.RellenarComboboxOpciones(cmb_items);     
        }

        private void SeleccionItem(object sender, EventArgs e)
        {
            string opcion = cmb_items.SelectedItem.ToString();
            lbl_busqueda.Text = opcion;
            Proceso.RellenarTreeView(opcion, tv_registros, tlp_info);
        }

        private void DespuesDeSeleccion(object sender, TreeViewEventArgs e)
        {
            opcion = cmb_items.SelectedItem.ToString();
            nodo = tv_registros.SelectedNode.Text;
        }

        private void ClickBotonBuscar(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case "Planetas":
                    Proceso.VolcarDatosFormsPlaneta(nodo, Proceso.FormPlaneta);
                    break;
                case "Regiones":
                    Proceso.VolcarDatosFormsRegion(nodo, Proceso.FormRegion);
                    break;
                case "Rutas":
                    Proceso.VolcarDatosFormsRutas(nodo, Proceso.FormRuta);
                    break;
                default:
                    break;
            }
        }
    }

    public class Procedimientos
    {
        public CC_Planetas.FrmPlaneta FormPlaneta = new CC_Planetas.FrmPlaneta();
        public CC_Region.FrmRegiones FormRegion = new CC_Region.FrmRegiones();
        public CC_Rutas.FrmRutas FormRuta = new CC_Rutas.FrmRutas();
        
        /// <summary>
        /// Rellena la Combobox con el nombre de las colecciones de MongoDB
        /// </summary>
        /// <param name="Opciones"></param>
        public void RellenarComboboxOpciones(ComboBox Opciones)
        {
            var filtro = new BsonDocument();
            var opciones = new ListCollectionsOptions { Filter = filtro };

            var NombreDeCollecciones = new List<string>();
            using (var cursor = Colecciones.MongoDB.BaseDeDatos.ListCollections(opciones))
            {
                while (cursor.MoveNext())
                {
                    var coleccion = cursor.Current;
                    foreach (var documento in coleccion)
                    {
                        NombreDeCollecciones.Add(documento["name"].AsString);
                    }
                }
            }

            foreach (var item in NombreDeCollecciones)
            {
                string nombre = item;
                Opciones.Items.Add(nombre);
            }

            int elemento_rutas = Opciones.Items.IndexOf("Alianzas");
            Opciones.Items.RemoveAt(elemento_rutas);
        }

        /// <summary>
        /// Añadir los elementos de una colección en un TreeView y adjuntar UserControl
        /// el un Table Layout Panel
        /// </summary>
        /// <param name="opcion"></param>
        /// <param name="ArbolDeItems"></param>
        /// <param name="TLP"></param>
        public void RellenarTreeView(string opcion, TreeView ArbolDeItems, TableLayoutPanel TLP)
        {
            List<Colecciones.Planeta> ListaPlanetas = Colecciones.ColeccionPlanetas.SeleccionarTodo();
            List<Colecciones.Region> ListaRegiones = Colecciones.ColeccionRegiones.SeleccionarTodo();
            List<Colecciones.Ruta> ListaRutas = Colecciones.ColeccionRutas.SeleccionarTodo();
            
            ArbolDeItems.Nodes.Clear();

            switch (opcion)
            {
                case "Planetas":
                    foreach (var item in ListaPlanetas)
                    {
                        string planeta = item.Nombre;
                        ArbolDeItems.Nodes.Add(planeta);
                        TLP.Controls.Clear();
                        TLP.Controls.Add(FormPlaneta);
                    }
                    break;
                case "Regiones":
                    foreach (var item in ListaRegiones)
                    {
                        string region = item.NombreRegion;
                        ArbolDeItems.Nodes.Add(region);
                        TLP.Controls.Clear();
                        TLP.Controls.Add(FormRegion);
                    }
                    break;
                case "Rutas":
                    foreach (var item in ListaRutas)
                    {
                        string ruta = item.Nombre;
                        ArbolDeItems.Nodes.Add(ruta);
                        TLP.Controls.Clear();
                        TLP.Controls.Add(FormRuta);
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Volcar los datos de la colección Regiones en UserControl
        /// </summary>
        /// <param name="region"></param>
        /// <param name="FormRegion"></param>
        public void VolcarDatosFormsRegion(string region, CC_Region.FrmRegiones FormRegion)
        {
            List<Colecciones.Region> Region = Colecciones.ColeccionRegiones.SeleccionarPorNombre(region);
            FormRegion.Nombre = Region[0].NombreRegion;
            FormRegion.Descripcion = Region[0].DescripcionRegion;
            FormRegion.Imagen = Region[0].MapaRegion;
        }

        /// <summary>
        /// Volcar los datos de la colección Planetas en UserControl
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="FormPlaneta"></param>
        public void VolcarDatosFormsPlaneta(string planeta, CC_Planetas.FrmPlaneta FormPlaneta)
        {
            List<Colecciones.Planeta> Planeta = Colecciones.ColeccionPlanetas.SeleccionarPorNombre(planeta);
            
            FormPlaneta.Planeta = Planeta[0].Nombre;
            FormPlaneta.Nativos = Planeta[0].Nativos;
            FormPlaneta.Alianza = Planeta[0].Alianza;
            FormPlaneta.Longitud = Planeta[0].Ubicacion.Longitud;
            FormPlaneta.Latitud = Planeta[0].Ubicacion.Latitud;
            FormPlaneta.Parsecs = Planeta[0].Ubicacion.Parsecs;
            FormPlaneta.Sector = Planeta[0].Sector;
            FormPlaneta.Ruta_A = Planeta[0].RutasHiperespacio.Rutas[0];

            if (Planeta[0].RutasHiperespacio.Rutas.Length > 1)
            {
                string ruta_b = Planeta[0].RutasHiperespacio.Rutas[1];
                FormPlaneta.Ruta_B = ruta_b;
            }
            else
            {
                FormPlaneta.Ruta_B = "";
            }

            FormPlaneta.Imagen = Planeta[0].Nombre;
        }

        /// <summary>
        /// Volcar los datos de la colección Rutas en UserControl
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="FormRutas"></param>
        public void VolcarDatosFormsRutas(string ruta, CC_Rutas.FrmRutas FormRutas)
        {
            List<Colecciones.Ruta> Ruta = Colecciones.ColeccionRutas.SeleccionarPorNombre(ruta);

            FormRutas.Region = Ruta[0].Nombre;
            FormRutas.Tipo = Ruta[0].Tipo;
            FormRutas.Inicio = Ruta[0].Inicio;
            FormRutas.Final = Ruta[0].Final;
            FormRutas.Imagen = Ruta[0].Nombre;
        }
    }
}
