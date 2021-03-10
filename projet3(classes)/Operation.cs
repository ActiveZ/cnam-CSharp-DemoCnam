using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet3_classes_
{
        enum Toperation { crédit, débit };
    class Operation
    {
        public Toperation TypeOp { get; set; }
        public double MontantOp { get; set; }
        public DateTime DateOp { get; set; }

        //private Toperation _typeOp ; // crédit ou débit
        //private DateTime _dateOp;
        //private double _montantOp;

        public Operation(Toperation typeOp, DateTime dateOp, double montantOp)
        {
            TypeOp = typeOp;
            DateOp = dateOp;
            MontantOp = montantOp;
        }

        public override string ToString() => $"Opération type: " + TypeOp + " - date: " + DateOp + " - montant: " + MontantOp + "\n"; 
    }
}
