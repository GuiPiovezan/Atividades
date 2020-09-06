package pacoteFixacao;
import util.ES;
public class PrincipalFixacao 
{
    public static void main(String[] args) 
    {
      Veiculo v1 = new Veiculo
        (
         ES.lerInteiro("Digite o ano de fabricação do veículo: "),
         ES.lerReal("Digite o valor do veículo: "),
         ES.lerLiteral("Digite a placa do carro: ")
        );
        ES.mostrarMensagem(v1.exibirRelatorio());
        
        /*Veiculo civic = new Veiculo();
        civic.setAnoFabricacao(ES.lerInteiro("Digite o ano de fabricação do veículo"));
        civic.setValor(ES.lerInteiro("Digite o valor do veículo"));
        civic.setPlaca(ES.lerLiteral("Digite a placa do carro"));
        ES.mostrarMensagem(civic.exibirRelatorio());*/
        
    }
    
}
