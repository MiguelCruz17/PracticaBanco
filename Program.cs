using System;

namespace P3
{
    #region Detalles del Programa
    /*Crear un programa que simule un banco que tiene 3 clientes que pueden hacer depósitos y retiros. 
    También el banco requiere que al final del día calcule la cantidad de dinero que hay depositado.*/
    #endregion
    class Clientes
    {
        private string nombre;
        private int monto;
        public Clientes(string n2)
        {
            nombre = n2;
            monto = 0;
        }
        public void Deposito(int result)
        {
            monto = monto + result;
        }
        public void Retiro(int result)
        {
            monto = monto - result;
        }
        public int RMonto()
        {
            return monto;
        }
        public void SalidaT()
        {
            Console.WriteLine("Distinguido {0}, el balance actual de su cuenta es de: {1} $RD pesos\n", nombre, monto);
        }


    }
    class Banco
    {
        private Clientes u1, u2, u3;
        public Banco()
        {
            u1 = new Clientes("Miguel");
            u2 = new Clientes("Randy");
            u3 = new Clientes("Angel");
        }
        public void Saldo()
        {
            u1.Deposito(5000);
            u2.Deposito(10000);
            u3.Deposito(20000);
            u1.Retiro(1500); //El Cliente(usuario) retiró de su cuenta 1500 pesos, por lo que su balance actual es de 3500 $RD pesos(se mostrará en la terminal).
        }

        public void TotalDR()
        {
            int Total = u1.RMonto() + u2.RMonto() + u3.RMonto();

            Console.WriteLine("\nEl dinero total en el Banco es de: {0} $RD pesos\n", Total);
            u1.SalidaT();
            u2.SalidaT();
            u3.SalidaT();

        }
        static void Main(string[] args)
        {
            Banco resultado = new Banco();
            resultado.Saldo();
            resultado.TotalDR();

        }
    }
}
