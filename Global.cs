using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppsRemesas
{
    class Global
    {
        public static List<Year> year = new List<Year>
        {
            new Year(1, 2000),
            new Year(2, 2001),
            new Year(3, 2002),
            new Year(4, 2003),
            new Year(5, 2004),
            new Year(6, 2005),
            new Year(7, 2006),
            new Year(8, 2007),
            new Year(9, 2008),
            new Year(10, 2009),
            new Year(11, 2010),
            new Year(12, 2011),
            new Year(13, 2012),
            new Year(14, 2013),
            new Year(15, 2014),
            new Year(16, 2015),
            new Year(17, 2016),
            new Year(18, 2017)
        };

        public static List<Meses> mes = new List<Meses>
        {
            new Meses(1,"Enero",19.8, 1),
            new Meses(2,"Febrero",20.8, 1),
            new Meses(3,"Marzo",23.4, 1),
            new Meses(4,"Abril",23.6, 1),
            new Meses(5,"Mayo",24.8, 1),
            new Meses(6,"Junio",25.2, 1),
            new Meses(7,"Julio",26.3, 1),
            new Meses(8,"Agosto",27.5, 1),
            new Meses(9,"Septiembre",29.4, 1),
            new Meses(10,"Octubre",29.9, 1),
            new Meses(11,"Noviembre",29.5, 1),
            new Meses(12,"Diciembre",39.8, 1),

            new Meses( 13,"Enero",25.1,2),
            new Meses( 14,"Febrero",24.7,2),   
            new Meses( 15,"Marzo",27.3,2),  
            new Meses( 16,"Abril",26.2,2), 
            new Meses( 17,"Mayo",27.6,2),  
            new Meses( 18,"Junio",25.2,2),
            new Meses( 19,"Julio",27.4,2), 
            new Meses( 20,"Agosto",30.4,2), 
            new Meses( 21,"Septiembre",29.5,2), 
            new Meses( 22,"Octubre",30.9,2),   
            new Meses( 23,"Noviembre",27.3,2), 
            new Meses( 24,"Diciember",34.1,2),

            new Meses( 25,"Enero",30.3,3),
            new Meses( 26,"Febrero",29,3),
            new Meses( 27,"Marzo",32.1,3),
            new Meses( 28,"Abril",32,3),
            new Meses( 29,"Mayo",33.5,3),
            new Meses( 30,"Junio",29.3,3),
            new Meses( 31,"Julio",29.1,3),
            new Meses( 32,"Agosto",30,3),
            new Meses( 33,"Septiembre",32.8,3),
            new Meses( 34,"Octubre",33.8,3),
            new Meses( 35,"Noviembre",29.4,3),
            new Meses( 36,"Diciember",35.2,3),

            new Meses( 37,"Enero",33.5,4),
            new Meses( 38,"Febrero",31.8,4),
            new Meses( 39,"Marzo",35.6,4),
            new Meses( 40,"Abril",33,4),
            new Meses( 41,"Mayo",36.2,4),
            new Meses( 42,"Junio",33.2,4),
            new Meses( 43,"Julio",36.4,4),
            new Meses( 44,"Agosto",38.1,4),
            new Meses( 45,"Septiembre",39.6,4),
            new Meses( 46,"Octubre",38.1,4),
            new Meses( 47,"Noviembre",38.2,4),
            new Meses( 48,"Diciember",45.1,4),

            new Meses( 49,"Enero",38,5),
            new Meses( 50,"Febrero",37.2,5),
            new Meses( 51,"Marzo",42.3,5),
            new Meses( 52,"Abril",40,5),
            new Meses( 53,"Mayo",43.4,5),
            new Meses( 54,"Junio",41.5,5),
            new Meses( 55,"Julio",43.2,5),
            new Meses( 56,"Agosto",43,5),
            new Meses( 57,"Septiembre",48.9,5),
            new Meses( 58,"Octubre",47.9,5),
            new Meses( 59,"Noviembre",46.1,5),
            new Meses( 60,"Diciember",47.3,5),

            new Meses( 61,"Enero",51.4,6),
            new Meses( 62,"Febrero",49.5,6),
            new Meses( 63,"Marzo",52.7,6),
            new Meses( 64,"Abril",48.8,6),
            new Meses( 65,"Mayo",52.3,6),
            new Meses( 66,"Junio",47.8,6),
            new Meses( 67,"Julio",49.8,6),
            new Meses( 68,"Agosto",48.6,6),
            new Meses( 69,"Septiembre",52.1,6),
            new Meses( 70,"Octubre",49.5,6),
            new Meses( 71,"Noviembre",50.8,6),
            new Meses( 72,"Diciember",62.4,6),

            new Meses( 73,"Enero",57.8,7),
            new Meses( 74,"Febrero",54.6,7),
            new Meses( 75,"Marzo",61.2,7),
            new Meses( 76,"Abril",54.7,7),
            new Meses( 77,"Mayo",60.2,7),
            new Meses( 78,"Junio",53.6,7),
            new Meses( 79,"Julio",57.1,7),
            new Meses( 80,"Agosto",58.1,7),
            new Meses( 81,"Septiembre",63.4,7),
            new Meses( 82,"Octubre",61.2,7),
            new Meses( 83,"Noviembre",52.9,7),
            new Meses( 84,"Diciember",62.7,7),

            new Meses( 85,"Enero",51.4,8), 
            new Meses( 86,"Febrero",52.6,8),  
            new Meses( 87,"Marzo",61.1,8), 
            new Meses( 88,"Abril",57.3,8), 
            new Meses( 89,"Mayo",63.9,8), 
            new Meses( 90,"Junio",59.9,8),
            new Meses( 91,"Julio",61.8,8), 
            new Meses( 92,"Agosto",65.2,8),
            new Meses( 93,"Septiembre",62.7,8),
            new Meses( 94,"Octubre",66.5,8),   
            new Meses( 95,"Noviembre",65.7,8),
            new Meses( 96,"Diciember",71.5,8),

            new Meses( 97,"Enero",60.8,9),  
            new Meses( 98,"Febrero",63.4,9),
            new Meses( 99,"Marzo",71.5,9), 
            new Meses( 100,"Abril",67.7,9),
            new Meses( 101,"Mayo",73.6,9), 
            new Meses( 102,"Junio",66.8,9),
            new Meses( 103,"Julio",66.9,9), 
            new Meses( 104,"Agosto",69.5,9),
            new Meses( 105,"Septiembre",70.8,9), 
            new Meses( 106,"Octubre",67.5,9),  
            new Meses( 107,"Noviembre",66.1,9), 
            new Meses( 108,"Diciember",73.5,9),

            new Meses( 109,"Enero",62.7,10),    
            new Meses( 110,"Febrero",62.8,10), 
            new Meses( 111,"Marzo",70.4,10), 
            new Meses( 112,"Abril",62.5,10),
            new Meses( 113,"Mayo",66.2,10), 
            new Meses( 114,"Junio",62.1,10),  
            new Meses( 115,"Julio",61.3,10), 
            new Meses( 116,"Agosto",60.7,10),  
            new Meses( 117,"Septiembre",62.2,10),   
            new Meses( 118,"Octubre",64.4,10), 
            new Meses( 119,"Noviembre",61.9,10), 
            new Meses( 120,"Diciember",71.2,10),

            new Meses( 121,"Enero",60.7,11), 
            new Meses( 122,"Febrero",64.1,11),
            new Meses( 123,"Marzo",77,11),  
            new Meses( 124,"Abril",63.8,11),  
            new Meses( 125,"Mayo",70.2,11), 
            new Meses( 126,"Junio",63.5,11), 
            new Meses( 127,"Julio",66.5,11), 
            new Meses( 128,"Agosto",66.5,11), 
            new Meses( 129,"Septiembre",67.9,11),  
            new Meses( 130,"Octubre",70.3,11),  
            new Meses( 131,"Noviembre",70.6,11),  
            new Meses( 132,"Diciember",81.7,11),

            new Meses( 133,"Enero",67.4,12),   
            new Meses( 134,"Febrero",69.3,12),
            new Meses( 135,"Marzo",77.5,12),   
            new Meses( 136,"Abril",73.4,12),    
            new Meses( 137,"Mayo",77.8,12), 
            new Meses( 138,"Junio",70,12),  
            new Meses( 139,"Julio",74.5,12),
            new Meses( 140,"Agosto",77.3,12),
            new Meses( 141,"Septiembre",74.8,12), 
            new Meses( 142,"Octubre",79.4,12), 
            new Meses( 143,"Noviembre",75.7,12), 
            new Meses( 144,"Diciember",94.5,12),

            new Meses( 145,"Enero",78.1,13), 
            new Meses( 146,"Febrero",82.3,13), 
            new Meses( 147,"Marzo",89.7,13),    
            new Meses( 148,"Abril",80.1,13),    
            new Meses( 149,"Mayo",85.2,13), 
            new Meses( 150,"Junio",78.9,13),  
            new Meses( 151,"Julio",80.9,13),  
            new Meses( 152,"Agosto",82.4,13),  
            new Meses( 153,"Septiembre",82.9,13), 
            new Meses( 154,"Octubre",87.3,13), 
            new Meses( 155,"Noviembre",82.8,13),  
            new Meses( 156,"Diciember",103.6,13),

            new Meses( 157,"Enero",83.4,14),   
            new Meses( 158,"Febrero",83.7,14), 
            new Meses( 159,"Marzo",90.2,14),   
            new Meses( 160,"Abril",90.7,14),   
            new Meses( 161,"Mayo",92.7,14), 
            new Meses( 162,"Junio",80.9,14),   
            new Meses( 163,"Julio",86.6,14),   
            new Meses( 164,"Agosto",88.6,14),  
            new Meses( 165,"Septiembre",90.5,14),  
            new Meses( 166,"Octubre",90.3,14), 
            new Meses( 167,"Noviembre",89.1,14), 
            new Meses( 168,"Diciember",111,14),

            new Meses( 169,"Enero",85.6,15),   
            new Meses( 170,"Febrero",90,15),   
            new Meses( 171,"Marzo",101.6,15),  
            new Meses( 172,"Abril",91.1,15),   
            new Meses( 173,"Mayo",98.5,15),
            new Meses( 174,"Junio",88.4,15),   
            new Meses( 175,"Julio",92.6,15),   
            new Meses( 176,"Agosto",92.2,15),  
            new Meses( 177,"Septiembre",94.7,15),
            new Meses( 178,"Octubre",93.5,15),
            new Meses( 179,"Noviembre",91,15), 
            new Meses( 180,"Diciember",116.6,15),

            new Meses( 181,"Enero",88.9,16),  
            new Meses( 182,"Febrero",94.1,16),  
            new Meses( 183,"Marzo",106.2,16), 
            new Meses( 184,"Abril",94.4,16),   
            new Meses( 185,"Mayo",104.9,16),   
            new Meses( 186,"Junio",93.1,16),    
            new Meses( 187,"Julio",97.6,16),   
            new Meses( 188,"Agosto",96.6,16),   
            new Meses( 189,"Septiembre",98.7,16),  
            new Meses( 190,"Octubre",102.6,16), 
            new Meses( 191,"Noviembre",95.7,16),  
            new Meses( 192,"Diciember",120.6,16),

            new Meses( 193,"Enero",91.2,17),  
            new Meses( 194,"Febrero",103.4,17), 
            new Meses( 195,"Marzo",107.7,17),   
            new Meses( 196,"Abril",103.5,17),  
            new Meses( 197,"Mayo",107.4,17),  
            new Meses( 198,"Junio",95.5,17),   
            new Meses( 199,"Julio",98.7,17),   
            new Meses( 200,"Agosto",107.9,17), 
            new Meses( 201,"Septiembre",106.3,17),
            new Meses( 202,"Octubre",108.1,17), 
            new Meses( 203,"Noviembre",104.3,17),  
            new Meses( 204,"Diciember",130.1,17),

            new Meses( 205,"Enero",102.1,18), 
            new Meses( 206,"Febrero",107.6,18), 
            new Meses( 207,"Marzo",113.6,18),  
            new Meses( 208,"Abril",108.4,18),   
            new Meses( 209,"Mayo",121.2,18),   
            new Meses( 210,"Junio",111.1,18),   
            new Meses( 211,"Julio",122.4,18),   
            new Meses( 212,"Agosto",120.4,18), 
            new Meses( 213,"Septiembre",112.8,18),  
            new Meses( 214,"Octubre",118.5,18), 
            new Meses( 215,"Noviembre",116,18), 
            new Meses( 216,"Diciember",136.7,18)
        };

        public static string conversion_Millones(double cantidad_remesa)
        {
            return formato_Numero(Math.Round(cantidad_remesa * 1000000));
        }

        public static string formato_Numero(double cantidad_Remesa)
        {
            string cadena_Cantidad_Remesa = cantidad_Remesa.ToString(), formato_Millone = "";
            int posicion = 0;

            for (int i = cadena_Cantidad_Remesa.Length - 1; i >= 0; i--)
            {
                if (posicion < 3)
                {
                    formato_Millone += cadena_Cantidad_Remesa[i];
                    posicion++;
                }
                else
                {
                    posicion = 1;
                    formato_Millone += " ";
                    formato_Millone += cadena_Cantidad_Remesa[i];
                }
            }

            return cadena_Espejo(formato_Millone);
        }

        private static string cadena_Espejo(string cantidad_Remesa)
        {
            string espejo_Cantidad_Remesa = "";

            for (int i = cantidad_Remesa.Length - 1; i >= 0; i--)
            {
                espejo_Cantidad_Remesa += cantidad_Remesa[i];
            }

            return espejo_Cantidad_Remesa;
        }

        public static int ranking(List<Meses> meses, int id_meses)
        {
            int posicion = 0, iterador = 0;
            meses = meses.OrderByDescending(x=>x.Cantidad_Remesa).ToList();

            foreach (Meses item in meses)
            {
                if (id_meses == item.Id)
                {
                    iterador++;
                    posicion = iterador;
                    break;
                }
                else
                    iterador++;
            }
            return posicion;
        }
    }

    public class Year
    {
        int id;
        int year;

        public Year(int id, int years)
        {
            this.Id = id;
            this.Years = years;
        }

        public int Id { get => id; set => id = value; }
        public int Years { get => year; set => year = value; }
    }

    public class Meses
    {
        int id;
        string nombre;
        double cantidad_Remesa;
        int id_Year;

        public Meses(int id, string nombre, double cantidad_Remesa, int id_Year)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cantidad_Remesa = cantidad_Remesa;
            this.Id_Year = id_Year;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Cantidad_Remesa { get => cantidad_Remesa; set => cantidad_Remesa = value; }
        public int Id_Year { get => id_Year; set => id_Year = value; }
    }
}