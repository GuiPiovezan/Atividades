#include <stdio.h> // inclusao das bibliotecas

main()  // programa principal
{
   // declara��o das constantes
   const float GRAMAS = 1000.00;
   
   // declara��o e atribui��o das vari�veis
   float pesoKg, pesoG;
   
   // atribui��o do valor na vari�vel pesoKg
   pesoKg = 23.5;
   
   // c�lculo do peso em g   
   pesoG = pesoKg * GRAMAS;
   
   // mostrar os resultados
   printf("\n Peso da crianca em quilos: %.2f Kg", pesoKg);
   printf("\n Peso da crianca em gramas: %.2f g \n", pesoG);
}


 
