using UnityEngine;

public class OpenURL : MonoBehaviour
{
    [SerializeField]
    private string _myURL;

    private void OnMouseDown()
    {
        Application.OpenURL(_myURL);
    }

}
