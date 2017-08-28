
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute("d70ddc6f-ccb7-4221-ad45-a89458ce02b5", "cc7f076047764c8bb37fec016887db9e")))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
         intentName = "None";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    

    #region Family & Safety
    string intentName = "";
    // Go to https://luis.ai and create a new intent, then train/publish your luis app.
    // Finally replace "MyIntent" with the name of your newly created intent in the following handler
    [LuisIntent("Declaration")]
    public async Task DeclarationIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Declaration";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Dissolution when wife is pregnant")]
    public async Task DissolutionIntent(IDialogContext context, LuisResult result)
    {        
        intentName = "Dissolution when wife is pregnant";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }
    
    

    [LuisIntent("Divorce")]
    public async Task DivorceIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Divorce";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
        
        
    }

 [LuisIntent("Eviction")]
    public async Task EvictionIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Eviction";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
        
        
    }

    private async Task DoneWithDivorceDialog(IDialogContext context, IAwaitable<IMessageActivity> result)
    {
        //var selection = await result;
        await context.PostAsync($"Thank you for choosing legal bot. Enter another query that you would like to search for?");
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Divorce, Debt, and Bankruptcy")]
    public async Task DDBIntent(IDialogContext context, LuisResult result)
    {
       intentName = "Divorce, Debt, and Bankruptcy";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
        
    }
    
    [LuisIntent("Ending Domestic partnership with children")]
    public async Task WithChildrenIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Ending Domestic partnership with children";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Ending Domestic partnership without children")]
    public async Task WithoutChildrenIntent(IDialogContext context, LuisResult result)
    {
       intentName = "Ending Domestic partnership without children";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Future retirement benefits")]
    public async Task RetirementIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Future retirement benefits";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Helping Children")]
    public async Task HelpChildrenIntent(IDialogContext context, LuisResult result)
    {
         intentName = "Helping Children";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }
    
        [LuisIntent("Jurisdiction")]
    public async Task JurisdictionIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Jurisdiction";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Paperwork")]
    public async Task PaperworkIntent(IDialogContext context, LuisResult result)
    {
          intentName = "Paperwork";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("serve the opposing party")]
    public async Task ServeIntent(IDialogContext context, LuisResult result)
    {
         intentName = "serve the opposing party";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion

    #region Housing & Apartment

    [LuisIntent("Eviction and Defence")]
    public async Task DefenceIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Eviction and Defence";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("HUD Eviction")]
    public async Task HudIntent(IDialogContext context, LuisResult result)
    {
        intentName = "HUD Eviction";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }


    [LuisIntent("Landlord locked me out what can i do")]
    public async Task LockedIntent(IDialogContext context, LuisResult result)
    {
       intentName = "Landlord locked me out what can i do";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Public & subsidized housing")]
    public async Task PublicIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Public & subsidized housing";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Public Housing Evictions")]
    public async Task PublicHousingIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Public Housing Evictions";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Public Housing Grievance Procedure")]
    public async Task GrievanceIntent(IDialogContext context, LuisResult result)
    {
       intentName = "Public Housing Grievance Procedure";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Section 515: Rural Rights")]
    public async Task RuralrightsIntent(IDialogContext context, LuisResult result)
    {
         intentName = "Section 515: Rural Rights";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Tenant Living in a foreclosed property")]
    public async Task TenantIntent(IDialogContext context, LuisResult result)
    {
         intentName = "Tenant Living in a foreclosed property";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Tenant's Rights in Washington state")]
    public async Task TenantRightsIntent(IDialogContext context, LuisResult result)
    {
         intentName = "Tenant's Rights in Washington state";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion

    #region Tenant's Rights

    [LuisIntent("Can landlord do that")]
    public async Task LandlorddothatIntent(IDialogContext context, LuisResult result)
    {
        
         intentName = "Can landlord do that";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Rent-to-own in Washington state")]
    public async Task RenttoownIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Rent-to-own in Washington state";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Tenants if need repairs")]
    public async Task NeedrepairsIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Tenants if need repairs";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Getting security deposit back")]
    public async Task SecuritydepositIntent(IDialogContext context, LuisResult result)
    {
         intentName = "Getting security deposit back";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion

    #region Foreclousre

    [LuisIntent("Foreclosure when have mortgage")]
    public async Task ForeclosuremortagageIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Foreclosure when have mortgage";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Homeowner's guide to short sales")]
    public async Task HomeownerguideIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Homeowner's guide to short sales";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Non Borrowing spouses and Reverse Mortgages")]
    public async Task NonborrowingIntent(IDialogContext context, LuisResult result)
    {
       intentName = "Non Borrowing spouses and Reverse Mortgages";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion

    #region Emergency shelter & Assistance

    [LuisIntent("Fight a denial or termination for HEN")]
    public async Task FightdenialIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Fight a denial or termination for HEN";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Local HEN Admin Directory Homeless prevention")]
    public async Task HendirectoryIntent(IDialogContext context, LuisResult result)
    {
       intentName = "Local HEN Admin Directory Homeless prevention";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("People unable to work : ABD and HEN")]
    public async Task UnabletoworkIntent(IDialogContext context, LuisResult result)
    {
       intentName = "People unable to work : ABD and HEN";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion

    #region Utilites & Phone

    [LuisIntent("Low income home energy")]
    public async Task LowincomehomeIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Low income home energy";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Public utilities")]
    public async Task PublicutilitiesIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Public utilities";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion

    #region Homebuyers & Owners

    [LuisIntent("Forfeiture of Your Real Estate Contract")]
    public async Task ForfeitureIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Forfeiture of Your Real Estate Contract";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Options to Avoid Property Tax Foreclosure")]
    public async Task AvoidpropertyIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Options to Avoid Property Tax Foreclosure";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Know Your Rights Before Buying a Home")]
    public async Task RightsbeforebuyingIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Know Your Rights Before Buying a Home";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion

    #region House Discrimination

    [LuisIntent("Fair Housing")]
    public async Task FairhousingIntent(IDialogContext context, LuisResult result)
    {
       intentName = "Fair Housing";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Fair Housing Guide for Renters & Home Buyers")]
    public async Task GuideforrentersandbuyersIntent(IDialogContext context, LuisResult result)
    {
       intentName = "Fair Housing Guide for Renters & Home Buyers";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Tenant Screening: Your Rights")]
    public async Task TenantscreeningIntent(IDialogContext context, LuisResult result)
    {
       intentName = "Tenant Screening: Your Rights";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    [LuisIntent("Service Animals Questions")]
    public async Task ServiceanimalsIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Service Animals Questions";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion

    #region Mobile home park tenants


    [LuisIntent("My Landlord Has Not Paid Their Water Bill")]
    public async Task landordnotpaidIntent(IDialogContext context, LuisResult result)
    {
       intentName = "My Landlord Has Not Paid Their Water Bill";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }


    [LuisIntent("Buying a Manufactured Home")]
    public async Task BuyingmanufacturedIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Buying a Manufactured Home";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion

    #region Public & subsidized Hosuing

    [LuisIntent("When I Do Not Pay the Rent")]
    public async Task DontpayrentIntent(IDialogContext context, LuisResult result)
    {
        intentName = "When I Do Not Pay the Rent";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion

    #region Small claim court

    [LuisIntent("Using Small Claims Court to Recover Unpaid Wages")]
    public async Task SmallclaimsIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Using Small Claims Court to Recover Unpaid Wages";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }


    [LuisIntent("Certificate of Service - Small Claims Court")]
    public async Task CertificatessmallIntent(IDialogContext context, LuisResult result)
    {
        intentName = "Certificate of Service - Small Claims Court";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion

    #region Veteran and servicemember rights in housing and home loans

    [LuisIntent("About VA Home Loan Program")]
    public async Task HomeloanprogramIntent(IDialogContext context, LuisResult result)
    {
        intentName = "About VA Home Loan Program";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }


    [LuisIntent("Information for Military Personnel")]
    public async Task MilitaryinfoIntent(IDialogContext context, LuisResult result)
    {
       intentName = "Information for Military Personnel";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }


    [LuisIntent("Military and Veteran Legal Resource Guide")]
    public async Task MilitaryveteranguideIntent(IDialogContext context, LuisResult result)
    {
     intentName = "Military and Veteran Legal Resource Guide";
        await GetContentsFromContenExtractionApi(context);
        context.Wait(MessageReceived);
    }

    #endregion
    #region ContentExtraction  Api call
    async Task GetContentsFromContenExtractionApi(IDialogContext context)
    {
        try
        {
            
            var query = ((Microsoft.Bot.Connector.Activity)((Microsoft.Bot.Builder.Dialogs.IBotContext)context).Activity).Text;
            var client = new HttpClient();
            string intent = intentName;
            var uri = "http://contentsextractionapi.azurewebsites.net/api/ExtractContents";

            HttpResponseMessage response;          
            string finalResponse = "";
            string reqBody = "{\"Topic\":\""+intent+"\",\"Title\":\"" + query+"\"}";

            using (var content = new StringContent(reqBody))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
                response.EnsureSuccessStatusCode();
                finalResponse = await response.Content.ReadAsStringAsync();
                var jsonString = await response.Content.ReadAsStringAsync();
                await context.PostAsync($"{jsonString}");
            } 
        }
        catch (Exception e)
        {
            
        }
    }
    #endregion


}
