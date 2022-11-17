using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RoomNodeGraphEditor : EditorWindow
{
   private GUIStyle _roomNodeStyle;
   
   //Node layout values
   private const float NODE_WIDTH = 160f;
   private const float NODE_HEIGHT = 75f;
   private const int NODE_PADDING = 25;
   private const int NODE_BORDER = 12;
   
   /// <summary>
   /// The MenuItem attribute allows you to add menu items to the main menu and Inspector window context menus.
    ///The MenuItem attribute turns any static function into a menu command. Only static functions can use the MenuItem attribute.
   /// </summary>
   [MenuItem("Room Node Graph Editor", menuItem = "Window/Dungeon Editor/ Room Node Graph Editor")] 
   
   private static void OpenWindow() //sadece static methodlar kullaniyor MenuItem
   {
      GetWindow<RoomNodeGraphEditor>("Room Node Graph Editor"); //GetWindow metodu EditorWindow class'indan geliyor.
   }

   private void OnEnable()
   {
      //Define node layout style

      _roomNodeStyle = new GUIStyle();
      _roomNodeStyle.normal.background = EditorGUIUtility.Load("node1") as Texture2D;
      _roomNodeStyle.normal.textColor = Color.white;
      _roomNodeStyle.padding = new RectOffset(NODE_PADDING, NODE_PADDING, NODE_PADDING, NODE_PADDING);
      _roomNodeStyle.border = new RectOffset(NODE_BORDER, NODE_BORDER, NODE_BORDER, NODE_BORDER);
   }


   /// <summary>
   /// Draw Editor Gui
   /// </summary>
   private void OnGUI()
   {
      Debug.Log("OnGuI Has Been Called"); //mouse yeni yaptigimiz editorwindow uzerinde gezdiginde oluyor.
      
      GUILayout.BeginArea(new Rect(new Vector2(100f, 100f), new Vector2(NODE_WIDTH, NODE_HEIGHT)),_roomNodeStyle);
      EditorGUILayout.LabelField("Node 1");
      GUILayout.EndArea();
      
      GUILayout.BeginArea(new Rect(new Vector2(300f, 300f), new Vector2(NODE_WIDTH, NODE_HEIGHT)),_roomNodeStyle);
      EditorGUILayout.LabelField("Node 2");
      GUILayout.EndArea();
      
      
      
   }
}
