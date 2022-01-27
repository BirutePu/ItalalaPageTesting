using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatinis.Test
{
    class NewItalalaTest : NewItalalaBaseTest
    {
        [Test]
        public void ASelectKavosPupelesPage()
        {
            _newItalalaPage.NavigateToDefaultPage()
               .CloseKukis()
               .ClosePopUp()
             //.ClosePopUpAtsarginis()
               .ClickParduotuveSeleniumButton();
        }

        [Test]
        public void BSelectElsalvador()
        {
            _newKavosPupelesPage.NavigateToDefaultPage()
               .CloseKukis()
               .ClosePopUp()
             //.ClosePopUpAtsarginis()
               .SelectElSalvadorSelenium();
        }

        [Test]
        public void CBuy3PacksFrenchPressElSalvadorCofee()
        {
            _newElSalvadorPage.NavigateToDefaultPage()
               .CloseKukis()
               .ClosePopUp()
            // .ClosePopUpAtsarginis()
               .SelectPackagesAmount()
               .SelectPupeliuParuosimas("French Press")
               .VerifySelectedValue("French Press")
               .ClickIKrepseli()
               .GetBackToParduotuve();
        }

        [Test]
        public void DSelectTirtira()
        {
            _newKavosPupelesPage.NavigateToDefaultPage()
               .CloseKukis()
               .ClosePopUp()
            // .ClosePopUpAtsarginis()
               .SelectTirtiraSelenium();
        }

        [Test]
        public void EBuy3PacksAeropressTirtiraCofee()
        {
            _newTirtiraPage.NavigateToDefaultPage()
               .CloseKukis()
               .ClosePopUp()
            // .ClosePopUpAtsarginis()
               .SelectPackagesAmount()
               .SelectPackagesAmountSelenium()
               .SelectPupeliuParuosimas("Aeropress")
               .VerifySelectedValue("Aeropress")
               .ClickIKrepseli()
               .GetToCart()
               .InputImonesKodas()
               .SelectTerminal()
               .ClickCheckBox()
               .VerifyDropUpValue("Vilnius 124 Ozas Ozo g. 18 08243")
               .ClickMoketi();
        }

        [TestCase("jonas.jonaitis@gmail.com", "Jonas", "Jonaitis", "Menulio 10-10", "Vilnius", "LT-03223", "+37022332210")]
        //[TestCase("petras.petraitis@gmail.com", "Petras", "Petraitis", "Saules 10-10", "Klaipeda", "LT-01111", "+3702231010")]
        public void FillInAplicationForm(string emailaddress, string name, string surname, string address, string city, string postCode, string phoneNumber)
        {
            _newRegistrationPage.NavigateToDefaultPage()
               .InputEmailAddress(emailaddress)
               .InputName(name)
               .InputSurname(surname)
               .InputHomeAddress(address)
               .InputCity(city)
               .SelectCountry()
               .InputCode(postCode)
               .InputPhone(phoneNumber)
               .VerifyAddressAdded()
               .VerifyEmailAdded()
               .RememberCheckBoxClick()
               .ClickContinueButtonSelenium();
        }


    }
}
    

