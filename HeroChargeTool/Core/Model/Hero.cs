using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    class Hero
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Line Line { get; set; }

        public Type Type { get; set; }

        public List<Role> Roles { get; set; }
    }
}
