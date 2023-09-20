using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorDisparosUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    public void UpdateScoreText(int score)
    {
        _scoreText.SetText(score.ToString());
    }
}
