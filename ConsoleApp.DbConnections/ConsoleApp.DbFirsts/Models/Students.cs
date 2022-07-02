using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DbFirsts.Models
{
    public class Students
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Email { get; set; }

        public string? Phone { get; set; }
    }
}
