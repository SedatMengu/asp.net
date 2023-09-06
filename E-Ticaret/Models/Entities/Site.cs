using System;
using System.Collections.Generic;

namespace asp.net2
{
    public partial class Site
    {
        public int SiteId { get; set; }
        public string Title { get; set; } = null!;
        public string? Url { get; set; }
        public string? Intro { get; set; }
        public string? Keywords { get; set; }
        public string? IntroImage { get; set; }
        public string? IntroExtension { get; set; }
        public string? LogoImage { get; set; }
        public string? LogoExtension { get; set; }
        public string? Shift { get; set; }
        public string? Username { get; set; }
        public string Password { get; set; } = null!;
        public string? AdminName { get; set; }
        public DateTime? LoginTime { get; set; }
        public string? AdminEmail { get; set; }
        public string? Smtpserver { get; set; }
        public string? Smtpuser { get; set; }
        public string? Smtppassword { get; set; }
        public string Email { get; set; } = null!;
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Phone2 { get; set; }
        public string? Faks { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? Youtube { get; set; }
        public string? Instagram { get; set; }
        public string? PasswordNew { get; set; }
        public string? PasswordNewConfirm { get; set; }
        public string? Maps { get; set; }
        public string? ContactInfo { get; set; }
        public string? PopupImage { get; set; }
        public string? PopupExtension { get; set; }
        public string? Popup { get; set; }
        public string? Smtpport { get; set; }
        public bool? Smtpssl { get; set; }
        public int? LogoWidth { get; set; }
        public int? LogoHeight { get; set; }
        public int? IntroWidth { get; set; }
        public int? IntroHeight { get; set; }
        public int? PopupWidth { get; set; }
        public int? PopupHeight { get; set; }
        public string? PopupUrl { get; set; }
        public string? PopupTarget { get; set; }
        public string? Error { get; set; }
        public string? CountryPhoneCode { get; set; }
        public int? CountryId { get; set; }
        public string? FaviconImage { get; set; }
        public string? FaviconExtension { get; set; }
        public int? FaviconWidth { get; set; }
        public int? FaviconHeight { get; set; }
    }
}
