using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Instancias de las pastillas para la gripe
            Acetaminofen acetaminofen = new Acetaminofen();
            Ibuprofeno ibuprofeno = new Ibuprofeno();
            Naxen naxen = new Naxen();
            DolexGripa dolexGripa = new DolexGripa();
            GelocatilGripa gelocatil= new GelocatilGripa();
            Mucosolvan mucosolvan = new Mucosolvan();
            Nastizol nastizol = new Nastizol();
            Tabcin tabcin = new Tabcin();

            //inyecciones para la gripe 
            TIV tIV = new TIV();
            QIV qIV = new QIV();
            IIV iIV= new IIV();
            LAIV lAIV = new LAIV();

            //pomadas para la gripe
            VicksVapoRub vicksVapo = new VicksVapoRub();
            PomadaMentolEucalipto mentolEucalipto = new PomadaMentolEucalipto();

            //Pastillas para la Anemia
            FerrousSulfate ferrousSulfate = new FerrousSulfate();
            FerrousGluconate ferrousGluconate = new FerrousGluconate();
            FerrousFumarate ferrousFumarate = new FerrousFumarate();
            Polysaccharide polysaccharide = new Polysaccharide();
            VitaminB12 vitaminB12 = new VitaminB12();
            FolicAcid folicAcid = new FolicAcid();
            VitaminC vitaminC = new VitaminC();
            VitaminE vitaminE = new VitaminE();

            //Inyecciones para la Anemia
            HierroIntravenoso hierroIntravenoso = new HierroIntravenoso();
            Eritropoyetina eritropoyetina = new Eritropoyetina();
            VitaminaB12 vitaminaB12 = new VitaminaB12();

            //Pastillas para la Diabetes
            Metformina metformina = new Metformina();
            Sulfonilureas sulfonilureas = new Sulfonilureas();
            Meglitinidas meglitinidas = new Meglitinidas();
            InhibidoresDPP inhibidoresDPP = new InhibidoresDPP();
            InhibidoresSGLT2 inhibidoresSGLT2 = new InhibidoresSGLT2();

            //Inyecciones para la Diabetes
            Insulina insulina = new Insulina();
            InhibidoresDipeptidilDPP dPP = new InhibidoresDipeptidilDPP();
            Glucagon glucagon = new Glucagon();

            //Instancias de las pastillas para la artritis
            Esteroides esteroides = new Esteroides();
            Medicamentos_antirreumáticos_modificadores_de_enfermedad medicamentos_Antirreumáticos_Modificadores_De_Enfermedad = new Medicamentos_antirreumáticos_modificadores_de_enfermedad();
            Contrairritantes contrairritantes = new Contrairritantes();
            Anti_inflamatoriosno_esteroides anti_Inflamatoriosno_Esteroides = new Anti_inflamatoriosno_esteroides();
            //Instancias de las pastillas para la Hipertension
            Inhibidores_de_la_enzima_convertidora_de_la_angiotensina inhibidores_De_La_Enzima_Convertidora_De_La_Angiotensina = new Inhibidores_de_la_enzima_convertidora_de_la_angiotensina();
            Diuréticos diuréticos = new Diuréticos();
            AntagonistasdereceptoresdeangiotensinaII antagonistasdereceptoresdeangiotensinaII = new AntagonistasdereceptoresdeangiotensinaII();
            Bloqueadores_delos_canales_de_calcio bloqueadores_Delos_Canales_De_Calcio = new Bloqueadores_delos_canales_de_calcio();
            
            //Instancias de las pastillas para la Neumonia
            Cefalexina cefalexina = new Cefalexina();
            Cefadroxilo cefadroxilo = new Cefadroxilo();
            Amoxicilina amoxicilina = new Amoxicilina();
            Cefaclor cefaclor = new Cefaclor();
            //inyecciones para la Neumonia
            piperacilina_y_tazobactam piperacilina_Y_Tazobactamb = new piperacilina_y_tazobactam();

            //lISTA DE LABORATORIOS
            //0 al 9

            List <string> laboratorio= new List<string>() { "Laboratorios Labinco ","\nLaboratorios Stein ","\nLaboratorios López ","\nLaboratorios Calox ","\nLaboratorios Raam ","\nLaboratorios Nolver ","\nLaboratorios Pisa","\nLaboratorios Gramon ","\nLaboratorios Delta ","\nLaboratorios Rigar " };

            int Option;

           
            
            do
            {
                Console.Clear();
                Console.WriteLine("_______________Bienvenido/a a la farmaceutica_______________");
                Console.WriteLine("\n1.Comprar medicamentos");
                Console.WriteLine("\n2.Lista de laboratorios");
                Console.WriteLine("\n3.Salir");
                


                Console.Write("\nIngrese un número entero: ");
                string entrada = Console.ReadLine();

                while (!int.TryParse(entrada, out Option))
                {
                    Console.WriteLine("Error: Debe ingresar un número entero.");
                    Console.WriteLine("\nIngrese un numero entero:");
                    entrada = Console.ReadLine();
                }

                switch (Option)
                    {
                        case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Ha seleccionado la opcion 1\n ");
                            Console.WriteLine("__________LISTA DE ENFERMEDADES__________\n");
                            Console.WriteLine("-Seleccione la enfermedad para la que requiere medicamento\n");
                            List<string> listaEnfermedades = new List<string>() { "1-Gripe", "2-Anemia", "3-Diabetes", "4-Artritis", "5-Hipertensión arterial", "6-Neumonía",   "7-Salir" };
                            foreach (string mostrar in listaEnfermedades)
                            {
                                Console.WriteLine($"{mostrar}");
                            }
                            Console.WriteLine("\nIngrese el numero de la opcion (1-7)");
                            
                          
                            string entrada1 = Console.ReadLine();

                            while (!int.TryParse(entrada1, out Option))
                            {
                                Console.WriteLine("Error: Debe ingresar un número entero.");
                                Console.WriteLine("\nIngrese el numero de la opcion (1-7)");
                                entrada1 = Console.ReadLine();
                            }
                            switch (Option)
                            {
                                case 1:
                                    do
                                    {
                                        Console.WriteLine("__________ MEDICAMENTOS PARA LA GRIPE__________\n");
                                        Console.WriteLine("1.Pastillas" + "\n2.Inyecciones" + "\n3.Pomadas" + "\n4.Salir");
                                        Console.WriteLine("\nIngrese el numero de la opcion (1-4)");
                                       
                                        string entrada2 = Console.ReadLine();

                                        while (!int.TryParse(entrada2, out Option))
                                        {
                                            Console.WriteLine("Error: Debe ingresar un número entero.");
                                            Console.WriteLine("\nIngrese el numero de la opcion (1-4)");
                                            entrada2 = Console.ReadLine();
                                        }
                                        switch (Option)
                                        {
                                            case 1:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de pastillas para la gripe__________\n");
                                                    List<string> listaPastillasGripe = new List<string>() { "1.Acetaminofén ", "\n2.Ibuprofeno", "\n3.Naxen ", "\n4.Dolex Gripa ", "\n5.Gelocatil gripa ", "\n6.Mucosolvan ", "\n7.Nastizol ", "\n8.Tabcin ", "\n9.Salir" };
                                                    foreach (string gripeP in listaPastillasGripe)
                                                    {
                                                        Console.WriteLine($"{gripeP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-9)");
                                                    string entrada3 = Console.ReadLine();

                                                    while (!int.TryParse(entrada3, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-9)");
                                                        entrada3 = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");
                                                            
                                                            Console.WriteLine($" Nombre: {acetaminofen.Nombre()} \n Laboratorio: {laboratorio[0]} \n Componentes: {acetaminofen.Componentes()} \n Cantigad mg: {acetaminofen.CantidadMG()}\n Precio: $ {acetaminofen.Precio()}\n Descuento: {acetaminofen.Descuento()}\n Clasificación: {acetaminofen.Clasificacion()}\n");
                                                            acetaminofen.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {ibuprofeno.Nombre()} \n Laboratorio: {laboratorio[1]} \n Componentes: {ibuprofeno.Componentes()} \n Cantigad mg: {ibuprofeno.CantidadMG()}\n Precio: $ {ibuprofeno.Precio()}\n Descuento: {ibuprofeno.Descuento()}\n Clasificación: {ibuprofeno.Clasificacion()}\n");
                                                            ibuprofeno.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {naxen.Nombre()} \n Laboratorio: {laboratorio[2]} \n Componentes: {naxen.Componentes()} \n Cantigad mg: {naxen.CantidadMG()}\n Precio: $ {naxen.Precio()}\n Descuento: {naxen.Descuento()}\n Clasificación: {naxen.Clasificacion()}\n");
                                                            naxen.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 4:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {dolexGripa.Nombre()} \n Laboratorio: {laboratorio[3]} \n Componentes: {dolexGripa.Componentes()} \n Cantigad mg: {dolexGripa.CantidadMG()}\n Precio: $ {dolexGripa.Precio()}\n Descuento: {dolexGripa.Descuento()}\n Clasificación: {dolexGripa.Clasificacion()}\n");
                                                            dolexGripa.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 5:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {gelocatil.Nombre()} \n Laboratorio: {laboratorio[4]}  \n Componentes: {gelocatil.Componentes()} \n Cantigad mg: {gelocatil.CantidadMG()}\n Precio: $ {gelocatil.Precio()}\n Descuento: {gelocatil.Descuento()}\n Clasificación: {gelocatil.Clasificacion()}\n");
                                                            gelocatil.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 6:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {mucosolvan.Nombre()} \n Laboratorio: {laboratorio[5]} \n Componentes: {mucosolvan.Componentes()} \n Cantigad mg: {mucosolvan.CantidadMG()}\n Precio: $ {mucosolvan.Precio()}\n Descuento: {mucosolvan.Descuento()}\n Clasificación: {mucosolvan.Clasificacion()}\n");
                                                            mucosolvan.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 7:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {nastizol.Nombre()} \n Laboratorio: {laboratorio[6]} \n Componentes: {nastizol.Componentes()} \n Cantigad mg: {nastizol.CantidadMG()}\n Precio: $ {nastizol.Precio()}\n Descuento: {nastizol.Descuento()}\n Clasificación: {nastizol.Clasificacion()}\n");
                                                            nastizol.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 8:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {tabcin.Nombre()} \n Laboratorio: {laboratorio[7]} \n Componentes: {tabcin.Componentes()} \n Cantigad mg: {tabcin.CantidadMG()}\n Precio: $ {tabcin.Precio()}\n Descuento: {tabcin.Descuento()}\n Clasificación: {tabcin.Clasificacion()}\n");
                                                            tabcin.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 9:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 9);
                                                break;
                                            case 2:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de inyecciones para la gripe__________\n");
                                                    List<string> listaInyeccionesGripe = new List<string>() { "1.Vacuna contra la gripe trivalente (TIV) ", "\n2.Vacuna contra la gripe cuadrivalente (QIV) ", "\n3.Vacuna contra la gripe de virus fraccionados inactivados (IIV) ", "\n4.Vacuna de virus vivos atenuados (LAIV) ",  "\n5.Salir" };
                                                    foreach (string gripeP in listaInyeccionesGripe)
                                                    {
                                                        Console.WriteLine($"{gripeP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-5)");
                                                    string entrada4 = Console.ReadLine();

                                                    while (!int.TryParse(entrada4, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-5)");
                                                        entrada4 = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {tIV.Nombre()} \n Laboratorio: {laboratorio[8]} \n Componentes: {tIV.Componentes()} \n Cantigad mg: {tIV.CantidadML()}\n Precio: $ {tIV.Precio()}\n Descuento: {tIV.Descuento()}\n Clasificación: {tIV.Clasificacion()}\n");
                                                            tIV.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {qIV.Nombre()} \n Laboratorio: {laboratorio[9]} \n Componentes: {qIV.Componentes()} \n Cantigad mg: {qIV.CantidadML()}\n Precio: $ {qIV.Precio()}\n Descuento: {qIV.Descuento()}\n Clasificación: {qIV.Clasificacion()}\n");
                                                            qIV.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {iIV.Nombre()} \n Laboratorio: {laboratorio[0]} \n Componentes: {iIV.Componentes()} \n Cantigad mg: {iIV.CantidadML()}\n Precio: $ {iIV.Precio()}\n Descuento: {iIV.Descuento()}\n Clasificación: {iIV.Clasificacion()}\n");
                                                            iIV.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 4:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {lAIV.Nombre()} \n Laboratorio: {laboratorio[1]} \n Componentes: {lAIV.Componentes()} \n Cantigad mg: {lAIV.CantidadML()}\n Precio: $ {lAIV.Precio()}\n Descuento: {lAIV.Descuento()}\n Clasificación: {lAIV.Clasificacion()}\n");
                                                            lAIV.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                       
                                                 
                                                        case 5:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 5);
                                                break;
                                            case 3:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de pomadas para la gripe__________\n");
                                                    List<string> listaInyeccionesGripe = new List<string>() { "1.Vicks VapoRub ", "\n2.Pomada de mentol y eucalipto ", "\n3.Salir" };
                                                    foreach (string gripeP in listaInyeccionesGripe)
                                                    {
                                                        Console.WriteLine($"{gripeP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-3)");
                                                    string entrada5 = Console.ReadLine();

                                                    while (!int.TryParse(entrada5, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-3)");
                                                        entrada5 = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {vicksVapo.Nombre()} \n Laboratorio: {laboratorio[0]} \n Componentes: {vicksVapo.Componentes()} \n Cantigad mg: {vicksVapo.CantidadGramos()}\n Precio: $ {vicksVapo.Precio()}\n Descuento: {vicksVapo.Descuento()}\n Clasificación: {vicksVapo.Clasificacion()}\n");
                                                            vicksVapo.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {mentolEucalipto.Nombre()} \n Laboratorio: {laboratorio[1]} \n Componentes: {mentolEucalipto.Componentes()} \n Cantigad mg: {mentolEucalipto.CantidadGramos()}\n Precio: $ {mentolEucalipto.Precio()}\n Descuento: {mentolEucalipto.Descuento()}\n Clasificación: {mentolEucalipto.Clasificacion()}\n");
                                                            mentolEucalipto.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        

                                                        case 3:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 3);
                                                break;
                                            case 4:
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine("Fin de las consultas");
                                                Console.ReadLine();
                                                Environment.Exit(0);

                                                break;
                                            default:

                                                Console.WriteLine("Opción no válida.");
                                                break;
                                        }
                                        Console.ReadKey();

                                    }
                                    while (Option != 4);
                                    break;
                                case 2:
                                    do
                                    {
                                        Console.WriteLine("__________ MEDICAMENTOS PARA LA ANEMIA__________\n");
                                        Console.WriteLine("1.Pastillas" + "\n2.Inyecciones" + "\n3.Salir");
                                        Console.WriteLine("\nIngrese el numero de la opcion (1-3)");

                                        string entrada6 = Console.ReadLine();

                                        while (!int.TryParse(entrada6, out Option))
                                        {
                                            Console.WriteLine("Error: Debe ingresar un número entero.");
                                            Console.WriteLine("\nIngrese el numero de la opcion (1-3)");
                                            entrada6 = Console.ReadLine();
                                        }
                                        switch (Option)
                                        {
                                            case 1:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de pastillas para la Anemia__________\n");
                                                    List<string> listaPastillasAnemia = new List<string>() { "1.Ferrous Sulfate ", "\n2.Ferrous Gluconate", "\n3.Ferrous Fumarate ", "\n4.Polysaccharide Iron Complex ", "\n5.Vitamin B12 ", "\n6.Folic Acid ", "\n7.Vitamin C ", "\n8.Vitamin E ", "\n9.Salir" };
                                                    foreach (string gripeP in listaPastillasAnemia)
                                                    {
                                                        Console.WriteLine($"{gripeP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-9)");
                                                    string entrada7 = Console.ReadLine();

                                                    while (!int.TryParse(entrada7, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-9)");
                                                        entrada7 = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {ferrousSulfate.Nombre()} \n Laboratorio: {laboratorio[0]} \n Componentes: {ferrousSulfate.Componentes()} \n Cantigad mg: {ferrousSulfate.CantidadMG()}\n Precio: $ {ferrousSulfate.Precio()}\n Descuento: {ferrousSulfate.Descuento()}\n Clasificación: {ferrousSulfate.Clasificacion()}\n");
                                                            ferrousSulfate.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {ferrousGluconate.Nombre()} \n Laboratorio: {laboratorio[1]} \n Componentes: {ferrousGluconate.Componentes()} \n Cantigad mg: {ferrousGluconate.CantidadMG()}\n Precio: $ {ferrousGluconate.Precio()}\n Descuento: {ferrousGluconate.Descuento()}\n Clasificación: {ferrousGluconate.Clasificacion()}\n");
                                                            ferrousGluconate.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {ferrousFumarate.Nombre()} \n Laboratorio: {laboratorio[2]} \n Componentes: {ferrousFumarate.Componentes()} \n Cantigad mg: {ferrousFumarate.CantidadMG()}\n Precio: $ {ferrousFumarate.Precio()}\n Descuento: {ferrousFumarate.Descuento()}\n Clasificación: {ferrousFumarate.Clasificacion()}\n");
                                                            ferrousFumarate.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 4:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {polysaccharide.Nombre()} \n Laboratorio: {laboratorio[3]} \n Componentes: {polysaccharide.Componentes()} \n Cantigad mg: {polysaccharide.CantidadMG()}\n Precio: $ {polysaccharide.Precio()}\n Descuento: {polysaccharide.Descuento()}\n Clasificación: {polysaccharide.Clasificacion()}\n");
                                                            polysaccharide.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 5:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {vitaminB12.Nombre()} \n Laboratorio: {laboratorio[4]}  \n Componentes: {vitaminB12.Componentes()} \n Cantigad mg: {vitaminB12.CantidadMG()}\n Precio: $ {vitaminB12.Precio()}\n Descuento: {vitaminB12.Descuento()}\n Clasificación: {vitaminB12.Clasificacion()}\n");
                                                            vitaminB12.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 6:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {folicAcid.Nombre()} \n Laboratorio: {laboratorio[5]} \n Componentes: {folicAcid.Componentes()} \n Cantigad mg: {folicAcid.CantidadMG()}\n Precio: $ {folicAcid.Precio()}\n Descuento: {folicAcid.Descuento()}\n Clasificación: {folicAcid.Clasificacion()}\n");
                                                            folicAcid.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 7:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {vitaminC.Nombre()} \n Laboratorio: {laboratorio[6]} \n Componentes: {vitaminC.Componentes()} \n Cantigad mg: {vitaminC.CantidadMG()}\n Precio: $ {vitaminC.Precio()}\n Descuento: {vitaminC.Descuento()}\n Clasificación: {vitaminC.Clasificacion()}\n");
                                                            vitaminC.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 8:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {vitaminE.Nombre()} \n Laboratorio: {laboratorio[7]} \n Componentes: {vitaminE.Componentes()} \n Cantigad mg: {vitaminE.CantidadMG()}\n Precio: $ {vitaminE.Precio()}\n Descuento: {vitaminE.Descuento()}\n Clasificación: {vitaminE.Clasificacion()}\n");
                                                            vitaminE.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 9:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 9);
                                                break;
                                            case 2:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de inyecciones para la Anemia__________\n");
                                                    List<string> listaInyeccionesGripe = new List<string>() { "1.Hierro intravenoso ", "\n2.Eritropoyetina ", "\n3.Vitamina B12 ",  "\n4.Salir" };
                                                    foreach (string gripeP in listaInyeccionesGripe)
                                                    {
                                                        Console.WriteLine($"{gripeP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-4)");
                                                    string entrada8 = Console.ReadLine();

                                                    while (!int.TryParse(entrada8, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-4)");
                                                        entrada8 = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {hierroIntravenoso.Nombre()} \n Laboratorio: {laboratorio[0]} \n Componentes: {hierroIntravenoso.Componentes()} \n Cantigad mg: {hierroIntravenoso.CantidadML()}\n Precio: $ {hierroIntravenoso.Precio()}\n Descuento: {hierroIntravenoso.Descuento()}\n Clasificación: {hierroIntravenoso.Clasificacion()}\n");
                                                            hierroIntravenoso.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {eritropoyetina.Nombre()} \n Laboratorio: {laboratorio[1]} \n Componentes: {eritropoyetina.Componentes()} \n Cantigad mg: {eritropoyetina.CantidadML()}\n Precio: $ {eritropoyetina.Precio()}\n Descuento: {eritropoyetina.Descuento()}\n Clasificación: {eritropoyetina.Clasificacion()}\n");
                                                            eritropoyetina.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {vitaminaB12.Nombre()} \n Laboratorio: {laboratorio[2]} \n Componentes: {vitaminaB12.Componentes()} \n Cantigad mg: {vitaminaB12.CantidadML()}\n Precio: $ {vitaminaB12.Precio()}\n Descuento: {vitaminaB12.Descuento()}\n Clasificación: {vitaminaB12.Clasificacion()}\n");
                                                            vitaminaB12.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                      

                                                        case 4:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 4);
                                                break;
                                           
                                                
                                            case 4:
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine("Fin de las consultas");
                                                Console.ReadLine();
                                                Environment.Exit(0);

                                                break;
                                            default:

                                                Console.WriteLine("Opción no válida.");
                                                break;
                                        }
                                        Console.ReadKey();

                                    }
                                    while (Option != 3);
                                    break;
                                case 3:
                                    do
                                    {
                                        Console.WriteLine("__________ MEDICAMENTOS PARA LA DIABETES__________\n");
                                        Console.WriteLine("1.Pastillas" + "\n2.Inyecciones" + "\n3.Salir");
                                        Console.WriteLine("\nIngrese el numero de la opcion (1-3)");

                                        string entrada9 = Console.ReadLine();

                                        while (!int.TryParse(entrada9, out Option))
                                        {
                                            Console.WriteLine("Error: Debe ingresar un número entero.");
                                            Console.WriteLine("\nIngrese el numero de la opcion (1-3)");
                                            entrada9 = Console.ReadLine();
                                        }
                                        switch (Option)
                                        {
                                            case 1:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de pastillas para la Diabetes__________\n");
                                                    List<string> listaPastillasDiabetes = new List<string>() { "1.Metformina ", "\n2.Sulfonilureas ", "\n3.Meglitinidas ", "\n4.Inhibidores de la dipeptidil peptidasa-4 (DPP-4) ", "\n5.Inhibidores del cotransportador de sodio-glucosa tipo 2 (SGLT2) ",  "\n6.Salir" };
                                                    foreach (string gripeP in listaPastillasDiabetes)
                                                    {
                                                        Console.WriteLine($"{gripeP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-6)");
                                                    string entrada10 = Console.ReadLine();

                                                    while (!int.TryParse(entrada10, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-6)");
                                                        entrada10 = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {metformina.Nombre()} \n Laboratorio: {laboratorio[9]} \n Componentes: {metformina.Componentes()} \n Cantigad mg: {metformina.CantidadMG()}\n Precio: $ {metformina.Precio()}\n Descuento: {metformina.Descuento()}\n Clasificación: {metformina.Clasificacion()}\n");
                                                            metformina.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {sulfonilureas.Nombre()} \n Laboratorio: {laboratorio[8]} \n Componentes: {sulfonilureas.Componentes()} \n Cantigad mg: {sulfonilureas.CantidadMG()}\n Precio: $ {sulfonilureas.Precio()}\n Descuento: {sulfonilureas.Descuento()}\n Clasificación: {sulfonilureas.Clasificacion()}\n");
                                                            sulfonilureas.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {meglitinidas.Nombre()} \n Laboratorio: {laboratorio[7]} \n Componentes: {meglitinidas.Componentes()} \n Cantigad mg: {meglitinidas.CantidadMG()}\n Precio: $ {meglitinidas.Precio()}\n Descuento: {meglitinidas.Descuento()}\n Clasificación: {meglitinidas.Clasificacion()}\n");
                                                            meglitinidas.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 4:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {inhibidoresDPP.Nombre()} \n Laboratorio: {laboratorio[6]} \n Componentes: {inhibidoresDPP.Componentes()} \n Cantigad mg: {inhibidoresDPP.CantidadMG()}\n Precio: $ {inhibidoresDPP.Precio()}\n Descuento: {inhibidoresDPP.Descuento()}\n Clasificación: {inhibidoresDPP.Clasificacion()}\n");
                                                            inhibidoresDPP.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 5:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {inhibidoresSGLT2.Nombre()} \n Laboratorio: {laboratorio[5]} \n Componentes: {inhibidoresSGLT2.Componentes()} \n Cantigad mg: {inhibidoresSGLT2.CantidadMG()}\n Precio: $ {inhibidoresSGLT2.Precio()}\n Descuento: {inhibidoresSGLT2.Descuento()}\n Clasificación: {inhibidoresSGLT2.Clasificacion()}\n");
                                                            inhibidoresSGLT2.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                       
                                                        
                                                        case 6:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 6);
                                                break;
                                            case 2:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de inyecciones para la Diabetes__________\n");
                                                    List<string> listaInyeccionesDiabetes = new List<string>() { "1.Insulina ", "\n2.Inhibidores de la dipeptidil peptidasa-4 (DPP-4) ", "\n3.Glucagón ", "\n4.Salir" };
                                                    foreach (string gripeP in listaInyeccionesDiabetes)
                                                    {
                                                        Console.WriteLine($"{gripeP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-4)");
                                                    string entrada11 = Console.ReadLine();

                                                    while (!int.TryParse(entrada11, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-4)");
                                                        entrada11 = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {insulina.Nombre()} \n Laboratorio: {laboratorio[4]} \n Componentes: {insulina.Componentes()} \n Cantigad mg: {insulina.CantidadML()}\n Precio: $ {insulina.Precio()}\n Descuento: {insulina.Descuento()}\n Clasificación: {insulina.Clasificacion()}\n");
                                                            insulina.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {dPP.Nombre()} \n Laboratorio: {laboratorio[3]} \n Componentes: {dPP.Componentes()} \n Cantigad mg: {dPP.CantidadML()}\n Precio: $ {dPP.Precio()}\n Descuento: {dPP.Descuento()}\n Clasificación: {dPP.Clasificacion()}\n");
                                                            dPP.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {glucagon.Nombre()} \n Laboratorio: {laboratorio[2]} \n Componentes: {glucagon.Componentes()} \n Cantigad mg: {glucagon.CantidadML()}\n Precio: $ {glucagon.Precio()}\n Descuento: {glucagon.Descuento()}\n Clasificación: {glucagon.Clasificacion()}\n");
                                                            glucagon.comprar();
                                                            Console.ReadLine();
                                                            break;


                                                        case 4:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 4);
                                                break;


                                            case 3:
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine("Fin de las consultas");
                                                Console.ReadLine();
                                                Environment.Exit(0);

                                                break;
                                            default:

                                                Console.WriteLine("Opción no válida.");
                                                break;
                                        }
                                        Console.ReadKey();

                                    }
                                    while (Option != 3);
                                    break;

                                case 4:
                                    do
                                    {
                                        Console.WriteLine("__________ MEDICAMENTOS PARA LA ARTRITIS__________\n");
                                        Console.WriteLine("__________Catalogo de pastillas para la Artritis__________\n");
                                        List<string> listaPastillasArtritis = new List<string>() { "1.Anti_inflamatoriosno_esteroides ", "\n2.Contrairritantes", "\n3.Esteroides ", "\n4.Medicamentos_antirreumáticos_modificadores_de_enfermedad", "\n5.Salir" };
                                        foreach (string ArtritisP in listaPastillasArtritis)
                                        {
                                            Console.WriteLine($"{ArtritisP}");
                                        }
                                        Console.WriteLine("\nIngrese el numero de la opcion (1-5)");
                                        string entrada12 = Console.ReadLine();

                                        while (!int.TryParse(entrada12, out Option))
                                        {
                                            Console.WriteLine("Error: Debe ingresar un número entero.");
                                            Console.WriteLine("\nIngrese el numero de la opcion (1-5)");
                                            entrada12 = Console.ReadLine();
                                        }
                                        switch (Option)
                                        {
                                            case 1:
                                                Console.WriteLine("-----DETALLES-----");

                                                Console.WriteLine($" Nombre: {anti_Inflamatoriosno_Esteroides.Nombre()} \n Laboratorio: {laboratorio[1]} \n Componentes: {anti_Inflamatoriosno_Esteroides.Componentes()} \n Cantigad mg: {anti_Inflamatoriosno_Esteroides.CantidadMG()}\n Precio: $ {anti_Inflamatoriosno_Esteroides.Precio()}\n Clasificación: {anti_Inflamatoriosno_Esteroides.Clasificacion()}\n");
                                                anti_Inflamatoriosno_Esteroides.comprar();
                                                Console.ReadLine();
                                                break;
                                            case 2:
                                                Console.WriteLine("-----DETALLES-----");

                                                Console.WriteLine($" Nombre: {contrairritantes.Nombre()} \n Laboratorio: {laboratorio[2]} \n Componentes: {contrairritantes.Componentes()} \n Cantigad mg: {contrairritantes.CantidadMG()}\n Precio: $ {contrairritantes.Precio()}\n Descuento: {contrairritantes.Descuento()}\n Clasificación: {contrairritantes.Clasificacion()}\n");
                                                contrairritantes.comprar();
                                                Console.ReadLine();
                                                break;
                                            case 3:
                                                Console.WriteLine("-----DETALLES-----");

                                                Console.WriteLine($" Nombre: {esteroides.Nombre()} \n Laboratorio: {laboratorio[3]} \n Componentes: {esteroides.Componentes()} \n Cantigad mg: {esteroides.CantidadMG()}\n Precio: $ {esteroides.Precio()}\n Clasificación: {esteroides.Clasificacion()}\n");
                                                esteroides.comprar();
                                                Console.ReadLine();
                                                break;
                                            case 4:
                                                Console.WriteLine("-----DETALLES-----");

                                                Console.WriteLine($" Nombre: {medicamentos_Antirreumáticos_Modificadores_De_Enfermedad.Nombre()} \n Laboratorio: {laboratorio[4]} \n Componentes: {medicamentos_Antirreumáticos_Modificadores_De_Enfermedad.Componentes()} \n Cantigad mg: {medicamentos_Antirreumáticos_Modificadores_De_Enfermedad.CantidadMG()}\n Precio: $ {medicamentos_Antirreumáticos_Modificadores_De_Enfermedad.Precio()}\n Clasificación: {medicamentos_Antirreumáticos_Modificadores_De_Enfermedad.Clasificacion()}\n");
                                                medicamentos_Antirreumáticos_Modificadores_De_Enfermedad.comprar();
                                                Console.ReadLine();
                                                break;
                                            case 5:
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine("Fin de las consultas");
                                                Console.ReadLine();
                                                Environment.Exit(0);

                                                break;
                                            default:

                                                Console.WriteLine("Opción no válida.");
                                                break;
                                        }
                                        Console.ReadKey();

                                    }
                                    while (Option != 5);
                                    break;

                                case 5:
                                    do
                                    {
                                        Console.WriteLine("__________ MEDICAMENTOS PARA LA HIPERTENSION ARTERIAL__________\n");
                                        Console.WriteLine("__________Catalogo de pastillas para la Hipertension__________\n");
                                        List<string> listaPastillasHipertension = new List<string>() { "1.Diuréticos ", "\n2.Inhibidores_de_la_enzima_convertidora_de_la_angiotensina", "\n3.AntagonistasdereceptoresdeangiotensinaII", "\n4.Bloqueadores_delos_canales_de_calcio", "\n5.Salir" };
                                        foreach (string HipertensionP in listaPastillasHipertension)
                                        {
                                            Console.WriteLine($"{HipertensionP}");
                                        }
                                        Console.WriteLine("\nIngrese el numero de la opcion (1-5)");
                                        string entrada13 = Console.ReadLine();

                                        while (!int.TryParse(entrada13, out Option))
                                        {
                                            Console.WriteLine("Error: Debe ingresar un número entero.");
                                            Console.WriteLine("\nIngrese el numero de la opcion (1-5)");
                                            entrada13 = Console.ReadLine();
                                        }
                                        switch (Option)
                                        {
                                            case 1:
                                                Console.WriteLine("-----DETALLES-----");

                                                Console.WriteLine($" Nombre: {diuréticos.Nombre()} \n Laboratorio: {laboratorio[5]}  \n Componentes: {diuréticos.Componentes()} \n Cantigad mg: {diuréticos.CantidadMG()}\n Precio: $ {diuréticos.Precio()}\n Clasificación: {diuréticos.Clasificacion()}\n");
                                                diuréticos.comprar();
                                                Console.ReadLine();
                                                break;
                                            case 2:
                                                Console.WriteLine("-----DETALLES-----");

                                                Console.WriteLine($" Nombre: {inhibidores_De_La_Enzima_Convertidora_De_La_Angiotensina.Nombre()} \n Laboratorio: {laboratorio[6]} \n Componentes: {inhibidores_De_La_Enzima_Convertidora_De_La_Angiotensina.Componentes()} \n Cantigad mg: {inhibidores_De_La_Enzima_Convertidora_De_La_Angiotensina.CantidadMG()}\n Precio: $ {inhibidores_De_La_Enzima_Convertidora_De_La_Angiotensina.Precio()}\n Descuento: {inhibidores_De_La_Enzima_Convertidora_De_La_Angiotensina.Descuento()}\n Clasificación: {inhibidores_De_La_Enzima_Convertidora_De_La_Angiotensina.Clasificacion()}\n");
                                                inhibidores_De_La_Enzima_Convertidora_De_La_Angiotensina.comprar();
                                                Console.ReadLine();
                                                break;
                                            case 3:
                                                Console.WriteLine("-----DETALLES-----");

                                                Console.WriteLine($" Nombre: {antagonistasdereceptoresdeangiotensinaII.Nombre()} \n Laboratorio: {laboratorio[7]} \n Componentes: {antagonistasdereceptoresdeangiotensinaII.Componentes()} \n Cantigad mg: {antagonistasdereceptoresdeangiotensinaII.CantidadMG()}\n Precio: $ {antagonistasdereceptoresdeangiotensinaII.Precio()}\n Clasificación: {antagonistasdereceptoresdeangiotensinaII.Clasificacion()}\n");
                                                antagonistasdereceptoresdeangiotensinaII.comprar();
                                                Console.ReadLine();
                                                break;
                                            case 4:
                                                Console.WriteLine("-----DETALLES-----");

                                                Console.WriteLine($" Nombre: {bloqueadores_Delos_Canales_De_Calcio.Nombre()} \n Laboratorio: {laboratorio[8]} \n Componentes: {bloqueadores_Delos_Canales_De_Calcio.Componentes()} \n Cantigad mg: {bloqueadores_Delos_Canales_De_Calcio.CantidadMG()}\n Precio: $ {bloqueadores_Delos_Canales_De_Calcio.Precio()}\n Descuento: {bloqueadores_Delos_Canales_De_Calcio.Descuento()}\n Clasificación: {bloqueadores_Delos_Canales_De_Calcio.Clasificacion()}\n");
                                                bloqueadores_Delos_Canales_De_Calcio.comprar();
                                                Console.ReadLine();
                                                break;
                                            case 5:
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine("Fin de las consultas");
                                                Console.ReadLine();
                                                Environment.Exit(0);

                                                break;
                                            default:

                                                Console.WriteLine("Opción no válida.");
                                                break;
                                        }
                                        Console.ReadKey();

                                    }
                                    while (Option != 5);
                                    break;


                                case 6:
                                    do
                                    {
                                        Console.WriteLine("__________ MEDICAMENTOS PARA LA NEOMONIA__________\n");
                                        Console.WriteLine("1.Pastillas" + "\n2.Inyecciones" + "\n3.Salir");
                                        Console.WriteLine("\nIngrese el numero de la opcion (1-3)");

                                        string entrada14 = Console.ReadLine();

                                        while (!int.TryParse(entrada14, out Option))
                                        {
                                            Console.WriteLine("Error: Debe ingresar un número entero.");
                                            Console.WriteLine("\nIngrese el numero de la opcion (1-3)");
                                            entrada14 = Console.ReadLine();
                                        }
                                        switch (Option)
                                        {
                                            case 1:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de pastillas para la Neumonia__________\n");
                                                    List<string> listaPastillasNeumonia = new List<string>() { "1.Diuréticos ", "\n2.Inhibidores_de_la_enzima_convertidora_de_la_angiotensina", "\n3.AntagonistasdereceptoresdeangiotensinaII", "\n4.Bloqueadores_delos_canales_de_calcio", "\n5.Salir" };
                                                    foreach (string NeumoniaP in listaPastillasNeumonia)
                                                    {
                                                        Console.WriteLine($"{NeumoniaP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-5)");
                                                    string entrada15 = Console.ReadLine();

                                                    while (!int.TryParse(entrada15, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-5)");
                                                        entrada15 = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {amoxicilina.Nombre()} \n Laboratorio: {laboratorio[0]} \n Componentes: {amoxicilina.Componentes()} \n Cantigad mg: {amoxicilina.CantidadMG()}\n Precio: $ {amoxicilina.Precio()}\n Clasificación: {amoxicilina.Clasificacion()}\n");
                                                            amoxicilina.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {cefalexina.Nombre()} \n Laboratorio: {laboratorio[1]} \n Componentes: {cefalexina.Componentes()} \n Cantigad mg: {cefalexina.CantidadMG()}\n Precio: $ {cefalexina.Precio()}\n Descuento: {cefalexina.Descuento()}\n Clasificación: {cefalexina.Clasificacion()}\n");
                                                            cefalexina.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {cefadroxilo.Nombre()} \n Laboratorio: {laboratorio[2]} \n Componentes: {cefadroxilo.Componentes()} \n Cantigad mg: {cefadroxilo.CantidadMG()}\n Precio: $ {cefadroxilo.Precio()}\n Clasificación: {cefadroxilo.Clasificacion()}\n");
                                                            cefadroxilo.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 4:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {cefaclor.Nombre()} \n Laboratorio: {laboratorio[3]} \n Componentes: {cefaclor.Componentes()} \n Cantigad mg: {cefaclor.CantidadMG()}\n Precio: $ {cefaclor.Precio()}\n Descuento: {cefaclor.Descuento()}\n Clasificación: {cefaclor.Clasificacion()}\n");
                                                            cefaclor.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 5:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 6);
                                                break;
                                            case 2:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de inyecciones para la Neomonia__________\n");
                                                    List<string> listaInyeccionesNeumonia = new List<string>() { "1.Piperacilina y tazobactam ","\n2.Salir" };
                                                    foreach (string gripeP in listaInyeccionesNeumonia)
                                                    {
                                                        Console.WriteLine($"{gripeP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-2)");
                                                    string entrada16 = Console.ReadLine();

                                                    while (!int.TryParse(entrada16, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-2)");
                                                        entrada16 = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {piperacilina_Y_Tazobactamb.Nombre()} \n Laboratorio: {laboratorio[3]} \n Componentes: {piperacilina_Y_Tazobactamb.Componentes()} \n Cantigad mg: {piperacilina_Y_Tazobactamb.CantidadML()}\n Precio: $ {piperacilina_Y_Tazobactamb.Precio()}\n Descuento: {piperacilina_Y_Tazobactamb.Descuento()}\n Clasificación: {piperacilina_Y_Tazobactamb.Clasificacion()}\n");
                                                            piperacilina_Y_Tazobactamb.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        


                                                        case 2:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 2);
                                                break;


                                            case 3:
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine("Fin de las consultas");
                                                Console.ReadLine();
                                                Environment.Exit(0);

                                                break;
                                            default:

                                                Console.WriteLine("Opción no válida.");
                                                break;
                                        }
                                        Console.ReadKey();

                                    }
                                    while (Option != 3);
                                    break;

                                case 7:
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    Environment.Exit(0);

                                    break;
                                default:

                                    Console.WriteLine("Opción no válida.");
                                    break;

                            }
                            Console.ReadKey();

                        }
                        while (Option != 7);
                        break;

                        case 2:
                        
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Ha seleccionado la opcion 2\n ");
                            foreach (string datos in laboratorio)
                            {
                                Console.WriteLine(datos);
                            }
                            Console.WriteLine("1.salir\n");
                            Console.Write("\nIngrese un número entero: ");
                            string entrada17 = Console.ReadLine();

                            while (!int.TryParse(entrada17, out Option))
                            {
                                Console.WriteLine("Error: Debe ingresar un número entero.");
                                Console.WriteLine("\nIngrese un numero entero:");
                                entrada17 = Console.ReadLine();
                            }
                            switch (Option)
                            {
                                
                                case 1:
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    Environment.Exit(0);

                                    break;
                                default:

                                    Console.WriteLine("Opción no válida.");
                                    Console.ReadKey();
                                    break;
                            }

                        }
                        while (Option != 1);
                        break;
                       
                        case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Fin de las consultas");
                        Console.ReadLine();
                        Environment.Exit(0);

                        break;
                        default:
                            
                        Console.WriteLine("Opción no válida.");
                       
                        break;

                }
                  
                
                Console.ReadKey();

            }
            while (Option != 3);
        }
    }
}
