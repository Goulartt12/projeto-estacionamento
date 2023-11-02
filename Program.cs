int preçoi, preçoh, hora;
Console.WriteLine("Bem vindo ao estacionamento");
Console.Write("Digite o preço inicial: ");
preçoi=int.Parse(Console.ReadLine());
Console.Write("Digite o preço por hora: ");
preçoh=int.Parse(Console.ReadLine());
Console.Clear();
int o;
bool j;
j = true;
LinkedList<string> list = new LinkedList<string>();
while (j is true)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - cadastrar veículos");
    Console.WriteLine("2 - listar veículos");
    Console.WriteLine("3 - remover veículo");
    Console.WriteLine("4 - encerrar");
    o=int.Parse(Console.ReadLine());
    switch (o)
    {
        case 1:
            Console.WriteLine("Digite a placa do veículo que deseja registrar: ");
            string registro=(Console.ReadLine());
            list.AddLast(registro);
            Console.WriteLine("Pressione uma tecla para sair");
            Console.ReadKey();
            Console.Clear();
            break;

        case 2:
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Pressione uma tecla para sair");
            Console.ReadKey();
            Console.Clear();
            break;

        case 3:
            Console.WriteLine("Digite a placa do veículo que deseja remover: ");
            string r = Console.ReadLine();
            if (list.Contains(r))
            {
                Console.WriteLine("Horas que o veículo ficou estacionado: ");
                hora = int.Parse(Console.ReadLine());
                decimal total = preçoi + preçoh * hora;
                Console.WriteLine("Preço do estacionamento: R$" +total);
                list.Remove(r);
            }
            else
            {
                Console.WriteLine("Placa não encontrada");
            }
            Console.WriteLine("Pressione uma tecla para sair");
            Console.ReadKey();
            Console.Clear();
            break;

        case 4:
            Console.WriteLine("Deseja sair do sistema?");
            string choice = Console.ReadLine();
            if (choice == "sim")
            {
                j = false;
            }
            else
            {
                j = true;
                Console.Clear();
            }
            break;

        default:
            Console.Clear();
            break;
    }
}
