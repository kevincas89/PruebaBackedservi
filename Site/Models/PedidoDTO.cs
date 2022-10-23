using System;

namespace Site.Models
{
    public class PedidoDTO
    {
        public int Cod_pedido { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre_Tienda { get; set; }
        public string Barrio { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
    }
}
