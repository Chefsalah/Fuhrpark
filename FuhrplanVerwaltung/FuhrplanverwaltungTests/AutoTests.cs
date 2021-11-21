using System;
using FuhrplanVerwaltung;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuhrplanverwaltungTests
{
    [TestClass]
    public class Autotests
    {
        //1
        [TestMethod]
        public void Fahren_steigertJikometerstand()
        {
            //Arrange
            int kilometerstand = 100;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(150, a.Kilometerstand);


        }
        //2
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fahren_NichtNegativ()
        {

            //Arrange
            int kilometerstand = 0;
            Auto a = new Auto(kilometerstand);
            int streckeinKilometer = -1;

            //act
            a.Fahren(streckeinKilometer);

        }
        //3

        [TestMethod]
        public void Tankinhalt_senken()
        {
            //Arrange
            int kilometerstand = 100;
            double Tankinhalt = 10;
            double verbrauchInLiternpro100K = 5.7;
            Auto a = new Auto(kilometerstand,verbrauchInLiternpro100K,Tankinhalt);
            int streckeInKilometern = 100;
            
            //act
            a.Fahren(streckeInKilometern);

            //assert
            Assert.AreEqual(4.3,a.Tankinhalt2);
        }
        //4
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fahren_Tankinhaltnichtüberschreiten()
        {


            //Arrange 
            int kilometerstand = 100;
            double Tankinhalt = 10;
            double verbrauchInLiternpro100K = 10;
            Auto a = new Auto(kilometerstand, verbrauchInLiternpro100K, Tankinhalt);
            int streckeInKilometern = 200;

            //Act
            a.Fahren(streckeInKilometern);



        }
        //5
        [TestMethod]
        public void Fahren_KilometerBiszumStillstand()
        {
            // Arange
            int kilometerstand = 0;
            double Tankinhalt = 10;
            double verbrauchInLiternpro100K = 5.7;
            Auto a = new Auto(kilometerstand, verbrauchInLiternpro100K, Tankinhalt);
            int streckeInKilometern = 200;

            //act
            a.Fahren(streckeInKilometern);

            // 
            Assert.AreEqual(175,a.Kilometerstand);

        }
    
    }
}
