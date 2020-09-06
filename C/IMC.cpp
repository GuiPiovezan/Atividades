#include <stdio.h>
#include <stdlib.h>
#include <locale.h> //Biblioteca para habilitar a acentua��o
main()
{
	setlocale(LC_ALL, "Portuguese"); //Habilita acentua��o
	
	//declara��o de vari�veis
	float imc = 0.0, peso = 0.0, altura = 0.0;
	char repete = 's';
	//Necessariamente o programa pode ser executado ao menos uma vez
	do
	{
		system("cls");
		//Atribui��o de valores as vari�veis para fazer o c�lculo.
		printf("Por gentileza, utilize v�rgulas para a separa��o de casas decimais!!");
		printf("\nDigite sua altura em metros: ");
		scanf("%f", &altura);
		printf("Digite seu peso em Kg: ");
		scanf("%f", &peso);
		//Verificando se peso e altura s�o valores positivos.
		if(altura > 0 && peso > 0)
		{
			imc = (peso / (altura*altura));
			//Tomada de decis�o de acordo com o valo de IMC.
			if(imc<=17.0)
				printf("\nSeu �ndice de IMC tem um valor de: %.2f e sua categoria est� muito abaixo do peso.", imc);
			else if(imc < 18.50)
				printf("\nSeu �ndice de IMC tem um valor de: %.2f e sua categoria est� abaixo do peso.", imc);
			else if(imc < 25.99)
				printf("\nSeu �ndice de IMC tem um valor de: %.2f e sua categoria est� no peso normal.", imc);
			else if(imc<30.00)
				printf("\nSeu �ndice de IMC tem um valor de: %.2f e sua categoria est� acima do peso.", imc);
			else if(imc<35.00)
				printf("\nSeu �ndice de IMC tem um valor de: %.2f e sua categoria est� na obesidade I.", imc);
			else if(imc <40.00)
				printf("\nSeu �ndice de IMC tem um valor de: %.2f e sua categoria est� na obesidade II ou severa.", imc);
			else
				printf("\nSeu �ndice de IMC tem um valor de: %.2f e sua categoria est� na obesidade III ou m�rbida.", imc);
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