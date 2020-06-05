using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMvc.Models
{
    public class ArticleTag
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Tag { get; set; }

        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }
    }
}