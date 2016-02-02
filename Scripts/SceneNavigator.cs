using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour {

	private string queuedLevel = "MainMenu";

	public void QueueLevel(string level){

		this.queuedLevel = level;

	}

	public void Load(){

		SceneManager.LoadScene(queuedLevel);

	}
}
