using System;
namespace School
{
	public class FormOneStudent : Student
	{
		public readonly string streamm = "1Green";

        public int admissionNumber()

        {
            return admNumber;
        }

        // Method overriding
        public override string compulsorySciences()
        {
            return "Physics, Biology, Chemistry";
        }
	}
}

