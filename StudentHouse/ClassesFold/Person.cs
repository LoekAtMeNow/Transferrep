using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouse
{
    public class Person
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string PersonFamilyName { get; set; }
        public string PersonUserName { get; set; }
        public string PersonAddress { get; set; }
        public string PersonRoom { get; set; }
        public string PersonRole { get; set; }
        public string PersonKey { get; set; }
        public DateTime PersonEndDate { get; set; }


        public void AddPerson(string name, string fname, string username, string address, string room, string role, string key, DateTime date)
        {
            PersonName = name;
            PersonFamilyName = fname;
            PersonUserName = username;
            PersonAddress = address;
            PersonRoom = room;
            PersonRole = role;
            PersonKey = key;
            if (date != null)
            {
                PersonEndDate = date;
            }
            else
            {
                DateTime now = DateTime.Now;
                PersonEndDate = now.AddYears(1);
            }
        }

        public void UpdatePerson(Person person, string name, string fname, string username, string address, string room, string role, string key, DateTime date)
        {
            person.PersonName = name;
            person.PersonFamilyName = fname;
            person.PersonUserName = username;
            person.PersonAddress = address;
            person.PersonRoom = room;
            person.PersonRole = role;
            person.PersonKey = key;
            if (date != null)
            {
                person.PersonEndDate = date;
            }
            else
            {
                DateTime now = DateTime.Now;
                person.PersonEndDate = now.AddYears(1);
            }
        }

        public void ChangeRoom(Person person, string room)
        {
            person.PersonRoom = room;
        }

        public bool LoginPerson(string username, string password, List<Person> people)
        {
            foreach (Person person in people)
            {
                if (person.PersonUserName == username)
                {
                    if (person.PersonKey == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Person GetPerson(string username, List<Person> people)
        {
            foreach (Person person in people)
            {
                if (person.PersonUserName == username)
                {
                    Person personToReturn = new Person();
                    personToReturn = person;

                    return personToReturn;
                }
            }
            return null;
        }

    }
}
