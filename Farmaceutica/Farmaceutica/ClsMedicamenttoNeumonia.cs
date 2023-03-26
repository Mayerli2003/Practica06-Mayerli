using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica
{

    abstract class ClsPastillasNeumonia
    {
        public abstract string Nombre();
        public abstract string Componentes();
        public abstract string CantidadMG();
        public abstract double Precio();
        public abstract string Descuento();


    }


    interface IMedicamentoNeumnonia
    {
        string Clasificacion();
    }

    class Amoxicilina : ClsPastillasNeumonia, IMedicamentoNeumnonia
    {
        public override string CantidadMG()
        {
            return "500 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "gelatina, óxido de hierro amarillo (E-172), óxido de hierro rojo (E-172), dióxido de titanio (E-171)";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 0.55;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de Amoxicilina vale $0.55 cuantas pastillas desea comprar");

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
            return "  Amoxicilina ";
        }
    }


    class Cefalexina : ClsPastillasPresiónarterialalta, IMedicamentoPresiónarterialalta
    {
        public override string CantidadMG()
        {
            return "200 mg ";
        }

        public string Clasificacion()
        {
            return "Patillas";
        }

        public override string Componentes()
        {
            return "  celulosa microcristalina y estearato de magnesio ";
        }

        public override string Descuento()
        {
            return "0.20%";
        }

        public override double Precio()
        {
            return 0.95;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla  Cefalexina vale $0.95 cuantas  desea comprar");

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
            return " Cefalexina ";
        }
    }


    class Cefadroxilo : ClsPastillasPresiónarterialalta, IMedicamentoPresiónarterialalta
    {
        public override string CantidadMG()
        {
            return "250 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "  estearato de magnesio sílice coloidal anhidra  ";
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
            Console.WriteLine("- Cada pastilla de Cefadroxilo vale $0.85 cuantas pastillas desea comprar");

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
            return " Cefadroxilo ";
        }
    }


    class Cefaclor : ClsPastillasPresiónarterialalta, IMedicamentoPresiónarterialalta
    {
        public override string CantidadMG()
        {
            return "2000 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "  sacarosa, metilcelulosa, laurilsulfato de sodio, dimeticona, goma de xantano, almidón pregelatinizado, aroma artificial de fresa, eritrosina (E127) ";
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
            Console.WriteLine("- Cada pastilla de Cefaclor vale $0.75 cuantas pastillas desea comprar");

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
            return " Cefaclor ";
        }
    }

    //Inyecciones para la neumonia 
    abstract class ClsInyeccionNeumonia
    {
        public abstract string Nombre();
        public abstract string Componentes();
        public abstract string CantidadML();
        public abstract double Precio();
        public abstract string Descuento();


    }
    class piperacilina_y_tazobactam : ClsInyeccionNeumonia, IMedicamentoNeumnonia
    {
        public override string CantidadML()
        {
            return "10ml cada inyección";
        }

        public string Clasificacion()
        {
            return "Inyección";
        }

        public override string Componentes()
        {
            return " Cada vial contiene 4 g de piperacilina (como sal sódica) y 0,5 g de tazobactam (como sal sódica) ";
        }

        public override string Descuento()
        {
            return "20%";
        }

        public override double Precio()
        {
            return 6.50;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada inyección vale $6.50 cuantas inyecciones desea comprar");

            int cantidadInyeccion;



            Console.Write("Ingrese un número entero (cantidad que comprará): ");
            string entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out cantidadInyeccion) || cantidadInyeccion <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número entero y que sea mayor que 0.");
                Console.WriteLine("Ingrese un numero entero (cantidad que comprará):");
                entrada = Console.ReadLine();
            }
            double proceso = Precio() * cantidadInyeccion;
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
            return " piperacilina_y_tazobactam ";



        }
    }
}

