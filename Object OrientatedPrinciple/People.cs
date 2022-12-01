using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectorientatedprinciples
{
    class People
    {
        public string name;
        public int age;
        public string gender;
        public string race;

        public People(string PersonName, string PersonRace, int PersonAge, string PersonGender)
        {

            name = PersonName;
            age = PersonAge;
            gender = PersonGender;
            race = PersonRace;

        }


    }
}
