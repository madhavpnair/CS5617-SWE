// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace CampusMemberDirectory
{
    /// <summary>
    /// Representates a member affiliated with the campus
    /// </summary>
    public abstract class CampusMember
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampusMember"/> class with the specified name.
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentException"></exception>
        protected CampusMember(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
            }

            Name = name;
        }
        /// <summary>
        /// To get the Name of the Member
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// To describe the role of the member, this method must be implemented in derived classes.
        /// </summary>
        /// <returns>A sentence describing the member's role</returns>
        public abstract string DescribeRole();

        /// <summary>
        /// To introduce the member, combining their name and role description.
        /// </summary>
        /// <returns>A sentence introducing the member by name and describing their role</returns>
        public virtual string Introduce()
        {
            return $"Hello, my name is {Name}. I am a {DescribeRole()}.";
        }

    }
}
