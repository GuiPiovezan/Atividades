/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package util;


import java.awt.Component;
import javax.swing.JOptionPane;
import javax.swing.JTextField;



/**
 *
 * @author Rosana
 */
public abstract class ES {
    
   
    
    public static void mostrarMensagem(String msg, Component c){
        JOptionPane.showMessageDialog(c,msg);
        
    }
 
    public static boolean tahPreenchido(JTextField tf,Component c ){
       boolean ok=true;
       
       if (tf.getText().isEmpty()){
           ES.mostrarMensagem("Digite um valor",c);
           tf.requestFocus();
           ok=false;
       }
       return ok;
    } 
    
    public static boolean ehReal(JTextField tf, Component c) {
        boolean ok=false;
        double n = 0;

        if ( tahPreenchido(tf,c) )
        {
            try
            {
                n = Double.parseDouble( tf.getText() );
                ok = true; // verificou que o dado é um numero valido
            }
            catch (NumberFormatException e)
            {
                ES.mostrarMensagem("Digite um valor numérico",c);
                tf.requestFocus(); // coloca o foco
                tf.setText(""); // limpar a caixa de texto
            }
        }
        return ok;
  }  
  
   public static boolean ehInteiro(JTextField tf, Component c) {
        boolean ok=false;
        int i = 0;

        if ( tahPreenchido(tf,c) )
        {
            try
            {
                i = Integer.parseInt( tf.getText() );
                ok = true; // verificou que o dado é um numero valido
            }
            catch (NumberFormatException e)
            {
                ES.mostrarMensagem("Digite um valor numérico",c);
                tf.requestFocus(); // coloca o foco
                tf.setText(""); // limpar a caixa de texto
            }
        }
        return ok;
  }  
    
    public static int solicitarResposta(String tit, String msg)   {
      String[] opcoes ={"sim", "não"};
      int resp;
      resp= JOptionPane.showOptionDialog(null, msg, tit,  
              JOptionPane.YES_NO_OPTION, 
      JOptionPane.QUESTION_MESSAGE, null, opcoes, opcoes[0]);
      
      return resp;
  }      
      
    
  }//fim da classe

