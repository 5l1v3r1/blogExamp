using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMvc.Models
{
    public class ProjectForCategory
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Kategori Adı")]
        public string Name { get; set; }
        public virtual List<ProjectCategory> ProjectCategories { get; set; }
    }
}