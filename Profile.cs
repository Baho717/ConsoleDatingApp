using System;

namespace DatingProfile
{
    public class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string[] hobbies;

        public Profile(string name, int age, string city, string country, string[] hobbies)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.hobbies = hobbies;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string[] Hobbies
        {
            get { return hobbies; }
            set { hobbies = value; }
        }

        public string viewProfile()
        {
            string hobbiesList = string.Join(", ", Hobbies);
            string profileBio = $"Name: {Name}, Age: {Age}, City: {City}, Country: {Country}, Hobbies: {hobbiesList}";
            return profileBio;
        }
    }
}
