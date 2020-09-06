
package vetores;

import java.util.Arrays;


public class Vetores {

    
    public static void main(String[] args) {
        /*int V[] = new int[10];
        V[0]=100;
        V[1]=200;
        V[2]=300;
        V[3]=400;
        V[4]=500;
        V[5]=600;
        V[6]=700;
        V[7]=800;
        V[8]=900;
        V[9]=1000;
        System.out.println(V[2]);*/
            
            int V[] = {1000,300,800,900,400,700,200,500,600,100};
            Arrays.sort(V);
            /*for(int i=0;i<10;i++)
            {
            System.out.println(V[i]);
            }*/
            
            /*for(int i : V)
            {
            System.out.println(i);
            }*/
            System.out.println("Total de elementos : "+V.length);
    }
    
}
