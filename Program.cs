//Tienda de tecnologia 
string[] productos = new string [10];
double[] precioProducto = new double [10];
int[] cantidadVendida = new int [10];
double[] subtotal = new double[10];
int contaProductos=0;
int opcion=0;
double totalFinal=0;
int cantidadMax=0;
string productoMax=" ";
double promedio=0;
System.Console.WriteLine("Bienvenido a la tienda masaya");
System.Console.WriteLine("A continuacion, se desplegara un menu de opciones.");
do
{
System.Console.WriteLine("Seleccione la opcion segun el numero asignado");
System.Console.WriteLine("1. Registrar productos");
System.Console.WriteLine("2. Mostrar productos");
System.Console.WriteLine("3. Calcular total vendido");
System.Console.WriteLine("4. Mostrar producto mas vendido");
System.Console.WriteLine("5. Mostrar promedio de ventas");
System.Console.WriteLine("6. Salir");
System.Console.Write("Opcion a elegir: ");
try
{
    opcion=int.Parse(Console.ReadLine()!);
}
catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine("Error, introduzca un numero");
    Console.ResetColor();
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
            System.Console.Write("Unidades compradas: ");
            cantidadVendida[i]=int.Parse(Console.ReadLine()!);
            subtotal[i]=precioProducto[i]*cantidadVendida[i];
            totalFinal+=subtotal[i];
            contaProductos+=cantidadVendida[i];
            if(cantidadVendida[i]>cantidadMax)
                {
                    cantidadMax=cantidadVendida[i];
                    productoMax=productos[i];
                }
        }
    break;
    case 2:
      System.Console.WriteLine("Los productos registrados han sido:");
      for(int i=0; i<productos.Length; i++)
        {
            System.Console.WriteLine("Pruducto   - Precio - Cantidad - Subtotal");
            System.Console.WriteLine(productos[i] +"  "+ " $" + precioProducto[i] +"     "+ cantidadVendida[i] + "    "+" $" +subtotal[i]);
            System.Console.WriteLine("Regresando a menu...");
        }
    break;
    case 3:
     System.Console.WriteLine("El subtotal de cada una ha sido:");
      for(int i=0; i<productos.Length; i++)
            {
                
                System.Console.WriteLine("Producto #"+(i+1)+": C$"+ subtotal[i]);
            }
      System.Console.WriteLine("El total vendido ha sido de: C$" + totalFinal);
    break;
    case 4:
      System.Console.WriteLine("El producto mas vendido ha sido: "+ productoMax + ", con " + cantidadMax + " unidades vendidas");
    break;
    case 5:
      promedio=totalFinal/productos.Length;
      System.Console.WriteLine("El promedio de ventas entre los 10 productos ha sido de: C$"+promedio);
    break;
    case 6:
      System.Console.WriteLine("Saliendo...");
    break;
}
}
while(opcion!=6);