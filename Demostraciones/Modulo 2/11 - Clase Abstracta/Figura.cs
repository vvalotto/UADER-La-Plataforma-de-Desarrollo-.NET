using System;

namespace Modulo_2
{
    //Declaracion de la clase abstracta
	public abstract class Figura
	{
        //Constructor de instancia (de las clase derivadas)
		public Figura ()
		{
			Console.WriteLine ("Figura Creada");
		}

        //Declaracion de los metodos abstractos
		public abstract decimal CalcularPerimetro ();


		public abstract decimal CalcularArea ();

        //Declaracion de un método virtual
		public virtual void InformarDatosGeometricos(){

			Console.WriteLine (this.GetType ());
		}
	}
		
    //Declaracion de una clase derivada 
	public class Triangulo:Figura
	{
        //Campos
        decimal _baseT;
        decimal _altura;

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
        
        //Metodos Concretos
        public override decimal CalcularArea ()
		{
			return (_baseT * _altura) / 2;
		}

		public override decimal CalcularPerimetro ()
		{
			return (_altura * 2 + _baseT * 2);
		}

        //Polimorfismo
        public override void InformarDatosGeometricos()
        {
            Console.WriteLine("Area: {0}", this.CalcularArea());
            Console.WriteLine("Perimetro: {0}", this.CalcularPerimetro());
            base.InformarDatosGeometricos();
        }
	}

}

