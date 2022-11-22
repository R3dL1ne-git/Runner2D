using TMPro;
using UnityEngine;

public class RecordManager : MonoBehaviour
{
    public TMP_Text BestScore;
    public TMP_Text LastScore;

    void Start()
    {
        BestScore.text = $"Лучший счет: {PlayerPrefs.GetInt("coins")}";
        LastScore.text = $"Предыдущий счет: {PlayerPrefs.GetInt("lastCoins")}";
    }
}
