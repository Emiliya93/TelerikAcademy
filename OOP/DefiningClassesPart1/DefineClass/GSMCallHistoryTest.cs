namespace DefineClass
{
    using System;
    using System.Globalization;
    using System.Threading;

    class GSMCallHistoryTest
    {
        private const decimal pricePerMinute = 0.37M;
        private GSM phone;

        public GSMCallHistoryTest()
        {
            // this.Phone = new GSM("HTC One mini", "HTC", 520, "Smiley", "Li-Po 1800 mAh", 500, 20, 4.3, 16777216);
            this.Phone = new GSM("HTC One mini", "HTC", 520, "Smiley", new Battery(BatteryType.LiIon, 500, 20), new Display(4.3, 16777216));
            Phone.AddCall(new Call(new DateTime(2015, 03, 12, 15, 23, 45), "+359887755", 59));
            Phone.AddCall(new Call(new DateTime(2015, 03, 11, 15, 23, 45), "+359887755", 60 + 59));
            Phone.AddCall(new Call(new DateTime(2015, 03, 11, 15, 23, 45), "+359887755", 240));
        }

        public GSM Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public void DisplayCalls()
        {
            Console.WriteLine("Call history:");
            Console.WriteLine();
            if (this.phone.CallHistory.Count == 0)
            {
               Console.WriteLine("No information");
            }
            else
            {
                foreach (Call call in this.Phone.CallHistory)
                {
                    Console.WriteLine(call);
                }
            }
        }

        public void DisplayPrice()
        {
            decimal price = 0;

            foreach (Call call in this.phone.CallHistory)
            {
                price += call.CalculatePrice(pricePerMinute);
            }

            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            Console.WriteLine("Total price: {0:C}", price);
        }

        public void DeleteLongest()
        {
            int index = -1;
            int maxCall = int.MinValue;

            for (int i = 0; i < this.phone.CallHistory.Count; i++)
            {
                Call call = this.phone.CallHistory[i];
                if (call.Duration > maxCall)
                {
                    maxCall = call.Duration;
                    index = i;
                }
            }
            if (index >= 0)
            {
                this.phone.DeleteCall(index);
            }
        }

        public void ClearCalls()
        {
            this.phone.ClearCallHistory();
        }
    }
}
