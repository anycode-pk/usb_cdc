using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonModel.Entities
{
    public partial class Command : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
