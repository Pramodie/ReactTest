using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppApi.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string mobile { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string address { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }
    }
}
