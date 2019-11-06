using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp8.Models.DataAnnotations
{
    [Table("Movie")]
    public class Urun
    {
        [Key]
        [Column("Id")]
        public int UrunId { get; set; }

        [Column("Name")]
        public string UrunAdi { get; set; }
    }
}
