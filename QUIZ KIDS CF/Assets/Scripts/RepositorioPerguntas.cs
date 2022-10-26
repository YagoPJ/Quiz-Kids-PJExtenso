using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositorioPerguntas
{
    public static Pergunta Pergunta1()
    {
        string questao = "Onde se pode brincar ?"; //Criando a questão
        string resposta = "No campo de futebol"; //Criando a resposta
        Pergunta pergunta = new Pergunta(questao, resposta); //Criando a pergunta com a reposta

        pergunta.InserirAlternativa("Perto da mãe cozinhando"); //Criando as alternativas
        pergunta.InserirAlternativa("Ao lado da tomada");
        pergunta.InserirAlternativa("No campo de futebol");
        pergunta.InserirAlternativa("Perto de uma fogueira");

        return pergunta;
    }

//Daqui pra baixo segue o modelo de cima
    public static Pergunta Pergunta2()
    {
        string questao = "Qual o melhor lugar para soltar pipa";
        string resposta = "No parque";
        Pergunta pergunta = new Pergunta(questao, resposta);

        pergunta.InserirAlternativa("No parque");
        pergunta.InserirAlternativa("Perto dos fios elétricos");
        pergunta.InserirAlternativa("Na rua");
        pergunta.InserirAlternativa("Próximo ao rio");

        return pergunta;
    }

    public static Pergunta Pergunta3()
    {
        string questao = "O que passar para aliviar dores de queimadura ?";
        string resposta = "Água corrente";
        Pergunta pergunta = new Pergunta(questao, resposta);

        pergunta.InserirAlternativa("Maisena");
        pergunta.InserirAlternativa("Água corrente");
        pergunta.InserirAlternativa("Clara de ovo");
        pergunta.InserirAlternativa("Álcool");

        return pergunta;
    }

    public static Pergunta Pergunta4()
    {
        string questao = "Quem deve chamar, caso você se queime ?";
        string resposta = "Samu";
        Pergunta pergunta = new Pergunta(questao, resposta);

        pergunta.InserirAlternativa("Samu");
        pergunta.InserirAlternativa("Policia");
        pergunta.InserirAlternativa("Vizinho");
        pergunta.InserirAlternativa("Batman");

        return pergunta;
    }

    public static Pergunta Pergunta5()
    {
        string questao = "O que fazer quando estiver próximo de uma fogueira ?";
        string resposta = "Ficar longe";
        Pergunta pergunta = new Pergunta(questao, resposta);

        pergunta.InserirAlternativa("Pular ela");
        pergunta.InserirAlternativa("Dormir perto");
        pergunta.InserirAlternativa("Colocar a mão");
        pergunta.InserirAlternativa("Ficar longe");

        return pergunta;
    }
}
