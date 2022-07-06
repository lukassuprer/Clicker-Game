using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    [SerializeField]private int cookieNumber = 0;
    [SerializeField]private TextMeshProUGUI cookieMoney;
    private int autoCookieNumber = 0;

    public void CookieClick()
    {
        Debug.Log("Cookie Clicked");
        cookieNumber++;
        cookieMoney.text = cookieNumber.ToString();
    }
    
    public void BuyAutoCookieClick()
    {
        Debug.Log("Auto Cookie Clicked");
        autoCookieNumber++;
        StartCoroutine(AutoClick());
    }

    private IEnumerator AutoClick()
    {
        yield return new WaitForSeconds(1);
        cookieNumber += autoCookieNumber;
        cookieMoney.text = cookieNumber.ToString();
        StartCoroutine(AutoClick());
    }
}
