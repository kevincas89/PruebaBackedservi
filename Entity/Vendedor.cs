using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Vendedor : Empleado
    {
        public Vendedor()
        {

            this.pedidos = new HashSet<Pedido>();
            this.Empleados = new HashSet<Empleado>();

        }


        [Key]
        public int Cod_Vendedor { get; set; }

        public virtual ICollection<Pedido> pedidos { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
