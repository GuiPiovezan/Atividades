package pacoteInterface;

import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.io.BufferedReader;
import util.ES;

/**
 *
 * @author GUILHERME    
 */
public class Cliente implements InterfaceDAO
{
 private int codigo;
 private String nome;
 
 //Set Get Cliente
    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }
 // Fim SetGet
    
    //Construtor padrão
    public Cliente() 
    {
        
    }
    //Fim construtor padrão
    
    //Implementando os métodos da InterfaceDAO
    @Override
    public void inserir() 
    {
        FileWriter arq; //Classe usada para escrever em um arquivo
        ES.mostrarMensagem("Inserindo cliente "+this.nome+" no arquivo ", null);
        try
        {
            arq = new FileWriter("clientes.txt", true); //Classe usada para definir o que será gravado no arquivo
            PrintWriter gravarArq = new PrintWriter(arq);
            //Printf - escrever no arquivo
            gravarArq.printf("Código: "+this.codigo+" Nome: "+this.nome+" \r\n");
            arq.close();
            ES.mostrarMensagem("Cliente gravado com sucesso!", null);
        }
        catch (IOException ex)
        {
               ES.mostrarMensagem("Algo deu errado ao gravar o cliente!", null);
        }
    }

    @Override
    public void excluir() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void localizar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public String consultar() 
    {
        FileReader arq; //Classe usada para escrever em um arquivo
        ES.mostrarMensagem("Lendo conteúdo do arquivo!", null);
        
        String conteudo="";
        
        try
        {
            arq = new FileReader("clientes.txt");
            BufferedReader lerArq = new BufferedReader(arq);
            String linha = lerArq.readLine();
            while(linha!=null)
            {
                conteudo = conteudo + linha + "\n";
                linha = lerArq.readLine();
            }
            arq.close();
            
        }
        catch (IOException ex)
                {
                    ES.mostrarMensagem("Não existem informações!", null);
                }
        return conteudo;
    }

    @Override
    public void alterar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
