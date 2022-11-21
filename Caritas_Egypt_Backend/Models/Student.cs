using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Caritas_Egypt_Backend.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        [Display(Name = "تاريخ الميلاد")]
        public DateTime? DateOfBirth { get; set; }
        [Display(Name = "السن")]
        public float? Age { get; set; }
        [Display(Name = "رقم بطاقة الخدمات")]
        public int ServiceCardNumber { get; set; }
        [Display(Name = "نوع الاعاقة ")]
        public Guid? TypeOfDisabilityId { get; set; }
        [Display(Name = "عنوان السكن الحالى  ")]
        public string Adress { get; set; }
        [Display(Name = "الرقم القومى")]
        public string NationalID { get; set; }
        [Display(Name = "رقم التليفون ")]
        public int PhoneNumber { get; set; }
        [Display(Name = "هل ملتحق بالمدرسة ؟ ")]
        public bool InSchool { get; set; }
        [Display(Name = "اسم المدرسة")]
        public string SchoolName { get; set; }
        [Display(Name = "السنة الدراسية")]
        public string SchoolYear { get; set; }
        [Display(Name = "حصل على خدمه توظيف؟  ")]
        public bool GotAJobPlacement { get; set; }
        [Display(Name = "نوع الوظيفه")]
        public string JopType { get; set; }
        [Display(Name = "المكان التوظيف")]
        public string JopPlace { get; set; }
        [Display(Name = "العنوان")]
        public string JopAdress { get; set; }
        [StringLength(50)]
        [Display(Name = "الاسم الاول")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Display(Name = "الاسم الثانى")]
        public string SecondName { get; set; }
        [StringLength(50)]
        [Display(Name = "الاسم الثالث")]
        public string LastName { get; set; }
        [Display(Name = "رقم تليفون الاب")]
        public string ParentPhoneNumber { get; set; }
        [Display(Name = "رقم تليفون للواتساب")]
        public string PhoneNumberForWatsapp { get; set; }
        [Display(Name = "رقم تليفون ارضى الاب")]
        public string LandPhoneNumber { get; set; }
        [Display(Name = "مؤهل الاب ")]
        public string EducationQualification { get; set; }
        [Display(Name = "الوظيفة  الاب")]
        public string JopTitle { get; set; }
        [Display(Name = "البريد الالكترونى الاب ")]
        public string Email { get; set; }
        [Display(Name = "اسم الام الاول")]
        public string MotherFirstName { get; set; }
        [StringLength(50)]
        [Display(Name = "اسم الام الثانى")]
        public string MotherSecondName { get; set; }
        [StringLength(50)]
        [Display(Name = "اسم الام الثالث")]
        public string MotherLastName { get; set; }
        [Display(Name = "رقم تليفون الام ")]
        public string MotherPhoneNumber { get; set; }
        [Display(Name = "مؤهل الام")]
        public string MotherEducationQualification { get; set; }
        [Display(Name = "وظيفه الام")]
        public string MotherJopTitle { get; set; }
        [Display(Name = "اسم الاخت او الاخ الاول")]
        public string FirstBrotherOrSisterName { get; set; }
        [Display(Name = "رقم تليفون الاخت او الاخ الاول")]
        public string FirstBrotherOrSisterPhoneNumber { get; set; }
        [Display(Name = "الرقم القومى للاخت او الاخ الاول")]
        public string FirstBrotherOrSisterNationalID { get; set; }
        [Display(Name = "اسم الاخت او الاخ الثانى")]
        public string SecondBrotherOrSisterName { get; set; }
        [Display(Name = "رقم تليفون الاخت او الاخ الثانى")]
        public string SecondBrotherOrSisterPhoneNumber { get; set; }
        [Display(Name = "الرقم القومى للاخت او الاخ الثانى")] //BirhDate    Age    Job
        public string SecondBrotherOrSisterNationalID { get; set; }
        [Display(Name = "اسم الاخت او الاخ الثالث")]
        public string ThirdBrotherOrSisterName { get; set; }
        [Display(Name = "رقم تليفون الاخت او الاخ الثالث")]
        public string ThirdBrotherOrSisterPhoneNumber { get; set; }
        [Display(Name = "الرقم القومى للاخت او الاخ الثالث")]
        public string ThirdBrotherOrSisterNationalID { get; set; }
        [Display(Name = "اسم الاخت او الاخ الرابع")]
        public string ForthBrotherOrSisterName { get; set; }
        [Display(Name = "رقم تليفون الاخت او الاخ الرابع")]
        public string ForthBrotherOrSisterPhoneNumber { get; set; }
        [Display(Name = "الرقم القومى للاخت او الاخ الرابع")]
        public string ForthBrotherOrSisterNationalID { get; set; }
        [Display(Name = "اسم الاخت او الاخ الخامس")]
        public string FifthBrotherOrSisterName { get; set; }
        [Display(Name = "رقم تليفون الاخت او الاخ الخامس")]
        public string FifthBrotherOrSisterPhoneNumber { get; set; }
        [Display(Name = "الرقم القومى للاخت او الاخ الخامس")]
        public string FifthBrotherOrSisterNationalID { get; set; }
        public TypeOfDisability TypeOfDisability { get; set; }
    }
}
