using System;

class Jogador{
	private string nomeJogador;
	private string senhaJogador;
	protected int idadeJogador;
	protected float pesoJogador;
	protected float alturaJogador;
	private int contJogador = 0;

	public Jogador(){
		contJogador++;
		nomeJogador = ("Jogador "+contJogador);
		senhaJogador = " ";
		idadeJogador = 15;
		alturaJogador = 1.4f;
		pesoJogador = 40;
	} 
	public Jogador(string nome, string senha, int idade, float altura, float peso){
		contJogador++;
		nomeJogador = nome;
		senhaJogador = senha;
		idadeJogador = idade;
		alturaJogador = altura;
		pesoJogador = peso;
	}

	public bool SetNome(string nome){

		char [] verificacao = nome.ToCharArray();
		int condicao = 0;
		bool resposta = false;

		for(int i= 0; i<nome.Length;i++){

			switch (verificacao[i]){
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':{ condicao++; break;}
				default: {break;}
			}
			
		}
		if (condicao ==0){
				nomeJogador= nome;
				Console.WriteLine ("Nome alterado com sucesso!!!");
				resposta = true;
			}else{
				Console.WriteLine ("Nome inválido, possui numeros!!!");
				resposta = false;
			}
		return resposta;
	}
	public string GetNome(){
		return nomeJogador;
	}
	public SetSenha (string senha){
		
	}
	
}

class MainClass {
  public static void Main (string[] args) {
    
		string nome;
		Jogador jogador1 = new Jogador();

		Console.WriteLine ("New World Now - Game");

		/* ***Para alterar o Nome do Jogador***
		Console.WriteLine("Insira o novo nome: ");
		nome = Console.ReadLine();

		while(jogador1.SetNome(nome)==false){
		Console.WriteLine("Insira outro nome: ");	
		nome = Console.ReadLine();
		}******/
  }
}