﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEISWS
{
    public class CabeceraSA
    {
        string var_id_muestra;
        string var_idTam;
        string var_tipo_muestra;

        public CabeceraSA(string id_muestra, string idTam, string tipo_muestra) {

            this.var_id_muestra = id_muestra;
            this.var_idTam = idTam;
            this.var_tipo_muestra = tipo_muestra;
        
        }

        public CabeceraSA() { }

      

        public string Id_Muestra
        {
            get { return var_id_muestra; }
            set { var_id_muestra = value; }
        }

        public string IdTam
        {
            get { return var_idTam; }
            set { var_idTam = value; }
        }

        public string Tipo_muestra
        {
            get { return var_tipo_muestra; }
            set { var_tipo_muestra = value; }
        }
       
       
    }
}