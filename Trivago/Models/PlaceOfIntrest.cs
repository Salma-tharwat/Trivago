﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivago.Models
{
    public class PlaceOfIntrest
    {
        public String name;
        public CustomImage image;

        public PlaceOfIntrest(String name, CustomImage image)
        {
            this.name = name;
            this.image = image;
        }
    }
}
