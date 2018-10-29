using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm_Demo_Model
{
    public class Cls_Ecuaciones_Cuadraticas_Model
    {
        String _sParametroA;
        String _sParametroB;
        String _sParametroC;
        String _sDiscriminante;
        String _sSolucion1;
        String _sSolucion2;

        public String sParametroA
        {
            get
            {
                return _sParametroA;
            }

            set
            {
                _sParametroA = value;
            }
        }

        public String sParametroB
        {
            get
            {
                return _sParametroB;
            }

            set
            {
                _sParametroB = value;
            }
        }

        public String sParametroC
        {
            get
            {
                return _sParametroC;
            }

            set
            {
                _sParametroC = value;
            }
        }

        public String sDiscriminante
        {
            get
            {
                return _sDiscriminante;
            }

            set
            {
                _sDiscriminante = value;
            }
        }

        public String sSolucion1
        {
            get
            {
                return _sSolucion1;
            }

            set
            {
                _sSolucion1 = value;
            }
        }

        public String sSolucion2
        {
            get
            {
                return _sSolucion2;
            }

            set
            {
                _sSolucion2 = value;
            }
        }
    }
}
