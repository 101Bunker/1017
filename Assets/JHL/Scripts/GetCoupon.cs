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

        if (Input.touchCount > 0) //ȭ���� ��ġ���� ��
        {
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hitinfo;

            if (Physics.Raycast(ray, out hitinfo))
            {
                if (hitinfo.transform.CompareTag("coupon"))               //���� �±׸� ���� ������Ʈ�� Ŭ���ߴٸ�
                {
                    Destroy(hitinfo.transform.gameObject);  //������Ʈ �����

                    //UI �Լ�();
                }
            }
        }
    }  
 
}
