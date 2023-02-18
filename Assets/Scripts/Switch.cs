using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : PlayerInteractable
{
    [SerializeField] private List<AbstractReciver> recivers;
    private bool isOn = false;
    public override void collisionAction(Collider2D coll)
    {
        if(isOn)
        {
            foreach(AbstractReciver r in recivers)
            {
                r.Off();
            }
        }
        else
        {
            foreach (AbstractReciver r in recivers)
            {
                r.On();
            }
        }
        isOn = !isOn;
    }
}
