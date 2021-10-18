using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject togglesQuest1;
    List<GameObject> toggleList = new List<GameObject>();
    [SerializeField]
    public List<Toggle> toggle = new List<Toggle>();

    int count = 0;

    Animator uiAnim;

    public GameObject clearUI_Quest1;

    void Awake()
    {
        for (int i = 0; i < togglesQuest1.transform.childCount; i++)
        {
            toggle.Add(togglesQuest1.transform.GetChild(i).GetComponent<Toggle>());
        }
        uiAnim = GetComponent<Animator>();

    }

    public void GotOne()
    {
        if (count < toggle.Count)
        {
            toggle[count].interactable = false;
            //toggleList[count].GetComponent<Toggle>().interactable = true;
            toggle[count].interactable = true;
            count += 1;

            //Äù½ºÆ® ´Ù Ã¤¿ì¸é ÄíÆù UI ³ª¿È
            if (count == toggle.Count)
            {
                clearUI_Quest1.SetActive(false);
                clearUI_Quest1.SetActive(true);
            }
        }
    }
    //public void GotOne(List<Toggle> toogleList)
    //{
    //    if (count < toogleList.Count)
    //    {
    //        //toggleList[count].GetComponent<Toggle>().interactable = true;
    //        toogleList[count].interactable = true;
    //        count += 1;
    //        if(count== toogleList.Count)
    //        {

    //        }
    //    }
    //}

    #region Button Functions
    bool clickedQuest;
    bool clickedInven;
    bool clickedMy;

    public GameObject[] panels;
    public void OnClickQuest()
    {
        clickedQuest = !clickedQuest;
        if (clickedQuest)
        {
            panels[0].SetActive(true);
            panels[1].SetActive(false);
            panels[2].SetActive(false);
            uiAnim.Play("Panel_Quest_up");

            clickedInven = false;
            clickedMy = false;
        }
        else
        {
            //  panels[0].SetActive(false);
            uiAnim.Play("Panel_Quest_down");
        }
    }
    public void OnClickInventory()
    {
        clickedInven = !clickedInven;
        if (clickedInven)
        {
            panels[0].SetActive(false);
            panels[1].SetActive(true);
            panels[2].SetActive(false);
            uiAnim.Play("Panel_Inventory_up");

            clickedMy = false;
            clickedQuest = false;
        }
        else
        {
            //  panels[0].SetActive(false);
            uiAnim.Play("Panel_Inventory_down");
        }
    }
    public void OnClickMy()
    {
        clickedMy = !clickedMy;
        if (clickedMy)
        {
            panels[0].SetActive(false);
            panels[1].SetActive(false);
            panels[2].SetActive(true);
            uiAnim.Play("Panel_My_up");

            clickedQuest = false;
            clickedInven = false;
        }
        else
        {
            //  panels[0].SetActive(false);
            uiAnim.Play("Panel_My_down");
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
    #endregion

}
