namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private static GSM IPhone4SField;

        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private List<Call> callHistory;

        // Constructors
        static GSM()
        {
            IPhone4SField = new GSM("IPhone 4s", "Apple", 629, "Pesho", new Battery(BatteryType.LiIon, 200, 14), new Display(3.5, 16000000));
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, double? price, string owner)
            : this(model, manufacturer)
        {
        }

        public GSM(string model, string manufacturer, double? price, string owner,
                   Battery batteryChars,
                   Display displayChars)
                   : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = batteryChars;
            this.Display = displayChars;
        }

        // Static property
        public static GSM IPhone4S
        {
            get
            {
                return GSM.IPhone4SField;
            }
        }

        // Properties
        public string Model
        {
            get 
            { 
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model of phone cannot be null or empty!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get 
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer of phone cannot be null or empty!");
                }
                this.manufacturer = value;
            }
        }

        public double? Price
        {
            get 
            {
                return this.price;
            }
            set
            {
                if (value != null && value < 0)
                {
                    throw new ArgumentException("Price cannot be less than zero!");
                }
                
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value != null && Char.IsLower(value[0]))
                {
                    throw new ArgumentException("Owner name must be different from null and to start with upper letter!");
                }

                this.owner = value;
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        // Methods
        public override string ToString()
        {
            StringBuilder phone = new StringBuilder();
            phone.Append(String.Format("{0, -24}", "Model: "));
            phone.AppendLine(this.model ?? "No information");

            phone.Append(String.Format("{0, -24}", "Manufacturer: "));
            phone.AppendLine(this.manufacturer ?? "No information");

            phone.Append(String.Format("{0, -24}", "Price: "));
            phone.AppendLine(this.price == null ? "No information" : this.price.ToString());

            phone.Append(String.Format("{0, -24}", "Owner: "));
            phone.AppendLine(this.owner == null ? "No information" : this.owner);

            if (Battery == null)
            {
                phone.Append(String.Format("{0, -24}", "Battery model: "));
                phone.AppendLine("No information");

                phone.Append(String.Format("{0, -24}", "Battery hours stand-by: "));
                phone.AppendLine("No information");

                phone.Append(String.Format("{0, -24}", "Battery hours talk: "));
                phone.AppendLine("No information");
            }
            else
            {
                phone.Append(String.Format("{0, -24}", "Battery model: "));
                phone.Append(Battery.Model);
                phone.AppendLine();

                phone.Append(String.Format("{0, -24}", "Battery hours stand-by: "));
                phone.Append(Battery.HoursStandBy);
                phone.AppendLine();

                phone.Append(String.Format("{0, -24}", "Battery hours talk: "));
                phone.Append(Battery.HoursTalk);
                phone.AppendLine();
            }

            if (Display == null)
            {
                phone.Append(String.Format("{0, -24}", "Display size: "));
                phone.AppendLine("No information");
                phone.Append(String.Format("{0, -24}", "Display colors: "));
                phone.AppendLine("No information");
            }
            else
            {
                phone.Append(String.Format("{0, -24}", "Display size: "));
                phone.Append(Display.Size);
                phone.AppendLine();
                phone.Append(String.Format("{0, -24}", "Display colors: "));
                phone.Append(Display.Colors);
                phone.AppendLine();
            }

            phone.AppendLine();
            phone.AppendLine("Call history:");
            phone.AppendLine();
            if (this.CallHistory.Count == 0)
            {
                phone.AppendLine("No information");
            }
            else
            {
                foreach (Call call in this.CallHistory)
                {
                    phone.Append(call);
                    phone.AppendLine();
                }
            }

            return phone.ToString();
        }

        public void AddCall(Call newCall)
        {
            this.CallHistory.Add(newCall);
        }

        public void DeleteCall(int index)
        {
            this.CallHistory.RemoveAt(index);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
    }
}
