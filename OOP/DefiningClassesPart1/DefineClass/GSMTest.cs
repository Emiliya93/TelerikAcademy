namespace DefineClass
{
    using System;

    class GSMTest
    {
        private readonly string separator = new string('-', 40);
        private int countOfGSMs;
        private GSM[] gsms;

        private readonly GSM iphone4s = GSM.IPhone4S;

        public GSMTest(int countofGSMs)
        {
            this.CountOfGSMs = countofGSMs;
            this.GSMs = new GSM[countOfGSMs];
        }

        public int CountOfGSMs
        {
            get
            {
                return this.countOfGSMs;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Count cannot be less than zero!");
                }
                this.countOfGSMs = value;
            }
        }

        public GSM[] GSMs
        {
            get
            {
                return this.gsms;
            }
            set
            {
                this.gsms = value;
            }
        }

        public GSM Iphone4s
        {
            get
            {
                return this.iphone4s;
            }
        }

        public void DisplayGSMs()
        {
            for (int i = 0; i < this.countOfGSMs; i++)
            {
                this.GSMs[i] = new GSM("HTC One mini #" + (i + 1), "HTC", 520 + i*3, "Smiley", new Battery(BatteryType.LiIon, 400, 20), new Display(4.3 + i, 16000000 + i));
                Console.WriteLine(this.GSMs[i]);
                Console.WriteLine(separator);
            }
        }
    }
}