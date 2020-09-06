package mvc.controle;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.Vector;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import mvc.modelo.Carro;
import util.ES;

public class ConnCarro  implements InterfaceDao
{
    Carro c = new Carro();
    @Override
    public void inserir(Carro c) throws SQLException
    {
       Conn conexao = new Conn();
        String sql="Insert into tbCarro(idCarro,nome,placa,cor,combustivel )"
                + "values(null,?,?,?,?)";
        
        PreparedStatement ps = conexao.conectaBD().prepareStatement(sql);
        //PreparedStatement - permite o uso de parametros no comando sql
        ps.setString(1, c.getNome());
        ps.setString(2, c.getPlaca());
        ps.setString(3, c.getCor());
        ps.setString(4, c.getCombustivel());
        //executeUpdate - criação, atualização e delete
        ps.executeUpdate(); 
        
    }//Fim do inserir

   

    @Override
    public ResultSet consultar() throws SQLException 
    {
       Conn conexao = new Conn();
       String sql="Select * from tbCarro";
      
       PreparedStatement ps = conexao.conectaBD().prepareStatement(sql);
       ResultSet rs; //guarda dados vindos do banco 
     
     rs=ps.executeQuery(sql); //exucuteQuery - consulta
     return rs;
     }   //fim do consultar

    @Override
    public void alterar(Carro c) throws SQLException {
          Conn conexao = new Conn();
        String sql = "Update tbCarro set nome= ?, placa = ?, cor = ?, combustivel = ? where idCarro = ?";
        PreparedStatement ps = conexao.conectaBD().prepareStatement(sql);
        ps.setString(1, c.getNome());
        ps.setString(2,c.getPlaca());
        ps.setString(3, c.getCor());
        ps.setString(4, c.getCombustivel());
        ps.setInt(5, c.getIdCarro());
        
        ps.executeUpdate();
    }

  
    public void excluir(Carro c) throws SQLException {
         Conn conexao = new Conn();
        
        String sql = "DELETE from tbCarro WHERE idCarro = ?";
        PreparedStatement ps = conexao.conectaBD().prepareStatement(sql);
        ps.setInt(1, c.getIdCarro());
        ps.executeUpdate();
    }

 

}//fim do ConnCarro