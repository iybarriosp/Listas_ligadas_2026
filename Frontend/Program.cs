
using Backend;

DoubleLinkedList<string> list = new DoubleLinkedList<string>();

int option = -1;

while (option != 0)
{
    Console.WriteLine("\n===== MENÚ LISTAS LIGADAS =====");
    Console.WriteLine("1. Adicionar");
    Console.WriteLine("2. Mostrar hacia adelante");
    Console.WriteLine("3. Mostrar hacia atrás");
    Console.WriteLine("4. Ordenar descendentemente");
    Console.WriteLine("5. Mostrar modas");
    Console.WriteLine("6. Mostrar gráfico de frecuencias");
    Console.WriteLine("7. Consultar existencia");
    Console.WriteLine("8. Eliminar primera ocurrencia");
    Console.WriteLine("9. Eliminar todas las ocurrencias");
    Console.WriteLine("0. Salir");

    Console.Write("\nSeleccione una opción: ");
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out option))
    {
        Console.WriteLine("Opción no válida.");
        option = -1;
        continue;
    }

    switch (option)
    {
        case 1:
            Console.Write("Ingrese un valor: ");
            string value = Console.ReadLine() ?? "";
            list.Insert(value);
            Console.WriteLine("Valor agregado.");
            break;

        case 2:
            Console.WriteLine("\nLista hacia adelante:");
            Console.WriteLine(list);
            break;

        case 3:
            Console.WriteLine("\nLista hacia atrás:");
            Console.WriteLine(list.ShowReverse());
            break;

        case 4:
             list.OrderDesc();
             Console.WriteLine("Lista ordenada descendentemente.");
             Console.WriteLine(list);
             break;
        case 5:
            Console.WriteLine(list.ShowModa());
            break;
        case 6:
            Console.WriteLine("\nGráfico de frecuencias:");
            Console.WriteLine(list.ShowChart());
            break;
        case 7:
            Console.Write("Ingrese el valor a buscar: ");
            string searchValue = Console.ReadLine() ?? "";

            if (list.Exists(searchValue))
            {
                Console.WriteLine("El valor existe en la lista.");
            }
            else
            {
                Console.WriteLine("El valor no existe en la lista.");
            }
            break;
        case 8:
            Console.Write("Ingrese el valor a eliminar: ");
            string removeValue = Console.ReadLine() ?? "";

            if (list.RemoveFirst(removeValue))
            {
                Console.WriteLine("Valor eliminado.");
            }
            else
            {
                Console.WriteLine("El valor no existe en la lista.");
            }
            break;
        case 9:
            Console.Write("Ingrese el valor a eliminar: ");
            string removeAllValue = Console.ReadLine() ?? "";

            int removed = list.DeleteAll(removeAllValue);

            if (removed > 0)
            {
                 Console.WriteLine("Valores eliminados: " + removed);
            }
            else
            {
                Console.WriteLine("El valor no existe en la lista.");
            }
            break;
        case 0:
            Console.WriteLine("¡Chao mij@!");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
    
}
