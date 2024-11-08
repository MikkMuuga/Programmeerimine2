using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace KooliProjekt.Data
{
    public class WorkersMachines
    {
        public int id { get; set; }
        public string Workers {  get; set; }
        public String Supervision { get; set; }
        public decimal CostOfMachines { get; set; }

    }
}
