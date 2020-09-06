package exerciciomedia;
import java.util.Scanner;
public class ExercicioMedia 
{  

    public static void main(String[] args)
    {
        Scanner captura = new Scanner(System.in);
    String nome;
    int n1, n2;
    double med;
    
    
        System.out.println("Por favor, digite o seu nome: ");
        nome = captura.nextLine();
        System.out.println("Digite a primeira nota: ");
        n1 = captura.nextInt();
        System.out.println("Digite a segunda nota: ");
        n2 = captura.nextInt();
        med = ((n1 + n2)/2);
        System.out.printf("%s sua média é %.1f. E sua notas são: %d e %d\n", nome, med, n1, n2);
        if(med>=6)
        {System.out.println("E você for aprovado!");}
        else 
        {System.out.println("E você está reprovado!");}
    }
    
}
