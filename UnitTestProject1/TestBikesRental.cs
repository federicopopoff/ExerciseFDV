using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciceFDV;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class TestBikesRental
    {

        [TestMethod]
        public void RentalHourTest()
        {

            RentalHour rh = new RentalHour();

            //Rent for 5 hours
            rh.cantRent = 5;

            //The function calculation for the total of the cost
            double totalCost = rh.CalcCost();


            Assert.AreEqual(totalCost, 25.00);


        }

        [TestMethod]
        public void RentalDayTest()
        {

            RentalDay rd = new RentalDay();

            //Rent for 2 days
            rd.cantRent = 2;

            //The function calculation for the total of the cost
            double totalCost = rd.CalcCost();


            Assert.AreEqual(totalCost, 40.00);


        }

        [TestMethod]
        public void RentalWeekTest()
        {

            RentalWeek rd = new RentalWeek();

            //Rent for 14 weeks
            rd.cantRent = 14;

            //The function calculation for the total of the cost
            double totalCost = rd.CalcCost();


            Assert.AreEqual(totalCost, 840.00);


        }

        [TestMethod]
        public void RentalFamilyTest()
        {
            //Creates the collection of rentals
            List<IRental> listRentals = new List<IRental>();

            listRentals.Add(new RentalHour() { cantRent = 9 });
            listRentals.Add(new RentalDay() { cantRent = 3 });
            listRentals.Add(new RentalWeek() { cantRent = 12 });
            
            FamilyRental rf = new FamilyRental(listRentals);

            //The function calculation for the total of the cost
            double totalCost = rf.CalcCost();
            
            Assert.AreEqual(totalCost, 577.5);


        }

        [TestMethod]
        public void RentalFamilyTestFailNoPromotion()
        {
            //Creates the collection of rentals
            List<IRental> listRentals = new List<IRental>();

            listRentals.Add(new RentalHour() { cantRent = 9 });
            listRentals.Add(new RentalDay() { cantRent = 3 });

            FamilyRental rf = new FamilyRental(listRentals);

            try
            {
                //The function calculation for the total of the cost
                double totalCost = rf.CalcCost();
                Assert.Fail("Without promocion");
            }
            catch (Exception ex)
            {
                // whatever logging code
            }
           


        }

        [TestMethod]
        public void RentalFamilyTestFailNoRentals()
        {
            //Creates the collection of rentals
            List<IRental> listRentals = new List<IRental>();

            FamilyRental rf = new FamilyRental(listRentals);

            try
            {
                //The function calculation for the total of the cost
                double totalCost = rf.CalcCost();
                Assert.Fail("Without rents");
            }
            catch (Exception ex)
            {
                // whatever logging code
            }



        }
    }
}
