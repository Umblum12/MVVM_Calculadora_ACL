using MvvmGuia.VistaModelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Calculadora_ACL.VistaModelo
{
    internal class VMCalculadora: BaseViewModel
    {
        #region Variables
        double? valor1 = null, valor2 = null, resultado = null;
        string operador = null;
        String _Pantalla;
        #endregion
        #region Constructor
        public VMCalculadora(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetos
        public String Pantalla
        {
            get { return _Pantalla; }
            set { SetValue(ref _Pantalla, value); }
        }
        #endregion
        #region Precesos
        public void Btn_BorrarTodo()
        {
            valor1 = null;
            valor2 = null;
            operador = null;
            resultado = null;
            Pantalla = null;
        }
        public void Btn_Borrarunoauno()
        {
            if (Pantalla.Length != 0)
            {
                Pantalla = Pantalla.Substring(0, Pantalla.Length - 1);
            }
        }
        public void Btn_NumUno()
        {
            if (valor1 == null || operador == null)
            {
                Pantalla += "1";
                valor1 = Convert.ToDouble(Pantalla);
            }
            else if (valor2 == null || operador != null)
            {
                Pantalla += "1";
                valor2 = Convert.ToDouble(Pantalla);
            }
        }
        public void Btn_NumDos()
        {
            if (valor1 == null || operador == null)
            {
                Pantalla += "2";
                valor1 = Convert.ToDouble(Pantalla);
            }
            else if (valor2 == null || operador != null)
            {
                Pantalla += "2";
                valor2 = Convert.ToDouble(Pantalla);
            }
        }
        public void Btn_NumTres()
        {
            if (valor1 == null || operador == null)
            {
                Pantalla += "3";
                valor1 = Convert.ToDouble(Pantalla);
            }
            else if (valor2 == null || operador != null)
            {
                Pantalla += "3";
                valor2 = Convert.ToDouble(Pantalla);
            }
        }
        public void Btn_NumCuatro()
        {
            if (valor1 == null || operador == null)
            {
                Pantalla += "4";
                valor1 = Convert.ToDouble(Pantalla);
            }
            else if (valor2 == null || operador != null)
            {
                Pantalla += "4";
                valor2 = Convert.ToDouble(Pantalla);
            }
        }
        public void Btn_NumCinco()
        {
            if (valor1 == null || operador == null)
            {
                Pantalla += "5";
                valor1 = Convert.ToDouble(Pantalla);
            }
            else if (valor2 == null || operador != null)
            {
                Pantalla += "5";
                valor2 = Convert.ToDouble(Pantalla);
            }
        }
        public void Btn_NumSeis()
        {
            if (valor1 == null || operador == null)
            {
                Pantalla += "6";
                valor1 = Convert.ToDouble(Pantalla);
            }
            else if (valor2 == null || operador != null)
            {
                Pantalla += "6";
                valor2 = Convert.ToDouble(Pantalla);
            }
        }
        public void Btn_NumSitete()
        {
            if (valor1 == null || operador == null)
            {
                Pantalla += "7";
                valor1 = Convert.ToDouble(Pantalla);
            }
            else if (valor2 == null || operador != null)
            {
                Pantalla += "7";
                valor2 = Convert.ToDouble(Pantalla);
            }
        }
        public void Btn_NumOcho()
        {
            if (valor1 == null || operador == null)
            {
                Pantalla += "8";
                valor1 = Convert.ToDouble(Pantalla);
            }
            else if (valor2 == null || operador != null)
            {
                Pantalla += "8";
                valor2 = Convert.ToDouble(Pantalla);
            }
        }
        public void Btn_NumNueve()
        {
            if (valor1 == null || operador == null)
            {
                Pantalla += "9";
                valor1 = Convert.ToDouble(Pantalla);
            }
            else if (valor2 == null || operador != null)
            {
                Pantalla += "9";
                valor2 = Convert.ToDouble(Pantalla);
            }
        }       
        public void Btn_NumCero()
        {
            if (valor1 == null || operador == null)
            {
                Pantalla += "0";
                valor1 = Convert.ToDouble(Pantalla);
            }
            else if (valor2 == null || operador != null)
            {
                Pantalla += "0";
                valor2 = Convert.ToDouble(Pantalla);
            }
        }
        public void Btn_Coma()
        {
            Pantalla += ",";
        }
        public void Btn_Suma()
        {
            if (valor1 != null)
            {
                operador = "+";
                valor1 = Convert.ToDouble(Pantalla);
                Pantalla = null;
            }
        }
        public void Btn_Resta()
        {
            if (valor1 != null)
            {
                operador = "-";
                valor1 = Convert.ToDouble(Pantalla);
                Pantalla = null;
            }
        }
        public void Btn_Multiplicacion()
        {
            if (valor1 != null)
            {
                operador = "X";
                valor1 = Convert.ToDouble(Pantalla);
                Pantalla = null;
            }
        }
        public void Btn_Divicion()
        {
            if (valor1 != null)
            {
                operador = "÷";
                valor1 = Convert.ToDouble(Pantalla);
                Pantalla = null;
            }
        }
        public void Btn_Porsentaje()
        {
            if (valor1 != null)
            {
                operador = "%";
                valor1 = Convert.ToDouble(Pantalla);
            }
        }
        public void Btn_Igual()
        {
            calcular(valor1, valor2, operador);
            calcular1(valor1, operador);
        }
        public void calcular(double? v1, double? v2, string op)
        {
            switch (op)
            {
                case "÷":
                    if (v2 != 0)
                    {
                        resultado = v1 / v2;
                        Pantalla = resultado.ToString();
                        valor1 = resultado;
                        valor2 = null;
                    }
                    else
                    {
                        Pantalla = "Error";
                    }
                    break;
                case "*":
                    resultado = v1 * v2;
                    Pantalla = resultado.ToString();
                    valor1 = resultado;
                    valor2 = null;
                    break;
                case "-":
                    resultado = v1 - v2;
                    Pantalla = resultado.ToString();
                    valor1 = resultado;
                    valor2 = null;
                    break;
                case "+":
                    resultado = v1 + v2;
                    Pantalla = resultado.ToString();
                    valor1 = resultado;
                    valor2 = null;
                    break;
                default:
                    break;
            }
        }
        public void calcular1(double? v1, string op)
        {
            switch (op)
            {
                case "%":
                    resultado = v1 / 100;
                    Pantalla = resultado.ToString();
                    valor1 = resultado;
                    valor2 = null;
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region COMANDOS
        public ICommand Btn_BorrarTodocommand => new Command(Btn_BorrarTodo);
        public ICommand Btn_Borrarunoaunocommand => new Command(Btn_Borrarunoauno);
        public ICommand Btn_NumUnocommand => new Command(Btn_NumUno);
        public ICommand Btn_NumDoscommand => new Command(Btn_NumDos);
        public ICommand Btn_NumTrescommand => new Command(Btn_NumTres);
        public ICommand Btn_NumCuatrocommand => new Command(Btn_NumCuatro);
        public ICommand Btn_NumCincocommand => new Command(Btn_NumCinco);
        public ICommand Btn_NumSeiscommand => new Command(Btn_NumSeis);
        public ICommand Btn_NumSitetecommand => new Command(Btn_NumSitete);
        public ICommand Btn_NumOchocommand => new Command(Btn_NumOcho);
        public ICommand Btn_NumNuevecommand => new Command(Btn_NumNueve);
        public ICommand Btn_NumCerocommand => new Command(Btn_NumCero);
        public ICommand Btn_Comacommand => new Command(Btn_Coma);
        public ICommand Btn_Sumacommand => new Command(Btn_Suma);
        public ICommand Btn_Restacommand => new Command(Btn_Resta);
        public ICommand Btn_Multiplicacioncommand => new Command(Btn_Multiplicacion);
        public ICommand Btn_Divicioncommand => new Command(Btn_Divicion);
        public ICommand Btn_Porsentajecommand => new Command(Btn_Porsentaje);
        public ICommand Btn_Igualcommand => new Command(Btn_Igual);
        #endregion
    }
}
