using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class Animal : MonoBehaviour
    {
        public float speed = 3.0f;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            // 아래로 내려가는 코드를 작성하세요
            // transform .  동물이 내려오는 속도. 방향 * 속도 * 시간

            transform.position = transform.position + Vector3.back * speed * Time.deltaTime;
        }
    }
}