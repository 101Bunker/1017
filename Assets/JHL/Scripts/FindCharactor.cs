//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class FindCharactor : MonoBehaviour
//{
//    public GameObject parentObj;
//    GameObject monitorChar;
//    GameObject monitorCharTwo;
//    GameObject egg;
//    //GameObject[] charactors;
//    //List<GameObject> charactors = new List<GameObject>();
//    UIManager canvas;
//    public GameObject findCharactorPopUp;

//    int count;
//    void Start()
//    {
//        findCharactorPopUp.SetActive(false);

//        monitorChar = GameObject.Find("MonitorCollider");
//        monitorCharTwo = GameObject.Find("MonitorCollider_2");
//        egg = GameObject.Find("eggCollider");
//        //for (int i = 0; i <charactors.Length; i++)
//        //{
//        //    charactors.Add(i)
//        //}
////charactors = GameObject.FindGameObjectsWithTag("CharactorCollder");
//        canvas = GetComponent<UIManager>();
//    }

//    void Update()
//    {
        
//        if (parentObj != null && parentObj.gameObject.activeInHierarchy==true /*&& count==0*/)
//        {
//           // count++;
//            findCharactorPopUp.SetActive(true);
//        }
//        //else
//        //{
//        //    findCharactorPopUp.SetActive(false);

//        //}


//        //오브젝트 터치하면 토글+1하고, 오브젝트 삭제함
//        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//        RaycastHit hitinfo;
//        if (Physics.Raycast(Camera.main.transform.position, ray.direction, out hitinfo))
//        {
          
//            if (Input.GetMouseButtonDown(0) && hitinfo.transform.gameObject == monitorChar.transform.gameObject)
//            {
//                Debug.Log("got");
//                canvas.GotOne();
//                monitorChar.transform.parent.gameObject.SetActive(false);
//               //Destroy(monitorChar.transform.parent.gameObject);

//                // findCharactorPopUp.SetActive(true);
//            }
//            if (Input.GetMouseButtonDown(0) && hitinfo.transform.gameObject == monitorCharTwo.transform.gameObject)
//            {
//                Debug.Log("got");
//                canvas.GotOne();
//                monitorCharTwo.transform.parent.gameObject.SetActive(false);

//                //Destroy(monitorCharTwo.transform.parent.gameObject);

//                // findCharactorPopUp.SetActive(true);
//            }
//            if (Input.GetMouseButtonDown(0) && hitinfo.transform.gameObject == egg.transform.gameObject)
//            {
//                Debug.Log("got");
//                canvas.GotOne();
//                egg.transform.parent.gameObject.SetActive(false);

//                //Destroy(monitorCharTwo.transform.parent.gameObject);

//                // findCharactorPopUp.SetActive(true);
//            }
//        }
//    }
//}

