using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public interface IitemColletable
    {
        public void Interact();
    }
    public class Banana : MonoBehaviour, IitemColletable
    {
        public void Interact()
        {
            Debug.Log("바나나 실행");
        }
    }
}
