using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_9
{
    public class Emplyee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Emplyee(int id,string name,DateTime DOB)
        {
            Id = id;
            Name = name;
            DateOfBirth = DOB;
        }
    }
}
