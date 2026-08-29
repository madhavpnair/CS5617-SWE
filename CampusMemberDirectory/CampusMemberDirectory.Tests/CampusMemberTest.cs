using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CampusMemberDirectory.Tests
{
    /// <summary>
    /// Unit tests for <see cref="CampusMember"/> and its derived types,
    /// <see cref="Student"/> and <see cref="Lecturer"/>.
    /// </summary>
    [TestClass]
    public class CampusMemberDirectoryTests
    {
        /// <summary>A valid name should be stored unchanged on the Name property.</summary>
        [TestMethod]
        public void Constructor_ValidName_SetsNameProperty()
        {
            Student student = new Student("Ramesh", "Computer Science");

            Assert.AreEqual("Ramesh", student.Name);
        }

        /// <summary>A null name must be rejected by the base class constructor.</summary>
        [TestMethod]
        public void Constructor_NullName_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Student(null!, "Computer Science"));
        }

        /// <summary>An empty name must be rejected by the base class constructor.</summary>
        [TestMethod]
        public void Constructor_EmptyName_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Student("", "Computer Science"));
        }

        /// <summary>A whitespace-only name must be rejected by the base class constructor.</summary>
        [TestMethod]
        public void Constructor_WhitespaceName_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Student("   ", "Computer Science"));
        }

        /// <summary>
        /// Testing the base class's shared <see cref="CampusMember.Introduce"/> 
        /// </summary>
        [TestMethod]
        public void Introduce_CombinesNameAndDescribeRole()
        {
            Student student = new Student("Ramesh", "Computer Science");

            string introduction = student.Introduce();

            Assert.AreEqual(
                "Hello, my name is Ramesh. I am a Student in Computer Science.",
                introduction);
        }

        /// <summary>A valid programme should be stored on the Programme property.</summary>
        [TestMethod]
        public void Student_Constructor_SetsProgramme()
        {
            Student student = new Student("Ramesh", "Computer Science");

            Assert.AreEqual("Computer Science", student.Programme);
        }

        /// <summary>A null programme must be rejected by the Student constructor.</summary>
        [TestMethod]
        public void Student_Constructor_NullProgramme_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Student("Ramesh", null!));
        }

        /// <summary>An empty programme must be rejected by the Student constructor.</summary>
        [TestMethod]
        public void Student_Constructor_EmptyProgramme_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Student("Ramesh", ""));
        }

        /// <summary>A whitespace-only programme must be rejected by the Student constructor.</summary>
        [TestMethod]
        public void Student_Constructor_WhitespaceProgramme_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Student("Ramesh", "   "));
        }

        /// <summary>DescribeRole should incorporate the student's programme.</summary>
        [TestMethod]
        public void Student_DescribeRole_ReturnsExpectedFormat()
        {
            Student student = new Student("Ramesh", "Computer Science");

            Assert.AreEqual("Student in Computer Science", student.DescribeRole());
        }

        /// <summary>A null name must be rejected by the Lecturer constructor (via the base class).</summary>
        [TestMethod]
        public void Lecturer_Constructor_NullName_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Lecturer(null!, "Mathematics"));
        }

        /// <summary>An empty name must be rejected by the Lecturer constructor (via the base class).</summary>
        [TestMethod]
        public void Lecturer_Constructor_EmptyName_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Lecturer("", "Mathematics"));
        }

        /// <summary>A whitespace-only name must be rejected by the Lecturer constructor (via the base class).</summary>
        [TestMethod]
        public void Lecturer_Constructor_WhitespaceName_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Lecturer("   ", "Mathematics"));
        }

        /// <summary>A valid department should be stored on the Department property.</summary>
        [TestMethod]
        public void Lecturer_Constructor_SetsDepartment()
        {
            Lecturer lecturer = new Lecturer("Dr. Rao", "Mathematics");

            Assert.AreEqual("Mathematics", lecturer.Department);
        }

        /// <summary>A null department must be rejected by the Lecturer constructor.</summary>
        [TestMethod]
        public void Lecturer_Constructor_NullDepartment_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Lecturer("Dr. Rao", null!));
        }

        /// <summary>An empty department must be rejected by the Lecturer constructor.</summary>
        [TestMethod]
        public void Lecturer_Constructor_EmptyDepartment_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Lecturer("Dr. Rao", ""));
        }

        /// <summary>A whitespace-only department must be rejected by the Lecturer constructor.</summary>
        [TestMethod]
        public void Lecturer_Constructor_WhitespaceDepartment_ThrowsArgumentException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Lecturer("Dr. Rao", "   "));
        }

        /// <summary>DescribeRole should incorporate the lecturer's department.</summary>
        [TestMethod]
        public void Lecturer_DescribeRole_ReturnsExpectedFormat()
        {
            Lecturer lecturer = new Lecturer("Dr. Rao", "Mathematics");

            Assert.AreEqual("Lecturer in Mathematics", lecturer.DescribeRole());
        }


        [TestMethod]
        public void Lecturer_Introduce_CombinesNameAndDescribeRole()
        {
            Lecturer lecturer = new Lecturer("Dr. Rao", "Mathematics");

            string introduction = lecturer.Introduce();

            Assert.AreEqual(
                "Hello, my name is Dr. Rao. I am a Lecturer in Mathematics.",
                introduction);
        }


        [TestMethod]
        public void Introduce_DispatchesToCorrectDescribeRole_ForEitherDerivedType()
        {
            CampusMember student = new Student("Ramesh", "Computer Science");
            CampusMember lecturer = new Lecturer("Dr. Rao", "Mathematics");

            Assert.Contains(student.DescribeRole(), student.Introduce());
            Assert.Contains(lecturer.DescribeRole(), lecturer.Introduce());
            Assert.AreNotEqual(student.DescribeRole(), lecturer.DescribeRole());
        }
    }
}
