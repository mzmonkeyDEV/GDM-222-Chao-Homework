using UnityEngine;

namespace Solution
{
    public class OOPExit : Identity
    {
        public GameObject YouWin;
        
        public override void Hit(Identity hitBy)
        {
            if (hitBy is OOPPlayer) {
                OOPPlayer player = (OOPPlayer) hitBy;
                player.UpdatePosition(this.positionX, this.positionY);
                mapGenerator.playerScript.enabled = false;
                YouWin.SetActive(true);
                Debug.Log("You win");
            }
            
        }
    }
}