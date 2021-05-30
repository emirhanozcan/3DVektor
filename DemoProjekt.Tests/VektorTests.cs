using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Projekt;
using Xunit;

namespace DemoProjekt.Tests
{
    public class VektorTests
    {
        double[] vector1 = { 10, 20, 30 };

        [Theory]
        [InlineData(10, 20, 30, new double[] {10, 20, 30 })]
        [InlineData(20, 30, 40, new double[] {20, 30, 40 })]
        public void VektorErzeugung_SollBerechnen(double x, double y, double z, double[] soll)
        {

            double[] ist = Auswertung.VectorErzeugung(x, y, z);
            Assert.Equal(soll, ist);
        }

        [Theory]
        [InlineData(new double[] {10,20,30}, new double[] {-10, -20, -30 })]
        [InlineData(new double[] { 20, 40, 30 }, new double[] { -20, -40, -30 })]
        public void Invertierung_SollBerechnen(double[] v1, double[] soll)
        {

            double[] ist = Auswertung.Invertierung(v1);
            Assert.Equal(soll, ist);
        }

        [Theory]
        [InlineData(new double[] { 10, 20, 30 }, new double[] { -10, -20, -30 }, new double[] { 0, 0, 0 })]
        [InlineData(new double[] { 20, 40, 30 }, new double[] { -5, -9, 10 }, new double[] { 15, 31, 40 })]
        public void Addition_SollBerechnen(double[] v1, double[] v2, double[] soll)
        {

            double[] ist = Auswertung.Addition(v1, v2);
            Assert.Equal(soll, ist);
        }

        [Theory]
        [InlineData(new double[] { 10, 20, 30 }, new double[] { -10, -20, -30 }, new double[] { 20, 40, 60 })]
        [InlineData(new double[] { 20, 40, 30 }, new double[] { -5, -9, 10 }, new double[] { 25, 49, 20 })]
        public void Subtraktion_SollBerechnen(double[] v1, double[] v2, double[] soll)
        {

            double[] ist = Auswertung.Subtraktion(v1, v2);
            Assert.Equal(soll, ist);
        }

        [Theory]
        [InlineData(new double[] { 10, 20, 30 }, 10, new double[] { 100, 200, 300 })]
        [InlineData(new double[] { 20, 40, 30 }, 0, new double[] { 0, 0, 0 })]
        public void Multiplikation_SollBerechnen(double[] v1, int v2, double[] soll)
        {

            double[] ist = Auswertung.Multiplikation(v1, v2);
            Assert.Equal(soll, ist);
        }

        [Theory]
        [InlineData(new double[] { 10, 20, 30 }, 10, new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 20, 40, 30 }, -2, new double[] { -10, -20, -15 })]
        public void Divison_SollBerechnen(double[] v1, int v2, double[] soll)
        {

            double[] ist = Auswertung.Division(v1, v2);
            Assert.Equal(soll, ist);
        }

        [Theory]
        [InlineData(new double[] { 10, 20, 30 }, new double[] { -10, -20, -30 }, -1400)]
        [InlineData(new double[] { 20, 30, 40 }, new double[] { -5, -9, 10 }, 30)]
        public void SkalarProdukt_SollBerechnen(double[] v1, double[] v2, double soll)
        {

            double ist = Auswertung.Skalarprodukt(v1, v2);
            Assert.Equal(soll, ist);
        }

        [Theory]
        [InlineData(new double[] { 10, 20, 30 }, new double[] { -10, -20, -30 }, new double[] {0, 0, 0})]
        [InlineData(new double[] { 20, 30, 40 }, new double[] { -5, -9, 10 }, new double[] {660, -400, -30 })]
        public void VektorProdukt_SollBerechnen(double[] v1, double[] v2, double[] soll)
        {

            double[] ist = Auswertung.Vektorprodukt(v1, v2);
            Assert.Equal(soll, ist);
        }

        [Theory]
        [InlineData(new double[] { 10, 20, 30 }, 37.416573867739416)]
        [InlineData(new double[] { -20, 0, -40 }, 44.721359549995796)]
        public void Länge_SollBerechnen(double[] v1, double soll)
        {

            double ist = Auswertung.Länge(v1);
            Assert.Equal(soll, ist);
        }

        [Theory]
        [InlineData(new double[] { 10, 20, 30 }, new double[] { -10, -20, -30 }, 180.0)]
        [InlineData(new double[] { 20, 30, 40 }, new double[] { -5, -9, 10 }, 87.78)]
        public void Winkel_SollBerechnen(double[] v1, double[] v2, double soll)
        {

            double ist = Auswertung.Winkel(v1, v2);
            Assert.Equal(soll, ist);
        }

        [Theory]
        [InlineData(new double[] { 10, 20, 30 }, new double[] { -10, -20, -30 }, "Ungleich")]
        [InlineData(new double[] { 20, 30, 40 }, new double[] { 20, 30, 40 }, "Gleich")]
        public void Gleichheit_SollBerechnen(double[] v1, double[] v2, string soll)
        {

            string ist = Auswertung.Gleichheit(v1, v2);
            Assert.Equal(soll, ist);
        }

    }
}
