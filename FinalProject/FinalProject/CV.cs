using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class CV
    {
        private string id;
        private string name;
        private string currentAddress;
        private string dateOfBirth;
        private string phoneNumber;
        private string workExperience;
        private string educationAndCertifications;
        private string professionalSkills;
        public CV() { }
        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string CurrentAddress { get { return currentAddress; } set { currentAddress = value; } }
        public string DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string WorkExperience { get { return workExperience; } set { workExperience = value; } }
        public string EducationAndCertifications { get { return educationAndCertifications; } set { educationAndCertifications = value; } }
        public string ProfessionalSkills { get { return professionalSkills; } set { professionalSkills = value; } }
    }
}
