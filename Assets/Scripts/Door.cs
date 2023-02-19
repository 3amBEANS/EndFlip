using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Vincent
{
    public class Door : PlayerInteractable
    {
        public override void collisionAction(Collider2D coll)
        {
            if(ConsumableManager.curConsumable.GetType() == typeof(Key))
            {
                Open();
            }
        }
        public void Open()
        {
            Destroy(gameObject);
        }
    }
}
