﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    interface ICommentable
    {
        List<string> Comments { get; set; }

        void Comment(string comment);
    }
}
