package aula3;

public class Aula3 
{

    public static void main(String[] args) 
    {
        String nome = "Guilherme";
        String sobrenome = "Piovezan";
        float nota = 9;
        //o percentual esta dizendo para o IDE que ele esta buscando algo, e o s indica que ele está buscando um dado do tipo String
        //para %.2f está falando ao IDE que é um número inteiro que tem 2 casas depois da virgula
        System.out.printf("A nota de %s %s é %.1000f \n", nome,sobrenome,nota);
    }
    
}
