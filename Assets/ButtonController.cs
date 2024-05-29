using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
	public Text text;
	public int value = 0;

	public void OnPress()
	{
		value++;
		text.text = value.ToString();
	}
}
