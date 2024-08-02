using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public class Grade : Base
    {
        public User Student { get; set; }
        public User Trainer { get; set; }
        public Subject Subject { get; set; }
        public int SubjectGrade { get; set; }
    }
}
