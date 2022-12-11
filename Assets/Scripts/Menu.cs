using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public TMP_InputField nameValue;

    void Start()
    {
        string nome = PlayerPrefs.GetString("Nome");
        if (nome != "" && nameValue)
        {
            nameValue.text = nome;
        }

    }

    public void SceneLoad(string Cena)
    {
        PlayerPrefs.SetString("Nome",nameValue.text);
        if(nameValue.text != "")
        {
            SceneManager.LoadScene(Cena);
        }else
        {
            ErrorPresenter.Show("Para jogar é necessário informar o nome.");
        }

    }

    public void LoadSceneMenu(string MenuScene)
    {
        SceneManager.LoadScene(MenuScene);

    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Jogo fechando");
    }
}
