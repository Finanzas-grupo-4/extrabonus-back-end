﻿namespace ExtraBonus.API.BonusCenter.Domain.Models;

public class Result
{ 
    public int Id;

    public int Frecuencia { get; set; }  
    public int Capitalizacion { get; set; }  
    public int Periodo { get; set; } 
    public int TotalPeriodo { get; set; }  
    public double EfectivaAnual { get; set; }  
    public double Efectiva { get; set; } 
    public double Cok { get; set; } 
    public double CostoEmisor { get; set; }  
    public double CostoInversor { get; set; }  
    public double Utilidad { get; set; } 
    public double Duracion { get; set; }  
    public double Convexidad { get; set; } 
    public double Total { get; set; } 
    public double DuracionModif { get; set; } 
    public double Precio { get; set; }
    public int BondId { get; set; } 
    public Bond Bond { get; set; } 
}