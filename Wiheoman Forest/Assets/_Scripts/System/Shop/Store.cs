using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    [System.Serializable]
    public class ItemData
    {
        public int itemId;
        public string itemName;
        public string itemDescription;
        public int itemPrice;
    }

    [System.Serializable]
    public class ItemList
    {
        public List<ItemData> Item;
    }

    [SerializeField] private ItemList itemsList;
    [SerializeField] private int BeginLine;
    [SerializeField] private int EndLine;

    [Header("UI")]
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private TextMeshProUGUI itemDescriptionText;
    [SerializeField] private GameObject storeUI;

    private bool isStoreActive = false;

    private int currentLine = 1;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isStoreActive)
            {
                StoreActivate();
            }
            else 
            {
                isStoreActive = false;
                storeUI.SetActive(false);
            }
        }
    }

    private void StoreActivate()
    {
        isStoreActive = true;
        storeUI.SetActive(true);       

        Transform backGroundPanel = storeUI.transform.GetChild(0);
        Transform ImagePanel = backGroundPanel.transform.GetChild(0);
        GameObject itemImage = ImagePanel.transform.GetChild(0).gameObject;

        itemImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + itemsList.Item[currentLine].itemName);

        itemNameText.text = itemsList.Item[currentLine].itemName;
        itemDescriptionText.text = itemsList.Item[currentLine].itemDescription;
    }
}