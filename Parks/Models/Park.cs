namespace Parks.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int SquareMileage { get; set; }
        public string Terrain { get; set; }
        public string Description { get; set; }
    }
}