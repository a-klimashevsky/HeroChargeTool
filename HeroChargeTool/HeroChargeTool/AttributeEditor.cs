using System;
using System.Windows.Forms;
using Core.Model;
using Attribute = Core.Model.Attribute;

namespace HeroChargeTool
{
    public partial class AttributeEditor : UserControl
    {
        private readonly AttributeType _attributeType;

        public AttributeEditor(AttributeType attributeType)
        {
            InitializeComponent();
            _attributeType = attributeType;
            nameLabel.Text = attributeType.Name;
        }

        public Attribute Attribute
        {
            get
            {
                if (string.IsNullOrEmpty(numericUpDown1.Text))
                {
                    return null;
                }
                float value = (float) numericUpDown1.Value;
                if (value == 0)
                {
                    return null;
                }
                return new Attribute {TypeId = _attributeType.Id, Value = value};
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
