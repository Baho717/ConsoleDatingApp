using System;
using System.Linq;
using System.Collections.Generic;

namespace DatingProfile
{
  class Program
  {
    static List<Profile> profilesDatabase = new List<Profile>();

    static void Main(string[] args)
    {
        PopulateDatabase();


      foreach (var profile in profilesDatabase)
        {
            Console.WriteLine(profile.viewProfile());
        }         
      
    }
        static void PopulateDatabase()
    {
        profilesDatabase.Add(new Profile("Alex Johnson", 25, "New York", "USA", new string[] {"Gaming", "Reading"}));
        profilesDatabase.Add(new Profile("Chris Lee", 30, "Los Angeles", "USA", new string[] {"Surfing", "Traveling"}));
        profilesDatabase.Add(new Profile("Morgan Taylor", 28, "Chicago", "USA", new string[] {"Cooking", "Photography"}));
        profilesDatabase.Add(new Profile("Jamie Rivera", 35, "Miami", "USA", new string[] {"Fishing", "Hiking"}));
        profilesDatabase.Add(new Profile("Casey Jordan", 22, "Seattle", "USA", new string[] {"Biking", "Yoga"}));
        profilesDatabase.Add(new Profile("Drew Cameron", 40, "Boston", "USA", new string[] {"Writing", "Chess"}));
        profilesDatabase.Add(new Profile("Taylor Reyes", 26, "San Francisco", "USA", new string[] {"Painting", "Gardening"}));
        profilesDatabase.Add(new Profile("Jordan Casey", 32, "Austin", "USA", new string[] {"Dancing", "Swimming"}));
        profilesDatabase.Add(new Profile("Riley Harper", 29, "Denver", "USA", new string[] {"Skiing", "Brewing"}));
        profilesDatabase.Add(new Profile("Peyton Morgan", 31, "Washington D.C.", "USA", new string[] {"Politics", "History"}));
        profilesDatabase.Add(new Profile("Alexis Bailey", 27, "Las Vegas", "USA", new string[] {"Magic", "Gaming"}));
        profilesDatabase.Add(new Profile("Avery Gray", 34, "Atlanta", "USA", new string[] {"Music", "Filmmaking"}));
        profilesDatabase.Add(new Profile("Jordan Ellis", 38, "Portland", "USA", new string[] {"Cycling", "Tech"}));
        profilesDatabase.Add(new Profile("Blake Kennedy", 24, "Philadelphia", "USA", new string[] {"Art", "Theater"}));
        profilesDatabase.Add(new Profile("Charlie Parker", 36, "San Diego", "USA", new string[] {"Surfing", "Beach Volleyball"}));
        profilesDatabase.Add(new Profile("Quinn Lee", 33, "Dallas", "USA", new string[] {"Cooking", "Blogging"}));
        profilesDatabase.Add(new Profile("Harper Brooks", 37, "Nashville", "USA", new string[] {"Songwriting", "Guitar"}));
        profilesDatabase.Add(new Profile("Reese Campbell", 23, "Houston", "USA", new string[] {"Astronomy", "Science"}));
        profilesDatabase.Add(new Profile("Casey Jordan", 39, "Phoenix", "USA", new string[] {"Photography", "Desert Hiking"}));
        profilesDatabase.Add(new Profile("Morgan Bailey", 21, "San Antonio", "USA", new string[] {"Video Games", "Anime"}));
    }
  }
}
