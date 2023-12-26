using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShubhKarya.Data;

namespace ShubhKarya.Models
{
    public class HomeReg
    {
        public int Id { get; set; }
        public Nullable<int> SrNo { get; set; }
        public string OnBehalf { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Religion { get; set; }
        public string Cast { get; set; }
        public string MotherTongue { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public string PinCode { get; set; }
        public string Education { get; set; }
        public string Profession { get; set; }
        public string Income { get; set; }
        public string Img { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string IsActive { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string BloodGroup { get; set; }
        public string SkinComp { get; set; }



    }
}