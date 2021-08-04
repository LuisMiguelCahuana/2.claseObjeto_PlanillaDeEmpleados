﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.claseObjeto_PlanillaDeEmpleados
{
    public class Planilla
    {
        // Atributos
        public string empleado { get; set; }
        public string cargo { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int años { get; set; }

        // Metodos
        public int añosServicio()
        {
            return DateTime.Now.Year - fechaIngreso.Year;
        }
        public string mesConsultado()
        {
            int mes = DateTime.Now.Month; ;
            switch (mes)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Setiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
            }
            return "";
        }
        // Determinar el sueldo basico
        public double DeterminaBasico()
        {
            switch (cargo)
            {
                case "Coordinador": return 2000;
                case "Jefe": return 4000;
                case "Capacitador": return 2500;
                case "Asistente": return 1200;
            }
            return 0;
        }
        // Determina el monto de gratificacion
        public double determinaGratificacion()
        {
            if (mesConsultado() == "Abril")
                return 400;
            else if (mesConsultado() == "Julio")
                return 450;
            else if (mesConsultado() == "Diciembre")
                return DeterminaBasico() * 2;
            return 0;
        }
        // Determina la comision
        public double determinaComision()
        {
            if (cargo == "Asistente")
                return 100;
            else if (cargo == "Coordinador")
                return 200;
            return 0;
        }
        // Determinar el descuento AFP
        public double determinarDescuentoAFP()
        {
            return 0.12 * DeterminaBasico();
        }
        // Determina el descuento por cooperativa
        public double determinaDescuentoCooperativa()
        {
            if (cargo == "Jefe")
                return 5.0 / 100 * DeterminaBasico();
            else if (cargo == "Capacitador")
                return 2.0 / 100 * DeterminaBasico();
            return 0;
        }
        // Determinar aportaciones por seguro social
        public double determinaAportacionSeguro()
        {
            return 0.05 * DeterminaBasico();
        }
        // Calculando los totales
        public double calculaTotalIngresos()
        {
            return DeterminaBasico() + determinaGratificacion() + determinaComision();
        }
        public double calculaTotalDescuentos()
        {
            return determinarDescuentoAFP() + determinaDescuentoCooperativa();
        }
        public double calculaTotalAportaciones()
        {
            return determinaAportacionSeguro();
        }
        // Determinar el total neto
        public double determinaNeto()
        {
            return calculaTotalIngresos() - calculaTotalDescuentos() - calculaTotalAportaciones();
        }
    }
}
