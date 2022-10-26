using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPerguntas : MonoBehaviour
{
    List<Pergunta> perguntas = new List<Pergunta>();
    int perguntaDaVez;

    [Header("Alternativas")]
    [SerializeField] private Text alternativa1;
    [SerializeField] private Text alternativa2;
    [SerializeField] private Text alternativa3;
    [SerializeField] private Text alternativa4;

    [Header("Questão")]
    [SerializeField] private Text questao;

    [Header("Resultado")]
    [SerializeField] private Text resultado;
    [SerializeField] private GameObject botaoProxima;
    [SerializeField] private GameObject imgParabens;

    public void Start()
    {
        resultado.text = ""; //resultado começa sem nada

        perguntas.Add(RepositorioPerguntas.Pergunta1());
        perguntas.Add(RepositorioPerguntas.Pergunta2());
        perguntas.Add(RepositorioPerguntas.Pergunta3());
        perguntas.Add(RepositorioPerguntas.Pergunta4());
        perguntas.Add(RepositorioPerguntas.Pergunta5());

        CriarPergunta();
    }

    public void BotaoAlternativa(int numBotao)
    {
        switch (numBotao)
        {
            case 1:
                if(perguntas[perguntaDaVez].ConferirResposta(alternativa1.text))
                {
                    RespostaCorreta();
                }
                else
                {
                    RespostaErrada();
                }
                break;
            case 2:
                if (perguntas[perguntaDaVez].ConferirResposta(alternativa2.text))
                {
                    RespostaCorreta();
                }
                else
                {
                    RespostaErrada();
                }
                break;
            case 3:
                if (perguntas[perguntaDaVez].ConferirResposta(alternativa3.text))
                {
                    RespostaCorreta();
                }
                else
                {
                    RespostaErrada();
                }
                break;
            case 4:
                if (perguntas[perguntaDaVez].ConferirResposta(alternativa4.text))
                {
                    RespostaCorreta();
                }
                else
                {
                    RespostaErrada();
                }
                break;
        }
    }

    public void BotaoProxima()
    {
        resultado.text = "";
        botaoProxima.SetActive(false);

        if(Pergunta.perguntasQueJaForam <= 4)
        {
            CriarPergunta();
        }
        else
        {
            imgParabens.SetActive(true);
        }
    }

    private void CriarPergunta()
    {
        do
        {
            perguntaDaVez = Random.Range(0, 5);

        } while(perguntas[perguntaDaVez].GetRepetida());

        questao.text = perguntas[perguntaDaVez].GetQuestao().ToString();
        CriandoAlternativas(perguntas[perguntaDaVez]);
        perguntas[perguntaDaVez].PerguntaRepetida();                    
    }

    private void CriandoAlternativas(Pergunta pergunta)
    {
        int numeroAlternativa = Random.Range(0, 4);

        List<string> alternativas = pergunta.RetornarLista();

        switch (numeroAlternativa)
        {
            case 0:
                alternativa1.text = alternativas[0].ToString();
                alternativa2.text = alternativas[1].ToString();
                alternativa3.text = alternativas[2].ToString();
                alternativa4.text = alternativas[3].ToString();
                break;
            case 1:
                alternativa1.text = alternativas[3].ToString();
                alternativa2.text = alternativas[0].ToString();
                alternativa3.text = alternativas[1].ToString();
                alternativa4.text = alternativas[2].ToString();
                break;             
            case 2:
                alternativa1.text = alternativas[2].ToString();
                alternativa2.text = alternativas[3].ToString();
                alternativa3.text = alternativas[0].ToString();
                alternativa4.text = alternativas[1].ToString();
                break;
            case 3:
                alternativa1.text = alternativas[1].ToString();
                alternativa2.text = alternativas[2].ToString();
                alternativa3.text = alternativas[3].ToString();
                alternativa4.text = alternativas[0].ToString();
                break;
        }
    }  

    private void RespostaCorreta() //metodo para quando a resposta for correta
    {
        resultado.text = "PARABÉNS, VOCÊ ACERTOU!"; //mensagem que vai aparecer caso acerte a questão
        botaoProxima.SetActive(true); //ativando o botão para próxima pergunta
    }

    private void RespostaErrada() //metodo para caso a resposta estiver errada
    {   
        resultado.text = "QUE PENA, VOCÊ ERROU, CONTINUE TENTANDO"; //mensagem de erro
        botaoProxima.SetActive(false); //desativando o botão próximo(na unity ele ja ta desativado, é só pra confirmar)
    }
}
