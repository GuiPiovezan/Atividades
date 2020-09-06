package Classes;
import java.util.Calendar;

public class Revisao2 
{
   private String nome;
   private int anoNascimento;
   private double peso;
   private double altura;
   private char sexo;

   //Get Set
    public char getSexo() {
        return sexo;
    }

    public void setSexo(char sexo) {
        this.sexo = sexo;
    }
   
   

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
   //Fim get e Set
   
    public double calcularIdade(){
     int ano;
     Calendar calendario = Calendar.getInstance();
     ano= calendario.get(Calendar.YEAR);
     
     
     return ano - anoNascimento;
       
    }
    
     public double calcularIMC(){
     double imc;
     imc=this.peso / (this.altura * this.altura);
     return imc;
        
    }
     
     public String retornarClassificacao(double imc){
        String classi;
        if (imc <18.5) 
            classi="abaixo do peso";
        else if (imc<24.9)
            classi="peso normal";
        else if (imc<29.9)
            classi="sobrepeso";
        else if (imc<34.9)
            classi="obesidade grau I";
        else if (imc<39.9)
            classi="obesidade grau II";
        else
            classi="obesidade grau III ou mórbida";
        return classi;
   
     }
     
     public String retornarClassificacao(){
        double imc;
        imc=this.calcularIMC();
        String classi;
        if (imc <18.5) 
            classi="Abaixo do peso";
        else if (imc<24.9)
            classi="Peso normal";
        else if (imc<29.9)
            classi="Sobrepeso";
        else if (imc<34.9)
            classi="Obesidade grau I";
        else if (imc<39.9)
            classi="Obesidade grau II";
        else
            classi="Obesidade grau III ou mórbida";
        return classi;
        
        
    }
     public double calcularPesoIdeal(){
         double pesoIdeal;
       if(this.sexo=='f' || this.sexo=='F')  
         pesoIdeal=  62.1 *this.altura - 44.7;
       else 
        pesoIdeal=72.7 * this.altura -58;
        
      return pesoIdeal;     
         
         
     }
}
