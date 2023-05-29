using System;
namespace Country
{
	public class Citizen
	{
        private int IdNumber;

        private DateTime dateOfBirth;

        public int Age()
        {
            DateTime now = DateTime.Now;
            return (now - dateOfBirth).Days / 365;
        }

        protected string Gender;

        internal string Address;

        protected internal bool VoterRegistered;

        private protected string TaxNumber;

        public int GetIdentityNumber()
        {
            return IdNumber;
        }
    }
}

