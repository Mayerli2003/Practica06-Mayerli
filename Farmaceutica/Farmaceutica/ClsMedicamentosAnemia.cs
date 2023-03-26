using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica
{
    abstract class ClsPastillaAnemia
    {
        public abstract string Nombre();
        public abstract string Componentes();
        public abstract string CantidadMG();
        public abstract double Precio();
        public abstract string Descuento();
    }
    interface IMedicamentoAnemia
    {
        string Clasificacion();
    }
    class FerrousSulfate : ClsPastillaAnemia, IMedicamentoAnemia
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
            return "esta pastilla contiene hierro, que es esencial para la producción de glóbulos rojos.";
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
            Console.WriteLine("- Cada pastilla de ferrous sulfate vale $0.55 cuantas pastillas desea comprar");

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
            return " Ferrous Sulfate";
        }
    }
    class FerrousGluconate : ClsPastillaAnemia, IMedicamentoAnemia
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
            return "al igual que Ferrous Sulfate, esta pastilla también contiene hierro";
        }

        public override string Descuento()
        {
            return "10%";
        }

        public override double Precio()
        {
            return 0.40;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de ferrous gluconate vale $0.40 cuantas pastillas desea comprar");

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
            Console.WriteLine("La cantidad a pagar es de : $" + pagar);
            Console.WriteLine("Efectivo con el que cancelara:");
            double efectivo;

            string dato = Console.ReadLine();

            while (!double.TryParse(dato, out efectivo) || efectivo <= 0.0)
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
            return " Ferrous Gluconate";
        }
    }
    class FerrousFumarate : ClsPastillaAnemia, IMedicamentoAnemia
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
            return "esta pastilla también contiene hierro y se usa para tratar la anemia por deficiencia de hierro";
        }

        public override string Descuento()
        {
            return "25%";
        }

        public override double Precio()
        {
            return 0.75;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de ferrous fumarate vale $0.75 cuantas pastillas desea comprar");

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
            double descuento = proceso * 0.25;
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
            return " Ferrous Fumarate";
        }
    }
    class Polysaccharide : ClsPastillaAnemia, IMedicamentoAnemia
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
            return "contiene hierro y se usa para tratar la anemia por deficiencia de hierro";
        }

        public override string Descuento()
        {
            return "55%";
        }

        public override double Precio()
        {
            return 2.00;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de polysaccharide iron complex vale $2.00 cuantas pastillas desea comprar");

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
            double descuento = proceso * 0.55;
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
            return " Polysaccharide Iron Complex";
        }
    }
    class VitaminB12 : ClsPastillaAnemia, IMedicamentoAnemia
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
            return "esta pastilla contiene vitamina B12, que es necesaria para la producción de glóbulos rojos";
        }

        public override string Descuento()
        {
            return "15%";
        }

        public override double Precio()
        {
            return 0.70;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de vitamin B12 vale $0.70 cuantas pastillas desea comprar");

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
            double descuento = proceso * 0.15;
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
            return " Vitamin B12";
        }
    }
    class FolicAcid : ClsPastillaAnemia, IMedicamentoAnemia
    {
        public override string CantidadMG()
        {
            return "20 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "también conocido como ácido fólico, es una vitamina B que es esencial para la producción de glóbulos rojos";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 1.60;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de folic acid vale $1.60 cuantas pastillas desea comprar");

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

            while (!double.TryParse(dato, out efectivo) || efectivo <= 0)
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
            return " Folic Acid";
        }
    }
    class VitaminC : ClsPastillaAnemia, IMedicamentoAnemia
    {
        public override string CantidadMG()
        {
            return "12 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "esta vitamina puede ayudar a mejorar la absorción de hierro y a aumentar la cantidad de glóbulos rojos en la sangre";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 1.70;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de vitamin C vale $1.70 cuantas pastillas desea comprar");

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

            while (!double.TryParse(dato, out efectivo) || efectivo <= 0)
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
            return " Vitamin C";
        }
    }

    class VitaminE : ClsPastillaAnemia, IMedicamentoAnemia
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
            return "esta vitamina puede ayudar a proteger las células sanguíneas y prevenir la ruptura de los glóbulos rojos";
        }

        public override string Descuento()
        {
            return "15%";
        }

        public override double Precio()
        {
            return 2.00;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de vitamin E vale $2.00 cuantas pastillas desea comprar");

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
            double descuento = proceso * 0.15;
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
            return " Vitamin E";
        }
    }
    //inyecciones para la anemia 
    abstract class ClsInyeccionAnemia
    {
        public abstract string Nombre();
        public abstract string Componentes();
        public abstract string CantidadML();
        public abstract double Precio();
        public abstract string Descuento();


    }
    class HierroIntravenoso : ClsInyeccionAnemia, IMedicamentoAnemia
    {
        public override string CantidadML()
        {
            return "5ml cada inyección";
        }

        public string Clasificacion()
        {
            return "Inyección";
        }

        public override string Componentes()
        {
            return "la inyección de hierro intravenoso se utiliza para tratar la anemia por deficiencia de hierro que no puede ser tratada adecuadamente con pastillas orales. La inyección se administra directamente en una vena y puede ser necesaria en casos graves de anemia.";
        }

        public override string Descuento()
        {
            return "15%";
        }

        public override double Precio()
        {
            return 5.60;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada inyección vale $5.60 cuantas inyecciones desea comprar");

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
            double descuento = proceso * 0.15;
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
            return " Hierro intravenoso";
        }
    }
    class Eritropoyetina : ClsInyeccionAnemia, IMedicamentoAnemia
    {
        public override string CantidadML()
        {
            return "14 ml cada inyección";
        }

        public string Clasificacion()
        {
            return "Inyección";
        }

        public override string Componentes()
        {
            return "la eritropoyetina es una hormona que estimula la producción de glóbulos rojos en la médula ósea. Se administra en forma de inyección y se usa para tratar la anemia asociada con enfermedades crónicas como la enfermedad renal crónica y el cáncer.";
        }

        public override string Descuento()
        {
            return "25%";
        }

        public override double Precio()
        {
            return 9.00;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada inyección vale $9.00 cuantas inyecciones desea comprar");

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
            double descuento = proceso * 0.25;
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
            return " Eritropoyetina";
        }
    }
    class VitaminaB12 : ClsInyeccionAnemia, IMedicamentoAnemia
    {
        public override string CantidadML()
        {
            return "15 ml cada inyección";
        }

        public string Clasificacion()
        {
            return "Inyección";
        }

        public override string Componentes()
        {
            return "la vitamina B12 es necesaria para la producción de glóbulos rojos y la inyección de vitamina B12 se utiliza para tratar la anemia por deficiencia de B12.";
        }

        public override string Descuento()
        {
            return "10%";
        }

        public override double Precio()
        {
            return 3.00;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada inyección vale $3.00 cuantas inyecciones desea comprar");

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
            return " Vitamina B12";
        }
    }
}
