using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace Solution
{
    public class ActionHistoryManager : MonoBehaviour
    {
        // 1. Undo System using Stack
   

        // 2. Auto-Move System using Queue

        #region "This Is undoStack Function"

        /// Saves the current player state (position) to the undo stack.
        public void SaveStateForUndo(Vector2 currentPosition)
        {
            
        }
        /// Reverts the player's state to the previous one using the undo stack.
        /// </summary>
        public void UndoLastMove(OOPPlayer player)
        {
           
        }
        public void RedoLastMove(OOPPlayer player)
        {
            
        }
        #endregion

        #region "This Is autoMoveQueue Function"

        public void StartAutoMoveSequence(OOPPlayer player)
        {
           
        }
        public IEnumerator ProcessAutoMoveSequence(List<Vector2> moves, OOPPlayer player)
        {

            // 1. เตรียม Queue: ล้าง Queue เดิมและเพิ่มลำดับการเคลื่อนที่ใหม่
           
            // 2. ประมวลผล Queue ทีละขั้นตอน
          
            yield return new WaitForSeconds(0.5f);

            Debug.Log("Auto-move sequence finished.");
        }

        #endregion

    }
}

