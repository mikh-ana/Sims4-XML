using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp12
{
    [Serializable]
   public class Personages
    {
        public List<Personage> PersonagesList { get; set; } = new List<Personage>();
    }
    [Serializable]
    public class Personage
    {
        [XmlElement("PERSONAGE")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string FamilyStatus { get; set; }
        public int Finance { get; set; }
        public string Entity { get; set; }
        public string LifeGoal { get; set; }
        public string City { get; set; }
        public string Nature { get; set; }


        public Personage() { }
        public Personage(int Id,string Name, string Age, string FamilyStatus, int Finance,  string LifeGoal, string City, string Nature)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.FamilyStatus = FamilyStatus;
            this.Finance = Finance;   
            this.LifeGoal = LifeGoal;
            this.City = City;
            this.Nature = Nature;
        }

    }
}
