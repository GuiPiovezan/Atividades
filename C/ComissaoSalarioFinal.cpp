// inclusao de bibliotecas
#include <stdio.h>

// propgrama principal
main()
{
	// declara��o das vari�veis
	float salario, comissao, salarioFinal;
		
	// atribui��o do valor do sal�rio
	salario = 2300.00;	
	
	// c�lculo da comiss�o e do sal�rio final
	comissao = salario * 0.04;
	salarioFinal = salario + comissao;
		
	// sa�da de resultados
	printf("\n Salario R$ %.2f", salario);
	printf("\n Comissao R$ %.2f", comissao);
	printf("\n Salario Final R$ %.2f \n\n", salarioFinal);
}



