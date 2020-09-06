package pacoteRevisao;

import util.ES;

public class PrincipalRevisao4 {
public static void main(String[] args)
    {
       Revisao4 rev4 = new Revisao4();
       rev4.setNome(ES.lerLiteral("Digite o nome do animal"));
       rev4.setRaca(ES.lerLiteral("Digite a raça do animal"));
       rev4.setIdade(ES.lerInteiro("Digite a idade do animal"));
       rev4.setPeso(rev4.validarPesoCao("Digite o peso do animal"));
       rev4.setPorte(rev4.validarPorteCao("Digite o porte do animal, sendo p - Pequeno, m - Médio e g - Grande"));
       ES.mostrarMensagem(rev4.exibirRelatorio());
    }
    
}
