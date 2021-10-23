using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using 

public class UI_QuestManager : MonoBehaviour
{
    public GameObject questContent;
    public List<string> questList = new List<string>();

    public void OnClickAcceptQuest(int number)
    {
        if (number == 0)
        {
            questContent.SetActive(true);
            // questContent.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = questList[number];
            //TMP ��� �� ������ ���� ������ Text�� ��ü��.
            questContent.transform.GetChild(1).GetComponent<Text>().text = questList[number];
        }
        else
        {
            GameObject questAdd = Instantiate(questContent);
            questAdd.transform.SetParent(questContent.transform.parent);
            questAdd.transform.GetChild(1).GetComponent<TextMeshPro>().text = questList[number];
        }
    }
}
