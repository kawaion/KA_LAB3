﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KA_LAB3
{
    enum TokenKind
    {
        End,
        Plus,
        Minus,
        Star,
        Slash,
        Caret,
        Number,
        Var,
        Char,
        function,
        Space,
        OpenBracket,
        ClosedBracket,
        Dot,
        Bad
    }
}