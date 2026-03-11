using Solution;
using UnityEngine;

namespace Solution
{
    public class NPC : Identity
    {
        public DialogueUI dialogueUI;
        public DialogueSequen sequen;
        public bool canTalk = true;

        public override void SetUP()
        {
            base.SetUP();
            Name = "NPC";
            Invoke("SetMapData", 0.1f);
        }
        void SetMapData()
        {
            mapGenerator = FindFirstObjectByType<OOPMapGenerator>();
            mapGenerator.mapdata[positionX, positionY] = this;
        }
        public override void Hit(Identity identity)
        {

        }
    }

}
