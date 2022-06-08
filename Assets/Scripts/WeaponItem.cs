using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KL
{
    [CreateAssetMenu(menuName = "Items/Weapon")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;
    }
}