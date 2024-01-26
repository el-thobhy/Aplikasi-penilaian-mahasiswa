namespace ApplikasiPenilaianMahasiswa.Api.Validations
{
    public class ValidationMembers
    {
        public ValidationMembers(string name, string message)
        {
            Name = name;
            Message = message;
        }

        public string Name { get; set; }
        public string Message { get; set; }
    }
}
