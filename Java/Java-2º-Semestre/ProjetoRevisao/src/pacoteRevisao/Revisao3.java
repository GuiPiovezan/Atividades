package pacoteRevisao;
public class Revisao3
{ 
   private String paciente;
   private int idade;
   private double peso;
   private String tipoSangue;
   private char fatorRh;

    public String getPaciente() {
        return paciente;
    }

    public void setPaciente(String paciente) {
        this.paciente = paciente;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    public String getTipoSangue() {
        return tipoSangue;
    }

    public void setTipoSangue(String tipoSangue) {
        this.tipoSangue = tipoSangue;
    }

    public char getFatorRh() {
        return fatorRh;
    }

    public void setFatorRh(char fatorRh) {
        this.fatorRh = fatorRh;
    }
   
    public String podeDoar()
    {
        if (this.idade>=16 && this.idade<=69 && this.peso>=50)
            return "sim";
                        else
                            return "não";
    }        
   public String ehDoadorUniversal()
    {
        if(this.fatorRh == '-' && this.tipoSangue == "O")
        {
            return "sim";
        }
        else return "não";
    }
    public String mostrarRelatorio()
    {
      String rel="";
      rel="Paciente "+this.paciente+
              "\nIdade: "+this.idade+" anos"+
               "\nPeso: "+this.peso+"Kg"+
                "\nTipo sanguíneo: "+this.tipoSangue+""+this.fatorRh+
                 "\nÉ doador: "+this.podeDoar()+
                  "\nDoador universal: "+this.ehDoadorUniversal();
      return rel;  
    }
} 
//FIM DA CLASSE
