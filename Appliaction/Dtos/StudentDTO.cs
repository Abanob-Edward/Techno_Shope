using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Dtos
{
    public class StudentDTO
    {
        public int ID { get; set; }
        [MaxLength(5)]
        public string Name { get; set; }
        [Range(1, 18)]
        public int Age { get; set; }
    }
}
