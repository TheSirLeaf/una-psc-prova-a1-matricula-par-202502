

string[] diasDaSemana = ["Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb"];
int[] downloadsDiarios = [850000, 1050000, 1100000, 950000, 1200000, 1000000, 850000];
string menorDia = "PLACEHOLDER"; 
string maiorDia = "PLACEHOLDER";
int metaDiaria = 1000000;
int menorValor = 0;
int maiorValor = 0;
int somaDownloadsDiarios = 0;
int diasAcimaDaMeta = 0;

for (int i = 0; i < diasDaSemana.Length; i++)
{
    if (downloadsDiarios[i] < menorValor || i == 0)
    {
        menorValor = downloadsDiarios[i];
        menorDia = diasDaSemana[i];
    }
    if (downloadsDiarios[i] > maiorValor)
    {
        maiorValor = downloadsDiarios[i];
        maiorDia = diasDaSemana[i];
    }
    somaDownloadsDiarios += downloadsDiarios[i];
}

Console.WriteLine("~~~");
Console.WriteLine("=== Análise de Crescimento do Arattai (7 dias) ===");
Console.WriteLine("");
Console.WriteLine($"[R2] Total de Downloads na Semana: {somaDownloadsDiarios}");
Console.WriteLine("");
Console.WriteLine("[R3] Análise de Extremos:");
Console.WriteLine($"Dia de Pico de Downloads: {maiorDia} com {maiorValor} downloads.");
Console.WriteLine($"Dia de Mínimo de Downloads: {menorDia} com {menorValor} downloads.");
Console.WriteLine("");
Console.WriteLine($"[R4] Análise de Metas (Meta Diária: {metaDiaria}):");
for (int i = 0; i < diasDaSemana.Length; i++)
{
    if (downloadsDiarios[i] > metaDiaria)
    {
        Console.WriteLine($"  > {diasDaSemana[i]}: SUCESSO! ({downloadsDiarios[i]} downloads)");
        diasAcimaDaMeta++;
    }
    else
    {
        Console.WriteLine($"  > {diasDaSemana[i]}: Não atingiu. ({downloadsDiarios[i]} downloads)");
    }
}
Console.WriteLine($"[Relatório Final] O Arattai superou a meta diária em {diasAcimaDaMeta} dias esta semana.");
Console.WriteLine("=================================================");
Console.WriteLine("~~~");