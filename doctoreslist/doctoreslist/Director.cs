using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctoreslist //director del hospital
{
    public class Director
    {
        public string Name { get; set; }

        public List<Director> LoadDirectorsData () 
        {
            List<Director> directorList = new List<Director>();

            directorList.Add(new Director() { Name = " David lemus" });
            directorList.Add(new Director() { Name = " Emely lemus" });
            directorList.Add(new Director() { Name = " Daniela lemus" });

            return directorList;
        }
    }
}
