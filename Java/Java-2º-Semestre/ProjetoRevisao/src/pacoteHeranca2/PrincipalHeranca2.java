package pacoteHeranca2;
import java.util.HashSet;
import java.util.Set;
import util.ES;
public class PrincipalHeranca2 
{
    public static void main(String[] args)
    {
       //Classe Chacara
        Chacara c1 = new Chacara
       (
        ES.validarNome("Digite o nome do dono: "),
        ES.lerLiteral("Digite a cidade do dono:"),
        ES.lerInteiro("Digite a quantidade de quartos:"),
        ES.lerInteiro("Digite o número do lote: ")
       );
        ES.mostrarMensagem(c1.gerarRelatorio());
        
        //Classe Apartamento
        Apartamento a1 = new Apartamento
        (
        ES.validarNome("Digite o nome do dono: "),
        ES.lerLiteral("Digite a cidade do dono:"),
        ES.lerInteiro("Digite a quantidade de quartos:"),
        ES.lerInteiro("Digite o número do apartamento: ")
        );
        ES.mostrarMensagem(a1.exibirRelatorio());
    } //Fim do main
    
}//Fim class PrincipalHeranca2
