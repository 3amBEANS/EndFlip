using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Vincent
{
    public abstract class AbstractReciver : MonoBehaviour
    {
        public bool inverted;
        public abstract void On();
        public abstract void Off();
        public void TurnOn()
        {
            if (inverted) Off();
            else On();
        }

        public void TurnOff()
        {
            if (inverted) On();
            else Off();
        }
    }
}