using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public Producto()
        {
            this.Pedidos = new HashSet<Pedido>();
            
        }

        [Key]
        public int Cod_Producto { get; set; }
        [StringLength(20)]
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Precio_Unidad { get; set; }
        [Required]
        public int Precio_Pack { get; set; }
        [Required]
        public byte Presentacion { get; set; }
        [StringLength(80)]
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int unidades_pack { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int Cod_Marca_FK { get; set; }
        public Marca Marca { get; set; }


        public virtual ICollection<Pedido> Pedidos { get; set; }

    }
}
