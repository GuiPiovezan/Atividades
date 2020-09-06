#include <stdio.h>
#include <stdlib.h>
#include <locale.h> //Biblioteca para habilitar a acentuação
main()
{
	setlocale(LC_ALL, "Portuguese"); //Habilita acentuação
	
	//declaração de variáveis
	float imc = 0.0, peso = 0.0, altura = 0.0;
	char repete = 's';
	//Necessariamente o programa pode ser executado ao menos uma vez
	do
	{
		system("cls");
		//Atribuição de valores as variáveis para fazer o cálculo.
		printf("Por gentileza, utilize vírgulas para a separação de casas decimais!!");
		printf("\nDigite sua altura em metros: ");
		scanf("%f", &altura);
		printf("Digite seu peso em Kg: ");
		scanf("%f", &peso);
		//Verificando se peso e altura são valores positivos.
		if(altura > 0 && peso > 0)
		{
			imc = (peso / (altura*altura));
			//Tomada de decisão de acordo com o valo de IMC.
			if(imc<=17.0)
				printf("\nSeu índice de IMC tem um valor de: %.2f e sua categoria está muito abaixo do peso.", imc);
			else if(imc < 18.50)
				printf("\nSeu índice de IMC tem um valor de: %.2f e sua categoria está abaixo do peso.", imc);
			else if(imc < 25.99)
				printf("\nSeu índice de IMC tem um valor de: %.2f e sua categoria está no peso normal.", imc);
			else if(imc<30.00)
				printf("\nSeu índice de IMC tem um valor de: %.2f e sua categoria está acima do peso.", imc);
			else if(imc<35.00)
				printf("\nSeu índice de IMC tem um valor de: %.2f e sua categoria está na obesidade I.", imc);
			else if(imc <40.00)
				printf("\nSeu índice de IMC tem um valor de: %.2f e sua categoria está na obesidade II ou severa.", imc);
			else
				printf("\nSeu índice de IMC tem um valor de: %.2f e sua categoria está na obesidade III ou mórbida.", imc);
		}
		else
			printf("\nDigite valores corretos para seu peso e altura!");

		printf("\nDeseja repetir o programa, use 'S' ou 's' para continuar ou 'N' ou 'n' para fechar o programa");
		printf("\nDigite sua resposta: ");
		fflush(stdin);
		scanf("%c", &repete);
			   	
	}while(repete == 's' || repete == 'S');
	system("pause");
}