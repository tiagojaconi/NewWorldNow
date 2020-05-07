using System;

class Jogador{
	private string nomeJogador;
	private string senhaJogador;
	protected int idadeJogador;
	protected float pesoJogador;
	protected float alturaJogador;
	private int contJogador = 0;

	Jogador(){
		contJogador++;
		nomeJogador = ("Jogador "+contJogador);
		senhaJogador = " ";
		idadeJogador = 15;
		alturaJogador = 1.4f;
		pesoJogador = 40;
	} 
	Jogador(string nome, string senha, int idade, float altura, float peso){
		contJogador++;
		nomeJogador = nome;
		senhaJogador = senha;
		idadeJogador = idade;
		alturaJogador = altura;
		pesoJogador = peso;
	}
	
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}