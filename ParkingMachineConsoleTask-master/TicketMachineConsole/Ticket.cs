using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
{
    public class Ticket
    {
        private DateTime purchaseTime;
        private readonly int costPerHour;
        private readonly int price;

        /// <summary>
        /// A ticket. Cannot be changed once created.
        /// </summary>
        /// <param name="price">The amount of money payed for the ticket. A hole number.</param>
        /// <param name="costPerHour">The cost per hour to park. A hole number.</param>
        public Ticket(int price, int costPerHour)
        {
            this.price = price;
            this.costPerHour = costPerHour;
        }
        /// <summary>
        /// Property to read cost per hour.
        /// </summary>
        public int CostPerHour
        {
            get
            {
                return costPerHour;
            }

        }
        /// <summary>
        /// Property to read the amout payed for the ticket.
        /// </summary>
        public int Price
        {
            get
            {
                return price;
            }
        }

        /// <summary>
        /// Returns the amount of time the ticket is valid for. 
        /// </summary>
        /// <returns>TimeSpan object with days, hours and minutes. 
        /// The number of seconds is set to zero.</returns>
        public TimeSpan GetParkingTimeSpan()
        {

            int antalMin;
            int antalTimmar;
            int antalDagar;

            antalDagar = price / (costPerHour * 24);
            int Rest2 = price % (costPerHour * 24);
            antalTimmar = (Rest2 / costPerHour);
            int Rest = price % costPerHour;
            antalMin = (60 * Rest) / costPerHour;

            TimeSpan timeSpan = new TimeSpan(days: antalDagar, hours: antalTimmar, minutes: antalMin, seconds: 0);
            return (timeSpan);

        }
        /// <summary>
        /// Returns the date and time the ticket is valid to.
        /// </summary>
        /// <returns>A DateTime object for the validity date.</returns>
        public DateTime GetValidTo()
        {
            DateTime date = DateTime.Now;
            date = date.Add(GetParkingTimeSpan());
            return (date);
        }

        public override string ToString()
        {
            return "Parking ticket valid for:" + Environment.NewLine +
                GetParkingTimeSpan().Days + " days" + Environment.NewLine +
                GetParkingTimeSpan().Hours + " hours" + Environment.NewLine +
                GetParkingTimeSpan().Minutes + " minutes" + Environment.NewLine + Environment.NewLine +
                "Valid to: " + GetValidTo();
        }
    }
}