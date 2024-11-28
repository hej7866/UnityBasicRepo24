using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class Pizza : Item
    {
        public override void Interact()
        {
            base.Interact();
            GameManager.instance.AddScore();
            Debug.Log("피자 아이템의 기능이 실행됩니다.");
        }

    }
}