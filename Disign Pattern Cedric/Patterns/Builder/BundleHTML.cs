﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class BundleHTML : Bundle
    {
        public override void AddDocument(string document)
        {
            this.documents.Add("<HTML>" + document + "</HTML>");
        }
    }
}
