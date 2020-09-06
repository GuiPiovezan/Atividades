#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
main()
{
	setlocale(LC_ALL, "Portuguese"); // Habilita acentuação para o português
	
	// Declaração de variáveis
	float peso = 0, altura = 0, pesoIdeal = 0;
	char sexo, repete = 's';
	//Estrutura de repetição do while, pois necessariamente o programa será executado pelo menos uma vez
	do
	{
		system("cls");
		//Atribuição de valores à variáveis
		printf("----Por gentileza utilize vírgulas para separar casas decimais-----");
		printf("\nPor gentileza, digite seu peso em Kg: ");
		scanf("%f",&peso);
		printf("\nDigite sua altura em metros: ");
		fflush(stdin);
		scanf("%f", &altura);
		printf("\nDigite seu sexo, sendo m ou M para masculino e f ou F para feminino: ");
		fflush(stdin);
		scanf("%c", &sexo);
		
		//If para validar se o peso está acima de zero e diferente de zero
		if(peso>0)
		{	
			//Escolha caso, para escolher o sexo
			switch(sexo)
			{
				case 'm': 
				case 'M':
					pesoIdeal = ((72.2 * altura) - 58);
					break;
				case 'f': 
				case 'F':
					pesoIdeal = ((62.1 * altura) - 44.7);
					break;
				default:
					printf("\nOpção inválida, digite seu sexo corretamente!! Por favor, digite novamente seus dados!");
			}	
			//Comparação do resultado da equação do pesoIDeal
			if(peso > pesoIdeal)
				printf("\nVocê está acima do peso ideal, onde seu peso é de %.2fKg e o peso ideal seria %.2fKg",  peso, pesoIdeal );
			else if(peso < pesoIdeal)
				printf("\nVocê está abaixo do peso ideal, onde seu peso é de %.2fKg e o peso ideal seria %.2fKg", peso, pesoIdeal);
			else
				printf("\nVocê está no seu peso ideal com %.2fKg", pesoIdeal);
		}
		else
			printf("Insira seu peso corretamente!");
		//Decisão do usuário em repetir ou não
		printf("\nDeseja inserir novos dados?\n Use S ou s para repetir e N ou n para fechar o programa!");
		printf("\nDigite sua resposta: ");
		fflush(stdin);
		scanf("%c", &repete);
	} while(repete =='s' || repete =='S');
	
}