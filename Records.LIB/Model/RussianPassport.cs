using System;

namespace Records.LIB.Model
{
    public class RussianPassport : IPassport
    {
        public string DocumentId { get; set; }
        public DateTime IssuingDate { get; set; }
        public string IssuingOrganization { get; set; }
        public string Registration { get; set; }
    }
}