﻿namespace Events
{
    using System;
    using System.Text;

    internal class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int comparedByDate = this.date.CompareTo(other.date);
            int comparedByTitle = this.title.CompareTo(other.title);
            int comparedByLocation = this.location.CompareTo(other.location);

            if (comparedByDate == 0)
            {
                if (comparedByTitle == 0)
                {
                    return comparedByLocation;
                }
                else
                {
                    return comparedByTitle;
                }
            }
            else
            {
                return comparedByDate;
            }
        }

        public override string ToString()
        {
            StringBuilder formatedDate = new StringBuilder();
            string format = "yyyy-MM-ddTHH:mm:ss";

            formatedDate.Append(this.date.ToString(format));

            formatedDate.Append(" | " + this.title);
            if (this.location != null && this.location != string.Empty)
            {
                formatedDate.Append(" | " + this.location);
            }

            return formatedDate.ToString();
        }
    }
}
