namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        private Cliente _titular;
       public Cliente Titular
        {
            get
            {
                return this._titular;
            }
            set
            {
                this._titular = value;
            }
        }
        
        public int Agencia { get; set; }  
        public int Numero { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
           get { return _saldo; }
            
           set
            {
                if(value < 0)
                {
                    this._saldo = 0;
                }
                else
                {
                    _saldo = value;
                }
            }
        }
            
        public ContaCorrente(int agencia, int numero)
        {
            this.Agencia = agencia;
            this.Numero = numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (this._saldo <= valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}