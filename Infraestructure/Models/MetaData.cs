using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    internal partial class ResidenciaMetadata
    {
        public int idHome { get; set; }

        [Display(Name = "id usuario")]
        public Nullable<int> idUser { get; set; }

        [Display(Name = "Nombre del propietario")]
        public string owner { get; set; }

        [Display(Name = "Numero de residentes")]
        public int nResidents { get; set; }

        [Display(Name = "Numero de carros")]
        public Nullable<int> nCars { get; set; }

        [Display(Name = "Numero de condominio")]
        public Nullable<int> nCondominium { get; set; }

        [Display(Name = "Estado")]
        public string status { get; set; }

        [Display(Name = "Fecha de inicio")]
        public Nullable<DateTime> dateBegin { get; set; }


        public virtual ICollection<Pagos> Pagos { get; set; }
      
        public virtual Usuario Usuario { get; set; }
    }
    internal partial class pCobroMetadata
    {
        [Display(Name = "Identificacion del plan")]
        public int idCollectionPlan { get; set; }

        [Display(Name = "Descripción")]
        public string description { get; set; }

        [Display(Name = "Fecha de creación")]

        public DateTime date { get; set; }


        public virtual ICollection<pCobroDetalle> pCobroDetalle { get; set; }

    }

    internal partial class PagosMetadata
    {
        [Display(Name = "Identificacion de la deuda")]
        public int idDebt { get; set; }

        [Display(Name = "Cantidad")]
        public long amount { get; set; }

        [Display(Name = "Estado")]
        public string status { get; set; }

        [Display(Name = "Identficación casa")]
        public int idHome { get; set; }

        [Display(Name = "Fecha de cobro")]
        public System.DateTime date { get; set; }

        public Nullable<int> idCollectionPlan { get; set; }

        public virtual pCobro pCobro { get; set; }
        public virtual Residencia Residencia { get; set; }

    }

    internal partial class UsuarioMetadata
    {
        [Display(Name = "Identificación usuario")]
        public int idUser { get; set; }

        [Display(Name = "Usuario")]
        public string name { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

      
        public string password { get; set; }

        public int idProfile { get; set; }
        public string description { get; set; }
        public int status { get; set; }

    }
    internal partial class IncidenciasMetadata
    {
        [Display(Name = "Identificación de la incidencia")]
        public int  Idincidence { get; set; }

        [Display(Name = "Descripción")]
        public string description { get; set; }

        [Display(Name = "Estado de la incidencia")]

        public string status { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<pCobroDetalle> pCobroDetalle { get; set; }

    }
}


