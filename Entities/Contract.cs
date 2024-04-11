namespace ContractProcessing.Entities 
{
    class Contract (int number, DateTime date, double totalValue)
    {
        public int Number { get; set; } = number;
        public DateTime Date { get; set; } = date;
        public double TotalValue { get; set; } = totalValue;
        public List<Installment> Installments { get; set; } = [];

        public void AddInstallment(Installment installment) 
        {
            Installments.Add(installment);
        }
    }
}