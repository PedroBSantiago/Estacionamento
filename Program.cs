Console.Clear();
int tempo,hora,vlHora;
string tam;
string vallet, lavagem;

Console.Write("Tamanho do veículo (P/G).....: ");
tam = Console.ReadLine()!.ToUpper()!;
Console.Write("Tempo de permanência (min)...: ");
tempo = Convert.ToInt32(Console.ReadLine());
Console.Write("Serviço de valet (S/N).......: ");
vallet = Console.ReadLine()!;
Console.Write("Serviço de lavagem (S/N).....: ");
lavagem = Console.ReadLine()!;
hora = (tempo - 60) / 60;
if (tam == "P")
{

    vlHora = (hora * 10) + 20;
    if (hora > 5)
    {
        vlHora = 50;

        if (vallet == "S")
        {
            double valet;
            valet = vlHora * 100 / 20;

            if (lavagem == "S")
            {
                double lavg;
                lavg = 50;





            }




        }


    }
}


else if (tam == "G")
{
    vlHora = (hora * 20) + 20;

    if (hora > 5)
    {
        vlHora = 80;

        if (vallet == "S")
        {
            double valet;
            valet = vlHora * 100 / 20;

            if (lavagem == "S")
            {
                double lavg;
                lavg = 100;





            }




        }


    }
}