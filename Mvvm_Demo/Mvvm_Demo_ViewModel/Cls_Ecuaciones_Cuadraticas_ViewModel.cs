using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Mvvm_Demo_Model;

namespace Mvvm_Demo_ViewModel
{
    public class Cls_Ecuaciones_Cuadraticas_ViewModel : ObservableObject
    {
        private Cls_Ecuaciones_Cuadraticas_Model ecModel;

        public Cls_Ecuaciones_Cuadraticas_ViewModel()
        {
            this.ecModel = new Cls_Ecuaciones_Cuadraticas_Model();
            sParametroA = "0";
            sParametroB = "0";
            sParametroC = "0";
        }

        public String sParametroA
        {
            get
            {
                return ecModel.sParametroA;
            }

            set
            {
                ecModel.sParametroA = value;
                RaisePropertyChangedEvent("sParametroA");
            }
        }

        public String sParametroB
        {
            get
            {
                return ecModel.sParametroB;
            }

            set
            {
                ecModel.sParametroB = value;
                RaisePropertyChangedEvent("sParametroB");
            }
        }

        public String sParametroC
        {
            get
            {
                return ecModel.sParametroC;
            }

            set
            {
                ecModel.sParametroC = value;
                RaisePropertyChangedEvent("sParametroC");
            }
        }

        public String sDiscriminante
        {
            get
            {
                return ecModel.sDiscriminante;
            }

            set
            {
                ecModel.sDiscriminante = value;
                RaisePropertyChangedEvent("sDiscriminante");
            }
        }

        public String sSolucion1
        {
            get
            {
                return ecModel.sSolucion1;
            }

            set
            {
                ecModel.sSolucion1 = value;
                RaisePropertyChangedEvent("sSolucion1");
            }
        }

        public String sSolucion2
        {
            get
            {
                return ecModel.sSolucion2;
            }

            set
            {
                ecModel.sSolucion2 = value;
                RaisePropertyChangedEvent("sSolucion2");
            }
        }

        public ICommand CalcularDiscriminanteCommand
        {
            get { return new DelegateCommand(calcularDiscriminante); }
        }

        private void calcularDiscriminante()
        {
            sDiscriminante = "";
            sSolucion1 = "";
            sSolucion2 = "";

            float fParametroA = Convert.ToSingle(sParametroA);
            float fParametroB = Convert.ToSingle(sParametroB);
            float fParametroC = Convert.ToSingle(sParametroC);
            float fDiscriminante;

            fDiscriminante = (float)((Math.Pow(fParametroB, 2)) - (4 * fParametroA * fParametroC));
            sDiscriminante = fDiscriminante.ToString();
            if (fDiscriminante == 0)
                calcularunicaSolucion();
            if (fDiscriminante > 0)
                calcularSoluciones();
        }

        private void calcularunicaSolucion()
        {
            float fParametroA = Convert.ToSingle(sParametroA);
            float fParametroB = Convert.ToSingle(sParametroB);
            float fSolucion1;

            fSolucion1 = ((-fParametroB) / (2 * fParametroA));

            sSolucion1 = fSolucion1.ToString();
        }

        private void calcularSoluciones()
        {
            float fParametroA = Convert.ToSingle(sParametroA);
            float fParametroB = Convert.ToSingle(sParametroB);
            float fDiscriminante = Convert.ToSingle(sDiscriminante);
            float fSolucion1;
            float fSolucion2;

            fSolucion1 = (float)(((-fParametroB) + (Math.Sqrt(fDiscriminante))) / (2 * fParametroA));
            fSolucion2 = (float)(((-fParametroB) - (Math.Sqrt(fDiscriminante))) / (2 * fParametroA));

            sSolucion1 = fSolucion1.ToString();
            sSolucion2 = fSolucion2.ToString();
        }

        public ICommand LimpiarDatosCommand
        {
            get { return new DelegateCommand(LimpiarDatos); }
        }

        private void LimpiarDatos()
        {
            sParametroA = "0";
            sParametroB = "0";
            sParametroC = "0";
            sDiscriminante = "";
            sSolucion1 = "";
            sSolucion2 = "";
        }
    }
}
