package pacoteRevisao;
public class PrincipalRevisao1 
{
    public static void main(String[] args) 
    {
       Revisao1 rev1 = new Revisao1();
       rev1.setValor1(250.998);
       rev1.setValor2(890);
        
        System.out.println("Valor 1: "+rev1.getValor1()+"\nValor 2: "+ rev1.getValor2());
        System.out.println("Soma: "+rev1.somarValores());
        System.out.println("Multiplicação: "+rev1.multiplicarValores());
        System.out.println("Maior Valor: "+rev1.maiorValor());
        System.out.println("Menor Valor: "+rev1.menorValor());
        
        
        
    }
    
}
