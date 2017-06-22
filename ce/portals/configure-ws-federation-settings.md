---
title: "Configure WS-Federation provider settings for a portal in Dynamics 365  | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 59a081d8-cc73-454f-9b1d-58c760cbfd96
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Configure WS-Federation provider settings for portals

A single [!INCLUDE[pn-active-directory](../includes/pn-active-directory.md)] Federation Services server can be added (or another [WS-Federation](https://msdn.microsoft.com/library/bb498017.aspx)–compliant security token service) as an identity provider. In addition, a single [[!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] ACS](http://azure.microsoft.com/documentation/articles/active-directory-dotnet-how-to-use-access-control/) namespace can be configured as a set of individual identity providers. The settings for both AD FS and ACS are based on the properties of the [WsFederationAuthenticationOptions](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.aspx) class.  

## Create an AD FS relying party trust

Using the AD FS Management tool, select **Trust Relationships** &gt; **Relying Party Trusts**.

1.  Click **Add Relying Party Trust**.
2.  Welcome: Click **Start**.
3.  Select Data Source: Select **Enter data about the relying party manually**, click **Next**.
4.  Specify Display Name: Enter a **name**, click **Next**.
    Example: https://portal.contoso.com/
5.  Choose Profile: Select **AD FS 2.0 profile**, click **Next**.
6.  Configure Certificate: Click **Next**.
7.  Configure URL: Check **Enable support for the WS-Federation Passive protocol**.

Relying party WS-Federation Passive protocol URL: Enter https://portal.contoso.com/signin-federation

-   Note: AD FS requires that the portal run on **HTTPS**

    > [!Note] 
    > The resulting endpoint has the following settings:              
    > Endpoint type: **WS-Federation**                                 
    > -   Binding: **POST**                                            
    > -   Index: n/a (0)                                               
    > -   URL: **https://portal.contoso.com/signin-federation** 

8.  Configure Identities: Specify https://portal.contoso.com/, click **Add**, click **Next**
    If applicable, more identities can be added for each additional relying party portal. Users will be able to authenticate across any or all of the available identities.
9.  Choose Issuance Authorization Rules: Select **Permit all users to access this relying party**, click **Next**.
10.  Ready to Add Trust: Click **Next**.
11.  Click **Close**.

Add the **Name ID** claim to the relying party trust:

**Transform[!INCLUDE[pn-ms-windows-short](../includes/pn-ms-windows-short.md)] account name** to **Name ID** claim (Transform an Incoming Claim):

### Create AD FS site settings

Apply portal site settings referencing the above AD FS Relying Party Trust.

> [!Note]
> A standard AD FS (STS) configuration only uses the following settings (with example values): 
> - Authentication/WsFederation/ADFS/MetadataAddress - https://adfs.contoso.com/FederationMetadata/2007-06/FederationMetadata.xml
> - Authentication/WsFederation/ADFS/AuthenticationType - http://adfs.contoso.com/adfs/services/trust
>   - Use the value of the **entityID** attribute in the root element of the Federation Metadata (open the **MetadataAddress URL** in a browser that is the value of the above site setting)
> - Authentication/WsFederation/ADFS/Wtrealm - https://portal.contoso.com/
> - Authentication/WsFederation/ADFS/Wreply - https://portal.contoso.com/signin-federation   

The **WS-Federation metadata** can be retrieved in **[!INCLUDE[pn-powershell-short](../includes/pn-powershell-short.md)]** by running the following script on the AD FS server: `Import-Module adfs Get-ADFSEndpoint -AddressPath /FederationMetadata/2007-06/FederationMetadata.xml`

| Site Setting Name                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                            |
|-------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Authentication/Registration/ExternalLoginEnabled            | Enables or disables external account sign-in and registration. Default: true                                                                                                                                                                                                                                                                                                                                                           |
| Authentication/WsFederation/ADFS/MetadataAddress            | Required. The [WS-Federation](https://msdn.microsoft.com/library/bb498017.aspx) metadata URL of the AD FS (STS) server. Commonly ending with the path:/FederationMetadata/2007-06/FederationMetadata.xml . Example:https://adfs.contoso.com/FederationMetadata/2007-06/FederationMetadata.xml. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.metadataaddress.aspx). |  
| Authentication/WsFederation/ADFS/AuthenticationType         | Required. The OWIN authentication middleware type. Specify the value of the [entityID](https://msdn.microsoft.com/library/azure/dn195592.aspx) attribute at the root of the federation metadata XML. Example: http://adfs.contoso.com/adfs/services/trust. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.authenticationoptions.authenticationtype.aspx).                                                           |  
| Authentication/WsFederation/ADFS/Wtrealm                    | Required. The AD FS relying party identifier. Example: https://portal.contoso.com/. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.wtrealm.aspx).                                                                                                                                                                                                                    |  
| Authentication/WsFederation/ADFS/Wreply                     | Required. The AD FS WS-Federation passive endpoint. Example: https://portal.contoso.com/signin-federation. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.wreply.aspx).                                                                                                                                                                                              |  
| Authentication/WsFederation/ADFS/Caption                    | Recommended. The text that the user can display on a sign in user interface. Default: ADFS. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.caption.aspx).                                                                                                                                                                                                            |  
| Authentication/WsFederation/ADFS/CallbackPath               | An optional constrained path on which to process the authentication callback. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.callbackpath.aspx).                                                                                                                                                                                                                     |  
| Authentication/WsFederation/ADFS/SignOutWreply              | The 'wreply' value used during sign-out. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.signoutwreply.aspx).                                                                                                                                                                                                                                                         |  
| Authentication/WsFederation/ADFS/BackchannelTimeout         | Timeout value for back channel communications. Example: 00:05:00 (5 mins). [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.backchanneltimeout.aspx).                                                                                                                                                                                                                  |  
| Authentication/WsFederation/ADFS/RefreshOnIssuerKeyNotFound | Determines if a metadata refresh should be attempted after a SecurityTokenSignatureKeyNotFoundException. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.refreshonissuerkeynotfound.aspx).                                                                                                                                                                            |  
| Authentication/WsFederation/ADFS/UseTokenLifetime           | Indicates that the authentication session lifetime (e.g. cookies) should match that of the authentication token. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.usetokenlifetime.aspx).                                                                                                                                                                              |  
| Authentication/WsFederation/ADFS/AuthenticationMode         | The OWIN authentication middleware mode. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.authenticationoptions.authenticationmode.aspx).                                                                                                                                                                                                                                                                             |  
| Authentication/WsFederation/ADFS/SignInAsAuthenticationType | The AuthenticationType used when creating the System.Security.Claims.ClaimsIdentity. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.signinasauthenticationtype.aspx).                                                                                                                                                                                                |  
| Authentication/WsFederation/ADFS/ValidAudiences             | Comma separated list of audience URLs. [MSDN](https://msdn.microsoft.com/library/system.identitymodel.tokens.tokenvalidationparameters.allowedaudiences.aspx).                                                                                                                                                                                                                                                                         |  
| Authentication/WsFederation/ADFS/ValidIssuers               | Comma separated list of issuer URLs. [MSDN](https://msdn.microsoft.com/library/system.identitymodel.tokens.tokenvalidationparameters.validissuers.aspx).                                                                                                                                                                                                                                                                               |  
| Authentication/WsFederation/ADFS/ClockSkew                  | The clock skew to apply when validating times. MSDN.                                                                                                                                                                                                                                                                                                                                                                                   |
| Authentication/WsFederation/ADFS/NameClaimType              | The claim type used by the ClaimsIdentity to store the name claim. MSDN.                                                                                                                                                                                                                                                                                                                                                               |
| Authentication/WsFederation/ADFS/RoleClaimType              | The claim type used by the ClaimsIdentity to store the role claim. MSDN.                                                                                                                                                                                                                                                                                                                                                               |
| Authentication/WsFederation/ADFS/RequireExpirationTime      | A value indicating whether tokens must have an 'expiration' value. MSDN.                                                                                                                                                                                                                                                                                                                                                               |
| Authentication/WsFederation/ADFS/RequireSignedTokens        | A value indicating whether a System.IdentityModel.Tokens.SecurityToken xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" can be valid if not signed. MSDN.                                                                                                                                                                                                                                                                    |
| Authentication/WsFederation/ADFS/SaveSigninToken            | A Boolean to control if the original token is saved when a session is created. MSDN.                                                                                                                                                                                                                                                                                                                                                   |
| Authentication/WsFederation/ADFS/ValidateActor              | A value indicating whether the System.IdentityModel.Tokens.JwtSecurityToken.Actor should be validated. MSDN.                                                                                                                                                                                                                                                                                                                           |
| Authentication/WsFederation/ADFS/ValidateAudience           | A Boolean to control if the audience will be validated during token validation. MSDN.                                                                                                                                                                                                                                                                                                                                                  |
| Authentication/WsFederation/ADFS/ValidateIssuer             | A Boolean to control if the issuer will be validated during token validation. MSDN.                                                                                                                                                                                                                                                                                                                                                    |
| Authentication/WsFederation/ADFS/ValidateLifetime           | A Boolean to control if the lifetime will be validated during token validation. MSDN.                                                                                                                                                                                                                                                                                                                                                  |
| Authentication/WsFederation/ADFS/ValidateIssuerSigningKey   | A Boolean that controls if validation of the System.IdentityModel.Tokens.SecurityKey that signed the securityToken xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" is called. MSDN.                                                                                                                                                                                                                                         |
| Authentication/WsFederation/ADFS/Whr                        | Specifies a "whr" parameter in the identity provider redirect URL. [MSDN](https://msdn.microsoft.com/library/hh568665(v=vs.110).aspx).                                                                                                                                                                                                                                                                                                 |  

## WS-Federation settings for [!INCLUDE[pn-azure-active-directory](../includes/pn-azure-active-directory.md)]

The previous section describing AD FS can also be applied to [!INCLUDE[pn-azure-active-directory](../includes/pn-azure-active-directory.md)] ([[!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] AD](https://msdn.microsoft.com/library/azure/mt168838.aspx)), because [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] AD behaves like a standard [WS-Federation](https://msdn.microsoft.com/library/azure/dn903702.aspx) compliant security token service. To get started sign into the [[!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] Management Portal](https://msdn.microsoft.com/library/azure/hh967611.aspx#bkmk_azureportal) and create or select an existing directory. When a directory is available follow the instructions to [add an application](https://msdn.microsoft.com/library/azure/dn132599.aspx) to the directory.  

1.  Under the **Applications** menu of the directory, click the **Add** button
2.  Choose **Add an application my organization is developing**
3.  Specify a custom **name** for the application and choose the type **web application and/or web API**
4.  For the **Sign-On URL** and the **App ID URI**, specify the URL of the portal for both fields https://portal.contoso.com/
    This corresponds to the **Wtrealm** site setting value
5.  At this point, a new application is created. Navigate to the **Configure** section in the menu
    Under the **single sign-on** section, update the first **Reply URL** entry to include a path in the URL http://portal.contoso.com/signin-azure-ad
    -   This corresponds to the **Wreply** site setting value
6.  Click **Save** in the footer
7.  In the footer menu click the **View Endpoints** button and note the **Federation Metadata Document** field

This corresponds to the **MetadataAddress** site setting value

-   Paste this URL in a browser window to view the federation metadata XML and note the **entityID** attribute of the root element

-   This corresponds to the **AuthenticationType** site setting value

> [!Note]
> A standard [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] AD configuration only uses the following settings (with example values):
> - Authentication/WsFederation/ADFS/MetadataAddress - https://login.microsoftonline.com/01234567-89ab-cdef-0123-456789abcdef/federationmetadata/2007-06/federationmetadata.xml
> - Authentication/WsFederation/ADFS/AuthenticationType - https://sts.windows.net/01234567-89ab-cdef-0123-456789abcdef/
>   - Use the value of the **entityID** attribute in the root element of the Federation Metadata (open the **MetadataAddress URL** in a browser that is the value of the above site setting)
> - Authentication/WsFederation/ADFS/Wtrealm - https://portal.contoso.com/
> - Authentication/WsFederation/ADFS/Wreply - https://portal.contoso.com/signin-azure-ad

### Configure Facebook app authentication

Apply the configuration described in the topic [Facebook App (Page Tab) authentication for portals](#facebook-app-page-tab-authentication-for-portals).  

### See also

[Configure Dynamics 365 portal authentication](configure-portal-authentication.md)  
[Set authentication identity for a portal](set-authentication-identity.md)  
[OAuth2 provider settings for portals](configure-oauth2-settings.md)  
[Open ID Connect provider settings for portals](configure-openid-settings.md)  
[SAML 2.0 provider settings for portals](configure-saml2-settings.md)  
[Facebook App (Page Tab) authentication for portals](#facebook-app-page-tab-authentication-for-portals)  

