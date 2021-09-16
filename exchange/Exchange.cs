using System;
using System.Collections.Generic;
using System.Text;

namespace exchange
{
    class Exchange
    {
        private Crypto[] _cryptos;
        private int _limite;
        private int _numCrypto;

        public Exchange(int limite)
        {
            this._cryptos = new Crypto[limite];
            _limite = limite;
            _numCrypto = 0;
        }
        public void AniadirCrypto(Crypto c)
        {            
            if (c != null && _numCrypto < _cryptos.Length)
            {
                _cryptos[_numCrypto] = c;
                _numCrypto++;
            }
        }
        public void MostrarCrypto()
        {
            for (int i = 0; i < _numCrypto; i++)            
                Console.WriteLine(_cryptos[i]);            
        }
        public void EliminarCrypto(Crypto c)
        {
            if (c != null && _numCrypto != 0)
            {
                int posicion = -1;
                for (int i = 0; i < _numCrypto; i++)
                {
                    if (c.Ticker == _cryptos[i].Ticker)                    
                        posicion = i;                    
                }
                if (posicion == -1)                
                    Console.WriteLine("No existe esa crypto");
                
                else
                {
                    _cryptos[posicion] = null;

                    for (int i = posicion; i < _numCrypto; i++)                    
                        _cryptos[i] = _cryptos[i + 1];
                    
                    _numCrypto--;
                }
            }
        }
    }
}
