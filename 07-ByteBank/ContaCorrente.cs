using _07_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente _Titular;

        public Cliente titular { get; set; }    
        public int Agencia { get; set; }    
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









