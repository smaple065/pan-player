using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehavior : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;

    public void SwitchPans()
    {
        int index = dropdown.value;
        string panType = "";
        Debug.Log(index);

        switch (index)
        {
            case 0:
                panType = "Spiderweb Lead";
                SceneManager.LoadScene("MannetteSpiderwebLead");
                Debug.Log("Case 0: MannetteSpiderwebLead");
                break;
            case 1: 
                panType = "Double Tenor"; 
                SceneManager.LoadScene("MannetteDoubleTenor");
                Debug.Log("Case 1: MannetteDoubleTenor");
                break;
            case 2:
                panType = "Double Second";
                SceneManager.LoadScene("MannetteDoubleSecond");
                Debug.Log("Case 2: MannetteDoubleSecond");
                break;

                //case 3: panType = "Double Guitar"; break;
                //case 4: panType = "Triple Guitar"; break;
                //case 5: panType = "Tenor Bass"; break;
                //case 6: panType = "Six Bass"; break;
        }

        Debug.Log(panType);
    }
}
