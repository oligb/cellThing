// Place the selected object randomly between the interval of the Min Max Slider
// in the X,Y,Z coords

class EditorGUIMinMaxSlider extends EditorWindow {
	
	var minVal : float = -10;
	var minLimit : float = -20;
	var maxVal : float = 10;
	var maxLimit : float = 20;
	
	@MenuItem("Examples/Editor GUI Move Object Randomly")
	static function Init() {
		var window = GetWindow(EditorGUIMinMaxSlider);
		window.Show();
	}
	
	function OnGUI() {
		EditorGUI.MinMaxSlider(
			GUIContent("Random range:"), 
			Rect(0,0,position.width,20),
			minVal, maxVal,
			minLimit, maxLimit);
		if(GUI.Button(Rect(0,25,position.width, position.height -25),"Randomize!"))
			PlaceRandomly();
	}
	
	function PlaceRandomly() {
		if(Selection.activeTransform)
			Selection.activeTransform.position = 
				Vector3(Random.Range(minVal, maxVal),
				        Random.Range(minVal, maxVal),
				        Random.Range(minVal, maxVal));
		else 
			Debug.LogError("Select a GameObject to randomize its position.");
	}
}