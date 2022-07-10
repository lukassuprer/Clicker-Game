using System;
using UnityEngine;

public class BuyObject : MonoBehaviour
{
    public int Price;
    public string Name;
    public bool IsUnlocked;
    public int Multiplier;
    public int LevelPriceIncrease;
    public int Level = 0;
    public int MaxLevel = 0;

    [SerializeField] private ClickManager clickManager;
    
    public void Buy()
    {
        if (IsUnlocked)
        {
            return;
        }

        if (GameManager.Instance.Money < Price) return;
        GameManager.Instance.Money -= Price;
        clickManager.Multiplier += Multiplier;
        Price += LevelPriceIncrease;
        Level++;
        if (Level >= MaxLevel)
        {
            IsUnlocked = true;
        }
    }
}
