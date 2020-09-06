package verificanumero;
import java.util.Scanner;
public class VerificaNumero {
    
    
    public static void main(String[] args) 
    {
        int num;
        Scanner captura = new Scanner(System.in);
        System.out.print("Digite um número inteiro: ");
        num = captura.nextInt();
         if(num>=0)
         {
             System.out.println("Número Positivo");
         }
         /*else if(num==0)
         {
             System.out.println("Neutro");
         }*/
         else
         {
             System.out.println("Número Negativo");
         }
        
    }
    
}
