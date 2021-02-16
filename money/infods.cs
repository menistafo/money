using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    public class infods
    {
        public infods(string id, string description, byte[] image)
        {
            Id = id;
            Description = description;
            Image = image;
        }

        public string Id { get; private set; }
        public string Description { get; private set; }
        public byte[] Image { get; private set; }

    }
}
