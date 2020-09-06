package atividade4;
import java.util.Scanner;
public class Atividade4
{

    public static void main(String[] args) 
    {
        Scanner capturar = new Scanner(System.in);
        String mensagem = " ";
        System.out.print("Digite uma mensagem: ");
        mensagem = capturar.nextLine();
        
       while(!"fim".equals(mensagem))
       {
           System.out.print("Sua mensagem é: "+mensagem);
           System.out.print("\nDigite uma mensagem: ");
           mensagem = capturar.nextLine();
       }
        
    }
    
}
