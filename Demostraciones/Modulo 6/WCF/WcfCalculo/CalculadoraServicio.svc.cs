using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfCalculo
{
    public class CalculadoraServicio : ICalculadoraServicio
    {

        Resultado _res = new Resultado();

        public Resultado Sumar(decimal operador1, decimal operador2)
        {
            try
            {
                _res.Valor = operador1 + operador2;
                _res.Error = false;
                _res.Mensaje = "Operacion exitosa";
            }
            catch (Exception ex)
            {
                _res.Valor = 0;
                _res.Error = true;
                _res.Mensaje = ex.Message;
            }
            return _res;
        }

        public Resultado Restar(decimal operador1, decimal operador2)
        {
            try
            {
                _res.Valor = operador1 - operador2;
                _res.Error = false;
                _res.Mensaje = "Operacion exitosa";
            }
            catch (Exception ex)
            {
                _res.Valor = 0;
                _res.Error = true;
                _res.Mensaje = ex.Message;
            }

            return _res;
        }

        public Resultado Multiplicar(decimal operador1, decimal operador2)
        {
            try
            {
                _res.Valor = operador1 * operador2;
                _res.Error = false;
                _res.Mensaje = "Operacion exitosa";
            }
            catch (Exception ex)
            {
                _res.Valor = 0;
                _res.Error = true;
                _res.Mensaje = ex.Message;
            }

            return _res;
        }

        public Resultado Dividir(decimal operador1, decimal operador2)
        {

            try
            {
                _res.Valor = operador1 / operador2;
                _res.Error = false;
                _res.Mensaje = "Operacion exitosa";
            }
            catch (DivideByZeroException ex)
            {
                _res.Valor = 0;
                _res.Error = true;
                _res.Mensaje = ex.Message;
            }
            catch (Exception ex)
            {
                _res.Valor = 0;
                _res.Error = true;
                _res.Mensaje = ex.Message;
            }

            return _res;
        }
    }
}
