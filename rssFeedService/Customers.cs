using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSSFeedService
{
    public class Customers
    {
        private List<string> keep = new List<string>();
        private List<string> kill = new List<string>();
        private List<string> other = new List<string>();
        private List<string> url = new List<string>();
        private string id;

        public void Customer(string id, string url)
        {
            // Lägger till data från användaren
            this.id = id;
            this.url.Add(url);

            // Lägger till data som alla nya cutomers får som standard

            string[] addToKeep = { "snökaos", "jul", "katter", "öresundståg" };
            this.keep.AddRange(addToKeep);
            string[] addToKill = { "big brother", "dokusåpa" };
            this.kill.AddRange(addToKill);







        }

    }
}