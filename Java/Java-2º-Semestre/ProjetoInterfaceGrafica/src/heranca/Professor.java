package heranca;
public class Professor extends Pessoa
{
    //Atributos do Professor
  private int qtdAulasSemanais;
  private char contrato;

    public Professor() {
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
  
  //Getter e Setter
    public int getQtdAulasSemanais() {
        return qtdAulasSemanais;
    }

    public void setQtdAulasSemanais(int qtdAulasSemanais) {
        this.qtdAulasSemanais = qtdAulasSemanais;
    }

    public char getContrato() {
        return contrato;
    }

    public void setContrato(char contrato) {
        this.contrato = contrato;
    }
    //Fim get set
    
    //Contrutor com parâmentro
    public Professor(int qtdAulasSemanais, char contrato)
    {
        this.qtdAulasSemanais = qtdAulasSemanais;
        this.contrato = contrato;
    }
    //Construtor com Parâmetro
    public Professor (String nome, String email, char sexo, int qtdAulasSemanais, char contrato)
    {
        super(nome, email, sexo);
        this.qtdAulasSemanais = qtdAulasSemanais;
        this.contrato = contrato;
    }
    //Método gerarRelatorio
    public String gerarRelatorio()
    {
        String texto="";
        texto= super.geraRelatorio()+"\nQuantidade de aulas semanais: "+this.qtdAulasSemanais+"\nContrato: "+this.getContrato();
        return texto;
    }
  
}