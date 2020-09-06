package pacoteHeranca1;

import util.ES;

public class PrincipalHeranca1 
{
    public static void main(String[] args) 
    {
        //pessoa  antes de tornarmos a classe pessoa abstrata
     /*
        Pessoa ana = new Pessoa();//contrutor padrão
        ana.setNome(ES.validarNome("Digite seu nome"));
        ana.setEmail(ES.validarEmail("Digite seu email"));
        ana.setSexo(ES.validarSexo("Digite seu sexo"));
        ES.mostrarMensagem(ana.gerarRelatorio());
        
        Pessoa hugo=new Pessoa(ES.validarNome("Digite o nome"),
                               ES.validarEmail("Digite o email"),
                               ES.validarSexo("Digite seu sexo"));
        ES.mostrarMensagem(hugo.gerarRelatorio());
        */
        
           // classe aluno
    
    Aluno jose = new Aluno(ES.lerLiteral("Digite o curso"),
                            ES.lerLiteral("Digite o RM"),
                            ES.validarNome("Digite o nome"),
                            ES.validarEmail("Digite o email"),
                            ES.validarSexo("Digite o sexo"));
                            ES.mostrarMensagem(jose.geraRelatorio());
    
    
    //classe Professor
    Professor p1 = new Professor(ES.validarNome("Digite o nome do profesor"),
                                 ES.validarEmail("Digite o email do professor"),
                                 ES.validarSexo("Digite o sexo do professor"),
                                 ES.validarQtdAulasSemanais("Digite a quandiade de aulas"),
                                 ES.validarContrato("Digite o tipo de contrato"));
                                 ES.mostrarMensagem(p1.gerarRelatorio());
    } 
}
