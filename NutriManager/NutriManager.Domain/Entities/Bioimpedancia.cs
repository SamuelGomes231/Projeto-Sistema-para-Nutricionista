using NutriManager.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriManager.Domain.Entities
{
    public class Bioimpedancia : BaseEntity<int>
    {
        public Bioimpedancia() { }
        public Bioimpedancia(int id, float percentualGordura, float percentualMassaMagra, float percentualAguaCorporal, float massaMagra, float massaGorda, float taxaMetabolicaBasal)
        {
            Id = id;
            PercentualGordura = percentualGordura;
            PercentualMassaMagra = percentualMassaMagra;
            PercentualAguaCorporal = percentualAguaCorporal;
            MassaMagra = massaMagra;
            MassaGorda = massaGorda;
            TaxaMetabolicaBasal = taxaMetabolicaBasal;
        }

        public float PercentualGordura { get; set; }
        public float PercentualMassaMagra { get; set; }
        public float PercentualAguaCorporal { get; set; }
        public float MassaMagra { get; set; }
        public float MassaGorda { get; set; }
        public float TaxaMetabolicaBasal { get; set; }
    }
}
