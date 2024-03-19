//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//using static System.Net.Mime.MediaTypeNames;

//namespace FinalProject
//{
//    public class CVDAO
//    {
//        public CVDAO() { }
//        DBConnection dbconection = new DBConnection();
//        public DataTable Load(string name)
//        {
//            return dbconection.Load($"{name}");
//        }
//        public void Them(CV cv)
//        {
//            string SQL = string.Format("INSERT INTO CVs (Name,CurrentAddress,DateOfBirth,PhoneNumber,WorkExperience,EducationAndCertifications,ProfessionalSkills) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}')", cv.Name, cv.CurrentAddress, cv.DateOfBirth, cv.PhoneNumber, cv.WorkExperience, cv.EducationAndCertifications, cv.ProfessionalSkills;
//            dbconection.Excude(SQL);
//        }
//        public void Sua(CV cv)
//        {
//            string SQL = string.Format("UPDATE CVs SET Name = '{0}',Gender='{1}', Address = '{2}' , IdentityCard = '{3}', DateOfBirth = '{4}',PhoneNumber = '{5}',Email='{6}' WHERE ID = '{7}'", person.Name, person.Gender, person.Address, person.IdentityCard, person.DateOfBirth, person.PhoneNumber, person.Email, person.ID);
//            dbconection.Excude(SQL);
//        }
//        public void Xoa(CV cv)
//        {
//            string SQL = string.Format("DELETE FROM CVs WHERE ID = '{0}'", person.ID);
//            dbconection.Excude(SQL);
//        }
//    }
//}
