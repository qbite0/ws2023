namespace Api.Models {
    public class Employee {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public string Division { get; set; }
        public string Section { get; set; }
    }
}
