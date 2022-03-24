using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField]private InventoryItem item;

        // Use this for initialization
        void Start()
        {
            item = new InventoryItem();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}