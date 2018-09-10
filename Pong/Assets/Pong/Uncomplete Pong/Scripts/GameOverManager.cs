using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UncompletePong{
	
	public class GameOverManager : MonoBehaviour{

		private void OnCollisionEnter(Collision other){
			if (other.gameObject.name == "Ball"){
				gameOver();
			}
		}

		private void gameOver(){}
	}
}