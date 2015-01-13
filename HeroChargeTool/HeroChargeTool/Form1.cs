using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using Core.Model;

namespace HeroChargeTool
{
    public partial class Form1 : Form
    {
        private Data Data { get; set; }

        private BindingSource bs = new BindingSource();

        public Form1()
        {
            
            StreamReader reader = new StreamReader("data.xml");
            XmlSerializer serializer = new XmlSerializer(typeof (Data));
            Data = (Data) serializer.Deserialize(reader);
            reader.Close();
            bs.DataSource = Data.Items;
            InitializeComponent();
            gearsList.DataSource = bs;
            gearsList.DisplayMember = "Name";

        }

        private void addNewGearToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AddNewGearDialog dialog = new AddNewGearDialog(Data.Attributes);
            dialog.GearCreated+=dialog_GearCreated;
            dialog.ShowDialog(this);
        }

        private void dialog_GearCreated(Gear gear)
        {
            Data.Items.Add(gear);
            bs.ResetBindings(false);
       
        }

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            StreamWriter writer = new StreamWriter("data.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Data));
            serializer.Serialize(writer,Data);
            writer.Close();
        }

        private void exportToWikiToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (var writer = new StreamWriter("wiki\\Gears.md"))
            {
                writer.WriteLine("Gear | Min Level | Color");
                writer.WriteLine("--- | --- | ---");
                foreach (var gear in Data.Items)
                {
                    writer.WriteLine("[[" + gear.Name + "]]" + " | " + gear.MinLevel + " | " + gear.GearColor);
                    ExportToWikiGear(gear);
                }
                writer.Close();
            }
        }

        private void ExportToWikiGear(Gear gear)
        {
            using (var writer = new StreamWriter("wiki\\"+gear.Name.Replace(' ','-')+ ".md"))
            {
                writer.WriteLine("Min Level | Color");
                writer.WriteLine("--- | ---");
                writer.WriteLine(gear.MinLevel + " | " + gear.GearColor);
                writer.WriteLine();
                writer.WriteLine("#### Attributes");
                foreach(var attr in gear.Attributes)
                {
                    string name = (from x in Data.Attributes where x.Id == attr.TypeId select x.Name).First();
                    writer.WriteLine("* **" + name + "** *" + attr.Value + "*");
                }
                writer.Close();
            }
        }

        private void addNewHeroToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AddNewHeroDialog dialog = new AddNewHeroDialog();
            dialog.ShowDialog();
        }
    }
}
