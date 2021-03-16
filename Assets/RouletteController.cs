using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0.0f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {  //마우스 왼쪽 버튼 돌아감
            this.rotSpeed = 20.0f;
        }

        if (Input.GetMouseButtonDown(1)) {  //마우스 오른쪽 버튼일 때 멈춤
            this.rotSpeed = 0.0f;
        }

        this.rotSpeed *= 0.987f;  //속도가 서서히 줄어 들음.
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
