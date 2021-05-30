using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Projekt
{
    public class Auswertung
    {
        

        public static double[] VectorErzeugung(double x, double y, double z)
        {
            double[] dreiDvector = new double[3] { x, y, z };

            return dreiDvector;
        }

        public static double[] Invertierung(double[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = vector[i] * -1;
            }

            return vector;
        }

        public static double[] Addition(double[] vector1, double[] vector2)
        {
            double[] sum_vector = new double[3];

            for (int i = 0; i < vector1.Length; i++)
            {
                sum_vector[i] = vector1[i] + vector2[i];
                Console.WriteLine(sum_vector[i]);
            }

            return sum_vector;
        }

        public static double[] Subtraktion(double[] vector1, double[] vector2)
        {
            double[] sub_vector = new double[3];

            for (int i = 0; i < vector1.Length; i++)
            {
                sub_vector[i] = vector1[i] - vector2[i];
                Console.WriteLine(sub_vector[i]);
            }

            return sub_vector;
        }

        public static double[] Multiplikation(double[] vector1, int skalar)
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] = vector1[i] * skalar;
                Console.WriteLine(vector1[i]);
            }

            return vector1;
        }

        public static double[] Division(double[] vector1, int skalar)
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] = vector1[i] / skalar;
                Console.WriteLine(vector1[i]);
            }

            return vector1;
        }

        public static double Skalarprodukt(double[] vector1, double[] vector2)
        {
            double sum = 0;

            for (int i = 0; i < vector1.Length; i++)
            {
                sum = sum + (vector1[i] * vector2[i]);
            }

            return sum;
        }

        public static double[] Vektorprodukt(double[] vector1, double[] vector2)
        {
            double[] kreuz_vector = new double[3];

            double det_i = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
            double det_j = (vector1[0] * vector2[2]) - (vector1[2] * vector2[0]);
            double det_k = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);

            kreuz_vector[0] = det_i;
            kreuz_vector[1] = -1 * det_j;
            kreuz_vector[2] = det_k;

            return kreuz_vector;
        }

        public static double Länge(double[] vector1)
        {
            double länge = Math.Sqrt(Math.Pow(vector1[0], 2) + Math.Pow(vector1[1], 2) + Math.Pow(vector1[2], 2));

            return länge;
        }

        public static double Winkel(double[] vector1, double[] vector2)
        {
            double skalar_produkt = Skalarprodukt(vector1, vector2);
            double länge_vec1 = Länge(vector1);
            double länge_vec2 = Länge(vector2);

            double winkel = (180 / Math.PI) * Math.Acos(skalar_produkt / (länge_vec1 * länge_vec2));

            return Math.Round(winkel, 2);
        }

        public static string Gleichheit(double[] vector1, double[] vector2)
        {
            string result;


            if (vector1.SequenceEqual(vector2))
            {
                result = "Gleich";
            }
            else
            {
                result = "Ungleich";
            }

            return result;
        }
    }


}
