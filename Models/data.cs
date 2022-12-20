using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace database.Models
{
    public class data
    {
        [Key]
        public int Stdid { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }
        [Column(TypeName ="varchar(20)")]

        public string Email { get; set; }

        public DateTime Age { get; set; }



    }
}
