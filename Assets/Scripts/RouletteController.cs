using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 클릭할 경우 회전속도 설정
        /*
            GetMouseButtonDown - 클릭 확인
            0은 왼쪽, 1은 오른쪽, 2는 휠 클릭을 의미함
        */
        if (Input.GetMouseButtonDown(0)){
            this.rotSpeed = 10;
        }

        // 회전 속도만큼 룰렛 회전
        /*
            Rotate - 오브젝트 회전 가능
            양수면 시계 반대 방향, 음수면 시계 방향으로 회전
        */
        transform.Rotate(0, 0, this.rotSpeed);

        // 룰렛 감속
        /*
            감쇠 계수를 곱해서 줄여줌. 지수함수처럼 감속하므로 자연스럽게 줄어듬.
        */
        this.rotSpeed *= 0.96f;
    }
}
