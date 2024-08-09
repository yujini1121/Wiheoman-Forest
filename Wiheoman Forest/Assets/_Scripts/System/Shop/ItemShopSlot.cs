using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemShopSlot : MonoBehaviour
{
    [Header("판매할 아이템")]
    [SerializeField] public TestItem sellItem;

    [Header("거래 당 아이템 비용")]
    [SerializeField] public int itemCost;

    [Header("지급되는 아이템 수")]
    [SerializeField] public int buyItemCount;

    [Header("상점 UI")]
    [SerializeField] private GameObject storeUI;
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private TextMeshProUGUI itemCostText;
    [SerializeField] private TextMeshProUGUI itemDescriptionText;
    [SerializeField] private Button buyButton;

    private bool isStoreActive = false;
    private int totalCost;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isStoreActive)
            {
                isStoreActive = true;
                storeUI.SetActive(true);
                InitSlot();
            }
            else 
            {
                isStoreActive = false;
                storeUI.SetActive(false);
            }
        }
    }

    private void InitSlot()
    {
        totalCost = 0;

        itemImage.sprite = sellItem.ItemImage;
        itemNameText.text = sellItem.ItemName;
        itemCostText.text = totalCost.ToString();
        // itemDescriptionText.text = sellItem.ItemDescription;

        buyButton.onClick.RemoveAllListeners();
        buyButton.onClick.AddListener(OnBuyButtonClicked);
    }

    public void OnBuyButtonClicked()
    {
        totalCost += itemCost;
        itemCostText.text = totalCost.ToString();
        Debug.Log("아이템 구매함");
    }
}
