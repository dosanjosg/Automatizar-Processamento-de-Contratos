

using System.Globalization;
using Microsoft.VisualBasic;

namespace ContractProcessing.Entities;

class Installment (DateTime duoDate, double amount)
{
    public DateTime DuoDate { get; set; } = duoDate;
    public double Amount { get; set; } = amount;

    public override string ToString()
    {
        return DuoDate.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2", CultureInfo.InvariantCulture); 
    }
}