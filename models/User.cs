namespace reportsInNetCore.models
{
    public class User
    {
        public User(string name, long id, string address, int age){
            this.Name = name;
            this.Id = id;
            this.Address = address;
            this.Age = age;
        }
        public string Name { get; set; }
        public long Id { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}