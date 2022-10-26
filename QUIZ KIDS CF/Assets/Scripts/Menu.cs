using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject telaSobre; //referencia para alocação do gameobject la na unity
    public GameObject telaMenu; //idem acima
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChamarSobre() //chamar tela sobre
    {
        telaMenu.SetActive(false);//desativando o painel menu
        telaSobre.SetActive(true);//ativando o painel sobre
    }

    public void ChamarMenu() //chamando a tela menu
    {
        telaSobre.SetActive(false); //desativando o painel sobre
        telaMenu.SetActive(true); //ativando o painel menu
    }

    public void ChamarJogar() //metodo para chamar a cena de jogo
    {
        SceneManager.LoadScene(1); //chamando a cena do jogo, 1 é devido a posição dela no building
    }

    public void ChamarCenaMenu() //chamando a tela menu do jogo, 0 é devido a posição dela no building
    {
        SceneManager.LoadScene(0); //carregando a cena menu no jogo
    }
}
