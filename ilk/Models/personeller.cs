using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ilk.Models
{
    public class personeller
    {
        [Key]

        public int personel_id { get; set; }
        public string personel_adi { get; set; }
        public string personel_soyadi { get; set; }
        public string personel_sehir { get; set; }


    }
}
