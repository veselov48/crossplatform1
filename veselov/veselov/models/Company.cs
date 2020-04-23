using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veselov.Models
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }       
        public ICollection<Worker> Workers { get; set; }

        public int WorkersCount()
        {
            return Workers.Count;
        }

    }
}
