package ativdade_21_09;

public class Ativdade_21_09 
{    
    
    public static void main(String[] args) 
    {
        int cont=0;
        String acumNumP = " ";
        while(cont<50)
        {
            
            if(cont%2==0)
            {
                String num = Integer.toString(cont);
                acumNumP = acumNumP + " "+ num;
               
            }
           cont++;
        }
        System.out.println(acumNumP);
    }
    
}
