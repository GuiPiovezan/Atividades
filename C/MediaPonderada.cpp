// inclusao das bibliotecas
#include <stdio.h>
#include <stdlib.h>

// Programa principal
main()
{
	// declaração das variáveis
	float nota1, nota2, peso1, peso2, mediaPonderada;
		
	printf("\n Digite a 1a. Nota: ");
	scanf("%f", &nota1);	// entrada de dados
	printf("\n Digite a 2a. Nota: ");
	scanf("%f", &nota2);	// entrada de dados
	printf("\n Digite o Peso 1: ");
	scanf("%f", &peso1);	// entrada de dados
	printf("\n Digite o Peso 2: ");
	scanf("%f", &peso2);	// entrada de dados
	
	// calcular a média ponderada
	mediaPonderada = (nota1*peso1 + nota2*peso2) / (peso1+peso2);	
	
	// mostrar os resultados
	printf("\n\n Media Ponderada: %.2f \n\n", mediaPonderada);
	
	// pausa na execução do programa
	system("pause");
}