using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dontTrustMe.Models
{
    public class Data
    {
        public List<Yummy> vkusnyashki;
        public Data()
        {
            using (YummyContext qwe = new YummyContext())
            {
                vkusnyashki = (from Yummies in qwe.Yummies
                               select Yummies).ToList();
            }
        }
    }
}
