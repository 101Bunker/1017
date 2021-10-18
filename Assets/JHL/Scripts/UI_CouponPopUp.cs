using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_CouponPopUp : MonoBehaviour
{
    public GameObject questPopUp; //퀘스트가 추가되면 리스트로 바꿔야 함.
    public GameObject parentObj;

    [SerializeField] List<GameObject> couponCharactors = new List<GameObject>();

    UIManager uiManager;
    void Start()
    {
        questPopUp.SetActive(false);

        //쿠폰 캐릭터들 리스트화
        for (int i = 0; i < parentObj.transform.childCount; i++)
        {
            //콜라이더를 가진 것들 체크
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
        //사용자가 오브젝트가 있는 위치로 가서(오브젝트들이 active 상태이면) 퀘스트 팝업창 열기
        if (!isActive && parentObj.gameObject.activeInHierarchy)
        {
            questPopUp.SetActive(true);
            isActive = !isActive;
        }

        //오브젝트 터치하면 퀘스트 바의 토글 +1하고, 오브젝트 삭제
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
