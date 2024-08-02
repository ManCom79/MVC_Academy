using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public class Subject : Base
    {
        public string SubjectName { get; set; }
        public User SubjectTrainer {  get; set; }
    }
}
