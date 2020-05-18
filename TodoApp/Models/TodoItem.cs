using System;
/*
1. GET: listă de task-uri și detalii task.Implementați filtrare deadline from-to.De exemplu: toate task-urile care au deadline-ul între 10 februarie 2019 ora 10:23 și 15 ianuarie 2019 ora 17:50.
2. POST: adăugare task (title, description, dată+timp added, deadline, importance: low, medium, high, stare: open, in progress, closed, dată+timp closedAt).
3. PUT: modificarea stării unui task: dacă se schimbă în closed, se completează câmpul closedAt ca fiind timpul request-ului.Dacă se schimbă din închis în altceva, se pune timpul închiderii pe null.
4. DELETE: Ștergerea unui task.
*/
namespace TodoApp.Models
{
        public enum Importance { Low, Medium, High }
        public enum State { Open, InProgress, Closed }

        public class TodoItem
        {
            public long Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTimeOffset AddedAt { get; set; }
            public DateTimeOffset Deadline { get; set; }
            public Importance Importance { get; set; }
            public State State { get; set; }
            public DateTimeOffset ClosedAt { get; set; }
        }
    }
