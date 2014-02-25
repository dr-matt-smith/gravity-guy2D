using UnityEngine;
using System.Collections;

public class AnimatedSprite : MonoBehaviour 
{
	public float frameInterval = 0.9f;
	public Sprite[] spriteArray;
	private int spriteIndex = 0;
	private SpriteRenderer spriteRenderer;

	private void Awake() 
	{
		spriteRenderer = GetComponent<SpriteRenderer>();

		if (spriteArray.Length < 1)
			Debug.LogError("no sprite in array!");
		else
			StartCoroutine( PlayAnimation() );		
	}

	private IEnumerator PlayAnimation()
	{
		while( true )
		{
			ChangeSprite();
			yield return new WaitForSeconds(frameInterval);				
		}		
	}

	private void ChangeSprite()
	{
		spriteIndex++;
		spriteIndex = (spriteIndex % spriteArray.Length);
		Sprite nextSprite = spriteArray[ spriteIndex ];
		spriteRenderer.sprite = nextSprite;
	}
}
