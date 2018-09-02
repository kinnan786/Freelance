using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProviderDTO
/// </summary>
public class ProviderDTO
{
	public ProviderDTO()
	{
        providerId = 0;
        firstName = "";
        lastName = "";
        middleName = "";
        address1 = "";
        address2 = "";
        phone = "";
        mobile = "";
        fax = "";
        email = "";
        website="";
        userName = "";
        password = "";
        OverView = "";
        city = "";
        state = "";
        zipCode = "";
        haves = "";
        wants = "";
        providerSkills = "";
	}

    private long providerId;

    public long ProviderId
    {
        get { return providerId; }
        set { providerId = value; }
    }
    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    private string lastName;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    private string middleName;

    public string MiddleName
    {
        get { return middleName; }
        set { middleName = value; }
    }
    private string address1;

    public string Address1
    {
        get { return address1; }
        set { address1 = value; }
    }
    private string address2;

    public string Address2
    {
        get { return address2; }
        set { address2 = value; }
    }
    private string phone;

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
    private string mobile;

    public string Mobile
    {
        get { return mobile; }
        set { mobile = value; }
    }
    private string fax;

    public string Fax
    {
        get { return fax; }
        set { fax = value; }
    }
    private string country;

    public string Country
    {
        get { return country; }
        set { country = value; }
    }
    private string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    private string website;

    public string Website
    {
        get { return website; }
        set { website = value; }
    }

    private string userName;

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }
    private string password;

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    private DateTime joiningDate;

    public DateTime JoiningDate
    {
        get { return joiningDate; }
        set { joiningDate = value; }
    }
    private string overView;

    public string OverView
    {
        get { return overView; }
        set { overView = value; }
    }
    private string city;

    public string City
    {
        get { return city; }
        set { city = value; }
    }
    private string state;

    public string State
    {
        get { return state; }
        set { state = value; }
    }
    private string zipCode;

    public string ZipCode
    {
        get { return zipCode; }
        set { zipCode = value; }
    }
    private string haves;

    public string Haves
    {
        get { return haves; }
        set { haves = value; }
    }
    private string wants;

    public string Wants
    {
        get { return wants; }
        set { wants = value; }
    }

    private string providerSkills;

    public string ProviderSkills
    {
        get { return providerSkills; }
        set { providerSkills = value; }
    }

    private int totalRec;

    public int TotalRec
    {
        get { return totalRec; }
        set { totalRec = value; }
    }
    private int totalPage;

    public int TotalPage
    {
        get { return totalPage; }
        set { totalPage = value; }
    }

    private DateTime lastLogin;

    public DateTime LastLogin
    {
        get { return lastLogin; }
        set { lastLogin = value; }
    }

    private string imagename;

    public string ImageName
    {
        get { return imagename; }
        set { imagename = value; }
    }

}