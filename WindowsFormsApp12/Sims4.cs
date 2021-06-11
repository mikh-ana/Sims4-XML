using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp12
{
    public partial class Sims4 : Form
    {
        public Sims4()
        {
            InitializeComponent();
            ClearInput();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ClearInput()
        {
            id.Value = 0;
            name.Text = string.Empty;
            age.Text = string.Empty;
            familyStatus.Text = string.Empty;
            finance.Value = 0;
            lifeGoal.Text = string.Empty;
            city.Text = string.Empty;
            nature.Text = string.Empty;

        }
        private void SerializeXML(Personages personages)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Personages));
            using (FileStream fs = new FileStream("Personages.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, personages);
            }
        }
       private Personages DeserializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Personages));
            using (FileStream fs = new FileStream("Personages.xml", FileMode.OpenOrCreate))
            {
             return  (Personages)xml.Deserialize(fs);  
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Personage personage = new Personage((int)id.Value,name.Text,age.Text,familyStatus.Text,(int)finance.Value,lifeGoal.Text, city.Text,nature.Text);
            Add(personage);
            ClearInput();
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPersonages.SelectedItems.Count == 1)
            {
                Personage personage = (Personage)lvPersonages.SelectedItems[0].Tag;
                if (personage != null)
                {
                    id.Value = personage.Id;
                    name.Text = personage.Name;
                    age.Text = personage.Age;
                    familyStatus.Text = personage.FamilyStatus;
                    finance.Value = personage.Finance;
                    lifeGoal.Text = personage.LifeGoal;
                    city.Text= personage.City;
                    nature.Text = personage.Nature;
                }
            }
            else if(lvPersonages.SelectedItems.Count ==0)
            {
                ClearInput(); 
            }
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Personages personages = new Personages();
           
            foreach(ListViewItem item in lvPersonages.Items)
            {
                if(item.Tag != null)
                {
                    personages.PersonagesList.Add((Personage)item.Tag);
                }
            }
            SerializeXML(personages);
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            ClearInput();
            Personages personages = DeserializeXML();
            foreach(Personage personage in personages.PersonagesList)
            {
                Add(personage);
            }
        }
        private void Add(Personage personage)
        {
            ListViewItem LVI = new ListViewItem(personage.Name);
            LVI.Tag = personage;
            lvPersonages.Items.Add(LVI);
        }

      
    }
}
