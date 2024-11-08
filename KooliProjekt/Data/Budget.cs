namespace KooliProjekt.Data
{
    public class Budget
    {
        public int id {  get; set; }
        public string client {  get; set; }
        public DateTime date { get; set; }
        public decimal ServiceCost { get; set; }
        public decimal TotalCost { get; set; }


    }
}
