package util;
import javax.swing.*;
public abstract class ES 
{
    
    public static void mostrarMensagem(String msg)
    {
        JOptionPane.showMessageDialog(null,msg);
    }
    
    public static String lerLiteral(String msg)
    {
        String dado="";
        do{
          dado=JOptionPane.showInputDialog(msg) ;
            
                
        }while (dado==null || dado.equals(""));
        
       return dado;   
    }
    
       
    public static char lerCaractere(String msg)
    {
       String s;
       char c;
       
       s=lerLiteral(msg);
       s=s.toLowerCase();
       c=s.charAt(0);
       
       return c;
    }
    
   
	public static int lerInteiro(String msg)
        {
        int i=0;
        String entrada="";
        do{
           try
           {
              entrada=ES.lerLiteral(msg);
              i=Integer.parseInt(entrada);        
           }
           catch(NumberFormatException e)
           {
             mostrarMensagem(entrada + "não é inteiro");
             entrada="";
           } 
        }while(entrada.equals(""));
        return i;
        }  
	
    public static double lerReal(String msg)
    {	
        double i=0;
        String entrada="";
        do{
           try{
              entrada=ES.lerLiteral(msg);
              i=Double.parseDouble(entrada);
                 
           }catch(NumberFormatException e){
             mostrarMensagem(entrada + "não é real");
             entrada="";
           } 
        }while(entrada.equals(""));
        return i;
    }  
    
    //PacoteHerança
        
    public static String validarNome(String msg)
    {
        String nome="";
        
        do{
            nome=ES.lerLiteral(msg);
            if (nome.length()<=2)
                ES.lerLiteral("Nome inválido! \nDigite nomvamente");
        
        }while(nome.length()<=2); //length retorna a quantidade de caracteres em uma string
        
        return nome;
    }
    
    public static String validarEmail(String msg)
    {
        String  email="";
        do{
            email=ES.lerLiteral(msg);
            if(email.indexOf('@')==-1 || email.indexOf('.')==-1)
                ES.mostrarMensagem("Email inválido! \nDigite novamente");
        }while(email.indexOf('@')==-1 || email.indexOf('.')==-1);
        return email;
        //indexOf retorna o indice do caractere solicitado,
        //porém se ele não for encontrado na String, retornará -1
    }
    public static char validarSexo(String msg){
    char sexo;
    do{
        sexo=ES.lerCaractere(msg);
        if(sexo!='m' && sexo!='f')
            ES.mostrarMensagem("Sexo inválido");
    }while(sexo!='m' && sexo!='f');
     return sexo;       
    }
    
    public static int validarQtdAulasSemanais(String msg)
    {
        int aulas;
        do{
            
        aulas=ES.lerInteiro(msg);
        if(aulas<1 || aulas>34)
    
            ES.mostrarMensagem("Quantidade de aulas inválida");
        
        }while(aulas<1 || aulas>34);
        return aulas;            
    }
    
    public static char validarContrato(String msg)
    {
        char contrato;
        
        do{
            contrato=ES.lerCaractere(msg);
            if(contrato!='i' && contrato!='t')
                ES.mostrarMensagem("Forma de contrato inválida \nTente novamente");
        }while(contrato!='i' && contrato!='t');
        
        return contrato;
    }
  }//fim da classe

