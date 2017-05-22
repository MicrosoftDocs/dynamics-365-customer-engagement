---
title: "Configure SAML 2.0 provider settings for a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 71a5b45a-9793-48ae-ace5-2e99a5c44365
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# SAML 2.0 provider settings for portals



|  >[!Note]            |  
|----------------------------------------------------------------------------|
| This documentation applies to **Dynamics 365 portals** and later versions. |

One or more [SAML 2.0](http://docs.oasis-open.org/security/saml/Post2.0/sstc-saml-tech-overview-2.0-cd-02.html)–compliant Identity Providers (IdP) can be added to provide external authentication. This document describes how to setup various identity providers to integrate with a portal acting as a Service Provider (SP).  

## AD FS (IdP)

Settings for an IdP such as AD FS.

### Create an AD FS relying party trust

|  >[!Note]                                                                                                  |  
|------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| See [Configure AD FS by using PowerShell](#configure-ad-fs-by-using-powershell), below, for information about how to perform these steps in a PowerShell script. |  

Using the AD FS Management tool, select **Service** &gt; **Claim Descriptions**.

1.  Click **Add Claim Description**...

<!-- -->

1.  Specify the claim:

Display name: **Persistent Identifier**

-   Claim identifier: **urn:oasis:names:tc:SAML:2.0:nameid-format:persistent**

-   **Enable** checkbox for: Publish this claim description in federation metadata as a claim type that this Federation Service can accept

-   **Enable** checkbox for: Publish this claim description in federation metadata as a claim type that this Federation Service can send

-   Click **OK**

Using the AD FS Management tool, select **Trust Relationships** &gt; **Relying Party Trusts**.

1.  Click **Add Relying Party Trust**...

<!-- -->

1.  Welcome: Click **Start**

2.  Select Data Source: Select **Enter data about the relying party manually**, click **Next**

3.  Specify Display Name: Enter a **name**, click **Next**

Example: https://portal.contoso.com/

1.  Choose Profile: Select **AD FS 2.0 profile**, click **Next**

2.  Configure Certificate: Click **Next**

3.  Configure URL: Check **Enable support for the SAML 2.0 WebSSO protocol**

Relying party SAML 2.0 SSO service URL: Enter https://portal.contoso.com/signin-saml2

-   Note: AD FS requires that the portal run on **HTTPS**

|  >[!Note] |  
|-----------------------------------------------------------------|
| The resulting endpoint has the following settings:              
                                                                  
 Endpoint type: **SAML Assertion Consume Endpoints**              
                                                                  
 -   Binding: **POST**                                            
                                                                  
 -   Index: n/a (0)                                               
                                                                  
 -   URL: **https://portal.contoso.com/signin-saml2**             |

1.  Configure Identities: Specify https://portal.contoso.com/, click **Add**, click **Next**

If applicable, more identities can be added for each additional relying party portal. Users will be able to authenticate across any or all of the available identities.

1.  Choose Issuance Authorization Rules: Select **Permit all users to access this relying party**, click **Next**

2.  Ready to Add Trust: Click **Next**

3.  Click **Close**

Add the **Name ID** claim to the relying party trust:

**TransformWindows account name** to **Name ID** claim (Transform an Incoming Claim):

-   Incoming claim type: **Windows account name**

-   Outgoing claim type: **Name ID**

-   Outgoing name ID format: **Persistent Identifier**

-   Pass through all claim values

### Create site settings

Apply portal site settings referencing the above AD FS Relying Party Trust.

|  >[!Note]                                                                                                                            |  
|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| A standard AD FS (IdP) configuration only uses the following settings (with example values):                                                                                               
                                                                                                                                                                                             
 Authentication/SAML2/ADFS/MetadataAddress - https://adfs.contoso.com/FederationMetadata/2007-06/FederationMetadata.xml                                                                      
                                                                                                                                                                                             
 -   Authentication/SAML2/ADFS/AuthenticationType - http://adfs.contoso.com/adfs/services/trust                                                                                              
                                                                                                                                                                                             
 <!-- -->                                                                                                                                                                                    
                                                                                                                                                                                             
 -   Use the value of the **entityID** attribute in the root element of the Federation Metadata (open the **MetadataAddress URL** in a browser that is the value of the above site setting)  
                                                                                                                                                                                             
 <!-- -->                                                                                                                                                                                    
                                                                                                                                                                                             
 -   Authentication/SAML2/ADFS/ServiceProviderRealm - https://portal.contoso.com/                                                                                                            
                                                                                                                                                                                             
 -   Authentication/SAML2/ADFS/AssertionConsumerServiceUrl - https://portal.contoso.com/signin-saml2                                                                                         
                                                                                                                                                                                             
 The **Federation metadata** can be retrieved in **PowerShell** by running the following script on the AD FS server:                                                                         |

**Import-Module adfs**

**Get-ADFSEndpoint -AddressPath /FederationMetadata/2007-06/FederationMetadata.xml**

Multiple IdP services can be configured by substituting a label for the \[provider\] tag. Each unique label forms a group of settings related to an IdP. Examples: ADFS, AzureAD, MyIdP

| Site Setting Name                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                             |
|---------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Authentication/Registration/ExternalLoginEnabled              | Enables or disables external account sign-in and registration. Default: true                                                                                                                                                                                                                                                                                                                                                            |
| Authentication/SAML2/\[provider\]/MetadataAddress             | Required. The [WS-Federation](https://msdn.microsoft.com/library/bb498017.aspx) metadata URL of the AD FS (STS) server. Commonly ending with the path:/FederationMetadata/2007-06/FederationMetadata.xml . Example: https://adfs.contoso.com/FederationMetadata/2007-06/FederationMetadata.xml. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.metadataaddress.aspx). |  
| Authentication/SAML2/\[provider\]/AuthenticationType          | Required. The OWIN authentication middleware type. Specify the value of the [entityID](https://msdn.microsoft.com/library/azure/dn195592.aspx) attribute at the root of the federation metadata XML. Example: http://adfs.contoso.com/adfs/services/trust. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.authenticationoptions.authenticationtype.aspx).                                                            |  
| Authentication/SAML2/\[provider\]/ServiceProviderRealm        
                                                                
 or                                                             
                                                                
 Authentication/SAML2/\[provider\]/Wtrealm                      | Required. The AD FS relying party identifier. Example: https://portal.contoso.com/. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.wtrealm.aspx).                                                                                                                                                                                                                     |  
| Authentication/SAML2/\[provider\]/AssertionConsumerServiceUrl 
                                                                
 or                                                             
                                                                
 Authentication/SAML2/\[provider\]/Wreply                       | Required. The AD FS SAML Consumer Assertion endpoint. Example: https://portal.contoso.com/signin-saml2. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.wreply.aspx).                                                                                                                                                                                                  |  
| Authentication/SAML2/\[provider\]/Caption                     | Recommended. The text that the user can display on a sign in user interface. Default: \[provider\]. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.caption.aspx).                                                                                                                                                                                                     |  
| Authentication/SAML2/\[provider\]/CallbackPath                | An optional constrained path on which to process the authentication callback. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.callbackpath.aspx).                                                                                                                                                                                                                      |  
| Authentication/SAML2/\[provider\]/BackchannelTimeout          | Timeout value for back channel communications. Example: 00:05:00 (5 mins). [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.backchanneltimeout.aspx).                                                                                                                                                                                                                   |  
| Authentication/SAML2/\[provider\]/UseTokenLifetime            | Indicates that the authentication session lifetime (e.g. cookies) should match that of the authentication token. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.usetokenlifetime.aspx).                                                                                                                                                                               |  
| Authentication/SAML2/\[provider\]/AuthenticationMode          | The OWIN authentication middleware mode. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.authenticationoptions.authenticationmode.aspx).                                                                                                                                                                                                                                                                              |  
| Authentication/SAML2/\[provider\]/SignInAsAuthenticationType  | The AuthenticationType used when creating the System.Security.Claims.ClaimsIdentity. [MSDN](https://msdn.microsoft.com/library/microsoft.owin.security.wsfederation.wsfederationauthenticationoptions.signinasauthenticationtype.aspx).                                                                                                                                                                                                 |  
| Authentication/SAML2/\[provider\]/ValidAudiences              | Comma separated list of audience URLs. [MSDN](https://msdn.microsoft.com/library/system.identitymodel.tokens.tokenvalidationparameters.allowedaudiences.aspx).                                                                                                                                                                                                                                                                          |  
| Authentication/SAML2/\[provider\]/ClockSkew                   | The clock skew to apply when validating times.                                                                                                                                                                                                                                                                                                                                                                                          |
| Authentication/SAML2/\[provider\]/RequireExpirationTime       | A value indicating whether tokens must have an 'expiration' value.                                                                                                                                                                                                                                                                                                                                                                      |
| Authentication/SAML2/\[provider\]/ValidateAudience            | A boolean to control if the audience will be validated during token validation.                                                                                                                                                                                                                                                                                                                                                         |

### IdP initiated sign-In

AD FS supports the [IdP initiated SSO](https://technet.microsoft.com/library/jj127245.aspx) profile of the SAML 2.0 [specification](http://docs.oasis-open.org/security/saml/Post2.0/sstc-saml-tech-overview-2.0-cd-02.html#5.1.4.IdP-Initiated SSO: POST Binding|outline). In order for the portal (SP) to respond properly to the SAML request initiated by the IdP, the [RelayState](http://blogs.technet.com/b/askds/archive/2012/09/27/ad-fs-2-0-relaystate.aspx) parameter must be encoded properly.  

The basic string value to be encoded into the SAML RelayState parameter must be in the format: ReturnUrl=/content/sub-content/ where /content/sub-content/ is the path to the webpage you want to navigate to on the portal (SP). The path can be replaced by any valid webpage on the portal. The string value is encoded and placed into a container string of the format: RPID=&lt;URL encoded RPID&gt;&RelayState=&lt;URL encoded RelayState&gt;. This entire string is once again encoded and added to another container of the format: https://adfs.contoso.com/adfs/ls/idpinitiatedsignon.aspx?RelayState=&lt;URL encoded RPID/RelayState&gt;.

For example, given the SP path: /content/sub-content/ and the relying party ID: https://portal.contoso.com/, construct the URL with the steps:

Encode the value ReturnUrl=/content/sub-content/

-   to get ReturnUrl%3D%2Fcontent%2Fsub-content%2F

<!-- -->

-   Encode the value https://portal.contoso.com/

<!-- -->

-   to get https%3A%2F%2Fportal.contoso.com%2F

<!-- -->

-   Encode the value RPID=https%3A%2F%2Fportal.contoso.com%2F&RelayState=ReturnUrl%3D%2Fcontent%2Fsub-content%2F

<!-- -->

-   to get RPID%3Dhttps%253A%252F%252Fportal.contoso.com%252F%26RelayState%3DReturnUrl%253D%252Fcontent%252Fsub-content%252F

<!-- -->

-   Prepend the ADFS IdP initiated SSO path to get the final URL

<!-- -->

-   https://adfs.contoso.com/adfs/ls/idpinitiatedsignon.aspx?RelayState=RPID%3Dhttps%253A%252F%252Fportal.contoso.com%252F%26RelayState%3DReturnUrl%253D%252Fcontent%252Fsub-content%252F

The following PowerShell script can be used to construct the URL (save to a file named Get-IdPInitiatedUrl.ps1).

**&lt;\#**

**.SYNOPSIS **

**Constructs an IdP initiated SSO URL to access a portal page on the SP.**

**.PARAMETER path**

**The path to the portal page.**

**.PARAMETER rpid**

**The relying party identifier.**

**.PARAMETER adfsPath**

**The AD FS IdP initiated SSO page.**

**.EXAMPLE**

**PS C:\\&gt; .\\Get-IdPInitiatedUrl.ps1 -path "/content/sub-content/" -rpid "https://portal.contoso.com/" -adfsPath "https://adfs.contoso.com/adfs/ls/idpinitiatedsignon.aspx"**

**\#&gt;**

**param**

**(**

**\[parameter(mandatory=$true,position=0)\]**

**$path,**

**\[parameter(mandatory=$true,position=1)\]**

**$rpid,**

**\[parameter(position=2)\]**

**$adfsPath = "https://adfs.contoso.com/adfs/ls/idpinitiatedsignon.aspx"**

**)**

**$state = "ReturnUrl=$path"**

**$encodedPath = \[uri\]::EscapeDataString($state)**

**$encodedRpid = \[uri\]::EscapeDataString($rpid)**

**$encodedPathRpid = \[uri\]::EscapeDataString("RPID=$encodedRpid&RelayState=$encodedPath")**

**$idpInitiatedUrl = "{0}?RelayState={1}" -f $adfsPath, $encodedPathRpid**

**Write-Output $idpInitiatedUrl**

## SAML 2.0 settings for Azure Active Directory

The previous section describing AD FS can also be applied to [Azure AD](https://msdn.microsoft.com/library/azure/mt168838.aspx) because Azure AD behaves like a standard [SAML 2.0](https://msdn.microsoft.com/library/azure/dn195591.aspx) compliant IdP. To get started sign into the [Azure Management Portal](https://msdn.microsoft.com/library/azure/hh967611.aspx#bkmk_azureportal) and create or select an existing directory. When a directory is available, follow the instructions to [add an application](https://msdn.microsoft.com/library/azure/dn132599.aspx) to the directory.  

1.  Under the **Applications** menu of the directory, click the **Add** button

<!-- -->

1.  Choose **Add an application my organization is developing**

2.  Specify a custom **name** for the application and choose the type **web application and/or web API**

3.  For the **Sign-On URL** and the **App ID URI**, specify the URL of the portal for both fields https://portal.contoso.com/

This corresponds to the **ServiceProviderRealm** (Wtrealm) site setting value

1.  At this point, a new application is created. Navigate to the **Configure** section in the menu

Under the **single sign-on** section, update the first **Reply URL** entry to include a path in the URL http://portal.contoso.com/signin-azure-ad

-   This corresponds to the **AssertionConsumerServiceUrl** (Wreply) site setting value

1.  In the footer menu click the **View Endpoints** button and note the **Federation Metadata Document** field

This corresponds to the **MetadataAddress** site setting value

-   Paste this URL in a browser window to view the federation metadata XML and note the **entityID** attribute of the root element

-   This corresponds to the **AuthenticationType** site setting value

|  >[!Note]                                                                                                                            |  
|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| A standard Azure AD configuration only uses the following settings (with example values):                                                                                                  
                                                                                                                                                                                             
 Authentication/SAML2/AzureAD/MetadataAddress - https://login.microsoftonline.com/01234567-89ab-cdef-0123-456789abcdef/federationmetadata/2007-06/federationmetadata.xml                     
                                                                                                                                                                                             
 -   Authentication/SAML2/AzureAD/AuthenticationType - https://sts.windows.net/01234567-89ab-cdef-0123-456789abcdef/                                                                         
                                                                                                                                                                                             
 <!-- -->                                                                                                                                                                                    
                                                                                                                                                                                             
 -   Use the value of the **entityID** attribute in the root element of the Federation Metadata (open the **MetadataAddress URL** in a browser that is the value of the above site setting)  
                                                                                                                                                                                             
 <!-- -->                                                                                                                                                                                    
                                                                                                                                                                                             
 -   Authentication/SAML2/AzureAD/ServiceProviderRealm - https://portal.contoso.com/                                                                                                         
                                                                                                                                                                                             
 -   Authentication/SAML2/AzureAD/AssertionConsumerServiceUrl - https://portal.contoso.com/signin-azure-ad                                                                                   |

## Shibboleth Identity Provider 3

Use the following guidelines for correctly configuration [Shibboleth Identity Provider](https://wiki.shibboleth.net/confluence/display/IDP30/Home) as an IdP service. The following assumes the IdP is hosted on the domain: https://idp.contoso.com.  

The federation metadata URL is: https://idp.contoso.com/idp/shibboleth

-   The IdP must be configured to generate/serve a Persistent Identifier. Follow the instructions to enable [Persistent Identifier Generation](https://wiki.shibboleth.net/confluence/display/IDP30/NameIDGenerationConfiguration).  

-   The IdP federation metadata (&lt;IDPSSODescriptor&gt;) must be configured to include a [SSO redirect binding](https://shibboleth.net/about/advanced.html). [Example](https://wiki.shibboleth.net/confluence/display/SHIB2/MetadataExample).  

**&lt;SingleSignOnService Binding="urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect"**

**Location="https://idp.contoso.com/idp/profile/SAML2/Redirect/SSO"/&gt;**

Configure the Service Providers (Relying Parties) by setting up the [metadata-providers.xml](https://wiki.shibboleth.net/confluence/display/IDP30/MetadataConfiguration).  

-   Each SP federation metadata (&lt;SPSSODescriptor&gt;) must include an assertion consumer service post binding. One option is to use a [FilesystemMetadataProvider](https://wiki.shibboleth.net/confluence/display/IDP30/FilesystemMetadataProvider) and reference a configuration file that contains:  

**&lt;AssertionConsumerService index="1" isDefault="true"**

**Binding="urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST"**

**Location="https://portal.contoso.com/signin-saml2"/&gt;**

The Location attribute corresponds to the **AssertionConsumerServiceUrl** (Wreply) setting.

-   The SP federation metadata should specify an **entityID** attribute for the EntityDescriptor which corresponds to the **AuthenticationType** setting.

**&lt;EntityDescriptor entityID="https://portal.local.contoso.com/"&gt;...**

|  >[!Note]                                                                                                                            |  
|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| A standard Shibboleth configuration only uses the following settings (with example values):                                                                                                
                                                                                                                                                                                             
 Authentication/SAML2/Shibboleth/MetadataAddress - https://idp.contoso.com/idp/shibboleth                                                                                                    
                                                                                                                                                                                             
 -   Authentication/SAML2/Shibboleth/AuthenticationType - https://idp.contoso.com/idp/shibboleth                                                                                             
                                                                                                                                                                                             
 <!-- -->                                                                                                                                                                                    
                                                                                                                                                                                             
 -   Use the value of the **entityID** attribute in the root element of the Federation Metadata (open the **MetadataAddress URL** in a browser that is the value of the above site setting)  
                                                                                                                                                                                             
 <!-- -->                                                                                                                                                                                    
                                                                                                                                                                                             
 -   Authentication/SAML2/Shibboleth/ServiceProviderRealm - https://portal.contoso.com/                                                                                                      
                                                                                                                                                                                             
 -   Authentication/SAML2/Shibboleth/AssertionConsumerServiceUrl - https://portal.contoso.com/signin-saml2                                                                                   |

### IdP initiated sign-in

Shibboleth supports the [IdP initiated SSO](https://wiki.shibboleth.net/confluence/display/SHIB2/IdPUnsolicitedSSO) profile of the SAML 2.0 [specification](http://docs.oasis-open.org/security/saml/Post2.0/sstc-saml-tech-overview-2.0-cd-02.html#5.1.4.IdP-Initiated SSO: POST Binding|outline). For the portal (SP) to respond properly to the SAML request initiated by the IdP, the RelayState parameter must be encoded properly.  

The basic string value to be encoded into the SAML RelayState parameter must be in the format: ReturnUrl=/content/sub-content/ where /content/sub-content/ is the path to the desired webpage to navigate to on the portal (SP). The path can be replaced by any valid webpage on the portal. The full IdP initiated SSO URL should be in the format: https://idp.contoso.com/idp/profile/SAML2/Unsolicited/SSO?providerId=&lt;URL encoded provider ID&gt;&target=&lt;URL encoded return path&gt;.

For example, given the SP path: /content/sub-content/ and the relying party ID: https://portal.contoso.com/, the final URL is: https://idp.contoso.com/idp/profile/SAML2/Unsolicited/SSO?providerId=https%3A%2F%2Fportal.contoso.com%2F&target=ReturnUrl%3D%2Fcontent%2Fsub-content%2F

The following PowerShell script can be used to construct the URL (save to a file named Get-ShibbolethIdPInitiatedUrl.ps1).

**&lt;\#**

**.SYNOPSIS **

**Constructs an IdP initiated SSO URL to access a portal page on the SP.**

**.PARAMETER path**

**The path to the portal page.**

**.PARAMETER providerId**

**The relying party identifier.**

**.PARAMETER shibbolethPath**

**The Shibboleth IdP initiated SSO page.**

**.EXAMPLE**

**PS C:\\&gt; .\\Get-ShibbolethIdPInitiatedUrl.ps1 -path "/content/sub-content/" -providerId "https://portal.contoso.com/" -shibbolethPath "https://idp.contoso.com/idp/profile/SAML2/Unsolicited/SSO"**

**\#&gt;**

**param**

**(**

**\[parameter(mandatory=$true,position=0)\]**

**$path,**

**\[parameter(mandatory=$true,position=1)\]**

**$providerId,**

**\[parameter(position=2)\]**

**$shibbolethPath = "https://idp.contoso.com/idp/profile/SAML2/Unsolicited/SSO"**

**)**

**$state = "ReturnUrl=$path"**

**$encodedPath = \[uri\]::EscapeDataString($state)**

**$encodedRpid = \[uri\]::EscapeDataString($providerId)**

**$idpInitiatedUrl = "{0}?providerId={1}&target={2}" -f $shibbolethPath, $encodedRpid, $encodedPath**

**Write-Output $idpInitiatedUrl**

## Configure AD FS by using PowerShell

The process of adding a relying party trust in AD FS can also be performed by running the following **PowerShell** script on the AD FS server (save contents to a file named **Add-AdxPortalRelyingPartyTrustForSaml.ps1**). After running the script, continue with configuring the portal site settings.

**&lt;\#**

**.SYNOPSIS **

**Adds a SAML 2.0 relying party trust entry for a Dynamics CRM portals website.**

**.PARAMETER domain**

**The domain name of the portal.**

**.EXAMPLE**

**PS C:\\&gt; .\\Add-AdxPortalRelyingPartyTrustForSaml.ps1 -domain "portal.contoso.com"**

**\#&gt;**

**param**

**(**

**\[parameter(Mandatory=$true,Position=0)\]**

**$domain,**

**\[parameter(Position=1)\]**

**$callbackPath = "/signin-saml2"**

**)**

**$VerbosePreference = "Continue"**

**$ErrorActionPreference = "Stop"**

**Import-Module adfs**

**Function Add-CrmRelyingPartyTrust**

**{**

**param (**

**\[parameter(Mandatory=$true,Position=0)\]**

**$name**

**)**

**$identifier = "https://{0}/" -f $name**

**$samlEndpoint = New-ADFSSamlEndpoint -Binding POST -Protocol SAMLAssertionConsumer -Uri ("https://{0}{1}" -f $name, $callbackPath)**

**$identityProviderValue = Get-ADFSProperties | % { $\_.Identifier.AbsoluteUri }**

**$issuanceTransformRules = @'**

**@RuleTemplate = "MapClaims"**

**@RuleName = "Transform Windows Account Name to Name ID claim"**

**c:\[Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname"\]**

**=&gt; issue(Type = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", Issuer = c.Issuer, OriginalIssuer = c.OriginalIssuer, Value = c.Value, ValueType = c.ValueType, Properties\["http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/format"\] = "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent");**

**@RuleTemplate = "LdapClaims"**

**@RuleName = "Send LDAP Claims"**

**c:\[Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname", Issuer == "AD AUTHORITY"\]**

**=&gt; issue(store = "Active Directory", types = ("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname", "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname", "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"), query = ";givenName,sn,mail;{{0}}", param = c.Value);**

**'@ -f $identityProviderValue**

**$issuanceAuthorizationRules = @'**

**@RuleTemplate = "AllowAllAuthzRule"**

**=&gt; issue(Type = "http://schemas.microsoft.com/authorization/claims/permit", Value = "true");**

**'@**

**Add-ADFSRelyingPartyTrust -Name $name -Identifier $identifier -SamlEndpoint $samlEndpoint -IssuanceTransformRules $issuanceTransformRules -IssuanceAuthorizationRules $issuanceAuthorizationRules**

**}**

**\# add the 'Identity Provider' claim description if it is missing**

**if (-not (Get-ADFSClaimDescription | ? { $\_.Name -eq "Persistent Identifier" })) {**

**Add-ADFSClaimDescription -name "Persistent Identifier" -ClaimType "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent" -IsOffered:$true -IsAccepted:$true**

**}**

**\# add the portal relying party trust**

**Add-CrmRelyingPartyTrust $domain**

### See Also

[Configure Dynamics 365 portal authentication](configure-portal-authentication.md)  
[Set authentication identity for a portal](set-authentication-identity.md)  
[OAuth2 provider settings for portals](configure-oauth2-settings.md)  
[Open ID Connect provider settings for portals](configure-openid-settings.md)  
[WS-Federation provider settings for portals](configure-ws-federation-settings.md)  
[Facebook App (Page Tab) authentication for portals](#facebook-app-page-tab-authentication-for-portals)  

