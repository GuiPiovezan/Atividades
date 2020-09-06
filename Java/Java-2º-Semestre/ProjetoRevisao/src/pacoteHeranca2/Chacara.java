
package pacoteHeranca2;
public class Chacara extends Moradia
{
    //Atrbutos da classe Chacara
    private int numLote;
    
    //Getter´s e Setter´s

    public int getNumLote() {
        return numLote;
    }

    public void setNumLote(int numLote) {
        this.numLote = numLote;
    }
    //Fim get set
    
    //Construtor padrão
    public Chacara()
    {
        
    }
    //Construtor com parâmentro - Chacara
    public Chacara(int numLote)
    {
        this.numLote = numLote;
    }
    //Construtor com parâmentro - Chacara que se extende em Moradia
    public Chacara(String dono, String cidade, int qteQuartos, int numLote)
    {
        super(dono, cidade, qteQuartos);
        this.numLote = numLote;
    }
    //Método gerarRelatorio
    public String gerarRelatorio()
    {
        String relatorio="";
        relatorio = super.gerarRelatorio()+"\n Número do lote: "+this.numLote;
        return relatorio;
    }
}
