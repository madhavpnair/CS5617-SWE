// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace CampusMemberDirectory
{
    /// <summary>
    /// Represents a lecturer affiliated with the campus, inheriting from CampusMember.
    /// </summary>
    public sealed class Lecturer : CampusMember
    {
        /// <summary>
        /// Creates an instance of Lecturer with Name and Department
        /// </summary>
        /// <param name="name"></param>
        /// <param name="department"></param>
        /// <exception cref="ArgumentException"></exception>
        public Lecturer(string name, string department) : base(name)
        {
            if (string.IsNullOrWhiteSpace(department))
            {
                throw new ArgumentException("Department cannot be null or whitespace.", nameof(name));
            }
            Department = department;
        }

        /// <summary>
        /// To get the Department of the Lecturer
        /// </summary>
        public string Department { get; }

        /// <summary>
        /// DescribeRole is implemented by the Lecturer
        /// </summary>
        /// <returns>A short sentence conveying he/she is lecturer and the Department where he/she works</returns>
        public override string DescribeRole()
        {
            return $"Lecturer in {Department}";
        }
    }
}
