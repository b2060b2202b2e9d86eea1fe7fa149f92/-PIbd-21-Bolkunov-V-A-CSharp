using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_bolkunov
{
    public class PierCollection
    {
        public const char separator = '-';

        private readonly Dictionary<string, Pier<Vehicle>> piers;

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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (var fs = new FileStream(filename, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"PierCollection");
                    foreach (var level in piers)
                    {
                        sw.WriteLine($"Pier{separator}{level.Key}");
                        ITransport ship = null;
                        for (int i = 0; (ship = level.Value.GetElementAt(i)) != null; i++)
                        {
                            if (ship != null)
                            {
                                if (ship.GetType().Name == "Ship")
                                {
                                    sw.WriteLine($"Ship{separator}{ship}");
                                }
                                if (ship.GetType().Name == "MotorShip")
                                {
                                    sw.WriteLine($"MotorShip{separator}{ship}");
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (var fs = new FileStream(filename, FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                {
                    Vehicle ship = null;
                    string key = string.Empty;
                    string str = sr.ReadLine();
                    if (str.Contains("PierCollection"))
                    {
                        piers.Clear();
                    }
                    else
                    {
                        return false;
                    }
                    while (!sr.EndOfStream)
                    {
                        str = sr.ReadLine();
                        if (str.Contains("Pier"))
                        {
                            key = str.Split(separator)[1];
                            piers.Add(key, new Pier<Vehicle>(pictureWidth, pictureHeight));
                            continue;
                        }
                        if (string.IsNullOrEmpty(str))
                        {
                            continue;
                        }
                        if (str.Split(separator)[0] == "Ship")
                        {
                            ship = new Ship(str.Split(separator)[1]);
                        }
                        else if (str.Split(separator)[0] == "MotorShip")
                        {
                            ship = new MotorShip(str.Split(separator)[1]);
                        }
                        var result = piers[key] + ship;
                        if (!result)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
