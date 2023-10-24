using System;
using TMPro;
using UnityEngine;

public class LivesUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI livesText;

    private void Start()
    {
        BoxDodgeGameManager.Instance.OnLivesChange += BDGM_OnLivesChange;
    }

    private void BDGM_OnLivesChange(object sender, EventArgs e)
    {
        int lives = BoxDodgeGameManager.Instance.GetLivesCount();
        if (lives < 1) livesText.text = "0";
        else livesText.text = lives.ToString();
    }
}
