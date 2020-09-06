package mvc.modelo;

public class Carro 
{
    private int idCarro;
    private String nome;
    private String placa;
    private String cor;
    private String combustivel;
    
    //Set e Get
    public int getIdCarro() {
        return idCarro;
    }

    public void setIdCarro(int idCarro) {
        this.idCarro = idCarro;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getPlaca() {
        return placa;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }

    public String getCor() {
        return cor;
    }

    public void setCor(String cor) {
        this.cor = cor;
    }

    public String getCombustivel() {
        return combustivel;
    }

    public void setCombustivel(String combustivel) {
        this.combustivel = combustivel;
    }
    //Fim Set Get
    
    //Construtor Padrão
    public Carro() 
    {
        
    }
    //Fim Construtor
    
    
}
