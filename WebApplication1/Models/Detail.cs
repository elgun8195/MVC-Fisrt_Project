namespace First_Application.Models
{
    public class Detail
    {
        private static int _id;
        public int Id { get; set; }
        public int Pid { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Motor { get; set; }
        public Detail()
        {
            Id = ++_id;
        }
    }
}
