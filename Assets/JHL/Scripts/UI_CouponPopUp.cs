using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_CouponPopUp : MonoBehaviour
{
    public GameObject questPopUp; //����Ʈ�� �߰��Ǹ� ����Ʈ�� �ٲ�� ��.
    public GameObject parentObj;

    [SerializeField] List<GameObject> couponCharactors = new List<GameObject>();

    UIManager uiManager;
    void Start()
    {
        questPopUp.SetActive(false);

        //���� ĳ���͵� ����Ʈȭ
        for (int i = 0; i < parentObj.transform.childCount; i++)
        {
            //�ݶ��̴��� ���� �͵� üũ
            for (int j = 0; j < parentObj.transform.GetChild(j).transform.childCount; j++)
            {
                if (parentObj.transform.GetChild(j).transform.GetChild(j).GetComponent<MeshCollider>() != null)
                {
                    couponCharactors.Add(parentObj.transform.GetChild(i).transform.GetChild(j).gameObject);
                }
            }
            // couponCharactors.Add(parentObj.transform.GetChild(i).gameObject);
        }

        uiManager = GetComponent<UIManager>();
    }
    public bool isActive;
    void Update()
    {
        //����ڰ� ������Ʈ�� �ִ� ��ġ�� ����(������Ʈ���� active �����̸�) ����Ʈ �˾�â ����
        if (!isActive && parentObj.gameObject.activeInHierarchy)
        {
            questPopUp.SetActive(true);
            isActive = !isActive;
        }

        //������Ʈ ��ġ�ϸ� ����Ʈ ���� ��� +1�ϰ�, ������Ʈ ����
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;
        if (Physics.Raycast(Camera.main.transform.position, ray.direction, out hitinfo))
        {
            if (Input.GetMouseButtonDown(0) && couponCharactors.Contains(hitinfo.transform.gameObject))
            {
                uiManager.GotOne();
                Destroy(hitinfo.transform.parent.transform.gameObject);
            }
        }
    }
}
