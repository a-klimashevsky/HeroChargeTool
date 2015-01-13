using System;
using System.Windows.Forms;
using Core.Model;
using Type = Core.Model.Type;

namespace HeroChargeTool
{
    public partial class AddNewHeroDialog : Form
    {
        public AddNewHeroDialog()
        {
            InitializeComponent();
            lineCombobox.DataSource = Enum.GetValues(typeof (Line));
            typesCombobox.DataSource = Enum.GetValues(typeof (Core.Model.Type));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hero hero = new Hero()
                {
                    Name = nameTextBox.Text,
                    Type = (Type) typesCombobox.SelectedItem,
                    Line = (Line) lineCombobox.SelectedItem,
                };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
