﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonModel.Entities
{
    public partial class Device
    {
        public override string ToString()
        {
            return this.Name;
        }
    }
}
