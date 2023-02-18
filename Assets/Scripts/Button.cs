using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vincent
{
    public class Button : MonoBehaviour
    {
        [SerializeField] private List<AbstractReciver> recivers;
        public int numOn = 0;
        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player") || collision.CompareTag("PuzzleObject"))
            {
                numOn++;
                if (numOn > 0)
                    foreach (AbstractReciver r in recivers)
                    {
                        r.TurnOn();
                    }
            }
        }
        public void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag("Player") || collision.CompareTag("PuzzleObject"))
            {
                numOn--;
                if (numOn <= 0)
                    foreach (AbstractReciver r in recivers)
                    {
                        r.TurnOff();
                    }
            }
        }
    }
}
