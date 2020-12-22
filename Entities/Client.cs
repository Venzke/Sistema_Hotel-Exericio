using System;

namespace Programa_Hotel.Entities
{
    class Client
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Int64 NumberCel { get; set; }
        public int NumberRoom { get; set; }


        public Client(string name, int age, Int64 numberCel, int numberRoom)
        {
            Name = name;
            Age = age;
            NumberCel = numberCel;
            NumberRoom = numberRoom;
        }

        public Client(string name, int age, string email, Int64 numberCel, int numberRoom)
        {
            Name = name;
            Age = age;
            Email = email;
            NumberCel = numberCel;
            NumberRoom = numberRoom;
        }
        public override string ToString()
        {
            return "Room " + NumberRoom + ": " + Name + ", " + Age + " age, " + "contact: "
                + NumberCel + ", email: " + Email;
        }
    }
}
