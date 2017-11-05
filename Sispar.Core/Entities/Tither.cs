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
        [MaxLength(100)]
        public string Name { get; set; }

        [Column("ADDRESS_TITHER", TypeName = "varchar")]
        [MaxLength(200)]
        public string Address { get; set; }

        [Column("MATIRAL_STATUS", TypeName = "char")]
        [MaxLength(1)]
        public string MatiralStatus { get; set; }

        [Column("BIRTH_DATE", TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [Column("CPF_TITHER", TypeName = "varchar")]
        [MaxLength(20)]
        public string CPF { get; set; }

        [Column("MARRIAGE_DATE", TypeName = "date")]
        public DateTime MarriegeDate { get; set; }

        [Column("TELEPHONE", TypeName = "varchar")]
        [MaxLength(20)]
        public string Telephone { get; set; }

        [Column("CELLPHONE", TypeName = "varchar")]
        [MaxLength(20)]
        public string Cellphone { get; set; }

        [Column("NAME_SPOUSE", TypeName = "varchar")]
        [MaxLength(100)]
        public string NameSpouse { get; set; }

        [Column("DATE_BIRTH_SPOUSE", TypeName = "date")]
        public  DateTime? DateBirthSpouse { get; set; }

        [Column("ACTIVE")]
        public Boolean Active { get; set; } = true;
    }
}
