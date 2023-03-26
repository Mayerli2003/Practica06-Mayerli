using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica
{
    abstract class ClsPastillasArtritis
    {
        public abstract string Nombre();
        public abstract string Componentes();
        public abstract string CantidadMG();
        public abstract double Precio();
        public abstract string Descuento();


    }


    interface IMedicamentoArtritis
    {
        string Clasificacion();
    }


    class Anti_inflamatoriosno_esteroides : ClsPastillasArtritis, IMedicamentoArtritis
    {
        public override string CantidadMG()
        {
            return "200 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "ibuprofeno (Advil, Motrin IB, otros) y el naproxeno sódico (Aleve)";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 0.65;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de Anti_inflamatoriosno_esteroides vale $0.65 cuantas pastillas desea comprar");

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
            return " Anti_inflamatoriosno_esteroides ";
        }
    }


    class Contrairritantes : ClsPastillasArtritis, IMedicamentoArtritis
    {
        public override string CantidadMG()
        {
            return "200 g ";
        }

        public string Clasificacion()
        {
            return "Guento";
        }

        public override string Componentes()
        {
            return "mentol o capsaicina";
        }

        public override string Descuento()
        {
            return "20%";
        }

        public override double Precio()
        {
            return 3.75;
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
            double descuento = proceso * 0.20;
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
            return " Contrairritantes ";
        }
    }


    class Esteroides : ClsPastillasArtritis, IMedicamentoArtritis
    {
        public override string CantidadMG()
        {
            return "100 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "  vitaminas y hormonas formando cuatro anillos fusionados, tres con seis átomos y uno con cinco; posee en total 17 átomos de carbono";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 0.75;
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
            return " Esteroides ";
        }
    }


    class Medicamentos_antirreumáticos_modificadores_de_enfermedad : ClsPastillasArtritis, IMedicamentoArtritis
    {
        public override string CantidadMG()
        {
            return "150 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "  metotrexato (Trexall, Otrexup, otros), la leflunomida (Arava), la hidroxicloroquina (Plaquenil) y la sulfasalazina (Azulfidine) ";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 0.80;
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
            return " Medicamentos_antirreumáticos_modificadores_de_enfermedad ";
        }
    }

}
