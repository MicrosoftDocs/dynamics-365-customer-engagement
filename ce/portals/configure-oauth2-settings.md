---
title: "Configure OAuth2 provider settings for a portal in Dynamics 365  | MicrosoftDocs"
description: "Instructions to add and configure OAuth2 provider settings for a portal."
ms.custom:
  - dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: f5d8f8bf-4911-4311-b3a0-a5c0171e5810
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# Configure OAuth2 provider settings for portals

The OAuth 2.0 based external identity providers involve registering an "application" with a third-party service to obtain a "client ID" and "client secret" pair. Often this application requires specifying a redirect URL that allows the identity provider to send users back to the portal (relying party). The client ID and client secret are configured as portal site settings in order to establish a secure connection from relying party to identity provider. The settings are based on the properties of the [[!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)]AccountAuthenticationOptions](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.aspx), [TwitterAuthenticationOptions](https://msdn.microsoft.com//library/microsoft.owin.security.twitter.twitterauthenticationoptions.aspx), [FacebookAuthenticationOptions](https://msdn.microsoft.com//library/microsoft.owin.security.facebook.facebookauthenticationoptions.aspx), and [GoogleOAuth2AuthenticationOptions](https://msdn.microsoft.com//library/microsoft.owin.security.google.googleoauth2authenticationoptions.aspx) classes.  

The supported providers are:

- [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] Account
- Twitter
- Facebook
- Google
- LinkedIn
- Yahoo

## Create OAuth applications

In general, if an OAuth provider uses app settings that require a redirect URI value, specify <http://portal.contoso.com/or> http://portal.contoso.com/signin-\[provider\] depending on how the provider performs redirect URI validation (some providers require the full URL path to be specified along with the domain name). Substitute the name of the provider in place of \[provider\] in the redirect URI.

### Google

[Google OAuth2 API Credentials Instructions](https://developers.google.com/accounts/docs/OpenIDConnect#appsetup)  

1. Open [Google Developers Console](https://console.developers.google.com/)  
2. Create an API project or open an existing project
3. Go to**APIs & auth** &gt;**APIs**, and under **Social APIs**, select**Google+ API**, and then select**Enable API**
4. Go to**APIs & auth** &gt;**Consent screen**.
    - Specify an**Email address**.
    - Specify a custom**Product name**.
    - Select**Save**.
5. Go to**APIs & auth** &gt;**Credentials** and create a new client ID.
   - Application Type:**Web application**
   - Authorized [!INCLUDE[pn-javascript](../includes/pn-javascript.md)] Origins: http://portal.contoso.com
   - Authorized Redirect URIs: http://portal.contoso.com/signin-google 
   - Select **Create Client ID**.

### Facebook app settings

1. Open [Facebook Developers App Dashboard](https://developers.facebook.com/apps)  
2. Select **Add a New App**.
3. Select **Website**.
4. Select **Skip and Create App ID**.
    - Specify a **Display Name**.
    - Choose a **Category**.
    - Select **Create App ID**.

5. While on the dashboard for the new app, go to **Settings** &gt;**Basic** (tab) and add the following details:
    - App Domains (optional): portal.contoso.com 
    - Contact Email: *&lt;email address of your choice&gt;* 
    - Select **Add Platform**, and then select **Website**. 
    - Site URL: http://portal.contoso.com/ or http://portal.contoso.com/signin-facebook

6. Select **Save Changes**.
7. Go to **Status & Review** &gt; **Status** tab.
8. Select **Yes** when prompted to make the app and all its features available to the general public. You must have filled in the valid data in Step 5 above to to enable this setting.

### [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] application settings

1. Open [[!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] account Developer Center](https://account.live.com/developers/applications/index)  
2. Select **Create application** and specify an **Application name**.
3. Select **I accept** to accept Terms and Conditions.
4. Go to **Settings** &gt;**API settings**, and then set the redirect URL as http://portal.contoso.com/signin-microsoft 

### Twitter apps settings

1. Open [Twitter Application Management](https://apps.twitter.com/). 
2. Select **Create New App**.

    - Specify a **Name** and **Description** for your app.
    - Set the Website URL as http://portal.contoso.com.
    - Set the Callback URL as http://portal.contoso.com or http://portal.contoso.com/signin-twitter.

3. Select **Create your Twitter application**.

### LinkedIn app settings

1. Open [LinkedIn Developer Network](https://www.linkedin.com/secure/developer).  
2. Select **Add New Application**.

    - Specify an **Application Name**, **Description**, and so on.
    - Set Website URL as http://portal.contoso.com.
    - Set OAuth User Agreement/Default Scope: r\_basicprofie and r\_emailaddress
    - Set OAuth 2.0 Redirect url: http://portal.contoso.com/signin-linkedin.

3. Select **Add Application**.

### Yahoo! YDN App settings

1. Open [Yahoo! Developer Network](https://developer.yahoo.com/apps).
2. Select **Create an App**.
    
    - Specify an **Application Name**.
    - Application Type: **Web Application**.
    - Callback Domain: portal.contoso.com

3. Select **Create App**.

## Create site settings by using OAuth2

The application dashboard for each provider will display the client ID (app ID, consumer key) and client secret (app secret, consumer secret) for each application. Use these two values to configure the portal site settings.

>[!Note]
> A standard OAuth2 configuration only requires the following settings (with Facebook as an example):
> - `Authentication/OpenAuth/Facebook/ClientId`
> - `Authentication/OpenAuth/Facebook/ClientSecret`

Substitute the `[provider]` tag in the site setting name with a specific identity provider name: Facebook, Google, Yahoo,[!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)], LinkedIn, or Twitter.

|**Site Setting Name**                                           |**Description**                                                                                                                                                                                                                                                                                                                                      |
|-----------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Authentication/Registration/ExternalLoginEnabled                | Enables or disables external account sign-in and registration. Default: true                                                                                                                                                                                                                                                                         |
| Authentication/OpenAuth/\[provider\]/ClientId                   | Required. The client ID value from the provider application. It may also be referred to as an "App ID" or "Consumer Key".  The following setting names are allowed for backwards compatibility:  Authentication/OpenAuth/Twitter/ConsumerKey <ul><li>Authentication/OpenAuth/Facebook/AppId</li><li>Authentication/OpenAuth/LinkedIn/ConsumerKey</li> |
| Authentication/OpenAuth/\[provider\]/ClientSecret               | Required. The client secret value from the provider application. It may also be referred to as an "App Secret" or "Consumer Secret".  The following setting names are allowed for backwards compatibility:  Authentication/OpenAuth/Twitter/ConsumerSecret <ul><li>Authentication/OpenAuth/Facebook/AppSecret</li><li>Authentication/OpenAuth/LinkedIn/ConsumerSecret</li> |
| Authentication/OpenAuth/\[provider\]/AuthenticationType         | The OWIN authentication middleware type. Example: yahoo. [authenticationoptions.authenticationtype](https://msdn.microsoft.com//library/microsoft.owin.security.authenticationoptions.authenticationtype.aspx).                                                                                                                                |  
| Authentication/OpenAuth/\[provider\]/Scope                      | A comma separated list of permissions to request. [microsoftaccountauthenticationoptions.scope](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.scope.aspx).                                                                                                                |  
| Authentication/OpenAuth/\[provider\]/Caption                    | The text that the user can display on a sign in user interface. [microsoftaccountauthenticationoptions.caption](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.caption.aspx).                                                                                              |  
| Authentication/OpenAuth/\[provider\]/BackchannelTimeout         | Timeout value in milliseconds for back channel communications. [microsoftaccountauthenticationoptions.backchanneltimeout](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.backchanneltimeout.aspx).                                                                         |  
| Authentication/OpenAuth/\[provider\]/CallbackPath               | The request path within the application's base path where the user-agent will be returned. [microsoftaccountauthenticationoptions.callbackpath](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.callbackpath.aspx).                                                         |  
| Authentication/OpenAuth/\[provider\]/SignInAsAuthenticationType | The name of another authentication middleware which will be responsible for actually issuing a**userClaimsIdentity**. [microsoftaccountauthenticationoptions.signinasauthenticationtype](https://msdn.microsoft.com//library/microsoft.owin.security.microsoftaccount.microsoftaccountauthenticationoptions.signinasauthenticationtype.aspx). |  
| Authentication/OpenAuth/\[provider\]/AuthenticationMode         | The OWIN authentication middleware mode. [security.authenticationoptions.authenticationmode](https://msdn.microsoft.com//library/microsoft.owin.security.authenticationoptions.authenticationmode.aspx).                                                                                                                                       |  

### See also

[Configure Dynamics 365 portal authentication](configure-portal-authentication.md)  
[Set authentication identity for a portal](set-authentication-identity.md)  
[Open ID Connect provider settings for portals](configure-openid-settings.md)   
[WS-Federation provider settings for portals](configure-ws-federation-settings.md)  
[SAML 2.0 provider settings for portals](configure-saml2-settings.md)  
[Facebook App (Page Tab) authentication for portals](#facebook-app-page-tab-authentication-for-portals)
