using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica
{
    abstract class ClsPastillaGripe
    {
        public abstract string Nombre();
        public abstract string Componentes();
        public abstract string CantidadMG();
        public abstract double Precio();
        public abstract string Descuento();
        

    }
    interface IMedicamentoGripe
    {
        string  Clasificacion();
    }
    class Acetaminofen : ClsPastillaGripe, IMedicamentoGripe
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
            return "paracetamol";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 0.25;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de acetaminofen vale $0.25 cuantas pastillas desea comprar");
           
            int cantidadPastilla;
            

            
            Console.Write("Ingrese un número entero (cantidad que comprará): ");
            string entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out cantidadPastilla)|| cantidadPastilla<=0)
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
            if(resultado < 0.0)
            {
                Console.WriteLine("Debe : $" + resultado);
            }
            if(resultado>= 0.0)
            {
                Console.WriteLine("Su vuelto es de: $" + resultado);

            }
            


        }

        public override string Nombre()
        {
            return" Acetaminofén";
        }
    }
    class Ibuprofeno : ClsPastillaGripe, IMedicamentoGripe
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
            return "ibuprofeno";
        }

        public override string Descuento()
        {
            return "10%";
        }

        public override double Precio()
        {
            return 0.50;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de ibuprofeno vale $0.50 cuantas pastillas desea comprar");

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
            return " Ibuprofeno";
        }
    }
    class Naxen : ClsPastillaGripe, IMedicamentoGripe
    {
        public override string CantidadMG()
        {
            return "10 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "naproxeno";
        }

        public override string Descuento()
        {
            return "20%";
        }

        public override double Precio()
        {
            return 0.75;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de naxen vale $0.75 cuantas pastillas desea comprar");

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
            return " Naxen";
        }
    }
    class DolexGripa : ClsPastillaGripe, IMedicamentoGripe
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
            return "paracetamol, fenilefrina, clorfenamina y dextrometorfano";
        }

        public override string Descuento()
        {
            return "5%";
        }

        public override double Precio()
        {
            return 1.00;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de dolox gripa vale $1.00 cuantas pastillas desea comprar");

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
            double descuento = proceso * 0.05;
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
            return " Dolex Gripa";
        }
    }
    class GelocatilGripa : ClsPastillaGripe, IMedicamentoGripe
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
            return "paracetamol, fenilefrina, clorfenamina y cafeína";
        }

        public override string Descuento()
        {
            return "15%";
        }

        public override double Precio()
        {
            return 0.60;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de gelocatil gripa vale $0.60 cuantas pastillas desea comprar");

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
            return " Gelocatil gripa";
        }
    }
    class Mucosolvan : ClsPastillaGripe, IMedicamentoGripe
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
            return "ambroxol";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 0.60;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de mucosolvan vale $0.60 cuantas pastillas desea comprar");

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
            return " Mucosolvan";
        }
    }
    class Nastizol : ClsPastillaGripe, IMedicamentoGripe
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
            return "clorfenamina, fenilefrina y paracetamol";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 0.70;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de nastizol vale $0.70 cuantas pastillas desea comprar");

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
            return " Nastizol";
        }
    }
    
    class Tabcin : ClsPastillaGripe, IMedicamentoGripe
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
            return "paracetamol, fenilefrina y clorfenamina";
        }

        public override string Descuento()
        {
            return "15%";
        }

        public override double Precio()
        {
            return 0.50;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de tabcin vale $0.50 cuantas pastillas desea comprar");

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
            return " Tabcin";
        }
    }
    //Inyecciones pra la gripe
    abstract class ClsInyeccionGripe
    {
        public abstract string Nombre();
        public abstract string Componentes();
        public abstract string CantidadML();
        public abstract double Precio();
        public abstract string Descuento();


    }
    class TIV : ClsInyeccionGripe,IMedicamentoGripe
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
            return "contiene tres cepas de virus de la gripe, dos cepas de la influenza A (H1N1 y H3N2) y una cepa de la influenza B.";
        }

        public override string Descuento()
        {
            return "15%";
        }

        public override double Precio()
        {
            return 5.50;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada inyección vale $5.50 cuantas inyecciones desea comprar");

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
            return " Vacuna contra la gripe trivalente (TIV)";
        }
    }
    class QIV : ClsInyeccionGripe, IMedicamentoGripe
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
            return "contiene cuatro cepas de virus de la gripe, dos cepas de la influenza A (H1N1 y H3N2) y dos cepas de la influenza B.";
        }

        public override string Descuento()
        {
            return "25%";
        }

        public override double Precio()
        {
            return 7.00;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada inyección vale $7.00 cuantas inyecciones desea comprar");

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
            return "Vacuna contra la gripe cuadrivalente(QIV)";
        }
    }
    class IIV : ClsInyeccionGripe, IMedicamentoGripe
    {
        public override string CantidadML()
        {
            return "15ml cada inyección";
        }

        public string Clasificacion()
        {
            return "Inyección";
        }

        public override string Componentes()
        {
            return "contiene partículas de virus inactivas que estimulan una respuesta inmune. Esta vacuna puede ser trivalente o cuadrivalente.";
        }

        public override string Descuento()
        {
            return "10%";
        }

        public override double Precio()
        {
            return 4.00;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada inyección vale $4.00 cuantas inyecciones desea comprar");

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
            return " Vacuna contra la gripe de virus fraccionados inactivados (IIV)";
        }
    }
    class LAIV : ClsInyeccionGripe, IMedicamentoGripe
    {
        public override string CantidadML()
        {
            return "20ml cada inyección";
        }

        public string Clasificacion()
        {
            return "Inyección";
        }

        public override string Componentes()
        {
            return "contiene virus vivos debilitados que estimulan una respuesta inmune. Esta vacuna solo está disponible en forma de aerosol nasal y es solo para personas sanas entre 2 y 49 años de edad.";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 6.00;
        }

        public void comprar()
        {
            Console.WriteLine("- Cada inyección vale $6.00 cuantas inyecciones desea comprar");

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
            return " Vacuna de virus vivos atenuados (LAIV)";
        }
    }
    //pomadas y productos para la gripe
    abstract class ClsPomadaGripe
    {
        public abstract string Nombre();
        public abstract string Componentes();
        public abstract string CantidadGramos();
        public abstract double Precio();
        public abstract string Descuento();


    }
    class VicksVapoRub : ClsPomadaGripe, IMedicamentoGripe
    {
        public override string CantidadGramos()
        {
            return "100 gramos cada recipiente de pomada";
        }

        public string Clasificacion()
        {
            return "Pomada";
        }

        public override string Componentes()
        {
            return "contiene mentol, alcanfor y aceite de eucalipto, y se aplica directamente en el pecho y la garganta.";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 1.00;
        }

        public void comprar()
        {
            Console.WriteLine("- Cada pomada vale $1.00 cuantas pomadas desea comprar");

            int cantidadPomada;



            Console.Write("Ingrese un número entero (cantidad que comprará): ");
            string entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out cantidadPomada) || cantidadPomada <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número entero y que sea mayor que 0.");
                Console.WriteLine("Ingrese un numero entero (cantidad que comprará):");
                entrada = Console.ReadLine();
            }

            double proceso = Precio() * cantidadPomada;
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
            return " Vicks VapoRub ";
        }
    }
    class PomadaMentolEucalipto : ClsPomadaGripe, IMedicamentoGripe
    {
        public override string CantidadGramos()
        {
            return "200 gramos cada recipiente de pomada";
        }

        public string Clasificacion()
        {
            return "Pomada";
        }

        public override string Componentes()
        {
            return "contiene mentol y aceite de eucalipto, y se aplica directamente en la nariz para aliviar la congestión.";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 3.00;
        }

        public void comprar()
        {
            Console.WriteLine("- Cada pomada vale $3.00 cuantas pomadas desea comprar");

            int cantidadPomada;



            Console.Write("Ingrese un número entero (cantidad que comprará): ");
            string entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out cantidadPomada) || cantidadPomada <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número entero y que sea mayor que 0.");
                Console.WriteLine("Ingrese un numero entero (cantidad que comprará):");
                entrada = Console.ReadLine();
            }

            double proceso = Precio() * cantidadPomada;
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
            return " Pomada de mentol y eucalipto";
        }
    }
}
