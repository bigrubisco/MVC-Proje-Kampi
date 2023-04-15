using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Category
    {
        public int CatogeryID { get; set; }
        public string CatogeryName { get; set; }
        public string CategoryDesription { get; set; }
        public bool CategoryStatus { get; set; }

        public ICollection<Heading> Headings { get; set; }

    }
}
