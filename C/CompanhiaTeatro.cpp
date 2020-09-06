#include <stdio.h>
#include <stdlib.h>
#include <locale.h> //Biblioteca para habilitar a acentua��o 

main()
{
	setlocale(LC_ALL, "Portuguese"); //Habilita acentua��o
	//Declara��o de vari�veis
	float precoIngresso = 0.0, lucro = 0.0,rendMax = 0.0, precoIngressoMax=0.0;
	int qtdeIngressoVendidos = 350, qtdeIngressoMax=0.0;
	//Declar��o da constante DESPESAS_FIXAS para ser usada para se obter o lucro.
	const float DESPESAS_FIXAS = 5600.00;
	printf(" Pre�o do Ingresso\t\tQuantidade de ingressos vendidos\t\tLucro M�ximo\n");
	for (precoIngresso = 48.00; precoIngresso>=22.00; precoIngresso = precoIngresso - 2)
	{
		lucro = precoIngresso * qtdeIngressoVendidos - DESPESAS_FIXAS;
		//Compara��o de valores para atribuir valores ao rendimento m�ximo
		if(lucro>rendMax)
		{
			//Atribui��o dos valores de maior rendimento no lucro
			rendMax = lucro;
			precoIngressoMax = precoIngresso;
			qtdeIngressoMax = qtdeIngressoVendidos;
		}
		//Atualiza��o da quantidade de ingresso vendidos
		qtdeIngressoVendidos = qtdeIngressoVendidos + 17;
		//Exibi��o de resultados em tabela
		printf("\tR$%.2f\t\t\t\t %.2d\t\t\t\t\t R$%.2f\n", precoIngresso, qtdeIngressoVendidos, lucro);
	}
	//Exibi��o de resultados referente ao rendimento m�ximo, quantidade de ingresso e pre�o do ingresso.
	printf("\nO rendimento m�ximo foi de R$%.2f reais" 
   	   	   "\nQuantidade de ingressos     %.2d" 
           "\nPre�o de                  R$%.2f reais\n", rendMax, qtdeIngressoMax, precoIngressoMax);
	system("pause");
}