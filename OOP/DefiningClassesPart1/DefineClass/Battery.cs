namespace DefineClass
{
    using System;

    public class Battery
    {
        private BatteryType? model;
        private int? hoursStandBy;
        private int? hoursTalk;

        public Battery(BatteryType? model, int? hoursStandBy, int? hoursTalk)
        {
            this.Model = model;
            this.HoursStandBy = hoursStandBy;
            this.HoursTalk = hoursTalk;
        }

        public BatteryType? Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public int? HoursStandBy
        {
            get
            {
                return this.hoursStandBy;
            }
            set
            {
                if (value != null && value < 0)
                {
                    throw new ArgumentException();
                }

                this.hoursStandBy = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value != null && value < 0)
                {
                    throw new ArgumentException();
                }

                this.hoursTalk = value;
            }
        }
    }
}