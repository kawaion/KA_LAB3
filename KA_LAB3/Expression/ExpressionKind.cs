﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KA_LAB3.Expression
{
    enum ExpressionKind
    {
        Number,
        Var,
        Binary,
        Sign,
        Unary,
        Bracket,
        Function,
        Bad
    }
}