using System;

namespace GeneralEmployeeTerminal.Models {
    public class EditTicketResponse {
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

        public static EditTicketResponse FromTicket(Ticket ticket) =>
            new EditTicketResponse {
                From = ticket.From,
                To = ticket.To,
                Purpose = ticket.Purpose,
                Division = ticket.Division,
                Fullname = ticket.Fullname,
                Lastname = ticket.Lastname,
                Firstname = ticket.Firstname,
                Patronymic = ticket.Patronymic,
                Phone = ticket.Phone,
                Email = ticket.Email,
                Organization = ticket.Organization,
                Note = ticket.Note,
                Bday = ticket.Bday,
                PassportNumber = ticket.PassportNumber,
                PassportSeries = ticket.PassportSeries,
                Approved = ticket.Approved
            };
    }
}
