using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;


namespace Mvvm_Demo_Model
{
    public class Tabla
    {
        int _iTabla;
        String _sDisplay;

        public int ITabla
        {
            get
            {
                return _iTabla;
            }

            set
            {
                _iTabla = value;
            }
        }

        public string SDisplay
        {
            get
            {
                return _sDisplay;
            }

            set
            {
                _sDisplay = value;
            }
        }
    }

    public class Cls_Tablas_Model
    {
        String _bNumeroInicio;
        String _bNumeroFin;
        Tabla _tTabla;
        ObservableCollection<Tabla> _ocTablas;
        ObservableCollection<string> _ocTablaFinal;

        public string BNumeroInicio
        {
            get
            {
                return _bNumeroInicio;
            }

            set
            {
                _bNumeroInicio = value;
            }
        }

        public string BNumeroFin
        {
            get
            {
                return _bNumeroFin;
            }

            set
            {
                _bNumeroFin = value;
            }
        }

        public ObservableCollection<Tabla> OcTablas
        {
            get
            {
                return _ocTablas;
            }

            set
            {
                _ocTablas = value;
            }
        }

        public ObservableCollection<string> OcTablaFinal
        {
            get
            {
                return _ocTablaFinal;
            }

            set
            {
                _ocTablaFinal = value;
            }
        }

        public Tabla TTabla
        {
            get
            {
                return _tTabla;
            }

            set
            {
                _tTabla = value;
            }
        }
    }
}
