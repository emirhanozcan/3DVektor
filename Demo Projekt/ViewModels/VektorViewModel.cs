using Demo_Projekt.Command;
using Demo_Projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo_Projekt.ViewModels
{
    public class CrossProduktVM : INotifyPropertyChanged
    {
        private Vektor modelobj;
        private string _ergebnis;
        public string ergebnis
        {
            get { return _ergebnis; }
            set { _ergebnis = value; OnPropertyChanged("ergebnis"); }
        }
        public CrossProduktVM()
        {
            Modelobj = new Vektor();
            CrossProdukt = new RelayCommand(CrossProduktMethod);
        }
        public Vektor Modelobj
        {
            get { return modelobj; }
            set { modelobj = value; OnPropertyChanged("Modelobj"); }
        }
        private void CrossProduktMethod(object obj)
        {
            Modelobj.Cross_P[0] = Modelobj.VekOne_02 * Modelobj.VekTwo_03 - Modelobj.VekOne_03 * Modelobj.VekTwo_02;
            Modelobj.Cross_P[1] = Modelobj.VekOne_03 * Modelobj.VekTwo_01 - Modelobj.VekOne_01 * Modelobj.VekTwo_03;
            Modelobj.Cross_P[2] = Modelobj.VekOne_01 * Modelobj.VekTwo_02 - Modelobj.VekOne_02 * Modelobj.VekTwo_01;
            ergebnis = Modelobj.Cross_P[0].ToString() + " " + Modelobj.Cross_P[1].ToString() + " " + Modelobj.Cross_P[2].ToString();
        }
        private ICommand crossProdukt;
        public ICommand CrossProdukt
        {
            get
            {

                return crossProdukt;
            }
            set
            {
                crossProdukt = value;
                OnPropertyChanged("CrossProdukt");
            }
        }

         
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
