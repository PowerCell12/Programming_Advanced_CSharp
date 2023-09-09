using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> members {set; get;}

        public Family(){
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            members.Add(member);
        }


        public Person GetOldestMember()
        {
            return members.MaxBy(x => x.Age);
        }





    }
}
