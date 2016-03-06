using System;

namespace SampleMvvmLight.Models
{
    public class Friend
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Picture { get; set; }
        public string Location { get; set; }
        public string Message { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
