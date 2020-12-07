using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_bolkunov
{
    public class PierCollection
    {
        readonly Dictionary<string, Pier<Vehicle>> piers;

        public List<string> Keys => piers.Keys.ToList();

        private readonly int pictureWidth;
        private readonly int pictureHeight;

        public PierCollection(int pictureWidth, int pictureHeight)
        {
            piers = new Dictionary<string, Pier<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddPier(string name)
        {
            if (piers.ContainsKey(name))
            {
                return;
            }

            piers.Add(name, new Pier<Vehicle>(pictureWidth, pictureHeight));
        }

        public void RemovePier(string name)
        {
            if(piers.ContainsKey(name))
            {
                piers.Remove(name);
            }
        }

        public void RemovePierAt(int index)
        {
            if(index >= 0 && index < piers.Count)
            {
                piers.Remove(Keys[index]);
            }
        }

        public Pier<Vehicle> this[string id]
        {
            get
            {
                if (piers.ContainsKey(id))
                {
                    return piers[id];
                }
                return null;
            }
        }
    }
}
