using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Demo_Projekt.Models
{
    using System.ComponentModel;
    using Xamarin.Forms;

    public class Vektor : INotifyPropertyChanged
    {


        private double vekOne_01;
        private double vekOne_02;
        private double vekOne_03;
        private double vekTwo_01;
        private double vekTwo_02;
        private double vekTwo_03;
        private double[] cross_P = new double[3];

        public double VekOne_01
        {
            get
            {
                return vekOne_01;
            }
            set
            {
                vekOne_01 = value;
                OnPropertyChanged(VekOne_01.ToString());
            }
        }
        public double VekOne_02
        {
            get
            {
                return vekOne_02;
            }
            set
            {
                vekOne_02 = value;
                OnPropertyChanged(VekOne_02.ToString());
            }
        }
        public double VekOne_03
        {
            get
            {
                return vekOne_03;
            }
            set
            {
                vekOne_03 = value;
                OnPropertyChanged(VekOne_03.ToString());
            }
        }

        public double VekTwo_01
        {
            get
            {
                return vekTwo_01;
            }
            set
            {
                vekTwo_01 = value;
                OnPropertyChanged(VekTwo_01.ToString());
            }
        }
        public double VekTwo_02
        {
            get
            {
                return vekTwo_02;
            }
            set
            {
                vekTwo_02 = value;
                OnPropertyChanged(VekTwo_02.ToString());
            }
        }
        public double VekTwo_03
        {
            get
            {
                return vekTwo_03;
            }
            set
            {
                vekTwo_03 = value;
                OnPropertyChanged(VekTwo_03.ToString());
            }
        }
        public double[] Cross_P
        {
            get
            {
                return cross_P;
            }
            set
            {
                cross_P = value;
            }
        }



        #region INotifyPropertyChanged Members  
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    } 
}

