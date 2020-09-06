package mvc.controle;

import java.sql.SQLException;
import mvc.modelo.Carro;
import java.sql.ResultSet;

public interface InterfaceDao
{
   public void inserir (Carro c) throws SQLException;
   
   public ResultSet consultar() throws SQLException;
   
   public void alterar(Carro c) throws SQLException;
   
   public void excluir(Carro c) throws SQLException;
}
