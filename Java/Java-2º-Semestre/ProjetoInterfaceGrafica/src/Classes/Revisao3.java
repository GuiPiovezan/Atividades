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
public class Revisao3 {
    
    private String paciente;
    private int idade;
    private double peso;
    private String tipoSangue;
    private char fatorRh;

    public String getPaciente() {
        return paciente;
    }

    public void setPaciente(String paciente) {
        this.paciente = paciente;
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

    public String getTipoSangue() {
        return tipoSangue;
    }

    public void setTipoSangue(String tipoSangue) {
        this.tipoSangue = tipoSangue;
    }

    public char getFatorRh() {
        return fatorRh;
    }

    public void setFatorRh(char fatorRh) {
        this.fatorRh = fatorRh;
    }
    
    public boolean podeDoar(){
        if(this.idade >= 16 && this.idade <= 69 && this.peso >=50)
            return true;
        
        else
            return false;
        
    }
 
    public boolean ehDoadorUniversal(){
     if(this.tipoSangue.equalsIgnoreCase("o")&& 
             this.fatorRh=='-') 
         return true;
     else
         return false;
        
    }
    public String mostrarRelatorio(){
       String rel="";
       rel="Paciente "+this.getPaciente()+
           "\nIdade "+ this.getIdade() +
           "\nPeso "+ this.getPeso() +
           "\nTipo sanguíneo "+ this.getTipoSangue() +" "+this.getFatorRh()+
           "\nPode doar ? "+ this.podeDoar()+
           "\nÉ doador universal? "+ this.ehDoadorUniversal();
        
     return rel;   
    }
    
    
    
}//fim da classe
