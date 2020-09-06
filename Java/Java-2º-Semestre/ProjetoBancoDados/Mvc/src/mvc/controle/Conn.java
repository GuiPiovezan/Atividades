/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mvc.controle;

/**
 *
 * @author rosan
 */
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import util.ES;


/**
 *
 * @author Rosana
 */
public class Conn {
  
  Connection conn = null;  

  String driver="com.mysql.jdbc.Driver";
  // nome do driver para conexao com banco de dados
  
  String url="jdbc:mysql://localhost/bdProjeto";
  //parametros necessarios para conexao com o banco
  
  String login="root",senha="";//usuario e senha  
 
 
 //classe especifica para conexao 
  public Connection conectaBD()
  {
    try{
       Class.forName(driver);
	  //carrega o driver definido para a aplicacao
	  
      conn= DriverManager.getConnection(url,login,senha);
	  //estabelece uma conexao
	  
      
      
      return conn;
     }
   catch(ClassNotFoundException erro){ 
   //erro quando não encontra o driver
     ES.mostrarMensagem("Driver não encontrado \n "+ erro.toString(),null);
     return null;
   }
    catch(SQLException erro){
	//erro quando nao conseguiu realizar a conexao 
    ES.mostrarMensagem("Arquivo ou fonte de dados não encontrado \n "+erro.toString(),null);
  return null;
   }
 }
  
   }//fim da  classe
