using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class Projectile : MonoBehaviour
    {
        public float speed = 3f;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            // 방향 * 속력 * 시간
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.collider.CompareTag("Animal"))  // Tag .Animal 대상이면  
            {
                // 자기자신과 충돌한 대상의 게임 오브젝트를 파괴해라
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}