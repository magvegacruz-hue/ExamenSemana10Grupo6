//Tienda de tecnologia 
//Estudiante1 Kenneth, registrar producto
string[] productos = new string [10];
double[] precioProducto = new double [10];
int[] cantidadVendida = new int [10];
double[] total = new double[10];
int contaNumeroDeCompra=0;
int opcion;
double totalFinal=0;
int cantidadMax=0;
double promedio=0;
//Parte2 MarceloMojica
System.Console.WriteLine("Bienvenido a la tienda masaya");
System.Console.WriteLine("A continuacion, se desplegara un menu de opciones.");
System.Console.WriteLine("Seleccione la opcion segun el numero asignado");
System.Console.WriteLine("1. Registrar productos");
System.Console.WriteLine("2. Mostrar productos");
System.Console.WriteLine("3. Calcular total vendido");
System.Console.WriteLine("4. Mostrar producto mas vendido");
System.Console.WriteLine("5. Mostrar promedio de ventas");
System.Console.WriteLine("6. Salir");
System.Console.WriteLine("Opcion a elegir: ");
try
{
    opcion=int.Parse(Console.ReadLine()!);
}
catch
{
    Console.ForegroundColor=ConsoleColor.Red;
    System.Console.WriteLine("Error, introduzca un numero");
    Console.ResetColor();
    return;
}

switch(opcion)
{
    case 1:
      System.Console.WriteLine("Registre el nombre de cada cada producto:");
      for(int i=0; i<productos.Length; i++)
        {
            System.Console.Write("Producto " + (i+1) + ": ");
            productos[i]=(Console.ReadLine()!);
            System.Console.Write("Precio del producto: ");
            precioProducto[i]=int.Parse(Console.ReadLine()!);
        }
    break;
    case 2:
      System.Console.WriteLine("");
    break;
    case 3:
      System.Console.WriteLine("");
    break;
    case 4:
      System.Console.WriteLine("");
    break;
    case 5:
      System.Console.WriteLine("");
    break;
    case 6:
      System.Console.WriteLine("Saliendo...");
    break;
}