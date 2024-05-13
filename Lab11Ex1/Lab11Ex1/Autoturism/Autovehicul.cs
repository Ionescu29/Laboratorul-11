using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Ex1.Autoturism
{
    //Autovehiculele sunt caracterizate de model, id si o metoda ce va produce descrierea completa a
    //autovehiculului.Ele pot fi de mai multe tipuri
    internal class Autovehicul
    {
        private string id;
        private string model;
        private string tipulDeCombustibil;
        private int capacitateaRezervorului;
        private string combustibilIncarcat;
        private int cantitate;
        public Autovehicul(string id, string model, string tipulDeCombustibil, int capacitateaRezervorului, string combustibilIncarat, int cantitate)
        {
            this.id = id;
            this.model = model;
            this.tipulDeCombustibil = tipulDeCombustibil;
            this.capacitateaRezervorului = capacitateaRezervorului;
            this.combustibilIncarcat = combustibilIncarcat;
            this.cantitate = cantitate;
        }
        public void GetDescrpition()
        {
            Console.WriteLine(id , model, tipulDeCombustibil);
        }

        //Scrieti o metoda pentru alimentarea unui autovehicul
        //Metoda va primi ca parametru cantiatatea si tipul combustibilului incarcat
        //Aceasta metoda va fi apelata de catre cisterna, in procesul de alimentare
        //Un autovehicul nu va putea fi alimentat peste capacitatea maxima a rezervorului acestuia.
        //Un autovehicul nu va putea fi alimentat cu un combustibil incompatibil
        public void AlimentareVehicul()
        {
            if(tipulDeCombustibil==combustibilIncarcat)
            {
                Console.WriteLine($"Masina poate fi alimentata");
            }
            else
            {
                Console.WriteLine($"Masina nu poate fi alimentata");
            }
            if(cantitate>capacitateaRezervorului)
            {
                Console.WriteLine($"Masina nu poate fi alimentata");
            }
            else
            {
                Console.WriteLine($"Masina  poate fi aliemntata");
            }
        }
    }
}
