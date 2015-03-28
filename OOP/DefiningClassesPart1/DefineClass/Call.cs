namespace DefineClass
{
    using System;
    using System.Text;

    public class Call
    {
        private DateTime dateAndTime;
        private string dialedPhoneNumber;
        private int duration;

        public Call(DateTime dateAndTime, string dialedPhoneNumber, int duration)
        {
            this.DateAndTime = dateAndTime;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            set
            {
                this.dateAndTime = value;
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }

            set
            {
                this.dialedPhoneNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (duration < 0)
                {
                    throw new ArgumentException("Duration of call cannot be less than zero!");
                }
                this.duration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("{0, -28}", "Date of call: "));
            result.AppendLine(String.Format("{0}.{1}.{2}", this.DateAndTime.Day, this.DateAndTime.Month, this.DateAndTime.Year));

            result.Append(string.Format("{0, -28}", "Time of call: "));
            result.AppendLine(string.Format("{0}:{1}:{2}", this.DateAndTime.Hour, this.DateAndTime.Minute, this.DateAndTime.Second));

            result.Append(string.Format("{0, -28}", "Dialed phone number: "));
            result.AppendLine(this.DialedPhoneNumber);
            result.Append(string.Format("{0, -28}", "Call duration (in seconds): "));
            result.AppendLine(this.Duration.ToString());

            return result.ToString();
        }

        public decimal CalculatePrice(decimal pricePerMinute)
        {
            int seconds = this.Duration;
            int minutes = 0;
            //while (seconds > 0)
            //{
            //    if (seconds > 60)
            //    {
            //        minutes++;
            //        seconds = seconds - 60;
            //    }
            //    else // seconds <= 60
            //    {
            //        minutes++;
            //        break;
            //    }
            //}
            while (seconds > 0)
            {
                if (seconds <= 60)
                {
                    minutes++;
                    seconds = 0;
                }
                else
                {
                    minutes += seconds / 60;
                    seconds = seconds % 60;
                }
            }
            return (minutes * pricePerMinute);
        }
    }
}