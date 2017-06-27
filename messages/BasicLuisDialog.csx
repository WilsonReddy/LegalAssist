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
}