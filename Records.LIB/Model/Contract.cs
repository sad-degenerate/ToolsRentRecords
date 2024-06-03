using System;

namespace Records.LIB.Model
{
    public class Contract : IBaseItem
    {
        private const string Landlord = "Индивидуальный предприниматель ФИО, именуемый в дальнейшем \"Арендодатель\"";
        
        public int Id { get; set; }
        public string ContractNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Table Table { get; set; }
        public Client Client { get; set; }
        public int ToolsPrice { get; set; }
        public int ToolsRentPrice { get; set; }
    }
}