package pacoteFixacao;
import java.util.Arrays;
public class Veiculo 
{
    //Atributos da classe Veiculo
    private int anoFabricacao;
    private double valor;
    private String placa;
    
    //Getter´s e Setter´s
    public int getAnoFabricacao() {
        return anoFabricacao;
    }

    public void setAnoFabricacao(int anoFabricacao) {
        this.anoFabricacao = anoFabricacao;
    }

    public double getValor() {
        return valor;
    }

    public void setValor(double valor) {
        this.valor = valor;
    }

    public String getPlaca() {
        return placa;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }
    //Fim get set
    
    //Construtor sem parâmetro
    public Veiculo()
    {
        
    }

    //Construtor com parâmetro
    public Veiculo (int anoFabricacao, double valor, String  placa)
    {
        this.anoFabricacao = anoFabricacao;
        this.valor = valor;
        this.placa = placa;
    }
    
    //Método cálculo para a Taxa de Transferencia
    public double taxaTransferencia()
    {
        double resultado;
        if(this.anoFabricacao<2000)
        {
            resultado = (this.valor * 0.10);
        }
        else
        {
            resultado = (this.valor * 0.15);
        }
        return resultado; 
    }
    
    //Método cálculo do IPVA
    public double calcularIPVA ()
    {
        double valorIpva;
        valorIpva = (this.valor * 0.04);
        return valorIpva;
    }
    
    //Método listarDiaRodizio
    public String listarDiaRodizio()
    {
        char finalPlaca = placa.charAt(6);
        String resposta="";
        if(finalPlaca == '1' || finalPlaca == '2')
        {
            resposta = "Segunda";
        }
        else if(finalPlaca == '3' || finalPlaca == '4')
        {
            resposta = "Terça";
        }
        else if(finalPlaca == '5' || finalPlaca == '6')
        {
            resposta = "Quarta";
        }
        else if (finalPlaca == '7' || finalPlaca == '8')
        {
            resposta = "Quinta";
        }
        else if (finalPlaca == '9' || finalPlaca == '0')
        {
            resposta = "Sexta";
        }
        else
            resposta = "Valor deferido inválido";
        return resposta;
    }
            
        //Método exibirRelatório()
        public String exibirRelatorio()
        {
            String relatorio = "";
            relatorio = "Ano de fabricação: "+this.anoFabricacao+
                        "\nValor: R$"+this.valor+
                         "\nPlaca do veículo: "+this.placa+
                          "\nValor da taxa transferência: R$"+this.taxaTransferencia()+
                           "\nValor do IPVA: R$"+this.calcularIPVA()+
                            "\nDias de rodizio: "+this.listarDiaRodizio();
            return relatorio;
        }
    
}//Fim da Classe Veiculo
