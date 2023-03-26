using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica
{
    abstract class ClsPastillaDiabetes
    {
        public abstract string Nombre();
        public abstract string Componentes();
        public abstract string CantidadMG();
        public abstract double Precio();
        public abstract string Descuento();
    }
    interface IMedicamentoDiabetes
    {
        string Clasificacion();
    }
    class Metformina : ClsPastillaDiabetes, IMedicamentoDiabetes
    {
        public override string CantidadMG()
        {
            return "210 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "es un medicamento que ayuda a reducir el azúcar en la sangre al disminuir la producción de glucosa en el hígado y mejorar la sensibilidad a la insulina. Algunos nombres comerciales incluyen Glucophage, Riomet y Fortamet.\r\n\r\n";
        }

        public override string Descuento()
        {
            return "No tiene descuento";
        }

        public override double Precio()
        {
            return 1.55;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de metformina vale $1.55 cuantas pastillas desea comprar");

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
            return " Metformina";
        }
    }
    class Sulfonilureas : ClsPastillaDiabetes, IMedicamentoDiabetes
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
            return "son un tipo de medicamento que estimulan el páncreas para producir más insulina. Algunos nombres comerciales incluyen Glipizide, Glyburide y Glibenclamida.";
        }

        public override string Descuento()
        {
            return "10%";
        }

        public override double Precio()
        {
            return 1.40;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de sulfonilureas vale $1.40 cuantas pastillas desea comprar");

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
            return " Sulfonilureas";
        }
    }
    class Meglitinidas : ClsPastillaDiabetes, IMedicamentoDiabetes
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
            return "también ayudan a estimular la producción de insulina por parte del páncreas. Algunos nombres comerciales incluyen Repaglinida y Nateglinida.";
        }

        public override string Descuento()
        {
            return "25%";
        }

        public override double Precio()
        {
            return 1.05;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de meglitinidas vale $1.05 cuantas pastillas desea comprar");

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
            return " Meglitinidas";
        }
    }
    class InhibidoresDPP : ClsPastillaDiabetes, IMedicamentoDiabetes
    {
        public override string CantidadMG()
        {
            return "110 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "reducen la cantidad de glucosa producida por el hígado y ayudan a regular los niveles de insulina en el cuerpo. Algunos nombres comerciales incluyen Sitagliptina y Saxagliptina.";
        }

        public override string Descuento()
        {
            return "55%";
        }

        public override double Precio()
        {
            return 3.00;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de Inhibidores de la dipeptidil peptidasa-4 (DPP-4) vale $3.00 cuantas pastillas desea comprar");

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
            return " Inhibidores de la dipeptidil peptidasa-4 (DPP-4)";
        }
    }
    class InhibidoresSGLT2 : ClsPastillaDiabetes, IMedicamentoDiabetes
    {
        public override string CantidadMG()
        {
            return "520 mg por pastilla";
        }

        public string Clasificacion()
        {
            return "Pastillas";
        }

        public override string Componentes()
        {
            return "aumentan la eliminación de glucosa en la orina, lo que disminuye los niveles de azúcar en la sangre. Algunos nombres comerciales incluyen Canagliflozina y Empagliflozina.";
        }

        public override string Descuento()
        {
            return "15%";
        }

        public override double Precio()
        {
            return 1.80;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada pastilla de Inhibidores del cotransportador de sodio-glucosa tipo 2 (SGLT2) vale $1.80 cuantas pastillas desea comprar");

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
            return " Inhibidores del cotransportador de sodio-glucosa tipo 2 (SGLT2)";
        }
    }
    
    //inyecciones para la diabetes 
    abstract class ClsInyeccionDiabetes
    {
        public abstract string Nombre();
        public abstract string Componentes();
        public abstract string CantidadML();
        public abstract double Precio();
        public abstract string Descuento();


    }
    class Insulina : ClsInyeccionDiabetes, IMedicamentoDiabetes
    {
        public override string CantidadML()
        {
            return "54 ml cada inyección";
        }

        public string Clasificacion()
        {
            return "Inyección";
        }

        public override string Componentes()
        {
            return "la insulina es una hormona que ayuda a controlar los niveles de azúcar en la sangre. Se administra a través de una inyección subcutánea. Hay varios tipos de insulina, que se clasifican según su velocidad de acción y duración. Algunos nombres comerciales incluyen Humulin, Novolin, Lantus y Humalog.";
        }

        public override string Descuento()
        {
            return "10%";
        }

        public override double Precio()
        {
            return 4.60;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada inyección vale $4.60 cuantas inyecciones desea comprar");

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
            return " Insulina";
        }
    }
    class InhibidoresDipeptidilDPP : ClsInyeccionDiabetes, IMedicamentoDiabetes
    {
        public override string CantidadML()
        {
            return "20 ml cada inyección";
        }

        public string Clasificacion()
        {
            return "Inyección";
        }

        public override string Componentes()
        {
            return "se pueden administrar por inyección y ayudan a regular los niveles de azúcar en la sangre al disminuir la cantidad de glucosa producida por el hígado y aumentar la producción de insulina. Algunos nombres comerciales incluyen Byetta y Victoza.";
        }

        public override string Descuento()
        {
            return "35%";
        }

        public override double Precio()
        {
            return 8.00;
        }
        public void comprar()
        {
            Console.WriteLine("- Cada inyección vale $8.00 cuantas inyecciones desea comprar");

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
            double descuento = proceso * 0.35;
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
    class Glucagon : ClsInyeccionDiabetes, IMedicamentoDiabetes
    {
        public override string CantidadML()
        {
            return "25 ml cada inyección";
        }

        public string Clasificacion()
        {
            return "Inyección";
        }

        public override string Componentes()
        {
            return "es una hormona que se usa para tratar la hipoglucemia (bajos niveles de azúcar en la sangre). Se administra por inyección subcutánea o intramuscular y ayuda a aumentar los niveles de azúcar en la sangre. Algunos nombres comerciales incluyen GlucaGen y Baqsimi.\r\n\r\nEs importante recordar que estos medicamentos deben ser prescritos y supervisados por un médico, ya que cada persona tiene necesidades y condiciones médicas únicas que pueden afectar su tratamiento.\r\n\r\n\r\n\r\n\r\n\r\n";
        }

        public override string Descuento()
        {
            return "5%";
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
            return " Glucagón";
        }
    } 

}
