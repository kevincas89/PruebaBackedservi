using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Administrador
    {
        [Key]
        public int Cod_Administrador { get; set; }
        [ForeignKey("Empleado")]
        public int ID_Empleado_FK { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
