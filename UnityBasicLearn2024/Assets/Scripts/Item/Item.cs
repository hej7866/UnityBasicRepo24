using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class Item : MonoBehaviour, IitemCollectable
    {
        public virtual void Interact()
        {
            GameManager.instance.AddScore();
        }
    }
}