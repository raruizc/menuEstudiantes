﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    public class Alumno
    {
        
         // String[] misStrings = new String[10 n 50, 100]
         //string, boolean, int, double, float... tipos primitivos 
         // 
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        public double NotaFinal { get; set; }
        public string NotaConcepto { get; set; }
    }
    
}
