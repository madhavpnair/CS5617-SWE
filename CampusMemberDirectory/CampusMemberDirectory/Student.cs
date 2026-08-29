// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace CampusMemberDirectory;

public sealed class Student : CampusMember
{
    public Student(string name, string programme) : base(name)
    {
        Programme = programme;
    }

    public string Programme { get; }
    public override string DescribeRole()
    {
        return $"Student in {Programme}";
    }



}
