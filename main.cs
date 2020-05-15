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
				resposta = true;
			}else{
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
	public bool SetIdade(int idade){
		bool resposta = false;
		if ((idade>16)&&(idade<80)){
			idadeJogador = idade;
			resposta = true;
		}else{
			resposta = false;
		}
		return resposta;
	}
	public int GetIdade(){
		return idadeJogador;
	}
	public bool SetAltura(float altura){
		bool resposta = false;
		if ((altura>1.0f)&&(altura<3.0f)){
			alturaJogador = altura;
			resposta = true;
		}else{
			resposta = false;
		}
		return resposta;
	}
	public float GetAltura(){
		return alturaJogador;
	}
	public bool SetPeso(float peso){
		bool resposta = false;
		if ((peso>30)&&(peso<160)){
			pesoJogador = peso;
			resposta = true;
		}else{
			resposta = false;
		}
		return resposta;
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
  
	int menu = 1, idade=0, classe=0, funcao=0, submenu=0;
	float peso, altura, forca, vida, magia, inteligencia;
	string nome, senha, personagem;

		Console.WriteLine ("New World Now - Game");
		while(menu!=0){

			Console.WriteLine ("Escolha o que quer fazer:");
			Console.WriteLine ("1- Novo Jogo");
			Console.WriteLine ("2- Carregar Jogo");
			Console.WriteLine ("0- Fechar Jogo");

			menu = Convert.ToInt32(Console.ReadLine());

			if(menu == 1){
			
				Console.WriteLine("Escolha em qual posição salvar: 1- Jogador 1 ou 2-Jogador 2");
				submenu = Convert.ToInt32(Console.ReadLine());
				if (submenu ==1){
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
					Console.WriteLine("Nome inválido, insira outro nome: ");	
						nome = Console.ReadLine();
					}
					while(jogador1.SetIdade(idade)==false){
					Console.WriteLine("Idade não permitida, insira outra idade: ");	
						idade = Convert.ToInt32(Console.ReadLine());
					}
					while(jogador1.SetPeso(peso)==false){
					Console.WriteLine("Peso inválido, insira outro peso: ");	
						peso = Convert.ToSingle(Console.ReadLine());
					}
					while(jogador1.SetAltura(altura)==false){
					Console.WriteLine("Altura inválida, insira outra altura: ");	
						altura = Convert.ToSingle(Console.ReadLine());
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
					dados1escrever.WriteLine(classe);
					dados1escrever.WriteLine(funcao);
					dados1escrever.WriteLine(jogador1.GetVida());
					dados1escrever.WriteLine(jogador1.GetForca());
					dados1escrever.WriteLine(jogador1.GetMagia());
					dados1escrever.WriteLine(jogador1.GetInteligencia());
					dados1escrever.Close();
					dados1.Close();
					Console.WriteLine ("Dados gravados com sucesso!!!");
				}
				if (submenu==2){
					FileStream dados2 = new FileStream("jogador2.txt", FileMode.Open, FileAccess.Write);
					StreamWriter dados2escrever = new StreamWriter(dados2,Encoding.UTF8);

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
					Classe jogador2 = new Classe(classe, funcao);

					while(jogador2.SetNome(nome)==false){
					Console.WriteLine("Nome inválido, insira outro nome: ");	
						nome = Console.ReadLine();
					}
					while(jogador2.SetIdade(idade)==false){
					Console.WriteLine("Idade não permitida, insira outra idade: ");	
						idade = Convert.ToInt32(Console.ReadLine());
					}
					while(jogador2.SetPeso(peso)==false){
					Console.WriteLine("Peso inválido, insira outro peso: ");	
						peso = Convert.ToSingle(Console.ReadLine());
					}
					while(jogador2.SetAltura(altura)==false){
					Console.WriteLine("Altura inválida, insira outra altura: ");	
						altura = Convert.ToSingle(Console.ReadLine());
					}
					dados2escrever.WriteLine(nome);;
					jogador2.SetSenha(senha);
					dados2escrever.WriteLine(senha);
					jogador2.SetIdade(idade);
					dados2escrever.WriteLine(idade);
					jogador2.SetPeso(peso);
					dados2escrever.WriteLine(peso);
					jogador2.SetAltura(altura);
					dados2escrever.WriteLine(altura);
					jogador2.SetNomePersonagem(personagem);
					dados2escrever.WriteLine(personagem);
					dados2escrever.WriteLine(jogador2.GetVida());
					dados2escrever.WriteLine(jogador2.GetForca());
					dados2escrever.WriteLine(jogador2.GetMagia());
					dados2escrever.WriteLine(jogador2.GetInteligencia());
					dados2escrever.Close();
					dados2.Close();
					Console.WriteLine ("Dados gravados com sucesso!!!");
				}
			}
			if(menu == 2){

				Console.WriteLine("Escolha em qual posição carregar: 1- Jogador 1 ou 2-Jogador 2");
				submenu = Convert.ToInt32(Console.ReadLine());
				if (submenu ==1){
					FileStream dados1 = new FileStream("jogador1.txt", FileMode.Open, FileAccess.Read);
					StreamReader dados1ler = new StreamReader(dados1,Encoding.UTF8);

					nome = dados1ler.ReadLine();
					senha = dados1ler.ReadLine();
					idade = Convert.ToInt32(dados1ler.ReadLine());
					peso = Convert.ToSingle(dados1ler.ReadLine());
					altura = Convert.ToSingle(dados1ler.ReadLine());
					personagem = dados1ler.ReadLine();
					classe = Convert.ToInt32(dados1ler.ReadLine());
					funcao = Convert.ToInt32(dados1ler.ReadLine());
					vida = Convert.ToSingle(dados1ler.ReadLine());
					forca = Convert.ToSingle(dados1ler.ReadLine());
					magia = Convert.ToSingle(dados1ler.ReadLine());
					inteligencia = Convert.ToSingle(dados1ler.ReadLine());

					Classe jogador1 = new Classe(classe, funcao);
					jogador1.SetNome(nome);
					jogador1.SetSenha(senha);
					jogador1.SetIdade(idade);
					jogador1.SetPeso(peso);
					jogador1.SetAltura(altura);
					jogador1.SetNomePersonagem(personagem);
					jogador1.SetVida(vida);
					jogador1.SetForca(forca);
					jogador1.SetMagia(magia);
					jogador1.SetInteligencia(inteligencia);
					dados1ler.Close();
					dados1.Close();
					Console.WriteLine ("Dados carregados com sucesso!!!");
				}
				if (submenu ==2){
					FileStream dados2 = new FileStream("jogador2.txt", FileMode.Open, FileAccess.Read);
					StreamReader dados2ler = new StreamReader(dados2,Encoding.UTF8);

					nome = dados2ler.ReadLine();
					senha = dados2ler.ReadLine();
					idade = Convert.ToInt32(dados2ler.ReadLine());
					peso = Convert.ToSingle(dados2ler.ReadLine());
					altura = Convert.ToSingle(dados2ler.ReadLine());
					personagem = dados2ler.ReadLine();
					classe = Convert.ToInt32(dados2ler.ReadLine());
					funcao = Convert.ToInt32(dados2ler.ReadLine());
					vida = Convert.ToSingle(dados2ler.ReadLine());
					forca = Convert.ToSingle(dados2ler.ReadLine());
					magia = Convert.ToSingle(dados2ler.ReadLine());
					inteligencia = Convert.ToSingle(dados2ler.ReadLine());

					Classe jogador2 = new Classe(classe, funcao);
					jogador2.SetNome(nome);
					jogador2.SetSenha(senha);
					jogador2.SetIdade(idade);
					jogador2.SetPeso(peso);
					jogador2.SetAltura(altura);
					jogador2.SetNomePersonagem(personagem);
					jogador2.SetVida(vida);
					jogador2.SetForca(forca);
					jogador2.SetMagia(magia);
					jogador2.SetInteligencia(inteligencia);
					dados2ler.Close();
					dados2.Close();
					Console.WriteLine ("Dados carregados com sucesso!!!");
				}
			}
		}	
  }
}

	