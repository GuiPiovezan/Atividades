package pacoteRevisao;

import javax.swing.JOptionPane;

public class PrincipalEntradaSaida 
{
    public static void main(String[] args) 
    {
        /*
       //showMessageDialog
        //JOptionPane utilziado para perguntar algo ao usuário
       JOptionPane.showMessageDialog(null,"Estou aprendendo Java?",
               "Pergunta", JOptionPane.QUESTION_MESSAGE);
       
       //JOptionPane utilizado para exibir informações ao usuário
       JOptionPane.showMessageDialog(null,"Gravação ok",
               "MessageDialog - Informação", JOptionPane.INFORMATION_MESSAGE);
       
       //JOptionPane utilizado para exibir alertas ao usuário
       JOptionPane.showMessageDialog(null, "Cuidado!",
               "MessageDialog - Alerta", JOptionPane.WARNING_MESSAGE);
       
       //JOptionPane utilizado para exibir mensagem de ERRO ao usuário
       JOptionPane.showMessageDialog(null,"Ocorreu um erro",
               "MessageDialog - ERROR", JOptionPane.ERROR_MESSAGE);
       
       //JOptionPane - para exibição de caixa de mensagem simples, sem ícone
       JOptionPane.showMessageDialog(null, "Mensagem simples",
               "MessageDialog - Vazio", JOptionPane.PLAIN_MESSAGE);
 
    
    //ShowConfirmDialog
    
    int resp;
       //JOptionPane.showConfirmDialog para mensagem de YES e NO
    resp = JOptionPane.showConfirmDialog(null,"Deseja continuar?",
            "Confirm Dialog",JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
    if(resp==0)
        JOptionPane.showMessageDialog(null, "Você escolheu sim!");
    else if(resp==1)
        JOptionPane.showMessageDialog(null, "Você escolheu não!");
    else
        JOptionPane.showMessageDialog(null, "Opção inválida");
    /* switch (resp) 
       {
            case 0:
                JOptionPane.showMessageDialog(null, "Você escolheu não");
                break;
            case 1:
                JOptionPane.showMessageDialog(null, "Você escolheu sim");
                break;
            default:
                JOptionPane.showMessageDialog(null, "Opção inválida");
                break;
        }*/

    //showInputDIalog
    /*
          String nome;
	  nome = JOptionPane.showInputDialog (null , "Digite nome",        
                    "Cadastro", JOptionPane.INFORMATION_MESSAGE );
          if(nome==null)
          {
            JOptionPane.showMessageDialog(null,"Nome inválido");  
          }
          else
          JOptionPane.showMessageDialog(null, "Seu nome é "+nome);

          
          //ShowOptionDialog
          
          String[] cores={"azul", "amarelo", "verde"};
          int  cor;

           cor = JOptionPane. showOptionDialog 
            (null, "Escolha uma cor", "OptionDialog", 0,
              JOptionPane.INFORMATION_MESSAGE,   
               null , cores , cores[1]);
           if(cor!=-1)
           {
           JOptionPane.showMessageDialog(null, "Você escolheu a cor: "+cores[cor]);
           }
           else
               JOptionPane.showMessageDialog(null,"Ocorreu um erro",
               "MessageDialog - ERROR", JOptionPane.ERROR_MESSAGE); 
           */
           
           
           //Entrada de dados de valor inteiro
           String s = "";
           int num;
           try
           {
             s= JOptionPane.showInputDialog(null, "Digite um número inteiro"
                   ,"Entrada - inteiro" ,JOptionPane.QUESTION_MESSAGE);
           
           num = Integer.parseInt(s);  
           JOptionPane.showMessageDialog(null,"Número digitado: "+num);
           }
           catch(NumberFormatException e)
           {
               JOptionPane.showMessageDialog(null, "Valor inválido");
           }
           
           //Entrada de dados de valor real
           String ss="";
           double d;
           try
           {
               ss = JOptionPane.showInputDialog(null, "Digite um valor real",
                       "Entrada - real", JOptionPane.QUESTION_MESSAGE);
               d = Double.parseDouble(ss);
               JOptionPane.showMessageDialog(null, "Número digitado: "+d);
               
           }
           catch(NumberFormatException e)
           {
               JOptionPane.showMessageDialog(null, "Valor inválido");
           }
           
           //Entrada de dados caracter
           String sss="";
           char c;
           sss= JOptionPane.showInputDialog(null,"Digite um caractere",
                    "Entrada - caractere", JOptionPane.QUESTION_MESSAGE);
           sss=sss.toLowerCase();
           c = sss.charAt(0);
           JOptionPane.showMessageDialog(null, "Caracter digitado: "+c);
    }//Fim do main
    
}//Fim da classe
