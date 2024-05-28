namespace NumerosRacionales.Model
{
    public class Racional
    {
        //private uint _numerador;
        //private uint _denominador;

        //Propiedades
       // public uint Numerador
        //{
          //  get
          //  { 
          //     return _numerador;
          //  }
          //  set
          //  {
          //      if (_numerador != value)
          //      {
          //          _numerador = value;
         //       }
         //   }
        //}

        //public uint Denominador
        //{
          //  get
          //  {
          //      return _denominador;
         //   }
         //   set
         //   { 
        //       if (_denominador != value)
        //       {
        //            _denominador = value;
        //       }
        //    }
       // }

        //Propiedades automaticas
        public uint Numerador {  get; set; }
        public uint Denominador { get; set; }

        //Propiedad solo lectura
        public bool EsFraccionInpropia => Numerador >= Denominador;

        public Racional(uint numerador, uint denominador) 
        { 
            Numerador = numerador;
            Denominador = denominador;
        }
        //Métodos selectores o Getters
        //public uint GetNumerador()
        //{
        //    return _numerador;
        //}

        //public uint GetDenominador()
       // {
         //   return _denominador;
        //}

        //Métodos modificadores o Setters

        //public void SetNumerador(uint nuevoNumerador)
        //{
           // if (_numerador != nuevoNumerador) 
           // { 
           //     _numerador = nuevoNumerador;
           // }
            
        //}

        //public void SetDenominador(uint nuevoDenominador)
        //{
           // if (_denominador != nuevoDenominador)
            //{
            //    _denominador = nuevoDenominador;
            //}
       // }

        //public string ComoTexto() => $"{_numerador}/{_denominador}";
        public string ComoTexto()
        {
           return $"{Numerador}/{Denominador}";
        }

        public double Fraccion()
        {
            return (double)Numerador / Denominador;
        }


        public bool EsFraccionPropia()
        {
            return Numerador < Denominador;
        }

        public Racional Sumar(Racional r)
        {
            uint numerador;
            uint denominador;

            if (Denominador != r.Denominador)
            {
                //Los racionales tienen diferente denominador
                 numerador = Numerador * r.Denominador + r.Numerador * Denominador;
                 denominador = Denominador * r.Denominador;
            }
            else
            {
                //Los racionales tienen el mismo denominador
                numerador = Numerador + r.Numerador;
                denominador = Denominador;
            }
            return new Racional(numerador, denominador);
           
        }

        public Racional Restar(Racional r)
        {
              uint numerador;
              uint denominador;

            if (Denominador != r.Denominador)
            {
                //Los racionales tienen diferente denominador
                numerador = Numerador * r.Denominador - r.Numerador * Denominador;
                denominador = Denominador * r.Denominador;
            }
            else
            {
                //Los racionales tienen el mismo denominador
                numerador = Numerador - r.Numerador;
                denominador = Denominador;
            }
            return new Racional(numerador, denominador);
        }

        public Racional Multiplicar(Racional r)
        {
            uint numerador;
            uint denominador;

            numerador = Numerador * r.Denominador;
            denominador = Denominador * r.Denominador;
            return new Racional(numerador, denominador);

        }

        public Racional Dividir(Racional r)
        {
            uint numerador;
            uint denominador;

            numerador = Numerador * r.Denominador;
            denominador = Denominador * r.Numerador;
            return new Racional(numerador, denominador);
        }
    }
}
