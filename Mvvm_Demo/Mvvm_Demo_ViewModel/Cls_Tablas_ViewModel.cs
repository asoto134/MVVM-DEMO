using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvvm_Demo_Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Mvvm_Demo_ViewModel
{
    public class Cls_Tablas_ViewModel : ObservableObject
    {
        private Cls_Tablas_Model ecTabla;

        public Cls_Tablas_ViewModel()
        {
            this.ecTabla = new Cls_Tablas_Model();
            BNumeroInicio = "0";
            BNumeroFin = "0";
        }

        public string BNumeroInicio
        {
            get
            {
                return ecTabla.BNumeroInicio;
            }

            set
            {
                ecTabla.BNumeroInicio = value;
                RaisePropertyChangedEvent("BNumeroInicio");
            }
        }

        public string BNumeroFin
        {
            get
            {
                return ecTabla.BNumeroFin;
            }

            set
            {
                ecTabla.BNumeroFin = value;
                RaisePropertyChangedEvent("BNumeroFin");
            }
        }

        public ObservableCollection<Tabla> OcTablas
        {
            get
            {
                return ecTabla.OcTablas;
            }

            set
            {
                ecTabla.OcTablas = value;
                RaisePropertyChangedEvent("OcTablas");
            }
        }

        public ObservableCollection<string> OcTablaFinal
        {
            get
            {
                return ecTabla.OcTablaFinal;
            }

            set
            {
                ecTabla.OcTablaFinal = value;
                RaisePropertyChangedEvent("OcTablaFinal");
            }
        }

        public Tabla TTabla
        {
            get
            {
                return ecTabla.TTabla;
            }

            set
            {
                ecTabla.TTabla = value;
                CalcularTabla();
                RaisePropertyChangedEvent("TTabla");
            }
        }

        public ICommand CalcularListaTablasCommand
        {
            get { return new DelegateCommand(CalcularListaTablas); }
        }

        public void CalcularListaTablas()
        {
            OcTablas = new ObservableCollection<Tabla>();
            Byte bInicio = Convert.ToByte(BNumeroInicio);
            Byte bFin = Convert.ToByte(BNumeroFin);

            for (Byte i = bInicio; i <= bFin; i++)
            {
                OcTablas.Add(new Tabla() { ITabla = i, SDisplay = string.Format("Tabla de multiplicar del {0}", i) });
            }
        }

        public void CalcularTabla()
        {
            OcTablaFinal = new ObservableCollection<String>();

            if (TTabla != null)
            {
                for (int i = 0; i <= 12; i++)
                {
                    OcTablaFinal.Add(TTabla.ITabla.ToString() + " x " + i.ToString() + " = " + (TTabla.ITabla * i).ToString());
                }
            }
        }

        public ICommand LimpiartablasCommand
        {
            get { return new DelegateCommand(Limpiartablas); }
        }

        public void Limpiartablas()
        {
            BNumeroInicio = "0";
            BNumeroFin = "0";
            OcTablas = null;
            OcTablaFinal = null;
            TTabla = null;
        }

    }
}
