namespace ConceptosPOO
{
    public abstract class Employee: IPay
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        // este metodo lo implementan las clases que heredan de la clase.
        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName}{LastName}," +
                $"Birth: {BirthDate}," +
                $"Hiring: {HiringDate}," +
                $"Is Active{IsActive}";
        }
    }
}
