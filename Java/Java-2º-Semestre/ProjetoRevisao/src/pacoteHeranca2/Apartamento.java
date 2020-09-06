package pacoteHeranca2;
public class Apartamento extends Moradia
{
    //Atributos da classe Apartamento
    private int numApartamento;
    //Getter´s e Setter´s

    public int getNumApartamento() {
        return numApartamento;
    }

    public void setNumApartamento(int numApartamento) {
        this.numApartamento = numApartamento;
    }
    //Fim get set
    
    //Construtor padrão
    public Apartamento()
    {
        
    }
    //Construtor com parâmentros - Apartamento
    public Apartamento (int numApartamento)
    {
        this.numApartamento = numApartamento;
    }
    //Construtor com parâmentos - Apartamento que se extende em Moradia
    public Apartamento(String dono, String cidade, int qteQuartos, int numApartamento)
    {
     super(dono, cidade, qteQuartos);
     this.numApartamento = numApartamento;
    }
    //Método gerar relatório
    public String exibirRelatorio()
    {
        String relatorio = "";
        relatorio = super.gerarRelatorio()+"\nNúmero do apartamento: "+this.numApartamento;
        return relatorio;
    }
}
