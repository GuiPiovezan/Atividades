package Classes;
public class Revisao1 
{
      private double valor1;
      private double valor2;

      //Get e Set
     public double getValor1() {
        return valor1;
    }

    public void setValor1(double valor1) {
        this.valor1 = valor1;
    }

    public double getValor2() {
        return valor2;
    }

    public void setValor2(double valor2) {
        this.valor2 = valor2;
    }
    //Fim Get e Set
    
   //Método Adição
    public double somarValores(){
       return valor1+valor2;    
    }
    //Método para divisão
     public double dividirValores(){
       return valor1/valor2;    
    }
    //Método para subtrair valores
    public double subtrairValores(){
       return valor1-valor2;    
    }
    //Método para multiplicação de valores
   public double multiplicarValores(){
       return valor1* valor2;
   } 
   //Método para o maior valor
   public double maiorValor(){
       
   return Math.max(valor1, valor2);
   }
   //Método para o menor valor
   public double menorValor(){
       
   return Math.min(valor1, valor2);
   }   
   
    
    
}//fim da classe
