using System;
namespace School
{
	public class Student : Person
	{
		protected int admNumber;

		// Method OverLoading
		public int GradeA (int industrialAttch, int socialEthics)
		{
			return (industrialAttch + socialEthics);
		}

		public int GradeA (int cPlusPlus,int java, int cSharp)
		{
			return (cPlusPlus + java + cSharp);
		}

		public int GradeA(int operationsResearch)
		{
			return operationsResearch;
		}

		// Method Overriding
		public virtual string compulsorySciences()
		{
			return "Physics, Chemistry";
		}
	}
}

