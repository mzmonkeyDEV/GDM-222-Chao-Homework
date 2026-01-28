using UnityEngine;

namespace Solution
{
    [CreateAssetMenu(fileName = "ItemPotion",menuName = "Item/ItemPotion")]
    public class ItemPotion : ItemData
    {
       public int HealPoint = 10;

       public override void Use(Identity identity)
        {
            base.Use(identity);
            OOPPlayer p = identity as OOPPlayer;
            p.Heal(HealPoint);
            Debug.Log($"Healed {HealPoint} from {ItemName}");
        }
    }
}
