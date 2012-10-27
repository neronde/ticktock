using UnityEngine;
using System.Collections;

public class CollectibleSpawner : MonoBehaviour {
	
	public Transform collectiblePrefab;
	public int numberOfCollectibles;
	
	void Start() {
		var amountToAdd = 360f / numberOfCollectibles;
		var startingPosition = transform.localPosition;
		startingPosition.x = -0.006980963f;
		startingPosition.y = 1f;
		startingPosition.z = 0.3999391f;
		
		for (int i = 1; i < numberOfCollectibles; i++) {
			Transform collectible = (Transform)Instantiate(collectiblePrefab);
			collectible.transform.parent = gameObject.transform;
			collectible.localPosition = startingPosition;
			
			var scale = collectible.localScale;
			scale.x = 0.05f;
			scale.y = 0.05f;
			scale.z = 0.05f;
			collectible.localScale = scale;
			
			collectible.RotateAround(Vector3.zero, Vector3.up, amountToAdd*i);
			
		}
	}
}