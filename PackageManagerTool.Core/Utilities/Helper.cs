using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManagerTool.Core.Utilities
{
    public class Helper
    {
        /// <summary>
        /// Helper method to set the value of an object.
        /// </summary>
        /// <typeparam name="T">The Data Type</typeparam>
        /// <param name="variable">The object to hold the value</param>
        /// <param name="value">The value the object will hold</param>
        /// <param name="setIfNull">Set the value to the object only if the object is null</param>
        public static void SetValue<T>(T variable, T value, bool setIfNull)
        {
            if (setIfNull)
            {
                if (variable == null)
                {
                    variable = value;
                }
            }
            else
            {
                variable = value;
            }
        }

        /// <summary>
        /// Helper method to set the value of an object.
        /// </summary>
        /// <typeparam name="T">The Data Type</typeparam>
        /// <param name="variable">The object to hold the value</param>
        /// <param name="value">The value the object will hold</param>
        /// <param name="setIfNull">Set the value to the object only if the object is null</param>
        public static void SetValue<T>(ref T variable, ref T value, bool setIfNull)
        {
            if (setIfNull)
            {
                if (variable == null)
                {
                    variable = value;
                }
            }
            else
            {
                variable = value;
            }
        }
    }
}
