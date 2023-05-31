using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ilk.Models
{
	public class Admin
	{
        [Key]
        public int AdminID { get; set; }


        [Column(TypeName = "Varchar(20)")]
        public int Kullanici { get; set; }


		[Column(TypeName = "Varchar(10)")]
		public int Sifre { get; set; }
    }
}
