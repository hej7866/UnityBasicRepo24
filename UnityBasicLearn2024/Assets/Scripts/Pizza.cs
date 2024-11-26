using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public class Pizza : MonoBehaviour, IitemColletable
    {
        public GameManager gameManager;

        public void Interact()
        {
            AddScore();
            Debug.Log("피자 섭취");
        }

        private void AddScore()
        {
            gameManager.curScore += 100;
        }
    }
}
