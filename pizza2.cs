using System;

namespace Pizza.API.Models {
    public class Pizza {
        public int      Id              { get; set; }
        public string   Nombre          { get; set; }
        public bool     LibreGlutens    { get; set; }
        public float    Importe         { get; set; }
        public string   Descripcion     { get; set; }
        public string   Observaciones   { get; set; } //es
    }
}