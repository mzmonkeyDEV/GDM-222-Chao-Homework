using UnityEngine;
using UnityEngine.U2D.IK;

namespace Solution
{
    public class OOPExit : Identity
    {
        public Canvas can;
        public override void Hit(Identity hitBy)
        {
            base.Hit(hitBy);
             if (hitBy is OOPPlayer)
            {
                mapGenerator.UpdatePositionIdentity(hitBy,positionX,positionY);
                can.gameObject.SetActive(true);
                hitBy.enabled = false;
            }
        }
    }
}