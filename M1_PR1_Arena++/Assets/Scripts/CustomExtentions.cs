using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomExtentions
{
    public static class StringExtentions
    {
        public static void FancyDebug(this string str)
        {
            Debug.LogFormat("This string contains {0} characters.",
            str.Length);
        }
    }
}