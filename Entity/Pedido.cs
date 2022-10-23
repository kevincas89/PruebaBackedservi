using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pedido
    {

        public Pedido()
        {
            this.Vendedores = new HashSet<Vendedor>();
            this.Productos = new HashSet<Producto>();
        }


        [Key]
        public int Cod_Pedido { get; set; }
        [StringLength(20)]
        [Required]
        public string Estado { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [StringLength(20)]
        [Required]
        public string Nombre_Tienda { get; set; }
        [StringLength(20)]
        [Required]
        public string Barrio { get; set; }
        [StringLength(10)]
        [Required]
        public string Calle { get; set; }
        [StringLength(10)]
        [Required]
        public string Numero { get; set; }
        [Required]
        public int Cod_Vendedor_FK { get; set; }
        [Required]
        public int Cod_Producto_FK { get; set; }


        public virtual ICollection<Vendedor> Vendedores { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }


    }
}
