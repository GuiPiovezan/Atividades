package pacoteRevisao;

import util.ES;

public class PrincipalES
{
    public static void main(String[] args) 
    {
       String escola;
       int idade;
       char letra;
       double altura;
       
       escola=ES.lerLiteral("Digite o nome da escola"); //Parametro do metódo é a mensagem que irá aparecer ao usuário
       idade = ES.lerInteiro("Digite sua idade");
       letra = ES.lerCaractere("Digite uma letra");
       altura = ES.lerReal("Digite sua altura");
       ES.mostrarMensagem("Escola: "+escola+
               "\nIdade: "+idade+"\nLetra digitada: "+letra+"\nAltura: "+altura);
       
    }
    
}
