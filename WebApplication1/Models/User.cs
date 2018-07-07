using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User : BaseModel
    {
        
        public string Name { get; set; }
        public int ApplicationId { get; set;}
        [ForeignKey ("ApplicationId")]
        public Application Application { get; set; }
    }
}