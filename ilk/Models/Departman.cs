using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ilk.Models
{
    public class Departman
    {
        [Key]
        public int departman_id { get; set; }
        public string departman_adi { get; set; }
        public List<Personel> Personels { get; set; }
    }
}
 