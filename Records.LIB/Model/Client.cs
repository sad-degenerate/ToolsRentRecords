using System;

namespace Records.LIB.Model
{
    public class Client : IBaseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public IPassport Passport { get; set; }
        public bool WithoutDeposit { get; set; }
        public int TotalSpent { get; set; }
    }
}