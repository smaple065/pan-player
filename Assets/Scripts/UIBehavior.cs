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
                break;
            //case 1: panType = "Double Tenor"; break;
            case 1:
                panType = "Double Second";
                SceneManager.LoadScene("MannetteDoubleSecond");
                break;
                //case 2: panType = "Double Second"; break;
                //case 3: panType = "Double Guitar"; break;
                //case 4: panType = "Triple Guitar"; break;
                //case 5: panType = "Tenor Bass"; break;
                //case 6: panType = "Six Bass"; break;
        }

        Debug.Log(panType);
    }
}
