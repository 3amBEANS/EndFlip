using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Vincent
{
    public class Switch : PlayerInteractable
    {
        [SerializeField] private List<AbstractReciver> recivers;
        private bool isOn = false;
        public override void collisionAction(Collider2D coll)
        {
            if (isOn)
            {
                foreach (AbstractReciver r in recivers)
                {
                    r.TurnOff();
                }
            }
            else
            {
                foreach (AbstractReciver r in recivers)
                {
                    r.TurnOn();
                }
            }
            isOn = !isOn;
        }
    }
}
