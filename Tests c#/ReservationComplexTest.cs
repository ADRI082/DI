using NUnit.Framework;
using System;

namespace PicassoTest.Tests
{
    public class ReservationComplexTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void user_pay_reservation_return_0()
        {
            var user = new UserComplex
            {
                Money = 200,
                IsAdmin = false
            };

            var reservation = new ReservationComplex
            {
                Price = 50
            };

            Assert.That(reservation.PayReservation(user), Is.EqualTo(0));
            
        }

        [Test]
        public void user_cant_pay_reservation_return_1()
        {
            var user = new UserComplex
            {
                Money = 200,
                IsAdmin = false
            };

            var reservation = new ReservationComplex
            {
                Price = 500
            };

            Assert.That(reservation.PayReservation(user), Is.EqualTo(1));

        }

        [Test]
        public void user_pay_reservation_and_reduce_his_money()
        {
            var user = new UserComplex
            {
                Money = 200,
                IsAdmin = false
            };

            var reservation = new ReservationComplex
            {
                Price = 50
            };

            var mainMoney = user.Money;


            reservation.PayReservation(user);

            Assert.That(user.Money, Is.EqualTo(mainMoney - reservation.Price));

        }

        [Test]
        public void user_is_null()
        {
        
            var reservation = new ReservationComplex
            {
                Price = 50
            };

            Assert.That(reservation.PayReservation(null), Is.EqualTo(-404));

        }




    }
}
