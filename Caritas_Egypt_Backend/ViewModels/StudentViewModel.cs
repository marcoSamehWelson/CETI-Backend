using System;

namespace Caritas_Egypt_Backend.ViewModels
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public float? Age { get; set; }
        public int ServiceCardNumber { get; set; }
        public Guid? TypeOfDisabilityId { get; set; }
        public string Adress { get; set; }
        public Int16 NationalID { get; set; }
        public int PhoneNumber { get; set; }
        public bool InSchool { get; set; }
        public string SchoolName { get; set; }
        public string SchoolYear { get; set; }
        public bool GotAJobPlacement { get; set; }
        public string JopType { get; set; }
        public string JopPlace { get; set; }
        public string JopAdress { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int ParentPhoneNumber { get; set; }
        public int LandPhoneNumber { get; set; }
        public string EducationQualification { get; set; }
        public string JopTitle { get; set; }
        public int Email { get; set; }
        public string MotherFirstName { get; set; }
        public string MotherSecondName { get; set; }
        public string MotherLastName { get; set; }
        public string MotherPhoneNumber { get; set; }
        public string MotherEducationQualification { get; set; }
        public string MotherJopTitle { get; set; }
    }
}
