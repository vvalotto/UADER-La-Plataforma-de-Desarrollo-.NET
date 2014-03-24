using System;

namespace Modulo_2
{
	public abstract class Figura
	{
		public Figura ()
		{
			Console.WriteLine ("Figura Creada");
		}

		public abstract decimal CalcularPerimetro ();


		public abstract decimal CalcularArea ();


		public virtual void InformarDatosGeometricos(){

			Console.WriteLine (this.GetType ());
		}
	}
		
	public class Triangulo:Figura
	{

        decimal _baseT;
        decimal _altura;

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
        
        public override decimal CalcularArea ()
		{
			return (_baseT * _altura) / 2;
		}

		public override decimal CalcularPerimetro ()
		{
			return (_altura * 2 + _baseT * 2);
		}

        public override void InformarDatosGeometricos()
        {
            Console.WriteLine("Area: {0}", this.CalcularArea());
            Console.WriteLine("Perimetro: {0}", this.CalcularPerimetro());
            base.InformarDatosGeometricos();
        }
	}

}

