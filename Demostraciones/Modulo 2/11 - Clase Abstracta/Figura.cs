using System;

namespace Modulo_2
{
    #region Clase Abstracta Figura
    //Declaracion de la clase abstracta
	public abstract class Figura
    {
        #region Constructor
        //Constructor de instancia (de las clase derivadas)
		public Figura ()
		{
			Console.WriteLine ("Figura Creada");
		}
        #endregion

        #region Metodos Abstractos
        //Declaracion de los metodos abstractos
		public abstract decimal CalcularPerimetro ();


		public abstract decimal CalcularArea ();
        #endregion

        #region Metodos Virtuales
        //Declaracion de un método virtual
		public virtual void InformarDatosGeometricos(){

			Console.WriteLine (this.GetType ());
        }
        #endregion

    }
    #endregion

    #region Clase Derivada Triangulo
    //Declaracion de una clase derivada 
	public class Triangulo:Figura
    {
        #region Miembros Privados
        //Campos
        decimal _baseT;
        decimal _altura;
        #endregion

        #region Propiedades
        //Propiedades
        public decimal baseT
        {
            set { _baseT = value; }
            get { return _baseT ;}
        }

        public decimal altura
        {
            set { _altura = value; }
            get { return _altura; }
        }
        #endregion

        #region Metodos Implementados
        //Metodos Concretos
        public override decimal CalcularArea ()
		{
			return (_baseT * _altura) / 2;
		}

		public override decimal CalcularPerimetro ()
		{
			return (_altura * 2 + _baseT * 2);
		}
        #endregion

        #region Polimorfismo
        //Polimorfismo
        public override void InformarDatosGeometricos()
        {
            Console.WriteLine("Area: {0}", this.CalcularArea());
            Console.WriteLine("Perimetro: {0}", this.CalcularPerimetro());
            base.InformarDatosGeometricos();
        }
        #endregion
    }
    #endregion

}

