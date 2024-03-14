using WebApp.Models;

namespace WebApp.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    {
        ProfileImage = "images/profile-image.svg",
        FirstName = "Bonnie",
        LastName = "Hunden",
        Email = "bonnie@hunden.com"
    };
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
}
