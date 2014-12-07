using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core.Model;

namespace HeroChargeTool
{
    public delegate void GearCreatedHandler(Gear gear);

    public partial class AddNewGearDialog : Form
    {
        public event GearCreatedHandler GearCreated;

        private List<AttributeEditor> _editors = new List<AttributeEditor>();

        public AddNewGearDialog(List<AttributeType> attributeTypes)
        {
            InitializeComponent();
            foreach (AttributeType attributeType in attributeTypes)
            {
                AttributeEditor editor = new AttributeEditor(attributeType);
                _editors.Add(editor);
                flowLayoutPanel1.Controls.Add(editor);
            }
            comboBox1.DataSource = Enum.GetValues(typeof (GearColor));
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var gear = new Gear
                {
                    Name = nameTextBox.Text,
                    Attributes =
                        _editors.Select(editor => editor.Attribute).Where(attribute => attribute != null).ToArray(),
                    GearColor = (GearColor) comboBox1.SelectedItem,
                    MinLevel = (int) numericUpDown1.Value
                };
            GearCreated(gear);
            Hide();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
