package heranca;
import util.ES;
public class Aluno extends Pessoa
{
   //Atributos do aluno
    private String curso;
    private String rm;
    
    //Getter e Setter

    public String getCurso() {
        return curso;
    }

    public void setCurso(String curso) {
        this.curso = curso;
    }

    public String getRm() {
        return rm;
    }

    public void setRm(String rm) {
        this.rm = rm;
    }
    //Fim get set
    
    //Construtor com Parâmetro
   
    public Aluno(String curso, String rm) {
        this.curso = curso;
        this.rm = rm;
    }
    public Aluno()
    {
        
    }
    
    
    //construtor com parametros
    public Aluno(String curso, String rm, String nome, String email, char sexo) {
        super(nome, email, sexo);
        this.curso = curso;
        this.rm = rm;
    }
    
    //Método geraRelatorio
    public String geraRelatorio()
    {
        String texto="";
        texto = super.geraRelatorio()+"\nCurso: "+this.getCurso()+" \nRM: "+this.getRm();
        return texto;
    }
}//Fim da classe Aluno
