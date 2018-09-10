using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompletePong{

	public class StartController : MonoBehaviour{

		void Start(){
			LevelManager.Instance.startGame();
		}

	}
}