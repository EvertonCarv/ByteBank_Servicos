using _08_ByteBank;

namespace _08_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; } // Static porque pertence a todos dessa classe todos objetos compartilham mesma informação
                
        private int _agencia;
        public int Agencia
        {
            get
            { 
                return _agencia; 
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }    
        public int Numero { get; set; } 
                      
        private double _Saldo = 100;

        public double saldo
        {
            get 
            {
                return _Saldo;
            }
            set 
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    this._Saldo = value;
                }
            }
        }
       public ContaCorrente(int agencia, int numero) // Tratativa para que o programa não aceite <= 0 nessas variaveis
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }
        public bool Sacar(double valor)
        {
            if (this._Saldo < valor)
            {
                return false;
            }
            else
            {
                this._Saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._Saldo < valor)
            {
                return false;
            }

            else
            {
                this._Saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}









