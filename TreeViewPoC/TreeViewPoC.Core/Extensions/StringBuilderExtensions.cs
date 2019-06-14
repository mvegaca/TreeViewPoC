using System;
using System.Collections.Generic;
using System.Text;

namespace TreeViewPoC.Core.Extensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder TryAppend(this StringBuilder sb, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                sb?.Append(value);
            }

            return sb;
        }        

        public static StringBuilder TryAppendFormat(this StringBuilder sb, string format, params object[] args)
        {
            if (!string.IsNullOrEmpty(format) && args != null)
            {
                sb?.AppendFormat(format, args);
            }

            return sb;
        }
    }
}
