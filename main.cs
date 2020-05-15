using System;
using System.IO;
using System.Text;

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

class Personagem:Jogador{

	protected string nomePersonagem;
	protected float vidaPersonagem;
	protected float forcaPersonagem;
	protected float magiaPersonagem;
	protected float inteligenciaPersonagem;
	protected int levelPersonagem;

	public Personagem() {}

	public Personagem(string nome){
		nomePersonagem = nome;
		vidaPersonagem = 100;
		forcaPersonagem = 0;
		magiaPersonagem = 0;
		inteligenciaPersonagem = 0;
		levelPersonagem = 1;
	}

	public void SetNomePersonagem(string nome){
		nomePersonagem = nome;
	}
	public string GetNomePersonagem(){
		return nomePersonagem;
	}
	public void SetVida(float vida){
		if((vida>0)&&(vida<200)){
			vidaPersonagem = vida;
		}
	}
	public float GetVida(){
		return vidaPersonagem;
	}
	public void SetForca(float forca){
		if((forca>0)&&(forca<200)){
			forcaPersonagem = forca;
		}
	}
	public float GetForca(){
		return forcaPersonagem;
	}
	public void SetMagia(float magia){
		if((magia>0)&&(magia<100)){
			magiaPersonagem = magia;
		}
	}
	public float GetMagia(){
		return magiaPersonagem;
	}
	public void SetInteligencia(float inteligencia){
		if((inteligencia>0)&&(inteligencia<100)){
			inteligenciaPersonagem = inteligencia;
		}
	}
	public float GetInteligencia(){
		return inteligenciaPersonagem;
	}
	public void SetLevel(int level){
		//Incrementa level no personagem.
		if (level>0){
			if ((level+levelPersonagem)<100){
				levelPersonagem = levelPersonagem +level;
			}else{
				levelPersonagem = 99;
			}
		}
	}
	public int GetLevel(){
		return levelPersonagem;
	}
}
class Classe:Personagem{

	private string nomeClasse;
	
	public Classe(int classe, int funcao){

		switch(classe){

			case 1: //Humano
			{
				switch(funcao){
					case 1: //cavaleiro
					{
						forcaPersonagem = 95;
						magiaPersonagem = 90;
						inteligenciaPersonagem = 98;
						vidaPersonagem = 100;
						break;
					}
					case 2: //bandido
					{
						forcaPersonagem = 95;
						magiaPersonagem = 95;
						inteligenciaPersonagem = 110;
						vidaPersonagem = 95;
						break;
					}
					default: {break;}
				}
				break;
			}
			case 2: //Anjin
			{
				switch(funcao){
					case 1: //Feiticeiro
					{
						forcaPersonagem = 45;
						magiaPersonagem = 100;
						inteligenciaPersonagem = 200;
						vidaPersonagem = 120;
						break;
					}
					case 2: //Invocador
					{
						forcaPersonagem = 40;
						magiaPersonagem = 150;
						inteligenciaPersonagem = 180;
						vidaPersonagem = 140;
						break;
					}
					default: {break;}
				}
				break;
			}
			default: {break;}
		}
	}
}

class MainClass {

  public static void Main (string[] args) {
  
	int menu = 1, idade=0, classe=0, funcao=0;
	float peso, altura;
	string nome, senha, personagem;

		Console.WriteLine ("New World Now - Game");
		while(menu!=0){

			Console.WriteLine ("Escolha o que quer fazer:");
			Console.WriteLine ("1- Novo Jogo");
			Console.WriteLine ("2- Carregar Jogo");
			Console.WriteLine ("0- Fechar Jogo");

			menu = Convert.ToInt32(Console.ReadLine());

			if(menu == 1){
				
				FileStream dados1 = new FileStream("jogador1.txt", FileMode.Open, FileAccess.Write);
				StreamWriter dados1escrever = new StreamWriter(dados1,Encoding.UTF8);

				Console.WriteLine("Informe o seu nome:");
				nome = Console.ReadLine();
				Console.WriteLine("Informe o sua senha:");
				senha = Console.ReadLine();
				Console.WriteLine("Informe o sua idade:");
				idade = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Informe o seu peso:");
				peso = Convert.ToSingle(Console.ReadLine());
				Console.WriteLine("Informe o sua Altura:");
				altura = Convert.ToSingle(Console.ReadLine());
				Console.WriteLine("Informe o nome do seu personagem:");
				personagem = Console.ReadLine();
				Console.WriteLine("Informe a Classe que deseja: 1- Humano ou 2- Anjin");
				classe = Convert.ToInt32(Console.ReadLine());
				if (classe == 1){
					Console.WriteLine("Informe a Função que deseja: 1- Guerreiro ou 2- Bandido");
					funcao = Convert.ToInt32(Console.ReadLine());
				}else if (classe == 2){
					Console.WriteLine("Informe a Função que deseja: 1- Feiticeiro ou 2- Invocador");
					funcao = Convert.ToInt32(Console.ReadLine());
				}
				Classe jogador1 = new Classe(classe, funcao);

				while(jogador1.SetNome(nome)==false){
				Console.WriteLine("Insira outro nome: ");	
					nome = Console.ReadLine();
				}
				dados1escrever.WriteLine(nome);;
				jogador1.SetSenha(senha);
				dados1escrever.WriteLine(senha);
				jogador1.SetIdade(idade);
				dados1escrever.WriteLine(idade);
				jogador1.SetPeso(peso);
				dados1escrever.WriteLine(peso);
				jogador1.SetAltura(altura);
				dados1escrever.WriteLine(altura);
				jogador1.SetNomePersonagem(personagem);
				dados1escrever.WriteLine(personagem);
				
				dados1escrever.Close();
				dados1.Close();
			}
		}
	

		/* ***Para alterar o Nome do Jogador***
		Console.WriteLine("Insira o novo nome: ");
		nome = Console.ReadLine();

		while(jogador1.SetNome(nome)==false){
		Console.WriteLine("Insira outro nome: ");	
		nome = Console.ReadLine();
		}******/
  }
}

	