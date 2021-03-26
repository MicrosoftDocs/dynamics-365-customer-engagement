---
title: Configure server-based authentication with Customer Engagement (on-premises) and SharePoint Online
ms:assetid: 24245deb-48cb-4c13-adfe-efa2fe94b3cd
ms.date: 04/16/2020
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.author: matp
author: Mattp123
manager: kvivek
---

# Configure server-based authentication with Customer Engagement (on-premises) and SharePoint Online

This topic describes how to configure server-based authentication between Dynamics 365 Customer Engagement (on-premises) and Microsoft SharePoint Online. <!-- The following diagram illustrates the communication between Dynamics 365 (on-premises), [Azure AD Domain Services](/azure/active-directory-domain-services/overview), and SharePoint Online. -->

<!-- ![Dynamics 365 (on-premises) and SharePoint Online](images/Mt171421.7ec0a85e-1bfd-43f8-a0bc-f01cf8163275(CRM.8).jpeg "Customer Engagement (on-premises) and SharePoint Online")  -->

## Permissions required

Customer Engagement (on-premises)

  - System Administrator security role. This is required to run the Enable Server-Based SharePoint Integration wizard in Customer Engagement (on-premises).

  - If you are using a self-signed certificate for evaluation purposes, you must have local Administrators group membership on the computer where Microsoft Dynamics 365 Server is running.

SharePoint Online

  - Office 365 Global Administrators membership. This is required for administrative-level access to the Office 365 subscription and to run the Microsoft AzurePowerShell cmdlets

## Set up server-based authentication with Customer Engagement (on-premises) and SharePoint Online

Follow the steps in the order provided to set up Customer Engagement (on-premises) with SharePoint Online.


> [!IMPORTANT]
> <UL>
> <LI>
> <P>The steps described here must be completed in the order provided. If a task is not completed, such as a Windows PowerShell command that returns an error message, the issue must be resolved before you continue to the next command, task, or step.</P>
> <LI>
> <P>After you enable server-based SharePoint integration, you can’t revert to the previous client-based authentication method. This means you can’t use the Microsoft Dynamics CRM List Component after you have configured your Customer Engagement (on-premises) organization for server-based SharePoint integration.</P>
> <LI>
> <P>To connect multiple Customer Engagement (on-premises) organizations in the same Customer Engagement (on-premises) deployment to more than one SharePoint Online site, the SharePoint Online sites must be in the same Microsoft Office 365 tenant.</P></LI></UL>



## Verify prerequisites

Before you configure Customer Engagement (on-premises) and SharePoint Online for server-based authentication, the following prerequisites must be met:

  - The Customer Engagement (on-premises) deployment must already be configured and available through the Internet. More information: [Configure IFD for Dynamics 365 for Customer Engagement (on-premises)](../deploy/configure-ifd-for-dynamics-365.md)  

  - Microsoft Dynamics 365 Hybrid Connector. The Microsoft Dynamics 365 Hybrid Connector is a free connector that lets you use server-based authentication with Dynamics 365 (on-premises) and SharePoint Online. More information: [Microsoft Dynamics CRM Hybrid Connector](https://signup.microsoft.com/Signup?OfferId=2d11d538-945d-48c6-b609-a5ce54ce7b18&pc=76ac7a4d-8346-4419-959c-d3896e89b3c9&ali=1)
  - An x509 digital certificate issued by a trusted certificate authority that will be used to authenticate between Customer Engagement (on-premises) and SharePoint Online. If you are evaluating server-based authentication, you can use a self-signed certificate.

The following software features are required to run the Windows PowerShell cmdlets described in this topic.

  - [Microsoft Online Services Sign-In Assistant for IT Professionals Beta](https://www.microsoft.com/download/details.aspx?id=39267)

  - [Azure Active Directory Module for Windows PowerShell (64-bit version)](/powershell/azure/active-directory/install-msonlinev1?view=azureadps-1.0)


> [!IMPORTANT]
> <P>At the time of this writing, there is an issue with the RTW version of Microsoft Online Services Sign-In Assistant for IT Professionals. Until the issue is resolved, we recommend that you use the Beta version. More information: <A href="https://social.msdn.microsoft.com/forums/azure/46a38822-28a4-4abb-b747-96f7db2a2676/cannot-install-azure-active-directory-module-for-windows-powershell-mossia-is-not-installed?forum=windowsazuread">Microsoft Azure Forums: Cannot install Azure Active Directory Module for Windows PowerShell. MOSSIA is not installed</A>.</P>



#### Set up server-based authentication

1.  On the Dynamics 365 Server where the deployment tools server role is running, start the Azure Active Directory Module for Windows PowerShell.
    

    > [!IMPORTANT]
    > <P>The computer where you run the following PowerShell commands must have the prerequisite software features described earlier in Verify prerequisites.</P>



2.  Prepare the certificate.
    
        $CertificateScriptWithCommand = “.\CertificateReconfiguration.ps1 -certificateFile c:\Personalcertfile.pfx -password personal_certfile_password -updateCrm -certificateType S2STokenIssuer -serviceAccount contoso\CRMWebApplicationService -storeFindType FindBySubjectDistinguishedName”
        
        Invoke-Expression -command $CertificateScriptWithCommand

3.  Prepare the PowerShell session.
    
    The following cmdlets enable the computer to receive remote commands and add Office 365 modules to the PowerShell session. <!-- For more information about these cmdlets see [Windows PowerShell Core Cmdlets](/powershell/module/microsoft.powershell.core/). -->
    
        Enable-PSRemoting -force
        New-PSSession
        Import-Module MSOnline -force
        Import-Module MSOnlineExt -force

4.  Connect to Office 365.
    
    When you run the Connect-MsolService command, you must provide a valid Microsoft account that has Office 365 Global Administrator membership for the SharePoint Online license that is required.
    
    For detailed information about each of the MSOnline module for Azure Active Directory PowerShell commands listed here, see [MSOnline](/powershell/module/msonline/?view=azureadps-1.0#msonline).
    
        $msolcred = get-credential
        connect-msolservice -credential $msolcred

5.  Set the certificate.
    
        $Certificate = New-Object System.Security.Cryptography.X509Certificates.X509Certificate2
        $Certificate.Import(“c:\Personalcertfile.cer”)
        $CERCertificateBin = $Certificate.GetRawCertData()
        $CredentialValue = [System.Convert]::ToBase64String($CERCertificateBin)

6.  Set the Azure Active Directory Service Principal Name (SPN) in SharePoint.
    
    Replace *\*.contoso.com* with the domain name where Microsoft Dynamics 365 Server is located.
    
        $RootDomain = “*.contoso.com”
        $CRMAppId = "00000007-0000-0000-c000-000000000000" 
        New-MsolServicePrincipalCredential -AppPrincipalId $CRMAppId -Type asymmetric -Usage Verify -Value $CredentialValue
        $CRM = Get-MsolServicePrincipal -AppPrincipalId $CRMAppId
        $ServicePrincipalName = $CRM.ServicePrincipalNames
        $ServicePrincipalName.Remove("$CRMAppId/$RootDomain")
        $ServicePrincipalName.Add("$CRMAppId/$RootDomain")
        Set-MsolServicePrincipal -AppPrincipalId $CRMAppId -ServicePrincipalNames $ServicePrincipalName

7.  Configure the Microsoft Dynamics 365 Server for server-based authentication with SharePoint.
    
        Add-PSSnapin Microsoft.Crm.PowerShell 
        $setting = New-Object "Microsoft.Xrm.Sdk.Deployment.ConfigurationEntity"
        $setting.LogicalName = "ServerSettings"
        $setting.Attributes = New-Object "Microsoft.Xrm.Sdk.Deployment.AttributeCollection"
        $attribute1 = New-Object "System.Collections.Generic.KeyValuePair[String, Object]" ("S2SDefaultAuthorizationServerPrincipalId", "00000001-0000-0000-c000-000000000000")
        $setting.Attributes.Add($attribute1)
        $attribute2 = New-Object "System.Collections.Generic.KeyValuePair[String, Object]" ("S2SDefaultAuthorizationServerMetadataUrl", "https://accounts.accesscontrol.windows.net/metadata/json/1")
        $setting.Attributes.Add($attribute2)
        Set-CrmAdvancedSetting -Entity $setting

## Run the Enable Server-Based SharePoint Integration Wizard

1.  In the Customer Engagement (on-premises), go to **Document Management**.

2.  In the Document Management area, choose **Enable server-based SharePoint integration**.

3.  Review the information and then select **Next**.

4.  For the SharePoint sites, select **Online**, and then select **Next**.

5.  On the Prepare Sites stage, enter the following information.
    
      - Enter the SharePoint Online site collection **URL**, such as *https://contoso.sharepoint.com/sites/salesteam*.
    
      - Enter the **tenant ID**. More information: Get the SharePoint online tenant ID

6.  Select **Next**.

7.  The validate sites section appears. If all sites are determined to be valid, select **Enable**. If one or more sites are determined to be invalid, see [Troubleshooting server-based authentication](../admin/troubleshooting-server-based-authentication.md).

## Get the SharePoint online tenant ID

### Use PowerShell

1.  In the Azure Active Directory module for Windows PowerShell shell, run the following commands.
    
        $CRMContextId = (Get-MsolCompanyInformation).ObjectID
        $CRMContextId

2.  Copy the GUID that is displayed to the clipboard.

### Use site settings

1.  Sign in to the SharePoint site collection that you will use for document management with Customer Engagement (on-premises).

2.  Go to **Site settings** \> **Site app permissions**.
    
    The tenant ID is displayed under **App Identifier**, to the right of the @ sign. Copy and paste in only the GUID. Do not paste in any part of the identifier to the left of @.

## Troubleshoot enable server-based authentication wizard validation issues

Failed Authentication. This error can be returned when the certificate used for server-to-server authentication is missing or invalid.




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]