#include <stdio.h>
#include <stdlib.h>
#include <locale.h> //Biblioteca para habilitar a acentuação 

main()
{
	setlocale(LC_ALL, "Portuguese"); //Habilita acentuação
	//Declaração de variáveis
	float precoIngresso = 0.0, lucro = 0.0,rendMax = 0.0, precoIngressoMax=0.0;
	int qtdeIngressoVendidos = 350, qtdeIngressoMax=0.0;
	//Declarção da constante DESPESAS_FIXAS para ser usada para se obter o lucro.
	const float DESPESAS_FIXAS = 5600.00;
	printf(" Preço do Ingresso\t\tQuantidade de ingressos vendidos\t\tLucro Máximo\n");
	for (precoIngresso = 48.00; precoIngresso>=22.00; precoIngresso = precoIngresso - 2)
	{
		lucro = precoIngresso * qtdeIngressoVendidos - DESPESAS_FIXAS;
		//Comparação de valores para atribuir valores ao rendimento máximo
		if(lucro>rendMax)
		{
			//Atribuição dos valores de maior rendimento no lucro
			rendMax = lucro;
			precoIngressoMax = precoIngresso;
			qtdeIngressoMax = qtdeIngressoVendidos;
		}
		//Atualização da quantidade de ingresso vendidos
		qtdeIngressoVendidos = qtdeIngressoVendidos + 17;
		//Exibição de resultados em tabela
		printf("\tR$%.2f\t\t\t\t %.2d\t\t\t\t\t R$%.2f\n", precoIngresso, qtdeIngressoVendidos, lucro);
	}
	//Exibição de resultados referente ao rendimento máximo, quantidade de ingresso e preço do ingresso.
	printf("\nO rendimento máximo foi de R$%.2f reais" 
   	   	   "\nQuantidade de ingressos     %.2d" 
           "\nPreço de                  R$%.2f reais\n", rendMax, qtdeIngressoMax, precoIngressoMax);
	system("pause");
}