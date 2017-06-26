using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
	public static int GameState; //1 = 플레이어 이동, 2 = 좀비 이동, 3 = 전투
	public int maxActPoint;
	public static int? actPoint;

	private void Start()
	{
		actPoint = null;
	}

	private void Update()
	{
		switch(GameState)
		{
			case 1:
				if(actPoint.HasValue == false)
					actPoint = maxActPoint;
			break;
			case 2:
			break;
			case 3:
			break;
			default:
				Debug.Log("심각한 에러가 발생했습니다. GameState가 벗어났습니다.");
			break;
		}
	}

	public void PlayerTurnEnd()
	{
		GameState = GameState + 1;
	}
}