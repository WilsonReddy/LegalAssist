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




}