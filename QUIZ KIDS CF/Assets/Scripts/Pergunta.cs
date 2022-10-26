using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pergunta
{
    public static int perguntasQueJaForam = 0;

    private string questao;
    private List<string> alternativas = new List<string>();
    private string resposta;
    private bool repetida;

    public Pergunta(string questao, string resposta)
    {
        this.questao = questao;
        this.resposta = resposta;
    }
    public int GetPerguntasRepetidas()
    {
        return perguntasQueJaForam;
    }

    public string GetQuestao()
    {
        return this.questao;
    }

    public string GetResposta()
    {
        return this.resposta;
    }

    public bool GetRepetida()
    {
        return this.repetida;
    }

    public void PerguntaRepetida()
    {
        this.repetida = true;
        perguntasQueJaForam++;
    }

    public void InserirAlternativa(string alternativa)
    {
        this.alternativas.Add(alternativa);
    }

    public List<string> RetornarLista()
    {
        return this.alternativas;
    }

    public bool ConferirResposta(string alternativaEscolhida) //conferindo a resposta
    {
        if(this.resposta == alternativaEscolhida) // associando a resposta com a aalternativa
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
