using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeTypeListSO", menuName = "ScriptableObjects / Dungeon/Room Node Type List")]
public class RoomNodeTypeListSO : ScriptableObject
{
   #region ROOMNODE TYPE LIST

   

   #endregion
   //list of room node types (so we can easily populate in the inspector)
   public List<RoomNodeTypeSO> List;
   
    //Validation
#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEnumerableValues(this, nameof(List), List);
    }
#endif
}
