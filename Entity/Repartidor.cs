using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Repartidor : Empleado
    {

        public Repartidor()
        {

            this.Empleados = new HashSet<Empleado>();

        }


        [Key]
        public int Cod_Repartidor { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }

    }
}
