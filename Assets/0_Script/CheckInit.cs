using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckInit : MonoBehaviour
{
    [SerializeField] TMP_Text checkText;

    [SerializeField] IAP_Manager IAP_Manager;

    float frame;

    void Start()
    {

    }

    void Update()
    {
        if (frame > Time.time)
        {
            return;
        }

        frame += 0.1f;

        if (IAP_Manager.CanShowShop())
        {
            checkText.text = "can show shop";
        }
        else
        {
            checkText.text = "can not show shop";
        }
    }
}
