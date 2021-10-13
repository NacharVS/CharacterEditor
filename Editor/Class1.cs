using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Libmongocrypt;
using System;
using System.Collections.Generic;
using System.Text;


namespace Editor
{
    class Person
    {
                public static void AddToDataBase(Person person)
                  {
                      var client = new MongoClient("mongodb://localhost");
                      var database = client.GetDatabase("321gr2021brr");
                      var collection = database.GetCollection<Person>("qqPerson");
                       collection.InsertOne(person);
                 }
    }
}
