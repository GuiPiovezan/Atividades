package pacoteRevisao;

import javax.swing.JOptionPane;
import util.ES;

public class PrincipalRevisao3 {
    public static void main(String[] args) 
    {
        Revisao3 rev3 = new Revisao3();
        rev3.setPaciente(ES.lerLiteral("Digite o nome do paciente:"));
        rev3.setIdade(ES.lerInteiro("Digite a idade do paciente:"));
        rev3.setPeso(ES.lerReal("Digite peso do paciente:"));
        rev3.setTipoSangue(ES.lerLiteral("Digite o tipo sanguíneo do paciente:"));
        rev3.setFatorRh(ES.lerCaractere("Digite o Fator RH do tipo sanguíneo:"));
        rev3.ehDoadorUniversal();
        //System.out.println(rev3.mostrarRelatorio());
        /*JOptionPane.showMessageDialog(null, rev3.mostrarRelatorio()); // tem que ser String*/
        ES.mostrarMensagem(rev3.mostrarRelatorio());
    }
    
}
