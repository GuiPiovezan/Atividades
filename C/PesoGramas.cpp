#include <stdio.h> // inclusao das bibliotecas

main()  // programa principal
{
   // declaração das constantes
   const float GRAMAS = 1000.00;
   
   // declaração e atribuição das variáveis
   float pesoKg, pesoG;
   
   // atribuição do valor na variável pesoKg
   pesoKg = 23.5;
   
   // cálculo do peso em g   
   pesoG = pesoKg * GRAMAS;
   
   // mostrar os resultados
   printf("\n Peso da crianca em quilos: %.2f Kg", pesoKg);
   printf("\n Peso da crianca em gramas: %.2f g \n", pesoG);
}


 
