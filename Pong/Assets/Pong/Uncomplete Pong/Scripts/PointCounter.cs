﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UncompletePong{

	public class PointCounter : MonoBehaviour{

		private int bounce = 0;

		private void OnCollisionEnter(Collision other){
			if (other.gameObject.name == "Ball"){
				LevelManager.Instance.updateScoreUI(bounce);
			}
		}
	}
}