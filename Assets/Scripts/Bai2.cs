using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bai2 : MonoBehaviour
{
    public TMP_InputField yourName;
    public TMP_InputField diaChi;
    public TMP_InputField namSinh;
    public TMP_InputField emailInput;
    public TextMeshProUGUI myActivityText;

    public GameObject dangKy;
    public GameObject inRa;

    public void OnClickDangKy()
    {
        dangKy.SetActive(false);
        inRa.SetActive(true);
    }

    public void OnClickSignInOrRegister()
    {
        // Lấy thông tin từ các TMP_InputField
        string email = emailInput.text;
        string name = yourName.text;
        string address = diaChi.text;
        string birthYear = namSinh.text;

        // Cập nhật TextMeshProUGUI với thông tin
        myActivityText.text = "Name: " + name + "\nAddress: " + address + "\nBirth Year: " + birthYear + "\nEmail: " + email;

        // Ẩn đăng ký và hiển thị thông tin
        dangKy.SetActive(false);
        inRa.SetActive(true);
    }

}
