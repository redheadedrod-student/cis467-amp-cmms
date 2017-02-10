﻿namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// This class is simply a listing of contacts
    /// 
    /// ManContactID - Id for entry
    /// Name - full name of contact
    /// PhoneNumber - Phone number of contact
    /// FaxNumber - fax number for contact
    /// EmailAddress - Email Address for contact
    /// </summary>
    public class ManufacturerContact
    {
        public int ManContactId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}