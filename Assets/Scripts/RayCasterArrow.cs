using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasterArrow : MonoBehaviour {

	public LayerMask myMask;

	public GameObject greatSign;
	public GameObject badSign;


	void OnMouseDown()
	{
		RaycastHit2D hit = Physics2D.Raycast (new Vector2 (this.transform.position.x, this.transform.position.y + 2.5f), Vector2.down, Mathf.Infinity, myMask.value);

		if (hit.collider != null) 
		{
	
			if (hit.distance < 3)
			{
				Debug.Log ("Excelent");
				MinigameManager.Control.AddPoints(50);
				Destroy (hit.collider.gameObject);
				Instantiate (greatSign, new Vector3(5,-5,0), Quaternion.identity);
			} else if (hit.distance > 3 && hit.distance < 5)
			{
				Debug.Log ("Good");
				MinigameManager.Control.AddPoints(25);
				Destroy (hit.collider.gameObject);
			}else if (hit.distance > 5)
			{
				Debug.Log("Wrong");
				Instantiate (badSign, new Vector3(5,-5,0), Quaternion.identity);
				MinigameManager.Control.AddPoints(-10);
			}			

			MinigameManager.Control.startCounting = true;
		}
	}

	/*void OnDrawGizmosSelected() {
		Gizmos.color = Color.green;
		Vector2 direction = transform.TransformDirection(Vector2.down) * 3;
		Gizmos.DrawRay(new Vector2 (this.transform.position.x, this.transform.position.y + 1.5f), direction);
	}*/
}
