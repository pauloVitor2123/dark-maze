using UnityEngine;
using TMPro;
using LootLocker.Requests;
using UnityEngine.UI;

public class LootLocker_Sistema : MonoBehaviour
{
    private string Nome;
    private int Placar;
    public int ID_Leaderboard = 9118;
    int max = 5;
    public TextMeshProUGUI[] Jogadores;
    public Image loadingImage;

    private void Start()
    {
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            if (response.success)
            {
                Placar = PlayerPrefs.GetInt("Score");
                Nome = PlayerPrefs.GetString("Nome");
                if (Nome != "")
                {
                    EnviarPlacar();
                }
                MostrarPlacar();
            }
            else
            {
                Debug.Log("Erro na conexão");
            }
        });
    }

    public void EnviarPlacar()
    {
        LootLockerSDKManager.SubmitScore(Nome, Placar, ID_Leaderboard, (response) =>
        {
            if (response.success)
                Debug.Log("Enviado");
            else
                Debug.Log("Erro no envio");
        });
    }

    public void MostrarPlacar()
    {
        LootLockerSDKManager.GetScoreList(ID_Leaderboard, max, (response) =>
        {
            if (response.success)
            {
                loadingImage.enabled = false;
                LootLockerLeaderboardMember[] placares = response.items;
                for (int i = 0; i < placares.Length; i++)
                    Jogadores[i].text = placares[i].rank + "º " + placares[i].member_id + " - " + placares[i].score + "pts";

                if (placares.Length < Jogadores.Length)
                {
                    for (int i = placares.Length; i < max; i++)
                        Jogadores[i].text = "";
                }
            }
            else
                Debug.Log("Erro na placar");
        });
    }
}