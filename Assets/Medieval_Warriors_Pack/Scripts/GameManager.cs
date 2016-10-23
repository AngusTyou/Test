using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Transform EnemyHome;
	public Transform KnightHome;


	// Use this for initialization
	void Start () {
		
		GameObject Enemy = Instantiate(Resources.Load ("Prefabs/Knight2_Sword")) as GameObject;
		Enemy.transform.SetParent (EnemyHome);
		Enemy.transform.position = EnemyHome.localPosition;

		// Knight作成
		GameObject Knight = Instantiate(Resources.Load ("Prefabs/Knight1_Sword")) as GameObject;
		Knight.transform.SetParent (KnightHome);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
//		Debug.Log ("1");
//		GameObject Enemy  = (GameObject)Resources.Load("Prefabs/Knight2_Sword");
//		Instantiate (Enemy, Vector3.zero, Quaternion.identity);
//		Enemy.transform.SetParent (EnemyHome);
	}
}
