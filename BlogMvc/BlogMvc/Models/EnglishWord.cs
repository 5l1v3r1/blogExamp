using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvc.Models
{
    public class EnglishWord
    {
        public int Id { get; set; }
        public string EngWord { get; set; }
        public string TrWord { get; set; }
        public bool isLearn { get; set; }
    }
}