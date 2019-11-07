using System;
using System.Collections.Generic;
using System.Text;

namespace EventCalendar.Entities
{
    public class ClosedEvent : Event
    {

        private int _maxParticipators;
        
        public ClosedEvent(Person invitor, string title, DateTime dateTime, int maxParticipators)
            : base(invitor, title, dateTime)
        {
            _maxParticipators = maxParticipators;
            
        }

        public override bool AddPerson(Person person)
        {
            if (RegistertPersons.Count < _maxParticipators)
            {
                return base.AddPerson(person);
            }

            return false;
        }

        public override bool RemovePerson(Person person)
        {
            return base.RemovePerson(person);
        }
    }
}
