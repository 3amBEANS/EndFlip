using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
namespace Vincent
{
    public class ConsumableManager : MonoBehaviour
    {
        private static Image consumableUI;
        public static Consumable curConsumable;
        [HideInInspector]public static ConsumableManager consumableManager;
        public Sprite emptySprite;
        
        // Start is called before the first frame update
        void Start()
        {
            if (consumableManager == null)
            {
                consumableManager = this;
                consumableUI = GetComponent<Image>();
            }
            else
            {
                Debug.LogWarning("2 consumable manager scripts located");
                Destroy(this);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.E) && curConsumable != null)
            {
                curConsumable.powerUpAction();
            }
        }

        public void addConsumable(Consumable c)
        {
            curConsumable = c;
            consumableUI.sprite = c.powerUpSprite;
        }
        public void removeConsumable()
        {
            curConsumable = null;
            consumableUI.sprite = emptySprite;
        }
    }
}