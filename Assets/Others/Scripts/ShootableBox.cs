using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootableBox : MonoBehaviour {

	public Text txtPunts;

	//The box's current health point total
	public int currentHealth = 3;

	public void Damage(int damageAmount)
	{
		//subtract damage amount when Damage function is called
		currentHealth -= damageAmount;

		//Check if health has fallen below zero
		if (currentHealth <= 0) 
		{
            int punts = int.Parse(txtPunts.text);
            punts++;
            txtPunts.text = punts.ToString();

            //if health has fallen below zero, deactivate it 
            gameObject.SetActive (false);
		}
	}
}
