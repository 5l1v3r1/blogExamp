using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMvc.Models
{
    public class Todo
    {
        public Todo()
        {
            CreatedDate = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        [Display(Name = "Yapılacak")]
        public string Description { get; set; }
        [Display(Name = "Tamamlandı Mı")]
        public bool isComplated { get; set; }
        [Display(Name = "Oluşturulma Tarihi")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}