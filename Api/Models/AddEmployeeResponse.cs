namespace Api.Models
{
    public class AddEmployeeResponse
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public string Division { get; set; }
        public string Section { get; set; }

        public Employee ToEmployee()
        {
            return new Employee
            {
                Id = Guid.NewGuid(),
                Firstname = Firstname,
                Lastname = Lastname,
                Patronymic = Patronymic,
                Division = Division,
                Section = Section
            };
        }
    }
}
