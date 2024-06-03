using System;

namespace Records.LIB.Model
{
    public interface IPassport
    {
        string DocumentId { get; set; }
        DateTime IssuingDate { get; set; }
        string IssuingOrganization { get; set; }
        string Registration { get; set; }
    }
}