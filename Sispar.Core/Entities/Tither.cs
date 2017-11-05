using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sispar.Core.Entities
{
    [Table("TITHER")]
    public class Tither : Entity
    {
        [Key]
        [Column("ID_TITHER")]
        public int Id { get; set; }

        [Column("NAME_TITHER", TypeName = "varchar")]
        [MaxLength(15)]
        public string Name { get; set; }

        [Column("ADDRESS_TITHER", TypeName = "varchar")]
        [MaxLength(40)]
        public string Address { get; set; }

        [Column("MATIRAL_STATUS")]
        public string MatiralStatus { get; set; }

        [Column("BIRTH_DATE")]
        public DateTime BirthDate { get; set; }

        [Column("CPF_TITHER")]
        public string CPF { get; set; }

        [Column("MARRIAGE_DATE")]
        public DateTime MarriegeDate { get; set; }

        [Column("TELEPHONE")]
        public string Telephone { get; set; }

        [Column("CELLPHONE")]
        public string Cellphone { get; set; }

        [Column("NAME_SPOUSE")]
        public string NameSpouse { get; set; }

        [Column("DATE_BIRTH_SPOUSE")]
        public  DateTime? DateBirthSpouse { get; set; }

        [Column("ACTIVE")]
        public Boolean Active { get; set; }
    }
}
