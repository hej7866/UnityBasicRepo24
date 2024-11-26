using System.Collections;
using System.Collections.Generic;
using UnityBasic.ProtoType2;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class PM : MonoBehaviour
    {
        public float speed = 5.0f;
        public GameObject food;
        public Vector3 offset;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            Move();
            Attack();
        }

        private void Attack()
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                Vector3 foodPos = new Vector3(transform.position.x, transform.position.y, transform.position.z) + offset;

                Instantiate(food, foodPos, Quaternion.identity);
            }
        }

        private void Move()
        {
            // -20 > transform.position.x  -20 바꿔라   
            if (transform.position.x < -20)
            {
                transform.position = new Vector3(-20, transform.position.y, transform.position.z);
            }
            // 20 < transforn.position.x 20    traosform.position.x = 20
            if (transform.position.x > 20)
            {
                transform.position = new Vector3(20, transform.position.y, transform.position.z);
            }

            // transform 위치 + 변화 값( 방향 * 이동 속도 * 시간)

            // 방향 얻어 오기위해서
            float horiontalInput = Input.GetAxis("Horizontal");
            //Debug.Log($"입력받은 수평 값 : {horiontalInput}");
            transform.position = transform.position + Vector3.right * horiontalInput * speed * Time.deltaTime;
        }

    
        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Item"))
            {
                IitemColletable item = other.GetComponent<IitemColletable>();
                item.Interact();

                speed += 2;
                Destroy(other.gameObject);
            }
        }
        
    }
}