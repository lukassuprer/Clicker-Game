using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public static ShopManager Instance;
    [SerializeField]private GameObject shopPanel;

    public void ShopButton()
    {
        shopPanel.SetActive(shopPanel.activeSelf == false);
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
