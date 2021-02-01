﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarColor:IEntity
    {
        public int ColorId { get; set; }
        public string Color { get; set; }

    }
}