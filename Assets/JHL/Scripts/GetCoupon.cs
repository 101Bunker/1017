using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using maxstAR;

public class GetCoupon : MonoBehaviour
{
    void Start()
    {
        

    }

    void Update()
    {

        if (Input.touchCount > 0) //화면을 터치했을 때
        {
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hitinfo;

            if (Physics.Raycast(ray, out hitinfo))
            {
                if (hitinfo.transform.CompareTag("coupon"))               //쿠폰 태그를 가진 오브젝트를 클릭했다면
                {
                    Destroy(hitinfo.transform.gameObject);  //오브젝트 지우고

                    //UI 함수();
                }
            }
        }
    }  
 
}
