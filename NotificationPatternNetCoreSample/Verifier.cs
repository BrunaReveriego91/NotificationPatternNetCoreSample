using FluentValidator;
using NotificationPatternNetCoreSample.Entity;
using NotificationPatternNetCoreSample.Result;
using System;

namespace NotificationPatternNetCoreSample
{
    public class Verifier : Notifiable
    {
        public NotificationResultDTO Execute()
        {
            var person = new Person("Bruna Reveriego", "teste@gmail.com");
            return Verify(person);
        }

        private NotificationResultDTO Verify(Person person)
        {
            //Simulating validation of entity
            AddNotifications(person.Notifications);
            if (Invalid)
            {
                return new NotificationResultDTO(false, "Please validate following fields:", Notifications);
            }

            return new NotificationResultDTO(true, "OK", null);
        }
    }
}
