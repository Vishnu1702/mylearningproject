using System;
using System.ComponentModel.DataAnnotations;

namespace MAADISWEETS.Models
{
    public class Sweets
    {
        [Key]
        public int SweetId { get; set; }
        public string SweetName { get; set; }
        
    }
}