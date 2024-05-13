using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Ex1.Cisterna
{
    //O cisterna poate pune la dispozitia clientilor mai multe tipuri de combustibil (benzina, diesel, GPL, electricitate)
    internal class Cisterna
    {
        private string tipulCombustibilului;
        private int cantitateaDeCombustibil;
        private string tipulCombustibilului;
        private int capacitateaRezervorului;
        private string combustibilIncarcat;
        public Cisterna (string tipulCombustibilului, int cantitateaDeCombustibil, string tipulCombustibilului, int capacitateaRezervorului, string combustibilIncarcat)
        {
            this.tipulCombustibilului = tipulCombustibilului;
            this.cantitateaDeCombustibil = cantitateaDeCombustibil;
            this.tipulCombustibilului = tipulCombustibilului;
            this.capacitateaRezervorului = capacitateaRezervorului;
            this.combustibilIncarcat = combustibilIncarcat;
        }
        //Scrieti o metoda pentru incarcare, care va primi ca parametri cantitatea pentru incarcat precum
        //si tipul combustibilului incarcat
        //Cisterna nu poate fi incarcata peste capacitatea maxima.
        //Cisterna nu poate fi incarcata cu un combustibil diferit fata de cel deja incarcat.

        public void Incarcarea()
        {
            if(cantitateaDeCombustibil>capacitateaRezervorului)
            {
                Console.WriteLine($"Cisterna nu poate fi incarcata");
            }
            else
            {
                Console.WriteLine($"Csterna poate fi incarcata");
            }
            if(tipulCombustibilului!=combustibilIncarcat)
            {
                Console.WriteLine($"Cisterna nu poate fi incarcata");
            }
        }
        //Cisterna va putea alimenta orice autovehicul. Scrieti o metoda pentru incarcarea unui
        //autovehicul, care va primi ca parametru o referinta spre autovehicul precum si cantitatea de
        //combustibil dorita.
        //Metoda cisternei va apela metoda „alimenteaza” a autovehiculului.
        //Tratati situatiile in care incarcarea nu ar fi posibila din perspectiva cisternei.
       
    }
}
