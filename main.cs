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
		idadeJogador = 16;
		alturaJogador = 1.4f;
		pesoJogador = 30;
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
	public void SetSenha (string senha){
		if (senha.Length <8){
			senhaJogador = senha;
		}else{
			Console.WriteLine ("Senha Inválida!!!");
		}
	}
	public bool GetSenha(string senha){
		//Este apenas devolve verdadeiro para verificação se a senha esta correta ou não.
		bool resposta = false;
		if (senhaJogador == senha){
			resposta = true;
		}else{
			resposta = false;
		}
		return resposta;
	}
	public void SetIdade(int idade){
		if ((idade>16)&&(idade<80)){
			idadeJogador = idade;
		}else{
			Console.WriteLine ("Idade Inválida, ou não autorizada a jogar!!!");
		}
	}
	public int GetIdade(){
		return idadeJogador;
	}
	public void SetAltura(float altura){
		if ((altura>1.0f)&&(altura<3.0f)){
			alturaJogador = altura;
		}else{
			Console.WriteLine("Altura Inválida,, ou não aceito para o jogo!!!!!!");
		}
	}
	public float GetAltura(){
		return alturaJogador;
	}
	public void SetPeso(float peso){
		if ((peso>30)&&(peso<160)){
			pesoJogador = peso;
		}else{
			Console.WriteLine("Peso inválido, ou não aceito para o jogo!!!");
		}
	}
	public float GetPeso(){
		return pesoJogador;
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