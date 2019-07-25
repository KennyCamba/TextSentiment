using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Document
    {
        public string language { get; set; }
        public int id { get; set; }
        public string text { get; set; }
        public double score { get; set; }
    }
}
