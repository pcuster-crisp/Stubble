﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stubble.Core.Classes;

namespace Stubble.Core.Tests.Fixtures
{
    public class ParserTestFixture
    {
        public Parser Parser { get; set; }

        public ParserTestFixture()
        {
            Parser = new Parser(new Registry());
        }
    }
}
