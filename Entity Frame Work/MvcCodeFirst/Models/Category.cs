using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MvcCodeFirstExample.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategroyId { get; set; }
        public string CategroyName { get; set; }

    }
}
