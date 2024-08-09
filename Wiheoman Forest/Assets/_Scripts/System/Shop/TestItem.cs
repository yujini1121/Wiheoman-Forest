using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Add/Item")]
public class TestItem : ScriptableObject
{
    [Header("아이템 고유 ID(중복불가)")]
    [SerializeField] private int mItemID;
    // 아이템 고유 번호
    public int ItemID
    {
        get
        {
            return mItemID;
        }
    }

    [Header("아이템 이름")]
    [SerializeField] private string mItemName;
    public string ItemName
    {
        get
        {
            return mItemName;
        }
    }

    [Header("아이템 중첩이 가능한가?")]
    [SerializeField] private bool mCanOverlap;
    // 아이템 중첩 가능 여부a
    public bool CanOverlap
    {
        get
        {
            return mCanOverlap;
        }
    }

    [Header("상호작용이 가능한 아이템인가?")]
    [SerializeField] private bool mIsInteractivity;
    // 상호작용 가능 여부
    public bool IsInteractivity
    {
        get
        {
            return mIsInteractivity;
        }
    }

    [Header("사용하면 사라지는가?")]
    [SerializeField] private bool mIsConsumable;
    // 사용시 사라지는가
    public bool IsConsumable
    {
        get
        {
            return mIsConsumable;
        }
    }

    [Header("아이템 이미지")]
    [SerializeField] private Sprite mItemImage;
    public Sprite ItemImage
    {
        get
        {
            return mItemImage;
        }
    }

    /*
    [Header("아이템 설명")]
    [SerializeField] private string mItemDescription;
    public string ItemDescription
    {
        get
        {
            return mItemDescription;
        }
    }

    
    [Header("씬에서 오브젝트로 보여질 아이템 프리팹")]
    [SerializeField] private GameObject mItemPrefab;
    public GameObject ItemPrefab
    {
        get
        {
            return mItemPrefab;
        }
    }
    */
}
