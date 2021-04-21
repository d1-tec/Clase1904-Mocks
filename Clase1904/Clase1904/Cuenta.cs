using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1904
{
    public class Cuenta
    {
        public int Saldo { get; set; }
        public DateTime UltimaTransaccionRealizada { get; set; }
        private IDateTimeProvider dateTimeProvider;

        public Cuenta(IDateTimeProvider dateTimeProvider)
        {
            this.dateTimeProvider = dateTimeProvider;
        }

        public void Transferir(int montoATransferir, Cuenta cuenta)
        {
            this.Saldo -= montoATransferir;
            cuenta.Saldo += montoATransferir;
            this.UltimaTransaccionRealizada = dateTimeProvider.Now();
        }
    }
}
