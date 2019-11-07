using System;
using System.Collections.Generic;

namespace EventCalendar.Entities
{
    public class Event
    {
        private Person _invitor;
        public string Title { get; }
        private DateTime _dateTime;
        private readonly List<Person> _registerdPerson;

        protected List<Person> RegistertPersons
        {
            get
            {
                return _registerdPerson;
            }
            
        }

        public Event(Person invitor, string title, DateTime dateTime)
        {
            _invitor = invitor;
            Title = title;
            _dateTime = dateTime;
            _registerdPerson = new List<Person>();
        }

        public virtual bool AddPerson(Person person)
        {
            if (_registerdPerson.Contains(person))
            {
                return false;
            }
            _registerdPerson.Add(person);
            return true;
        }

        public virtual bool RemovePerson(Person person)
        {
            return _registerdPerson.Remove(person);
        }
    }
}
