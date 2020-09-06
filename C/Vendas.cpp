#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
main()
{
	setlocale(LC_ALL, "Portuguese"); //Habilita acentuação
	char codigo;
	float compraAVista = 0, compraAPrazo=0, comprasEfetuadas=0, compraMaisBarata=99.999, compraMaisCara=0, valorCompra=0;
	int contador;
	printf("Por gentileza, utilize vírgulas para a separação de casas decimais!!");
	for(contador = 1; contador<1500; contador++)
	{
		//Atribuição de valores
		printf("\nCompra à vista ou a prazo? Use 'V' para à vista ou 'P' para a prazo: ");
		fflush(stdin);
		scanf("%c", &codigo);
		printf("\nDigite o valor da compra: R$");
		scanf("%f", &valorCompra);
		//Validando o valor que será atribuido a variável.
		if(valorCompra>=0)
		{
			//Iremos escolher o tipo de código
			switch(codigo)
			{
				case 'v':
				case 'V':
					compraAVista = compraAVista + valorCompra; //Calculando o valor total de compras feitas à vista.
					break;
				case 'p':
				case 'P':
					compraAPrazo = compraAPrazo + valorCompra; //Calculando o valor total de compras feitas a prazo.
					break;
				default:
					printf("\nOpção inválida!");		
			}
			//Pegar a compra mais barata e a mais cara
			if(valorCompra<compraMaisBarata)
				compraMaisBarata = valorCompra;
			else if(valorCompra>compraMaisCara)
				compraMaisCara = valorCompra;	
	
		}
		else
			printf("\nDigite um valor de compra!");	
	}
		system("cls");
		//Valor total de compras 
		comprasEfetuadas = compraAVista + compraAPrazo;
		//Exibindo resultados
		printf("\nValor total das compras à vista: R$%.2f"
   	   	   	   "\nValor total das compras a prazo: R$%.2f"
           	   "\nValor de compra mais barata:     R$%.2f"
           	   "\nValor de compra mais cara:       R$%.2f"
		   	   "\nValor total de compras:          R$%.2f\n"
		   		  ,compraAVista, compraAPrazo, compraMaisBarata, compraMaisCara, comprasEfetuadas);

	system("pause");
}