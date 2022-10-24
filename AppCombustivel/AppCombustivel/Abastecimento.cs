using System;
using System.Collections.Generic;
using System.Text;

namespace AppCombustivel
{
    class Abastecimento
    {
        private double KmRodado;
        private double ValorLitro;
        private double ValorPago;

        public void SetKmRodado(double KmRodado)
        {
            if (KmRodado > 0) this.KmRodado = KmRodado;
        }
        public void SetValorPago(double ValorPago)
        {
            if (ValorPago > 0) this.ValorPago = ValorPago;
        }
        public void SetValorLitro(double ValorLitro)
        {
            if (ValorLitro > 0) this.ValorLitro = ValorLitro;
        }
        public double MediaKmLitro()
        {
            double numLitros = ValorPago / ValorLitro;
            return KmRodado / numLitros;
        }
        public double MediaReaisKm()
        {
            return ValorPago / KmRodado;
        }
    }
}
