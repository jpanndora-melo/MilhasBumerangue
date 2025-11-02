double percentualBonus, percentualRetorno;
int pontosATransferir;
int pontosAReduzirOrigem, pontosAAcrescentarDestino;
string contaOrigem, contaDestino;

Console.WriteLine("Digite a conta de origem: ");
contaOrigem = Console.ReadLine()!;
Console.WriteLine("Digite a conta de destino: ");
contaDestino = Console.ReadLine()!;
Console.WriteLine("Digite a quantidade de pontos a transferir: ");
pontosATransferir = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Digite o percentual de bonus para a conta destino (ex: 0.10 para 10%): ");
percentualBonus = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Digite o percentual de retorno para a conta origem (ex: 0.05 para 5%): ");
percentualRetorno = Convert.ToDouble(Console.ReadLine()!);
pontosAReduzirOrigem = pontosATransferir - (int)(pontosATransferir * percentualRetorno);
pontosAAcrescentarDestino = pontosATransferir + (int)(pontosATransferir * percentualBonus);
Console.WriteLine($"Conta Origem: {contaOrigem}");
Console.WriteLine($"Pontos reduzidos da conta origem: {pontosAReduzirOrigem}");
Console.WriteLine($"Conta Destino: {contaDestino}");
Console.WriteLine($"Pontos acrescentados na conta destino: {pontosAAcrescentarDestino}");

