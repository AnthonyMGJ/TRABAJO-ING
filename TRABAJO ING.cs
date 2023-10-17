using System;

namespace Sistema_de_negocio
{
    internal class Program
    {
        public static void Yape()
        {
            
            int producto = 0, cant = 0, cerrar = 0;
            double precio = 0;
            do
            {
                Console.WriteLine("¿Que producto llevara: (1) Pizza, (2) Hamburguesa o (3) Tallarines?");
                producto = int.Parse(Console.ReadLine());
                switch (producto)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese la cantidad de productos: ");
                            cant = int.Parse(Console.ReadLine());
                            Console.WriteLine("El precio es de 22.90 por cada Pizza");
                            precio = 22.90 * cant;
                            Console.WriteLine("En total debe yapear " + precio + " $");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Ingrese la cantidad de productos: ");
                            cant = int.Parse(Console.ReadLine());
                            Console.WriteLine("El precio es de 30.22 por cada Hamburguesa");
                            precio = 30.22 * cant;
                            Console.WriteLine("En total debe yapear " + precio + " $");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ingrese la cantidad de productos: ");
                            cant = int.Parse(Console.ReadLine());
                            Console.WriteLine("El precio es de 21.15 por cada Tallarin");
                            precio = 21.15 * cant;
                            Console.WriteLine("En total debe yapear " + precio + " $");
                            break;
                        }
                    default:
                        Console.WriteLine("ERROR. Debe ingresar uno de los productos, elija 2 por favor");
                        break;
                }
                Console.WriteLine("Ingrese 1 para terminar la compra, si desea reiniciar la compra ingrese 2");
                cerrar = int.Parse(Console.ReadLine());
            } while (cerrar == 2);
            Console.WriteLine("Su compra a sido completada y pagada.");
            Console.WriteLine("Muchas gracias por comprar con nosotros, vuelva pronto");
        }
        public static void Credito()
        {
            int producto = 0, cant = 0, cerrar = 0;
            double precio = 0;
            do
            {
                Console.WriteLine("¿Que producto llevara: (1) Pizza, (2) Hamburguesa o (3) Tallarines?");
                producto = int.Parse(Console.ReadLine());
                switch (producto)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese la cantidad de productos: ");
                            cant = int.Parse(Console.ReadLine());
                            Console.WriteLine("El precio es de 31.00 por cada Pizza");
                            precio = 31.00 * cant;
                            Console.WriteLine("En total debe pagar con credito " + precio + " $");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Ingrese la cantidad de productos: ");
                            cant = int.Parse(Console.ReadLine());
                            Console.WriteLine("El precio es de 32.59 por cada Hamburguesa");
                            precio = 32.59 * cant;
                            Console.WriteLine("En total debe pagar con credito " + precio + " $");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ingrese la cantidad de productos: ");
                            cant = int.Parse(Console.ReadLine());
                            Console.WriteLine("El precio es de 15.44 por cada Tallarin");
                            precio = 15.44 * cant;
                            Console.WriteLine("En total debe pagar con credito " + precio + " $");
                            break;
                        }
                    default:
                        Console.WriteLine("ERROR. Debe ingresar uno de los productos, elija 2 por favor");
                        break;
                }
                Console.WriteLine("Ingrese 1 para terminar la compra, si desea reiniciar la compra ingrese 2");
                cerrar = int.Parse(Console.ReadLine());
            } while (cerrar == 2);
            Console.WriteLine("Su compra a sido completada y pagada.");
            Console.WriteLine("Muchas gracias por comprar con nosotros, vuelva pronto");
        }
        public static void Efectivo()
        {
            int producto = 0, cant = 0, cerrar = 0;
            double precio = 0;
            do
            {
                Console.WriteLine("¿Que producto llevara: Pizza, Hamburguesa o Tallarines?");
                producto = int.Parse(Console.ReadLine());
                switch (producto)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese la cantidad de productos: ");
                            cant = int.Parse(Console.ReadLine());
                            Console.WriteLine("El precio es de 21.29 por cada Pizza");
                            precio = 21.29 * cant;
                            Console.WriteLine("En total debe pagar en efectivo " + precio + " $");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Ingrese la cantidad de productos: ");
                            cant = int.Parse(Console.ReadLine());
                            Console.WriteLine("El precio es de 18.00 por cada Hamburguesa");
                            precio = 18.00 * cant;
                            Console.WriteLine("En total debe pagar en efectivo " + precio + " $");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ingrese la cantidad de productos: ");
                            cant = int.Parse(Console.ReadLine());
                            Console.WriteLine("El precio es de 15.27 por cada Tallarin");
                            precio = 15.27 * cant;
                            Console.WriteLine("En total debe pagar en efectivo " + precio + " $");
                            break;
                        }
                    default:
                        Console.WriteLine("ERROR. Debe ingresar uno de los productos, elija 2 por favor");
                        break;
                }
                Console.WriteLine("Ingrese 1 para terminar la compra, si desea reiniciar la compra ingrese 2");
                cerrar = int.Parse(Console.ReadLine());
            } while (cerrar == 2);
            Console.WriteLine("Su compra a sido completada y pagada.");
            Console.WriteLine("Muchas gracias por comprar con nosotros, vuelva pronto");
        }
        public static void TipoPago()
        {
            int tipoPa;
            Console.WriteLine("Bienvenido a nuestro sistema de Delivery.");
            Console.WriteLine("Por favor, primero elija como desea pagar:");
            Console.WriteLine("(1) Yape, (2) Credito o (3) Efectivo");
            tipoPa = int.Parse(Console.ReadLine());
            switch (tipoPa)
            {
                case 1:
                    {
                        Yape();
                        break;
                    }
                case 2:
                    {
                        Credito();
                        break;
                    }
                case 3:
                    {
                        Efectivo();
                        break;
                    }
                default:
                    Console.WriteLine("ERROR. No eligió un tipo de pago, se cancelará la compra");
                    break;
            }
        }
        static void Main(string[] args)
        {
            TipoPago();
            Console.ReadKey();
        }
    }
}

