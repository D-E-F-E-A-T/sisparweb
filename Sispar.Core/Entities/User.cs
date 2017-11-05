using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sispar.Core.Entities
{
    [Table("USER")]
    public class User : Entity
    {
        [Key]
        [Column("ID_USER")]
        public int Id { get; set; }

        [Column("USER_NAME", TypeName = "varchar")]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Column("PASSWORD", TypeName = "varchar")]
        [MaxLength(100)]
        public string Password { get; set; }

        [Column("ACTIVE", TypeName = "bit")]
        public int Active { get; set; } = 1;
    }
}
