package pacoteRevisao;

public class Revisao1
{
    private double valor1;
    private double valor2;
    
    //Valor 1 - GET/SET
    public double getValor1()
    {
        return valor1;
    }
    public void setValor1(double valor1) 
    {
        this.valor1 = valor1;
    }
    
    //Valor 2 - GET/SET
    public double getValor2() 
    {
        return valor2;
    }
    public void setValor2(double valor2)
    {
        this.valor2 = valor2;
    }
    
    //Somar Valores
    public double somarValores()
    {
        return (this.valor1 + this.valor2);
    }
    
    //Multiplicar valores
    public double multiplicarValores()
    {
        return (this.valor1 * this.valor2);
    }
    
    //Maior valor
    public double maiorValor()
    {
        // return Math.max(valor1, valor2);
        
        if(valor1>valor2)
            return (valor1);
        else
            return(valor2);
    }
    
    //Menor valor
    public double menorValor()
    {
        // return Math.min(valor1, valor2);
        
        if(valor1<valor2)
            return (valor1);
        else
            return (valor2);
    }
    
}// FIM DA CLASSE
