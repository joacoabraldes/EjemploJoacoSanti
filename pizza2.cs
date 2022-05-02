using System;

namespace Pizza.API.Models {
    public class Pizza {
        public int      Id              { get; set; }
        public string   Nombre          { get; set; } // aca es ...
        public bool     LibreGluten     { get; set; }
        public float    Importe         { get; set; }
        public string   Descripcion     { get; set; }
    }
}
