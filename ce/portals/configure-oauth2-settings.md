---
title:"Configure OAuth2 provider settings for a portal in Dynamics 365  | MicrosoftDocs"
description:""
ms.custom:""
ms.date:05/22/2017
ms.service:crm-online
ms.suite:""
ms.tgt_pltfrm:""
ms.topic:article
ms.assetid:f5d8f8bf-4911-4311-b3a0-a5c0171e5810
ms.reviewer:""
author:sbmjais
ms.author:shjais
manager:sakudes
---
# OAuth2 provider settings for portals

Applies To: Dynamics 365 (online), Dynamics CRM Online

The OAuth 2.0 based external identity providers involve registering an "application" with a third-party service to obtain a "client ID" and "client secret" pair. Often this application requires specifying a redirect URL that allows the identity provider to send users back to the portal (relying party). The client ID and client secret are configured as portal site settings in order to establish a secure connection from relying party to identity provider. The settings are based on the properties of the [MicrosoftAccountAuthenticationOptions](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.aspx), [TwitterAuthenticationOptions](https://msdn.microsoft.com//library/microsoft.owin.security.twitter.twitterauthenticationoptions.aspx), [FacebookAuthenticationOptions](https://msdn.microsoft.com//library/microsoft.owin.security.facebook.facebookauthenticationoptions.aspx), and [GoogleOAuth2AuthenticationOptions](https://msdn.microsoft.com//library/microsoft.owin.security.google.googleoauth2authenticationoptions.aspx) classes.  

The supported providers are:

Microsoft Account

-   Twitter

-   Facebook

-   Google

-   LinkedIn

-   Yahoo

## Create OAuth applications

In general, if an OAuth provider uses app settings that require a redirect URI value, specify http://portal.contoso.com/or http://portal.contoso.com/signin-\[provider\] depending on how the provider performs redirect URI validation (some providers require the full URL path to be specified along with the domain name). Substitute the name of the provider in place of \[provider\] in the redirect URI.

### Google

[Google OAuth2 API Credentials Instructions](https://developers.google.com/accounts/docs/OpenIDConnect#appsetup)  

Open [Google Developers Console](https://console.developers.google.com/)  

-   Create an API project or open an existing project

-   Navigate to **APIs & auth** &gt; **APIs**

<!-- -->

-   Under Social APIs, click **Google+ API** then click **Enable API**

<!-- -->

-   Navigate to **APIs & auth** &gt; **Consent screen**

<!-- -->

-   Specify an **Email address**

-   Specify a custom **Product name**

-   Click **Save**

<!-- -->

-   Navigate to **APIs & auth** &gt; **Credentials**

<!-- -->

-   Create new Client ID

<!-- -->

-   Application Type: **Web application**

-   Authorized JavaScript Origins: http://portal.contoso.com

-   Authorized Redirect URIs: http://portal.contoso.com/signin-google

-   Click **Create Client ID**

### Facebook app settings

Open [Facebook Developers App Dashboard](https://developers.facebook.com/apps)  

-   Click **Add a New App**

-   Select **Website**

-   Click **Skip and Create App ID**

<!-- -->

-   Specify a **Display Name**

-   Select a **Category**

-   Click **Create App ID**

<!-- -->

-   While on the Dashboard for the new app, navigate to **Settings** &gt; **Basic** (tab)

<!-- -->

-   (Optional) App Domains: portal.contoso.com

-   Contact Email: *&lt;email address of your choice&gt;*

-   Click **Add Platform** and select **Website**

-   Site URL: http://portal.contoso.com/ or http://portal.contoso.com/signin-facebook

-   Click **Save Changes**

<!-- -->

-   Navigate to **Status & Review** &gt; **Status** (tab)

<!-- -->

-   Do you want to make this app an all its features available to the general public? **YES**

<!-- -->

-   The Contact Email field is required to enable this setting

### Microsoft application settings

Open [Microsoft account Developer Center](https://account.live.com/developers/applications/index)  

-   Click **Create application**

<!-- -->

-   Specify an **Application name**

-   Click **I accept**

<!-- -->

-   Navigate to **Settings** &gt; **API settings**

<!-- -->

-   Redirect URLs: http://portal.contoso.com/signin-microsoft

### Twitter apps settings

Open [Twitter Application Management](https://apps.twitter.com/)  

-   Click **Create New App**

<!-- -->

-   Specify a **Name** and **Description**

-   Website: http://portal.contoso.com

-   Callback URL: http://portal.contoso.com or http://portal.contoso.com/signin-twitter

-   Click **Create your Twitter application**

### LinkedIn app settings

Open [LinkedIn Developer Network](https://www.linkedin.com/secure/developer)  

-   Click **Add New Application**

<!-- -->

-   Specify an **Application Name**, **Description**, etc.

-   Website URL: http://portal.contoso.com

-   OAuth User Agreement/Default Scope: r\_basicprofie and r\_emailaddress

-   OAuth 2.0 Redirect Urls: http://portal.contoso.com/signin-linkedin

-   Click **Add Application**

### Yahoo! YDN App settings

Open [Yahoo! Developer Network](https://developer.yahoo.com/apps)  

-   Click **Create an App**

<!-- -->

-   Specify an **Application Name**

-   Application Type: **Web Application**

-   Callback Domain: portal.contoso.com

<!-- -->

-   Click **Create App**

## Create site settings using OAuth2

The application dashboard for each provider will display the client ID (app ID, consumer key) and client secret (app secret, consumer secret) for each application. Use these two values to configure the portal site settings.

| ![image6](media/image6.png) **Note **                                         |  
|---------------------------------------------------------------------------------------------------------|
| A standard OAuth2 configuration only requires the following settings (choosing Facebook as an example): 
                                                                                                          
 Authentication/OpenAuth/Facebook/ClientId                                                                
                                                                                                          
 -   Authentication/OpenAuth/Facebook/ClientSecret                                                        |

Substitute the \[provider\] tag in the site setting name with a specific identity provider name: Facebook, Google, Yahoo,Microsoft, LinkedIn, or Twitter.

| **Site Setting Name**                                           | **Description**                                                                                                                                                                                                                                                                                                                                      |
|-----------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Authentication/Registration/ExternalLoginEnabled                | Enables or disables external account sign-in and registration. Default: true                                                                                                                                                                                                                                                                         |
| Authentication/OpenAuth/\[provider\]/ClientId                   | Required. The client ID value from the provider application. It may also be referred to as an "App ID" or "Consumer Key".                                                                                                                                                                                                                            
                                                                                                                                                                                                                                                                                                                                                        
  The following setting names are allowed for backwards compatibility:                                                                                                                                                                                                                                                                                  
                                                                                                                                                                                                                                                                                                                                                        
  Authentication/OpenAuth/Twitter/ConsumerKey                                                                                                                                                                                                                                                                                                           
                                                                                                                                                                                                                                                                                                                                                        
  -   Authentication/OpenAuth/Facebook/AppId                                                                                                                                                                                                                                                                                                            
                                                                                                                                                                                                                                                                                                                                                        
  -   Authentication/OpenAuth/LinkedIn/ConsumerKey                                                                                                                                                                                                                                                                                                      |
| Authentication/OpenAuth/\[provider\]/ClientSecret               | Required. The client secret value from the provider application. It may also be referred to as an "App Secret" or "Consumer Secret".                                                                                                                                                                                                                 
                                                                                                                                                                                                                                                                                                                                                        
  The following setting names are allowed for backwards compatibility:                                                                                                                                                                                                                                                                                  
                                                                                                                                                                                                                                                                                                                                                        
  Authentication/OpenAuth/Twitter/ConsumerSecret                                                                                                                                                                                                                                                                                                        
                                                                                                                                                                                                                                                                                                                                                        
  -   Authentication/OpenAuth/Facebook/AppSecret                                                                                                                                                                                                                                                                                                        
                                                                                                                                                                                                                                                                                                                                                        
  -   Authentication/OpenAuth/LinkedIn/ConsumerSecret                                                                                                                                                                                                                                                                                                   |
| Authentication/OpenAuth/\[provider\]/AuthenticationType         | The OWIN authentication middleware type. Example: yahoo. [MSDN: authenticationoptions.authenticationtype](https://msdn.microsoft.com//library/microsoft.owin.security.authenticationoptions.authenticationtype.aspx).                                                                                                                                |  
| Authentication/OpenAuth/\[provider\]/Scope                      | A comma separated list of permissions to request. [MSDN: microsoftaccountauthenticationoptions.scope](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.scope.aspx).                                                                                                                |  
| Authentication/OpenAuth/\[provider\]/Caption                    | The text that the user can display on a sign in user interface. [MSDN: microsoftaccountauthenticationoptions.caption](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.caption.aspx).                                                                                              |  
| Authentication/OpenAuth/\[provider\]/BackchannelTimeout         | Timeout value in milliseconds for back channel communications. [MSDN: microsoftaccountauthenticationoptions.backchanneltimeout](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.backchanneltimeout.aspx).                                                                         |  
| Authentication/OpenAuth/\[provider\]/CallbackPath               | The request path within the application's base path where the user-agent will be returned. [MSDN: microsoftaccountauthenticationoptions.callbackpath](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.callbackpath.aspx).                                                         |  
| Authentication/OpenAuth/\[provider\]/SignInAsAuthenticationType | The name of another authentication middleware which will be responsible for actually issuing a **userClaimsIdentity**. [MSDN: microsoftaccountauthenticationoptions.signinasauthenticationtype](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.signinasauthenticationtype.aspx). |  
| Authentication/OpenAuth/\[provider\]/AuthenticationMode         | The OWIN authentication middleware mode. [MSDN: security.authenticationoptions.authenticationmode](https://msdn.microsoft.com//library/microsoft.owin.security.authenticationoptions.authenticationmode.aspx).                                                                                                                                       |  

### See Also

[Configure Dynamics 365 portal authentication](configure-portal-authentication.md)  
[Set authentication identity for a portal](set-authentication-identity.md)  
[Open ID Connect provider settings for portals](configure-openid-settings.md)  
[WS-Federation provider settings for portals](configure-ws-federation-settings.md)  
[SAML 2.0 provider settings for portals](configure-saml2-settings.md)  
[Facebook App (Page Tab) authentication for portals](#facebook-app-page-tab-authentication-for-portals)  

