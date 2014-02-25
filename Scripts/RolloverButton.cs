using UnityEngine;
using System.Collections;

public class RolloverButton : MonoBehaviour {
	public int levelToLoadOnClick = 0;
	public Texture2D normalImage;
	public Texture2D rolloverImage;
	
	private void OnMouseOver(){
		guiTexture.texture = rolloverImage;
	}
	
	private void OnMouseExit(){
		guiTexture.texture = normalImage;		
	}
	
	private void OnMouseUp(){
		Application.LoadLevel( levelToLoadOnClick );
	}
}
