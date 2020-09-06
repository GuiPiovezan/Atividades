package primeiroprograma;
import java.util.Scanner;

public class PrimeiroPRograma 
{
   
    public static void main(String[] args) 
            
    {
        String nome;
        int idade;
        Scanner ler = new Scanner (System.in);
        System.out.print("Digite seu nome: ");
        nome  = ler.nextLine();
        System.out.print("Digite a sua idade: ");
        idade = ler.nextInt();
        System.out.println("O seu nome é "+nome+" e a sua idade é "+idade+" anos");
    }
    
}
