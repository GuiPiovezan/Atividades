#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
main()
{
	setlocale(LC_ALL, "Portuguese"); // Habilita acentua��o para o portugu�s
	
	// Declara��o de vari�veis
	float peso = 0, altura = 0, pesoIdeal = 0;
	char sexo, repete = 's';
	//Estrutura de repeti��o do while, pois necessariamente o programa ser� executado pelo menos uma vez
	do
	{
		system("cls");
		//Atribui��o de valores � vari�veis
		printf("----Por gentileza utilize v�rgulas para separar casas decimais-----");
		printf("\nPor gentileza, digite seu peso em Kg: ");
		scanf("%f",&peso);
		printf("\nDigite sua altura em metros: ");
		fflush(stdin);
		scanf("%f", &altura);
		printf("\nDigite seu sexo, sendo m ou M para masculino e f ou F para feminino: ");
		fflush(stdin);
		scanf("%c", &sexo);
		
		//If para validar se o peso est� acima de zero e diferente de zero
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
					printf("\nOp��o inv�lida, digite seu sexo corretamente!! Por favor, digite novamente seus dados!");
			}	
			//Compara��o do resultado da equa��o do pesoIDeal
			if(peso > pesoIdeal)
				printf("\nVoc� est� acima do peso ideal, onde seu peso � de %.2fKg e o peso ideal seria %.2fKg",  peso, pesoIdeal );
			else if(peso < pesoIdeal)
				printf("\nVoc� est� abaixo do peso ideal, onde seu peso � de %.2fKg e o peso ideal seria %.2fKg", peso, pesoIdeal);
			else
				printf("\nVoc� est� no seu peso ideal com %.2fKg", pesoIdeal);
		}
		else
			printf("Insira seu peso corretamente!");
		//Decis�o do usu�rio em repetir ou n�o
		printf("\nDeseja inserir novos dados?\n Use S ou s para repetir e N ou n para fechar o programa!");
		printf("\nDigite sua resposta: ");
		fflush(stdin);
		scanf("%c", &repete);
	} while(repete =='s' || repete =='S');
	
}