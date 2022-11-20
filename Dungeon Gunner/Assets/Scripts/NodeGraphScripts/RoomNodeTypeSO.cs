using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "RoomNodeType", menuName = "ScriptableObjects/Dungeon/RoomNodeType")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string RoomNodeTypeName;

    #region Header
    [Header("Only flag the RoomNodeTypes that should e visible in the editor")]
    #endregion
    public bool DisplayInNodeGraphEditor = true;
    #region Header
    [Header("One type should be a corridor")]
    #endregion
    public bool IsCorridor;
    #region Header
    [Header("One type should be a corridor NS")]
    #endregion
    public bool IsCorridorNS;
    #region Header
    [Header("One type should be a corridor EW")]
    

    #endregion
    public bool IsCorridorEW;
    #region Header
    [Header("One type should be an Entrance")]
    

    #endregion
    public bool IsEntrance;
    #region Header
    [Header("One type should be Boss Room")]
    #endregion
    public bool IsBossRoom;
    #region Header
    [Header("One type should be a Non Assigned")]
    

    #endregion
    public bool IsNone;

    #region Validation

#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEmptyString(this, nameof(RoomNodeTypeName), RoomNodeTypeName);
    }
#endif
    

    #endregion
  
}
