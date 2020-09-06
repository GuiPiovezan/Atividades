
package pacoteHeranca2;
public abstract class Moradia 
{
    //Atributos da classe Moradia
   private String dono;
   private String cidade;
   private int qteQuartos;
  //Getter´s e Setter´s
    public String getDono() {
        return dono;
    }

    public void setDono(String dono) {
        this.dono = dono;
    }

    public String getCidade() {
        return cidade;
    }

    public void setCidade(String cidade) {
        this.cidade = cidade;
    }

    public int getQteQuartos() {
        return qteQuartos;
    }

    public void setQteQuartos(int qteQuartos) {
        this.qteQuartos = qteQuartos;
    }
   //Fim set get
    //Construtor padrão
    public Moradia()
    {
        
    }
    //Construtor com parâmetros
    public Moradia(String dono, String cidade, int qteQuartos)
    {
        this.dono = dono;
        this.cidade = cidade;
        this.qteQuartos = qteQuartos;
    }
   //Método gerarRelatorio
    public String gerarRelatorio()
    {
        String relatorio="";
        relatorio = "Dono: "+this.dono+
                "\nCidade: "+this.cidade+
                "\nQuantidade de quartos: "+this.qteQuartos;
        return relatorio;
    }
}
