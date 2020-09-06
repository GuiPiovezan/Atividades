/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package classes;



/**
 *
 * @author rosan
 */
public class Revisao4 {
    private String nome;
    private String raca;
    private int idade;
    private double peso;
    private char porte;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getRaca() {
        return raca;
    }

    public void setRaca(String raca) {
        this.raca = raca;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    public char getPorte() {
        return porte;
    }

    public void setPorte(char porte) {
        this.porte = porte;
    }
    
    public String verSituacaoIdade(){
        if(this.idade>=7)
            return "Animal adulto";
        else 
            return "Animal jovem";
        
    }
    public String retornarDescricaoPorte(){
        if(this.porte=='p')
            return "Pequeno";
        else if (this.porte=='m')
            return "Médio";
        else
            return "Grande";
        
    }
    public String mostrarRelatorio(){
       String rel="";
       
       rel="Nome do cachorro: "+ this.getNome()+
           "\nRaca: "+ this.getRaca()+
           "\nIdade: "+ this.getIdade() + " anos" +
           " Situacao: "+ this.verSituacaoIdade()+
           "\nPorte: "+ this.retornarDescricaoPorte();
        
        return rel;
    }
    
    
    
    
    
    
   
}
