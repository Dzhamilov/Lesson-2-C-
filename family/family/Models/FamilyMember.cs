using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family.Models
{
    internal class FamilyMember
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public Gender gender { get; set; }
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }
        public DateTime BrithData { get; set; }
        public DateTime DeathDate { get; set; }
        public FamilyMember Spouse { get; set; }

        public override string ToString()
        {
            return $"\nИмя {Name}\n Фамилия {SurName}\n Пол {gender}\n день рождения {BrithData}\n";
        }

    }

}
