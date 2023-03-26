using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica
{
    abstract class ClsPastillasPresiónarterialalta
    {
        public abstract string Nombre();
        public abstract string Componentes();
        public abstract string CantidadMG();
        public abstract double Precio();
        public abstract string Descuento();


    }


    interface IMedicamentoPresiónarterialalta
    {
        string Clasificacion();
    }

    class Diuréticos : ClsPastillasPresiónarterialalta, IMedicamentoPresiónarterialalta
    {
        public override string CantidadMG()
        {
            return "50 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "clortalidona, la hidroclorotiazida (Microzide)";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 0.50;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de Presiónarterialalta vale $0.50 cuantas pastillas desea comprar");

            int cantidadPastilla;



            Console.Write("Ingrese un número entero (cantidad que comprará): ");
            string entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out cantidadPastilla) || cantidadPastilla <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número entero y que sea mayor que 0.");
                Console.WriteLine("Ingrese un numero entero (cantidad que comprará):");
                entrada = Console.ReadLine();
            }

            double proceso = Precio() * cantidadPastilla;
            Console.WriteLine("La cantidad a pagar es de : $" + proceso);
            Console.WriteLine("Efectivo con el que cancelara:");
            double efectivo;

            string dato = Console.ReadLine();

            while (!double.TryParse(dato, out efectivo) || efectivo <= 0.0)
            {
                Console.WriteLine("Error: Debe ingresar un número y que sea mayor que 0.");
                entrada = Console.ReadLine();
            }
            double resultado = efectivo - proceso;
            if (resultado < 0.0)
            {
                Console.WriteLine("Debe : $" + resultado);
            }
            if (resultado >= 0.0)
            {
                Console.WriteLine("Su vuelto es de: $" + resultado);

            }



        }

        public override string Nombre()
        {
            return "  Diuréticos ";
        }
    }


    class Inhibidores_de_la_enzima_convertidora_de_la_angiotensina : ClsPastillasPresiónarterialalta, IMedicamentoPresiónarterialalta
    {
        public override string CantidadMG()
        {
            return "100 mg ";
        }

        public string Clasificacion()
        {
            return "Patillas";
        }

        public override string Componentes()
        {
            return " lisinopril (Prinivil, Zestril), el benazepril (Lotensin), el captoril ";
        }

        public override string Descuento()
        {
            return "0.10%";
        }

        public override double Precio()
        {
            return 0.75;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada bote de Contrairritantes vale $3.75 cuantas  desea comprar");

            int cantidaGuento;



            Console.Write("Ingrese un número entero (cantidad que comprará): ");
            string entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out cantidaGuento) || cantidaGuento <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número entero y que sea mayor que 0.");
                Console.WriteLine("Ingrese un numero entero (cantidad que comprará):");
                entrada = Console.ReadLine();
            }
            double proceso = Precio() * cantidaGuento;
            double descuento = proceso * 0.10;
            double pagar = proceso - descuento;
            Console.WriteLine("La cantidad a pagar es de : $" + pagar);
            Console.WriteLine("Efectivo con el que cancelara:");
            double efectivo;

            string dato = Console.ReadLine();

            while (!double.TryParse(dato, out efectivo) || efectivo <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número y que sea mayor que 0.");
                entrada = Console.ReadLine();
            }
            double total = efectivo - pagar;
            if (total < 0.0)
            {
                Console.WriteLine("Debe : $" + total);
            }
            if (total >= 0.0)
            {
                Console.WriteLine("Su vuelto es de: $" + total);

            }

        }

        public override string Nombre()
        {
            return " Inhibidores_de_la_enzima_convertidora_de_la_angiotensina ";
        }
    }


    class AntagonistasdereceptoresdeangiotensinaII : ClsPastillasPresiónarterialalta, IMedicamentoPresiónarterialalta
    {
        public override string CantidadMG()
        {
            return "50 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "  candesartán (Atacand), el losartán (Cozaar)  ";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 0.85;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de esteroides vale $0.75 cuantas pastillas desea comprar");

            int cantidadPastilla;



            Console.Write("Ingrese un número entero (cantidad que comprará): ");
            string entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out cantidadPastilla) || cantidadPastilla <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número entero y que sea mayor que 0.");
                Console.WriteLine("Ingrese un numero entero (cantidad que comprará):");
                entrada = Console.ReadLine();
            }

            double proceso = Precio() * cantidadPastilla;

            Console.WriteLine("La cantidad a pagar es de : $" + proceso);
            Console.WriteLine("Efectivo con el que cancelara:");
            double efectivo;

            string dato = Console.ReadLine();

            while (!double.TryParse(dato, out efectivo) || efectivo <= 0.0)
            {
                Console.WriteLine("Error: Debe ingresar un número y que sea mayor que 0.");
                entrada = Console.ReadLine();
            }
            double resultado = efectivo - proceso;
            if (resultado < 0.0)
            {
                Console.WriteLine("Debe : $" + resultado);
            }
            if (resultado >= 0.0)
            {
                Console.WriteLine("Su vuelto es de: $" + resultado);

            }



        }

        public override string Nombre()
        {
            return " AntagonistasdereceptoresdeangiotensinaII ";
        }
    }


    class Bloqueadores_delos_canales_de_calcio : ClsPastillasPresiónarterialalta, IMedicamentoPresiónarterialalta
    {
        public override string CantidadMG()
        {
            return "50 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "  el diltiazem (Cardizem, Tiazac y otros) ";
        }

        public override string Descuento()
        {
            return "0.10";
        }

        public override double Precio()
        {
            return 0.90;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de esteroides vale $0.75 cuantas pastillas desea comprar");

            int cantidadPastilla;



            Console.Write("Ingrese un número entero (cantidad que comprará): ");
            string entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out cantidadPastilla) || cantidadPastilla <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número entero y que sea mayor que 0.");
                Console.WriteLine("Ingrese un numero entero (cantidad que comprará):");
                entrada = Console.ReadLine();
            }

            double proceso = Precio() * cantidadPastilla;
            double descuento = proceso * 0.10;
            double pagar = proceso - descuento;
            Console.WriteLine("La cantidad a pagar es de : $" + proceso);
            Console.WriteLine("Efectivo con el que cancelara:");
            double efectivo;

            string dato = Console.ReadLine();

            while (!double.TryParse(dato, out efectivo) || efectivo <= 0.0)
            {
                Console.WriteLine("Error: Debe ingresar un número y que sea mayor que 0.");
                entrada = Console.ReadLine();
            }
            double resultado = efectivo - proceso;
            if (resultado < 0.0)
            {
                Console.WriteLine("Debe : $" + resultado);
            }
            if (resultado >= 0.0)
            {
                Console.WriteLine("Su vuelto es de: $" + resultado);

            }



        }

        public override string Nombre()
        {
            return " Bloqueadores_delos_canales_de_calcio ";
        }
    }
}
