// inclusao de bibliotecas
#include <stdio.h>

// propgrama principal
main()
{
	// declaração das variáveis
	float salario, comissao, salarioFinal;
		
	// atribuição do valor do salário
	salario = 2300.00;	
	
	// cálculo da comissão e do salário final
	comissao = salario * 0.04;
	salarioFinal = salario + comissao;
		
	// saída de resultados
	printf("\n Salario R$ %.2f", salario);
	printf("\n Comissao R$ %.2f", comissao);
	printf("\n Salario Final R$ %.2f \n\n", salarioFinal);
}



