namespace ConceptosPOO
{
    public class CommissionEmployee : Employee
    {
        private string _format;
        public float CommissionPercentaje { get; set; }

        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            _format = String.Format("{0:C}", GetValueToPay());
            return $"{base.ToString()}" +
                $"\n\t Commission Percentaje: {$"{CommissionPercentaje:P2}",18}" +
                $"\n\t Sales................: {Sales:C2}" +
                $"\n\tValue To Pay..........: {$"{GetValueToPay():C2} ",18}";
        }
    }
}
