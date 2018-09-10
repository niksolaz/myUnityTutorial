using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UncompletePong{

	public class StartController : MonoBehaviour{

		void Start(){
			LevelManager.Instance.startGame();
		}

	}
}