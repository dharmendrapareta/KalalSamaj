using System;

namespace KalalSamaj.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherOrHusbandName { get; set; }
        public string MotherName { get; set; }
        public bool IsActive { get; set; }
        public bool IsPhoto { get; set; }
        public DateTime DOB { get; set; }
        public string Caste { get; set; }
        public bool IsFeMale { get; set; }
        public string MarriedStats { get; set; }
        public string EmailId { get; set; }
        public string PermanentAddress { get; set; }
        public string PermanentCity { get; set; }
        public string PermanentState { get; set; }
        public string TempAddres { get; set; }
        public string TempCity { get; set; }
        public string TempState { get; set; }
        public string Mobile { get; set; }
        public string PanCardNo { get; set; }
    }
}