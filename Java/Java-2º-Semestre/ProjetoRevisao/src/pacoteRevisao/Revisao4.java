package pacoteRevisao;

import util.ES;

public class Revisao4 
{
   String nome="", raca="";
   double peso;
   int idade;
   char porte;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getRaca() {
        return raca;
    }

    public void setRaca(String raca) {
        this.raca = raca;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public char getPorte() {
        return porte;
    }

    public void setPorte(char porte) {
        this.porte = porte;
    }
   
   //Métodos
    public String verSituacaoIDade()
    {
        if(idade>7)
            return "Animal adulto";
        else
            return "Animal Jovem";
    }
    
   public String retornarDescricaoPorte()
   {
       switch (porte) {
           case 'p':
               return "pequeno";
           case 'm':
               return "médio";
           default:
               return "grande";
       }
   }
   
   public char validarPorteCao(String msg)
   {
       char porte;
      
       do
       {
        porte=ES.lerCaractere(msg);
         if(porte!='p' && porte!='m' && porte!='g')
           ES.mostrarMensagem("Porte inválido!");
       }
       while(porte!='p' && porte!='m' && porte!='g');
               return porte;
   }
   
   public double validarPesoCao (String msg)
   {
       double peso;
       do
       {
           peso = ES.lerReal(msg);
           if(peso<5)
               ES.mostrarMensagem("Peso inválido!");
       }
       while(peso<5);
       return peso;
   }
   
   public String exibirRelatorio()
   {
       String relatorio="";
       relatorio ="Relatório Animal\nNome: "+this.nome+
                   "\nRaça: "+this.raca+
                    "\nIdade: "+this.idade+
                     " anos\nSituação de idade: "+this.verSituacaoIDade()+
                      "\nPeso: "+this.peso+
                       "Kg\nPorte: "+this.porte+
                        "\nDescrição do Porte: Porte "+this.retornarDescricaoPorte();
       return relatorio;
   }
   
}//Fim da classe
