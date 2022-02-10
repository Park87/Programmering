using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
{
    /// <summary>
    /// An object of the class ParkingMachine represents a parking machine.
    /// 
    /// Insert money first. 
    /// 
    /// Then buy a ticket or select cancel to refund.
    /// </summary>
    public class ParkingMachine
    {
        // There is two places to save money.
        // Total in the machine, from all finnished purchases.
        private int total;

        // Total for the current customer.
        private int currentTotal;

        // Cost to park.
        private int costPerHour;

        public ParkingMachine(int costPerHour)
        {
            total = 0;
            currentTotal = 0;
            this.costPerHour = costPerHour;

        }
        

        public void InsertMoney(int money)
        {
            
            if (money > 0)
            {
                currentTotal = money + CurrentTotal;
            }

            
        }
        public int Cancel()
        {
            int liam = currentTotal;
            currentTotal = 0;
            return liam;
        }


        public int CurrentTotal { get { return currentTotal; } }
        
        public int CostPerHour { get { return costPerHour; } }

        public int Total { get { return total; } }

        



        public Ticket BuyTicket()
        {

            total = total + currentTotal;

            int antalMin;
            int antalTimmar;
            int antalDagar;

            antalDagar = currentTotal / (costPerHour * 24);
            int Rest2 = currentTotal % (costPerHour * 24);
            antalTimmar = (Rest2 / costPerHour);
            int Rest = currentTotal % costPerHour;
            antalMin = (60 * Rest) / costPerHour;


            string ticketText = TimeToTicketText(antalDagar, antalTimmar, antalMin);

            Ticket ticket = new Ticket(currentTotal, costPerHour);

            currentTotal = 0;

            return ticket;




        }

        public TimeSpan GetParkingTimeSpan()
        {

            int antalMin;
            int antalTimmar;
            int antalDagar;

            antalDagar = currentTotal / (costPerHour * 24);
            int Rest2 = currentTotal % (costPerHour * 24);
            antalTimmar = (Rest2 / costPerHour);
            int Rest = currentTotal % costPerHour;
            antalMin = (60 * Rest) / costPerHour;

            TimeSpan timeSpan = new TimeSpan(days: antalDagar, hours: antalTimmar, minutes: antalMin, seconds: 0);
            return (timeSpan);

        }

        public DateTime GetValidTo()
        {
            DateTime date = DateTime.Now;
            date = date.Add(GetParkingTimeSpan());
            return (date);
        }

        private string TimeToTicketText(int days, int hours, int minutes)
        {
            return "Parking ticket valid for:" + Environment.NewLine +
                days + " days" + Environment.NewLine +
                hours + " hours" + Environment.NewLine +
                minutes + " minutes" + Environment.NewLine + Environment.NewLine +
                "Valid to: " + GetValidTo();



        }
    }
}
