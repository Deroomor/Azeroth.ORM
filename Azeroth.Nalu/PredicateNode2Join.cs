﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Azeroth.Nalu
{
    /// <summary>
    /// Join中的where
    /// </summary>
    /// <typeparam name="L"></typeparam>
    /// <typeparam name="R"></typeparam>
    public class PredicateNode2Join : PredicateNode
    {
        IColumn right;

        public PredicateNode2Join(IColumn left,IColumn right):base(left)
        {
            this.right = right;
        }

        protected override string ResolveSQL(ResovleContext context)
        {
            return string.Format("{0}={1}", this.column.ResolveSQL(context), this.right.ResolveSQL(context));
        }
    }
}
