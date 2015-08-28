using UnityEngine;
using System.Collections;

public class Utilities {

	public static GameObject[] CombineGameObjectArrays(params GameObject[][] arrays){
		int totalSize = 0;
		int overallIndex = 0;
		
		for(int i = 0; i < arrays.Length; i++){
			totalSize += arrays[i].Length;
		}
		
		GameObject[] combinedArrays = new GameObject[totalSize];
		
		for(int i = 0; i < arrays.Length; i++){
			for(int j = 0; j < arrays[i].Length; j++){
				combinedArrays[overallIndex] = arrays[i][j];
				overallIndex++;
			}
		}
		
		return combinedArrays;
	}
}
