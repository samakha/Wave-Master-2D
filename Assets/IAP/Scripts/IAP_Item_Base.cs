using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IAP_Item_Base : MonoBehaviour
{
    [SerializeField]
    internal int productID;

    [SerializeField] Text tmpPrice;
    [SerializeField] Text tmpName;

    private void OnEnable()
    {
        GetComponentInChildren<UnityEngine.UI.Button>().onClick.AddListener(Buy);
        productID = transform.GetSiblingIndex();
    }

    [SerializeField]
    IAP_Manager IAP_Manager;
    //SubcribeManager subManager;

    private void Awake()
    {
        //_iapManager = FindObjectOfType<IAP_Manager>();
        
    }

    private void Start()
    {
        IAP_Manager.OnInitDone -= OnUpdateItem;
        IAP_Manager.OnInitDone += OnUpdateItem;
        OnUpdateItem();
    }

    void OnUpdateItem()
    {
        //check available to purchase item
        if (IAP_Manager.CanShowItem(IAP_Manager.id[productID]))
        {
            tmpPrice.text = IAP_Manager.GetPrice(IAP_Manager.id[productID]);
           // tmpName.text = IAP_Manager.GetName(IAP_Manager.id[productID]);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

    private void Buy()
    {
        //Debug.Log(IAP_Manager.id[_productID]);
        if (IAP_Manager != null && !string.IsNullOrEmpty(IAP_Manager.id[productID]))
        {
            //_iapManager.BuyProductID(IAP_Manager.id[_productID], (result) =>
            //{
            //    BuyCallBack(result, IAP_Manager.id[_productID]);
            //});
            IAP_Manager.BuyProductID(productID, (result) =>
            {
                BuyCallBack(result, IAP_Manager.id[productID]);
            });
        }
    }

    private void OnDisable()
    {
        GetComponentInChildren<UnityEngine.UI.Button>().onClick.RemoveAllListeners();
    }

    public virtual void BuyCallBack(bool result, string productID)
    {
        //if (subManager == null)
        //{
        //    subManager = FindObjectOfType<SubcribeManager>();
        //}

        if (productID.Equals(IAP_Manager.id[0]))
        {
            //DataManager.instance.SetHeart(25);
        }

        if (productID.Equals(IAP_Manager.id[1]))
        {
        }

        if (productID.Equals(IAP_Manager.id[2]))
        {
        }

        if (productID.Equals(IAP_Manager.id[3]))
        {
        }

        if (productID.Equals(IAP_Manager.id[4]))
        {
        }
        if (productID.Equals(IAP_Manager.id[5]))
        {
        }

        //sub
        //if (subManager == null) return;

        //if (productID.Equals(id[6]))
        //{
        //    subManager.UnlockSub(1);
        //}

        //if (productID.Equals(id[7]))
        //{
        //    subManager.UnlockSub(2);
        //}

        //if (productID.Equals(id[8]))
        //{
        //    subManager.UnlockSub(3);
        //}

        //if (productID.Equals(id[9]))
        //{
        //    subManager.UnlockSub(4);
        //}

        //if (productID.Equals(id[_productID]))
        //{
        //    subManager.UnlockSub(10);
        //}

        //if (productID.Equals(id[_productID]))
        //{
        //    subManager.UnlockSub(11);
        //}
        //subManager.AddCoinEveryDay();
    }

}
