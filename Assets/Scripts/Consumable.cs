using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Vincent
{
    public abstract class Consumable : PlayerInteractable
    {
        public Sprite powerUpSprite;
        public override void collisionAction(Collider2D coll)
        {
            ConsumableManager.consumableManager.addConsumable(this);
        }
        public virtual void powerUpAction()
        {
            ConsumableManager.consumableManager.removeConsumable();
        }
    }
}
