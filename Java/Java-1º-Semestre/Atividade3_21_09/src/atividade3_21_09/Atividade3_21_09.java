package atividade3_21_09;
import java.util.Scanner;
public class Atividade3_21_09 {

    public static void main(String[] args)
    {
        int num;
        String acumNumI = " ";
        int cont=0;
        int acum = 0;
        
        
        Scanner captura = new Scanner(System.in);
        System.out.println("Digite um número: ");
        num = captura.nextInt();
        do{
            
           if(cont%2!=0)
            {
                /*String num = Integer.toString(cont);
                acumNumP = acumNumP + " "+ num;*/
               
            }
           cont++;
        }
        while(cont<num);
        String acumI;
        System.out.println("De 0 a "+num+" temos "+acumNumI+" números ímpares!");
        
    }
    
}
