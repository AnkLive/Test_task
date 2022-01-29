using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ObjectSizeSetting)), CanEditMultipleObjects]
public class ObjectSizeSettingCustomEditor : Editor
{
    SerializedProperty objSize;
 
    void OnEnable()
    {
        objSize = serializedObject.FindProperty("_objSize");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        ObjectSizeSetting objectSizeSetting = (ObjectSizeSetting)target;
        EditorGUILayout.LabelField("���������", EditorStyles.boldLabel);
        EditorGUILayout.Space();
        objSize.intValue = EditorGUILayout.IntField("������ ������", objSize.intValue);
        objectSizeSetting.SetSizeObject();

        if (GUI.changed) EditorUtility.SetDirty(objectSizeSetting);

         serializedObject.ApplyModifiedProperties();
    }
}
