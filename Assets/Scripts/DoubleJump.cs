using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vincent
{
    public class DoubleJump : Consumable
    {
        public override void powerUpAction()
        {
            Debug.Log("player double jump");
            base.powerUpAction();
        }
    }
}
