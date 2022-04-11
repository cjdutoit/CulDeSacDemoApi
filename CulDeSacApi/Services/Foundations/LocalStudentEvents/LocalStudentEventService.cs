﻿using System;
using System.Threading.Tasks;
using CulDeSacApi.Brokers.Events;
using CulDeSacApi.Models.Students;

namespace CulDeSacApi.Services.Foundations.LocalStudentEvents
{
    public class LocalStudentEventService : ILocalStudentEventService
    {
        private readonly IEventBroker eventBroker;

        public LocalStudentEventService(IEventBroker eventBroker) =>
            this.eventBroker = eventBroker;

        public void ListenToStudentEvent(Func<Student, ValueTask<Student>> studentEventHandler)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Student> PublishStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
