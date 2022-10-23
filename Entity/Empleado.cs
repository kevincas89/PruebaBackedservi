using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Empleado
    {

        public Empleado()
        {
            this.Repartidores = new HashSet<Repartidor>();
            this.Vendedores = new HashSet<Vendedor>();
        } 


        [Key]
        public int ID_Empleado { get; set; }
        [StringLength(10)]
        [Required]
        public string Primer_Nombre { get; set; }
        [StringLength(10)]
        public string Segundo_Nombre { get; set; }
        [StringLength(10)]
        [Required]
        public string Primer_Apellido { get; set; }
        [StringLength(10)]
        [Required]
        public string Segundo_Apellido { get; set; }
        [StringLength(10)]
        [Required]
        public string Celular { get; set; }
        [StringLength(10)]
        [Required]
        public string Correo { get; set; }
        [StringLength(10)]
        [Required]
        public string Contraseña { get; set; }
        [Required]
        public int Salario { get; set; }

        public virtual Administrador Administrador { get; set; }

        public virtual ICollection<Repartidor> Repartidores { get; set; }
        public virtual ICollection<Vendedor> Vendedores { get; set; }

    }
}