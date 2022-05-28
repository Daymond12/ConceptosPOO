namespace ConceptosPOO
{
    public abstract class Employee
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();// este metodo lo implementas las clases que heredan de la clase.

        public override string ToString()
        {
            return $"{Id} - {FirstName}{LastName}," +
                $"Birth: {BirthDate}," +
                $"Hiring: {HiringDate}," +
                $"Is Active{IsActive}";
        }
    }
}
