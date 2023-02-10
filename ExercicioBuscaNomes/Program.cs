List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};

Console.WriteLine("Informe um nome para checar se está na lista dos escolhidos: ");
string nome = Console.ReadLine();
Console.WriteLine(VerificaNomes(nomesDosEscolhidos, nome));

string VerificaNomes(List<string> nomesDosEscolhidos, string escolhido)
{
    return $"{nomesDosEscolhidos.Contains(escolhido)}";
}