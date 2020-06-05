using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMvc.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string Title { get; set; }

        [Display(Name = "Özet")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string Summary { get; set; }

        [Display(Name = "Yazı")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string Text { get; set; }
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Beğeni Sayısı")]
        public int Like { get; set; }

        [Display(Name = "Yazar")]
        public string UserId { get; set; }
        [Display(Name = "Yayınlanma Tarihi")]
        public DateTime PublishedDate { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ArticleCategory ArticleCategory { get; set; }

        public Article()
        {
            CreatedDate = DateTime.Now;
        }
    }
}