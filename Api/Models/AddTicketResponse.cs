namespace Api.Models {
    public class AddTicketResponse {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Purpose { get; set; }

        public string Division { get; set; }
        public string Fullname { get; set; }

        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Organization { get; set; }
        public string Note { get; set; }
        public DateTime Bday { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }

        public Ticket ToTicket() =>
            new Ticket {
                Id = Guid.NewGuid(),
                From = From,
                To = To,
                Purpose = Purpose,
                Division = Division,
                Fullname = Fullname,
                Lastname = Lastname,
                Firstname = Firstname,
                Patronymic = Patronymic,
                Phone = Phone,
                Email = Email,
                Organization = Organization,
                Note = Note,
                Bday = Bday,
                PassportNumber = PassportNumber,
                PassportSeries = PassportSeries
            };
    }
}
