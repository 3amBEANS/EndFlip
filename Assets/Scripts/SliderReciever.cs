using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderReciever : AbstractReciver
{
    public Transform from, to;
    private bool atStart = true;
    public override void On()
    {
        atStart = false;
    }
    public override void Off()
    {
        atStart = true;
    }
    public void Update()
    {
        if(atStart)
        {
            transform.position = Vector3.MoveTowards(transform.position, from.position, Time.deltaTime * 10);
            Quaternion.RotateTowards(transform.rotation, from.rotation, Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, to.position, Time.deltaTime * 10);
            Quaternion.RotateTowards(transform.rotation, to.rotation, Time.deltaTime);
        }

    }
}
