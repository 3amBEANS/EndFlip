using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Vincent
{
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
            if (atStart)
            {
                transform.SetPositionAndRotation(Vector3.MoveTowards(transform.position, from.position, Time.deltaTime * Vector2.Distance(from.position, to.position)), Quaternion.RotateTowards(transform.rotation, from.rotation, Time.deltaTime * Quaternion.Angle(from.rotation, to.rotation)));
            }
            else
            {
                transform.SetPositionAndRotation(Vector3.MoveTowards(transform.position, to.position, Time.deltaTime * Vector2.Distance(from.position, to.position)), Quaternion.RotateTowards(transform.rotation, to.rotation, Time.deltaTime * Quaternion.Angle(from.rotation, to.rotation)));
            }

        }
    }
}
