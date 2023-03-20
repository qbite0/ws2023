using System;

namespace GeneralEmployeeTerminal.Models {
    public class Ticket {
        public Guid Id { get; set; }
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

        public bool Approved { get; set; }
    }
}
