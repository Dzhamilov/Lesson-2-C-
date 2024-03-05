using family.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family.Services
{
    internal class FMService
    {
        private List<FamilyMember> Family { get;  set;}
        public FMService()
        {
            Family = new List<FamilyMember>();
        }
        public void AddMember(params FamilyMember[] member) 
        {
            if (member != null && member.Length > 0)
            {
                Family.AddRange(member);
            }
        }
        public List<FamilyMember> GetGrandFather(FamilyMember member)
        {
            List<FamilyMember> grandFathers = new List<FamilyMember>();
            grandFathers.Add(member.Father.Father);
            grandFathers.Add(member.Mother.Father);
            return grandFathers;
        }

        public List<FamilyMember> GetGrandMothers(FamilyMember member)
        {
            List<FamilyMember> grandMothers = new List<FamilyMember>();
            grandMothers.Add(member.Father.Mother);
            grandMothers.Add(member.Mother.Mother);
            return grandMothers;
        }
        

        public FamilyMember OldFamilyMember()
        {
            var old = Family.Min(x => x.BrithData);
            return Family.FirstOrDefault(x => x.BrithData == old);
        }

        public FamilyMember FindCouple(FamilyMember member) => member.Spouse;


    }


}
