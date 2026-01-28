using UnityEngine;

namespace Solution
{

    public class OOPItem : Identity
    {
        public ItemData ItemData;
        public override void Hit(Identity hitBy)
        {
            base.Hit(hitBy);
            if (hitBy is Character)
            {
                mapGenerator.UpdatePositionIdentity(hitBy,positionX,positionY);
                ItemData.Use(hitBy);
                Destroy(gameObject);
            }
        }
       
    }
}