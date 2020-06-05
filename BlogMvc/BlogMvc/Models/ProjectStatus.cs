using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMvc.Models
{
    public class ProjectStatus
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        [Display(Name="Yapılacak")]
        public string Desctiption { get; set; }
        [Display(Name ="Tamamlandı Mı")]
        public bool isComplated { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
    }
}