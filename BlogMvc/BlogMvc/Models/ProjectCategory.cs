using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMvc.Models
{
    public class ProjectCategory
    {
        //[Key]
        //public int No { get; set; }
        //[Key, Column(Order = 0)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }
        //[Key, Column(Order = 1)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjetId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ProjectForCategory ProjectForCategory { get; set; }
        [ForeignKey("ProjetId")]
        public virtual Project Project { get; set; }
    }
}