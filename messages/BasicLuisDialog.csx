using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(Utils.GetAppSetting("LuisAppId"), Utils.GetAppSetting("LuisAPIKey"))))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the none intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #region Family & Safety

    // Go to https://luis.ai and create a new intent, then train/publish your luis app.
    // Finally replace "MyIntent" with the name of your newly created intent in the following handler
    [LuisIntent("Declaration")]
    public async Task DeclarationIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Declaration intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Dissolution when wife is pregnant")]
    public async Task DissolutionIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Dissolution when wife is pregnant intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Divorce")]
    public async Task DivorceIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Divorce intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Divorce, Debt, and Bankruptcy")]
    public async Task DDBIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Divorce, Debt, and Bankruptcy intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Ending Domestic partnership with children")]
    public async Task WithChildrenIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Ending Domestic partnership with children intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Ending Domestic partnership without children")]
    public async Task WithoutChildrenIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Ending Domestic partnership without children intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Future retirement benefits")]
    public async Task RetirementIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Future retirement benefits intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Helping Children")]
    public async Task HelpChildrenIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Helping Children intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
        [LuisIntent("Jurisdiction")]
    public async Task JurisdictionIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Jurisdiction intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Paperwork")]
    public async Task PaperworkIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Paperwork intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("serve the opposing party")]
    public async Task ServeIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the serve the opposing party intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion

    #region Housing & Apartment

    [LuisIntent("Eviction and Defence")]
    public async Task DefenceIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Eviction and Defence intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("HUD Eviction")]
    public async Task HudIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the HUD Eviction intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }


    [LuisIntent("Landlord locked me out what can i do")]
    public async Task LockedIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Landlord locked me out what can i do intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Public & subsidized housing")]
    public async Task PublicIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Public & subsidized housing intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Public Housing Evictions")]
    public async Task PublicHousingIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Public Housing Evictions intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Public Housing Grievance Procedure")]
    public async Task GrievanceIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Public Housing Grievance Procedure intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Section 515: Rural Rights")]
    public async Task RuralrightsIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Section 515: Rural Rights intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Tenant Living in a foreclosed property")]
    public async Task TenantIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Tenant Living in a foreclosed property intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Tenant's Rights in Washington state")]
    public async Task TenantRightsIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Tenant's Rights in Washington state intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion

    #region Tenant's Rights

    [LuisIntent("Can landlord do that")]
    public async Task LandlorddothatIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Can landlord do that intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Rent-to-own in Washington state")]
    public async Task RenttoownIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Rent-to-own in Washington state intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Tenants if need repairs")]
    public async Task NeedrepairsIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Tenants if need repairs intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Getting security deposit back")]
    public async Task SecuritydepositIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Getting security deposit back intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion

    #region Foreclousre

    [LuisIntent("Foreclosure when have mortgage")]
    public async Task ForeclosuremortagageIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Foreclosure when have mortgage intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Homeowner's guide to short sales")]
    public async Task HomeownerguideIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Homeowner's guide to short sales intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Non Borrowing spouses and Reverse Mortgages")]
    public async Task NonborrowingIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Non Borrowing spouses and Reverse Mortgages intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion

    #region Emergency shelter & Assistance

    [LuisIntent("Fight a denial or termination for HEN")]
    public async Task FightdenialIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Fight a denial or termination for HEN intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Local HEN Admin Directory Homeless prevention")]
    public async Task HendirectoryIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Local HEN Admin Directory Homeless prevention intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("People unable to work : ABD and HEN")]
    public async Task UnabletoworkIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the People unable to work : ABD and HEN intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion

    #region Utilites & Phone

    [LuisIntent("Low income home energy")]
    public async Task LowincomehomeIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Low income home energy intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Public utilities")]
    public async Task PublicutilitiesIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Public utilities intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion

    #region Homebuyers & Owners

    [LuisIntent("Forfeiture of Your Real Estate Contract")]
    public async Task ForfeitureIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Forfeiture of Your Real Estate Contract intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Options to Avoid Property Tax Foreclosure")]
    public async Task AvoidpropertyIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Options to Avoid Property Tax Foreclosure intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Know Your Rights Before Buying a Home")]
    public async Task RightsbeforebuyingIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Know Your Rights Before Buying a Home intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion

    #region House Discrimination

    [LuisIntent("Fair Housing")]
    public async Task FairhousingIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Fair Housing intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Fair Housing Guide for Renters & Home Buyers")]
    public async Task GuideforrentersandbuyersIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Fair Housing Guide for Renters & Home Buyers intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Tenant Screening: Your Rights")]
    public async Task TenantscreeningIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Tenant Screening: Your Rights intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Service Animals Questions")]
    public async Task ServiceanimalsIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Service Animals Questions intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion

    #region Mobile home park tenants


    [LuisIntent("My Landlord Has Not Paid Their Water Bill")]
    public async Task landordnotpaidIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the My Landlord Has Not Paid Their Water Bill intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }


    [LuisIntent("Buying a Manufactured Home")]
    public async Task BuyingmanufacturedIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Buying a Manufactured Home intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion

    #region Public & subsidized Hosuing

    [LuisIntent("When I Do Not Pay the Rent")]
    public async Task DontpayrentIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the When I Do Not Pay the Rent intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion

    #region Small claim court

    [LuisIntent("Using Small Claims Court to Recover Unpaid Wages")]
    public async Task SmallclaimsIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Using Small Claims Court to Recover Unpaid Wages intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }


    [LuisIntent("Certificate of Service - Small Claims Court")]
    public async Task CertificatessmallIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Certificate of Service - Small Claims Court intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion

    #region Veteran and servicemember rights in housing and home loans

    [LuisIntent("About VA Home Loan Program")]
    public async Task HomeloanprogramIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the About VA Home Loan Program intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }


    [LuisIntent("Information for Military Personnel")]
    public async Task MilitaryinfoIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Information for Military Personnel intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }


    [LuisIntent("Military and Veteran Legal Resource Guide")]
    public async Task MilitaryveteranguideIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Military and Veteran Legal Resource Guide intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    #endregion



}