using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vincent
{
    public class ToggleReciever : AbstractReciver
    {
        Collider2D c;
        SpriteRenderer sr;
        Color og;
        public void Start()
        {
            c = GetComponent<Collider2D>();
            sr = GetComponent<SpriteRenderer>();
            og = sr.color;
            TurnOff();
        }
        public override void On()
        {
            c.enabled = true;
            sr.color = og;
        }
        public override void Off()
        {
            c.enabled = false;
            sr.color = new Color(og.r, og.g, og.b, og.a / 2);
        }
    }
}