using UnityEngine;
using UnityEditor;
using NUnit.Framework;

[CustomEditor(typeof(Brush))]
[CanEditMultipleObjects]
[ExecuteInEditMode]
public class BrushEditor : Editor {
	Brush brush;
	GameObject g;

	public override void OnInspectorGUI ()
	{
		DrawDefaultInspector ();
		brush = (Brush)target;
		brush.MousePosition ();
		g = EditorGUILayout.ObjectField (g, typeof(Object), true) as GameObject;
		g.transform.localScale = new Vector3 (brush.Radius * 2, brush.Radius * 2, 1);
	}

	void OnGUI() {
		g.transform.position = brush.MousePosition ();
		Debug.Log (brush.MousePosition ());
	}
}
