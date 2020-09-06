package pacoteHeranca1;
import util.ES;
public abstract class Pessoa 
{
    //Atributos da Classe Pessoa
    private String nome;
    private String email;
    private char sexo;
    
    //Construtor Padrão
    public Pessoa()
    {
        
    }
    
    //Contrutor com parâmetros
    public Pessoa (String nome, String email, char sexo)
    {
        this.nome = nome;
        this.email = email;
        this.sexo = sexo;  
    }
    //Getter's e Setter's
    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public char getSexo() {
        return sexo;
    }

    public void setSexo(char sexo) {
        this.sexo = sexo;
    }
    //Fim get set
    //Método gera relatório
    public String geraRelatorio()
    {
        String rel="";
        rel = "Nome: "+this.nome+
              "Email: "+this.email+
              "Sexo: "+this.sexo;
        return rel;
    }
    
}
