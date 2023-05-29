using System;
namespace Country
{
	public class Citizen
	{
        private DateTime dateOfBirth;

        public int Age()
        {
            DateTime now = DateTime.Now;
            return (now - dateOfBirth).Days / 365;
        }
    }
}

