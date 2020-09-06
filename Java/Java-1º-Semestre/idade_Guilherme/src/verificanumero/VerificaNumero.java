//Guilherme Aparecido Ferreira Piovezan
package verificanumero;
import java.util.Scanner;
public class VerificaNumero 
{    

   public static void main(String[] args) 
    {
        Scanner captura = new Scanner(System.in);
        int idade=0,idade2=0,idade3=0,idade4=0, resultado1=0, resultado2=0;
        String nome1, nome2, nome3, nome4;
       
        System.out.println("Escreva o nome de um homem: "); //homem
        nome1 = captura.nextLine();
        System.out.println("Escreva o nome de um homem ");//homem
        nome2 = captura.nextLine();
        System.out.println("Escreva o nome de uma mulher: ");//mulher
        nome3 = captura.nextLine();
        System.out.println("Escreva o nome de uma mulher: ");//mulher
        nome4 = captura.nextLine();
        System.out.println("Agora sua idade "+nome1);
        idade = captura.nextInt();
        System.out.println("Agora sua idade "+nome2);
        idade2 = captura.nextInt();
        System.out.println("Agora sua idade "+nome3);
        idade3 = captura.nextInt();
        System.out.println("Agora sua idade "+nome4);
        idade4 = captura.nextInt();
        if (idade != idade2 && idade3 != idade4)
        {
           if((idade<idade2) && (idade3<idade4))
           {
              resultado1 = idade2 + idade3;
              resultado2 = idade * idade4;
              System.out.println("A soma do "+nome2+" e "+nome3+" são: "+resultado1+ " e o produto delas são: "+resultado2);
              
               //System.out.println(nome2);
           }

           else if ((idade>idade2) && (idade3>idade4))
           {
              resultado1 = idade + idade4;
              resultado2 = idade2 * idade3;
              System.out.println("A soma do "+nome1+" e "+ nome4+" são: "+resultado1+" o produto das idades são: "+resultado2);
               //System.out.println(nome3);
           }
           
           
        }
        
           
    }
    
}
