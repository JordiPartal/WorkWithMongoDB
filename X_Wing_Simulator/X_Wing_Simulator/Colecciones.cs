using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Wing_Simulator
{
    class Colecciones
    {
        public static class MongoDB
        {
            public static MongoClient Cliente = new MongoClient("mongodb://localhost:27017");
            public static IMongoDatabase BaseDeDatos = Cliente.GetDatabase("StarWars");
        }

        /// <summary>
        /// Alianzas de MongoDB
        /// </summary>
        public class Alianza
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("description")]
            public String Descripcion { get; set; }
        }

        /// <summary>
        /// Rutas de MongoDB
        /// </summary>
        public class Ruta
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("type")]
            public String Tipo { get; set; }

            [BsonElement("nameRoute")]
            public String Nombre { get; set; }

            [BsonElement("start")]
            public String Inicio { get; set; }

            [BsonElement("end")]
            public String Final { get; set; }
        }

        public static class ColeccionRutas
        {
            private static IMongoCollection<Ruta> Rutas = MongoDB.BaseDeDatos.GetCollection<Ruta>("Rutas");

            public static List<Ruta> SeleccionarTodo()
            {
                List<Ruta> ListaRutas = Rutas.Find(item => true).ToList();
                return ListaRutas;
            }
            public static List<Ruta> SeleccionarPorNombre(string nombre_ruta)
            {
                List<Ruta> ListaRutas = Rutas.Find(item => item.Nombre == nombre_ruta).ToList();
                return ListaRutas;
            }
        }

        /// <summary>
        /// Planetas de MongoDB
        /// </summary>
        public class Planeta
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("name")]
            public String Nombre { get; set; }

            [BsonElement("sector")]
            public String Sector { get; set; }

            [BsonElement("filiation")]
            public String Alianza { get; set; }

            [BsonElement("situation")]
            public Situation Ubicacion { get; set; }

            [BsonElement("hyperspaceRoute")]
            public Hyperspaceroute RutasHiperespacio { get; set; }

            [BsonElement("natives")]
            public String Nativos { get; set; }


            public class Situation
            {
                [BsonElement("long")]
                public String Longitud { get; set; }

                [BsonElement("lat")]
                public String Latitud { get; set; }

                [BsonElement("parsecs")]
                public String Parsecs { get; set; }
            }

            public class Hyperspaceroute
            {
                [BsonElement("route")]
                public String[] Rutas { get; set; }
            }
        }

        public static class ColeccionPlanetas
        {
            private static IMongoCollection<Planeta> Planetas = MongoDB.BaseDeDatos.GetCollection<Planeta>("Planetas");

            public static List<Planeta> SeleccionarTodo()
            {
                List<Planeta> ListaPlanetas = Planetas.Find(item => true).ToList();
                return ListaPlanetas;
            }
            public static List<Planeta> SeleccionarPorNombre(string nombre_planeta)
            {
                List<Planeta> ListaPlanetas = Planetas.Find(item => item.Nombre == nombre_planeta).ToList();
                return ListaPlanetas;
            }
        }

        /// <summary>
        /// Regiones de MongoDB
        /// </summary>
        public class Region
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("nameRegion")]
            public String NombreRegion { get; set; }

            [BsonElement("descriptionRegion")]
            public String DescripcionRegion { get; set; }

            [BsonElement("mapRegion")]
            public String MapaRegion { get; set; }
        }

        public static class ColeccionRegiones
        {
            private static IMongoCollection<Region> Regiones = MongoDB.BaseDeDatos.GetCollection<Region>("Regiones");

            public static List<Region> SeleccionarTodo()
            {
                List<Region> ListaRegiones = Regiones.Find(item => true).ToList();
                return ListaRegiones;
            }

            public static List<Region> SeleccionarPorNombre(string nombre_region)
            {
                List<Region> ListaRegiones = Regiones.Find(item => item.NombreRegion == nombre_region).ToList();
                return ListaRegiones;
            }
        }
    }
}
