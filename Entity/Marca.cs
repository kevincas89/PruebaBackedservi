using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Marca
    {
        [Key]
        public int Cod_Marca { get; set; }
        [StringLength(20)]
        [Required]
        public string Nombre { get; set; }

        public ICollection<Producto> Productos { get; set; }

    }



}
