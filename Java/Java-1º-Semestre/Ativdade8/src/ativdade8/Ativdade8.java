package ativdade8;
import java.util.Scanner;
//import java.util.Match
public class Ativdade8 
{   
    public static void main(String[] args)
    {   
        int base;
        int expoente;
        int resultado=1;
        int cont=1;
        Scanner captura = new Scanner(System.in);
        System.out.print("Digite a base: ");
        base = captura.nextInt();
        System.out.print("Digite o expoente: ");
        expoente = captura.nextInt();
        while(cont<=expoente)
        {
            resultado = resultado *base;
            cont++;
        }
       
        System.out.println(resultado);
    
    }
    
        
}
   
