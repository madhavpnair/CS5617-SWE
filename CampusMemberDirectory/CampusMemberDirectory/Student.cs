// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace CampusMemberDirectory
{
    /// <summary>
    /// A student affiliated with the campus 
    /// </summary>
    public sealed class Student : CampusMember
    {
        /// <summary>
        /// Creates an instance of Student with Name and Programme
        /// </summary>
        /// <param name="name"></param>
        /// <param name="programme"></param>
        /// <exception cref="ArgumentException"></exception>
        public Student(string name, string programme) : base(name)
        {
            if (string.IsNullOrWhiteSpace(programme))
            {
                throw new ArgumentException("Programme cannot be null or whitespace.", nameof(name));
            }
            Programme = programme;
        }

        /// <summary>
        /// To get the Programme which the student is doing
        /// </summary>
        public string Programme { get; }

        /// <summary>
        /// Student class implements its own version of DescribeRole()
        /// </summary>
        /// <returns></returns>
        public override string DescribeRole()
        {
            return $"Student in {Programme}";
        }



    }
}
