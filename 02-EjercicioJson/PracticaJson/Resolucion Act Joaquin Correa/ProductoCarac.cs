using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson.Resolucion_Act_Joaquin_Correa
{
    internal class ProductoCarac
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public double Existencias { get; set; }
        [JsonPropertyName("descuento_disponible")]
        public bool DescuentoDisponible { get; set; }
        public List<string> Etiquetas { get; set; }
        public DetalleProducto Detalles { get; set; }
        public ProductoCarac()
        {
            Etiquetas = new List<string>();
            Detalles = new DetalleProducto();
        }
    }
}
