using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loputootitpe23KH
{
    public class peoplelist
    {
        public static readonly List<people> People = new List<people>
    {
        new people()
                {
                    id = 1,
                    name = "Joonas",
                    age = 33

                },
        new people()
                {
                    id = 2,
                    name = "Hannes",
                    age = 23

                },
        new people()
                {
                    id = 3,
                    name = "Mohammed",
                    age = 16

                },
    };
    }
    
}
