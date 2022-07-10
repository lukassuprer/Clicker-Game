using System.Collections;
using TMPro;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI cookieMoney;
    [SerializeField]private int autoCookieNumber = 0;
    public int Multiplier = 1;

    public void CookieClick()
    {
        Debug.Log("Cookie Clicked");
        GameManager.Instance.Money += (1 * Multiplier);
        cookieMoney.text = GameManager.Instance.Money.ToString();
    }
    
    public void BuyAutoCookieClick()
    {
        Debug.Log("Auto Cookie Clicked");
        autoCookieNumber ++;
        StartCoroutine(AutoClick());
    }

    private IEnumerator AutoClick()
    {
        yield return new WaitForSeconds(1);
        GameManager.Instance.Money += autoCookieNumber;
        cookieMoney.text = GameManager.Instance.Money.ToString();
        StartCoroutine(AutoClick());
    }
}   
