using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrabalhoPaises.Modelos
{
    public class Pais        
    {
       
        public Name name { get; set; }
        public List<string> capital { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public int population { get; set; }
        public Dictionary<string, double> gini { get; set; }
        public Flags flags { get; set; }

               

    }

    

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public NativeName nativeName { get; set; }
    }

    public class NativeName
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
        public string alt { get; set; }
    }
   
}
        
        

    

