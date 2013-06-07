using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
     class datos
    {
         
      public Int64 Id { get; set; }
      public String amaterno { get; set; }
      public String  apaterno{ get; set; }
      public String nombre { get; set; }
      public String domicilio { get; set; }
      public String  colonia{ get; set; }
      public String  municipio{ get; set; }
      public String estado  { get; set; }
      public String pais { get; set; }
      public String  telefono { get; set; }
      public String celular { get; set; }
      public String  radio{ get; set; }
      public String  copostal{ get; set; }
      public String  mapa{ get; set; }
      public String  email{ get; set; }
      public String  observaciones{ get; set; }
  
      public datos() { }

      public datos(
          Int64 vId,
          String vnom,
          String vapa, 
          String vama,
          String vdom, 
          String vcol,
          String vmuni,
          String vestado,
          String vpais,
          String vtel,    
          String vcel,
          String vrad,
          String vcp,
          String vmapa,
          String vemail,
          String vobser)

      {
          this.Id = vId;
          this.amaterno = vama;
          this.apaterno = vapa;
          this.nombre = vnom;
          this.domicilio = vdom;
          this.colonia = vcol;
          this.municipio =vmuni;
          this.estado = vestado;
          this.pais = vpais;
          this.radio = vrad;
          this.telefono = vtel;
          this.celular = vcel;
          this.email = vemail;
          this.observaciones = vobser;
          this.mapa=vmapa    ;
          this.copostal = vcp;
        }
    }
}





