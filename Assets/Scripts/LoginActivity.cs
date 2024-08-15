using UnityEngine;
using TMPro;

public class LoginActivity : MonoBehaviour
{
    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;
    public GameObject MyActivity;
    public GameObject LoginAcctivity;
    public TextMeshProUGUI myActivityText; // TextView trong MyActivity

    public void OnClickSignInOrRegister()
    {
        string email = emailInput.text;
        string password = passwordInput.text;

        // Chuyển thông tin đến MyActivity
        MyActivity.SetActive(true);
        myActivityText.text = "Email: " + email + "\nPassword: " + password;

        // Ẩn LoginActivity sau khi đăng nhập
        MyActivity.SetActive(true);
        LoginAcctivity.SetActive(false);
    }
}
