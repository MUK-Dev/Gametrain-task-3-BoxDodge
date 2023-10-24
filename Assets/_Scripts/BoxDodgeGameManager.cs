using System;
using UnityEngine;

public class BoxDodgeGameManager : MonoBehaviour
{
    public static BoxDodgeGameManager Instance { get; private set; }
    public event EventHandler OnLivesChange;
    public event EventHandler OnStarsChange;
    private int lives = 3;
    private int stars = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        OnLivesChange?.Invoke(this, EventArgs.Empty);
        OnStarsChange?.Invoke(this, EventArgs.Empty);
    }

    public void ReduceLife()
    {
        lives--;
        OnLivesChange?.Invoke(this, EventArgs.Empty);
    }

    public void IncreaseLife()
    {
        lives++;
        OnLivesChange?.Invoke(this, EventArgs.Empty);
    }

    public void IncreaseStars()
    {
        stars++;
        OnStarsChange?.Invoke(this, EventArgs.Empty);
    }

    public int GetLivesCount() => lives;
    public int GetStarsCount() => stars;
}
