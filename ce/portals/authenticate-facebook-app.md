---
title: "Configure Facebook App (Page Tab) authentication for a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to authenticate the Facebook app to sign in to a portal."
ms.custom:
  - dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: f487a03a-7a22-4030-9dfb-bdbdfae202c0
ms.reviewer: ""
redirect_url: /dynamics365/customer-engagement/portals/administer-manage-portal-dynamics-365
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Authenticate the Facebook App

[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portals are capable of hosting Facebook Apps in the context of a [Facebook Page Tab](https://developers.facebook.com/docs/appsonfacebook/pagetabs/). This is achieved by employing features such as Login with Facebook and ASP.Net MVC Display Modes.  

## Prerequisites

Start by setting up a standard portal.

## Configure IIS

The same website used to host the standard portal is also used to host the Facebook App portal. However, the website must be configured to respond to Facebook-specific site bindings in addition to the existing bindings. The specific site bindings should contain a host name value that distinguishes it as a Facebook App portal. For example, a standard portal hosted from the domain contoso.com can specify the domain facebook-contoso.com for hosting the Facebook App.

| Type  | Host Name            | Port | Notes                           |
|-------|----------------------|------|---------------------------------|
| http  | contoso.com          | 80   | The standard portal.            |
| http  | facebook-contoso.com | 80   | The Facebook App portal.        |
| https | facebook-contoso.com | 443  | The Secure Facebook App portal. |
|||

## Configure display mode

The MVC Display Modes feature allows the Facebook App to present a customized user experience. The Facebook display mode is enabled by adding the following site setting.

| Site Setting Name              | Value (examples - replace with your Page Tab URL) | Note                                                        |
|--------------------------------|---------------------------------------------------|-------------------------------------------------------------|
| DisplayModes/Facebook/HostName | facebook-contoso.com, facebook-\*                 | The host name of the Facebook App portal. Accepts wildcard. |
|||

## Test the site bindings

View the portal through each of the site bindings in a web browser to ensure that the bindings are functioning correctly. Verify that the Facebook site bindings render a customized view distinct from the other bindings

## Set up the Facebook app

1.  Go to the [Facebook Developers](https://developers.facebook.com/) site and sign in by using a Facebook account. Under the**My Apps** drop-down menu, select **Add a New App**, and then select **Skip and Create App ID**.
2. In the resulting **Create a New App ID** dialog box, specify a valid **Display Name**,**Namespace**, and **Choose a Category** (such as Apps for Pages) because this will eventually be required to publish an app to the public. The **Namespace** can be left blank. Select **Create App**. Submit the **Security Check** (captcha) as well.
3. After landing on the Dashboard, go to the **Settings** area in the left column navigation.
4. Complete the **Basic** form by entering the fields shown in the following example:
    - **Display Name**: Contact Email

      **Contoso Portal**: administrator@contoso.com
    - **Display Name**: App Domains

      **Contoso Portal**: portal.contoso.comfacebook-portal.contoso.com

  > [!Note] 
  > If the domain values cannot be successfully set, leave this field blank for now, complete the next step to specify a **Site URL**, and then return to this field.

5. Select **+ Add Platform**, and then select **Website** from the Select Platform dialog box. Enter a **Site URL** (for example:  http://contoso.com) 
6. Again, select **+ Add Platform**, and this time select **Page Tab**. Complete this new section based on the following fields:
    * Secure Page Tab URL: https://facebook-contoso.com/app/facebook
    * Page Tab Name:Contoso Portal                 

  > [!Note]
  > The Page Tab URL should have the /app/facebook path appended to the App domain URL. The portal uses this endpoint to launch the App portal.

7. Select **Save Changes**.

Take note of the **App ID** and **App Secret** values of the new app. Use these values when configuring the site settings. The two Authentication Site Settings that need to be configured are:

```
Authentication/OpenAuth/Facebook/AppId
Authentication/OpenAuth/Facebook/AppSecret
```

The Value and Website of each site setting must also be added into the site settings. 
> [!Note]
> The Facebook Authentication Site Settings may require the Website's Application Pool to be recycled before they are functional.

## Publish the app

1. Go to the **Status & Review** area (under the Settings area). 
2. Set the first option of the **Status** tab **Do you want to make this app and all its live features available to the general public?** to **YES**.

## Add the Facebook page tab to your Facebook page

If you do not have a Facebook Page, follow the instructions here to create one [Create a Page](https://www.facebook.com/pages/create/). If you will be using an existing page, the current Facebook user must have sufficient permission to add a Page Tab to the Page. If your Facebook Page does not already have the Page Tab functionality enabled, you must enable it by browsing to a specific URL (substituting the relevant App ID and "next" URL value). The URL below can be used if you substitute the App ID and encoded URL with your information. Further details can be found in [Using Page Tabs](https://developers.facebook.com/docs/appsonfacebook/pagetabs/) and [URL Encoding](http://ascii.cl/url-encoding.htm).  

`https://www.facebook.com/dialog/pagetab?app_id=0123456789&next=http%3a%2f%2ffacebook-contoso.com%2F`

This displays the **Add Page Tab** dialog to select the **Page** that will contain the **Page Tab** and app. Browse back to the **Page** and the app should be available in the grid of added **Page Tabs**. Select the **Page Tab** to view the Facebook App portal framed within the Facebook Page.

## Update the App portal to publish a Platform for Privacy Preferences (P3P) policy
By default, [!INCLUDE[pn-internet-explorer](../includes/pn-internet-explorer.md)] does not allow [third-party cookies](http://support.microsoft.com/kb/260971) to be created for portals/apps that are rendered in an iFrame of another host portal. This is the case of a Facebook App portal hosted from a Page Tab. A side effect of this cookie blocking is that an app is unable to create and maintain an authenticated session. This is resolved by updating the App portal to publish a Platform for Privacy Preferences (P3P) policy. There are various options for achieving this one of which is to update the web.config of the App portal to include a [custom header](http://www.iis.net/configreference/system.webserver/httpprotocol/customheaders). For Example:

```
<configuration>
   <system.webServer>
    <httpProtocol>
      <customHeaders>
         <add name="P3P" value='CP="ALL ADM DEV PSAi COM OUR OTRo STP IND ONL"'/>
      </customHeaders>
    </httpProtocol>
   </system.webServer>
</configuration>
```
### See also

[Configure Dynamics 365 portal authentication](configure-portal-authentication.md)  
[Set authentication identity for a portal](set-authentication-identity.md)  
[OAuth2 provider settings for portals](configure-oauth2-settings.md)  
[Open ID Connect provider settings for portals](configure-openid-settings.md)  
[WS-Federation provider settings for portals](configure-ws-federation-settings.md)  
[SAML 2.0 provider settings for portals](configure-saml2-settings.md)  

