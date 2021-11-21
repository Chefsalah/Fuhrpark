using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuhrplanVerwaltung
{
    public class Auto
    {
        private int kilometerstand;
        private double verbrauchInLiternpro100K;
        private double tankinhalt = 100;

        int i = 0;

        public Auto(int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }
        public Auto(int kilometerstand, double verbrauchInLiternpro100K, double tankinhalt) : this(kilometerstand)
        {
            this.verbrauchInLiternpro100K = verbrauchInLiternpro100K;
            this.tankinhalt = tankinhalt;
        }
        public void Fahren(int streckeInKilometer)
        {
            if (streckeInKilometer < 0)
            {

                throw new ArgumentOutOfRangeException();

            }
            else
            {


                Tankinhaltberechenen(streckeInKilometer);

                if (i == 1)
                {

                   kilometerstand= kilometerstand + Convert.ToInt32(MaximaleKilometer());


                }
                else
                {
                    kilometerstand += streckeInKilometer;


                }
            }

        }
        public int Kilometerstand
        { get => kilometerstand; }
        private void Tankinhaltberechenen(double streckeInKilometer)
        {
            double ergebniss = streckeInKilometer / 100 * verbrauchInLiternpro100K;
            if (ergebniss >= tankinhalt)
            {
                i++;

                MaximaleKilometer();

                //throw new ArgumentOutOfRangeException();
               
                
            }
            else
            {
                tankinhalt = tankinhalt - ergebniss;
            }


        }
        public double Tankinhalt2
        {

            get => tankinhalt;

        }
        public double MaximaleKilometer()
        {

            double maximalereichweite = (tankinhalt / verbrauchInLiternpro100K) * 100;

            return maximalereichweite;
        }

    }



}

