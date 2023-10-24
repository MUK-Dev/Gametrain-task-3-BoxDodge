using System;
using TMPro;
using UnityEngine;

public class StarsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI starsText;

    private void Start()
    {
        BoxDodgeGameManager.Instance.OnStarsChange += BDGM_OnStarsChange;
    }

    private void BDGM_OnStarsChange(object sender, EventArgs e)
    {
        int stars = BoxDodgeGameManager.Instance.GetStarsCount();
        if (stars < 1) starsText.text = "0";
        else starsText.text = stars.ToString();
    }
}
