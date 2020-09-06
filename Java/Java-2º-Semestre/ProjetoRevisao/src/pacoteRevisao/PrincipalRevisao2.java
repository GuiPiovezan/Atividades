
package pacoteRevisao;

public class PrincipalRevisao2
{

    public static void main(String[] args)
    {
        Revisao2 rev2 = new Revisao2();
        rev2.setNome("Guilherme");
        rev2.setAnoNascimento(2000);
        rev2.setSexo('M');
        rev2.setAltura(1.85);
        rev2.setPeso(73);
        rev2.calcularIdade();
        rev2.calcularIMC();
        rev2.retornarClassificacao(0);
        System.out.println(rev2.getNome()+" com idade dê "+rev2.calcularIdade()+" anos, altura dê "+rev2.getAltura()+"m e peso dê "+rev2.getPeso()+"Kg");
        System.out.println("Índice de massa corpórea do paciente "+rev2.calcularIMC());
        System.out.println("Onde o mesmo se encontra em uma classificação de "+rev2.retornarClassificacao(rev2.calcularIMC()));
        System.out.println("Seu peso ideal seria de "+rev2.calcularPesoIdeal()+"Kg");
    }
    
}
