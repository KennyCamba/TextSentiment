using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Response
    {
        public List<Document> documents { get; set; }
        public List<object> errors { get; set; }
    }
}
