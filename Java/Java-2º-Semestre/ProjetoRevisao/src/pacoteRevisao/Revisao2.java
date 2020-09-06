package pacoteRevisao;
import java.util.Calendar;
public class Revisao2 
{
    private String nome;
    private int anoNascimento;
    private double peso;
    private double altura;
    private char sexo;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getAnoNascimento() {
        return anoNascimento;
    }

    public void setAnoNascimento(int anoNascimento) {
        this.anoNascimento = anoNascimento;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }
    
    public char getSexo() {
        return sexo;
    }

    public void setSexo(char sexo) {
        this.sexo = sexo;
    }
    
    public int calcularIdade()
    {
      Calendar calendario = Calendar.getInstance();
      return (calendario.get(calendario.YEAR)-anoNascimento);
    }
    
    public double calcularIMC()
    {
        return (peso/(altura*altura));
    }
    
    public String retornarClassificacao(double calcularIMC)
    {
       String classificacao="";
        //calcularIMC();
        if(calcularIMC<18.5)
           classificacao = ("abaixo do peso");
        else if(calcularIMC>=18.5 && calcularIMC<24.9)
            classificacao = ("peso normal");
        else if(calcularIMC>=24.9 && calcularIMC<29.9)
            classificacao = ("oobrepeso");
        else if(calcularIMC>=30 && calcularIMC<34.9)
            classificacao = ("obesidade grau I");
        else if(calcularIMC>=35 && calcularIMC<39.9)
            classificacao = ("obesidade grau II");
        else 
            classificacao = ("obesidade grau III ou mórbida");
        return classificacao;
            
    }
     
    public double calcularPesoIdeal()
    {
            if(this.sexo=='M' || this.sexo=='m')
            return ((72.7*this.altura)-58);
            
            else 
            return ((62.1*this.altura)-44.7);       
    }
        
    
            
} 
//Fim da Classe
