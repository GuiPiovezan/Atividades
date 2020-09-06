package exerciciovetor1;
import java.util.Scanner;
import java.util.Arrays;
public class ExercicioVetor1 
{

    public static void main(String[] args) 
    {     
        int i, cont=0;
        int Vetores[] = new int [5];
        for( i=0; i<5; i++)
        {
             Scanner captura = new Scanner(System.in);
             System.out.print("Digite um número: ");
             Vetores[i] = captura.nextInt();
              if(Vetores[i] < 0)
              {
                  int contadora=0;
                  cont++;
              }
             
             
        }
        System.out.println(cont);
    }
    
}
