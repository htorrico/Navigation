﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{

    public class MasterDetailPage2MenuItem
    {
        public MasterDetailPage2MenuItem()
        {
            TargetType = typeof(MasterDetailPage2Detail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}