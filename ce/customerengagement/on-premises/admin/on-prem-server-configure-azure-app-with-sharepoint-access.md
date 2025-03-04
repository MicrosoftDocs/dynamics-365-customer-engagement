---
title: "Create an Azure application for Dynamics 365 Customer Engagement with SharePoint permissions (on-premises)"
description: "Follow these steps to create an Azure application to enable integration between Dynamics 365 Customer Engagement (on-premises) and SharePoint Online."
ms:assetid: 
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.author: matp
author: Mattp123
---

# Configure Azure app for SharePoint access

Using the SharePoint Documents table in a Dynamics 365 environment outside of the documents grid in a model driven app requires an Azure application to grant access. Examples of this access include use within Power Automate or with Dataverse API calls. The setup uses the Power Platform Managed Identities with Azure to grant access.

Starting in March 2025, the current access is removed to enhance system protection. To ensure continued access, follow these steps to create an Azure application with the necessary SharePoint permissions, set up managed identities in Dataverse, and configure federated credentials.

## Create an Azure application with SharePoint permissions 

Create an App registration with API permission to SharePoint. Learn more about registering an app and SharePoint access in [Azure Quickstart Register App](https://learn.microsoft.com/entra/identity-platform/quickstart-register-app?tabs=certificate) and [SharePoint access via Azure AD App-Only](https://learn.microsoft.com/en-us/sharepoint/dev/solution-guidance/security-apponly-azuread). 

1. Open the Azure portal.

1. Under **Azure services**, select **App registrations**. 

1. Select **New registration**. 

1. Enter a **Name** for the application. 

1. Under **Supported account types**, select **Accounts in this organizational directory only**. 

   Note: Other types aren't supported at this time. 

1. Select **Register** to create the **App registration**. 

1. Note the **Application (client) ID** and **Directory (tenant) ID**. 
   1. In the navigation list, select **Overview**. 
   1. Under **Essentials**, copy the **Application (client) ID** and **Directory (tenant) ID** values for use in the next section. 

1. In the navigation list, select **Manage** > **API permissions**. 

1. Under **Configured permissions**, select **Add a permission** to open the **Request API permissions** panel. 
   1. Select **SharePoint**. 
   1. Under **What type of permissions does your application require?**, select **Application permissions**. 
   1. Under **Select permissions**, select **Sites.FullControl.All**. 
   1. Select **Add permissions** to create the SharePoint permission. 
   1. Select **Grant admin consent** for the `<tenant name>`.

## Server setup prerequisites 

1. Download NuGet package for assembly "Microsoft.Identity.Client" version 4.11.0
   1. Open https://www.nuget.org/packages/Microsoft.Identity.Client/4.11.0#readme-body-tab
   1. Under **About** on far side, select **Download package**

1. Rename the downloaded package from "microsoft.identity.client.4.11.0.nupkg" to "microsoft.identity.client.4.11.0.zip"

1. Run extract on "microsoft.identity.client.4.11.0.zip".

1. Within extracted directory, open the **lib/net45** folder and find the files "Microsoft.Identify.Client.dll" and "Microsoft.Identify.Client.xml" to use in a later step

1. On the web server, open **Internet Information Services Manager**
   1. Open **Run** prompt from start menu
   1. Type "inetmgr" and press enter)

1. Expand the **Sites** section in the **Connections** pane

1. Right click on the **Microsoft Dynamics CRM** site and click on **Explore** to open the **CRMWeb** folder

1. Open the **bin** folder

1. Copy the two files "Microsoft.Identity.Client.dll" and "Microsoft.Identity.Client.xml" from the extracted NuGet package directory then paste the **bin** folder

## Create Azure application record in PartnerApplicationBase table in CRM database 

1. Open **SQL Server Management Studio** and copy in this SQL script

```SQL
IF (SELECT COUNT(*)
FROM OrganizationBase WITH (NOLOCK)) <> 1
	THROW 51000, 'Organization records does not equal 1', 1
 
DECLARE @organizationId UNIQUEIDENTIFIER  = (SELECT OrganizationId
FROM OrganizationBase WITH (NOLOCK));
DECLARE @utcNow DATETIME = GetUtcDate();
DECLARE @principalId UNIQUEIDENTIFIER = '00000003-0000-0ff1-ce00-000000000000';
DECLARE @applicationName NVARCHAR(100) = 'Microsoft SharePoint Online';
DECLARE @byoaAppId UNIQUEIDENTIFIER = '<appId>';
--Customer need to provide the app id.
DECLARE @tenantId UNIQUEIDENTIFIER = '<tenantId';
 
BEGIN TRANSACTION InsertRows
 
INSERT INTO [dbo].[PartnerApplicationBase]
	([PrincipalId]
	,[StateCode]
	,[Name]
	,[UseAuthorizationServer]
	,[PartnerApplicationId]
	,[StatusCode]
	,[ApplicationRole]
	,[OrganizationId]
	,[CreatedOn]
	,[ModifiedOn]
	,[TenantId])
VALUES
	(@principalId
	, 0
	, @applicationName
	, 1
	, @byoaAppId
	, 1
	, 1
	, @organizationId
	, @utcNow
	, @utcNow
	, @tenantId)
 
COMMIT TRANSACTION InsertRows
```

1. Update the **@byoaAppId** and **@tenantId** variables for Application ID and Tenant ID from Microsoft Azure portal at the end of the first section of this page.

1. Verify the database and then execute the script 

1. Confirm by running the select query `SELECT *  FROM [PartnerApplicationBase]`and looking at **PartnerApplicationId** and **TenantId** fields.

## Upload certificate in Azure Active Directory app certificates 

Fetch existing CRM certificate using this script.

```PowerShell
cd $PSScriptRoot 

$OutputFilePath = $PSScriptRoot + "\certificates\existing_crmsharepoints2s.cer" 
$RemoveSnapInWhenDone = $False 

if (-not (Get-PSSnapin -Name Microsoft.Crm.PowerShell -ErrorAction SilentlyContinue)) { 
    Add-PSSnapin Microsoft.Crm.PowerShell 
    $RemoveSnapInWhenDone = $True 
} 

try { 
    # Ensure the directory exists 
    $directory = [System.IO.Path]::GetDirectoryName($OutputFilePath) 
    if (-not (Test-Path -Path $directory)) { 
        New-Item -ItemType Directory -Path $directory | Out-Null 
    }

    # Fetch existing certificate using Get-CrmCertificate and filter by CertificateType 
    $existingCert = Get-CrmCertificate | Where-Object { $_.CertificateType -eq "S2STokenIssuer" } 

    if ($null -eq $existingCert) { 
        Write-Error "No certificate found with CertificateType 'S2STokenIssuer'." 
        return 
    } 

    # Store the certificate in the specified path 
    $certBytes = [Convert]::FromBase64String($existingCert.Data) 
    [System.IO.File]::WriteAllBytes($OutputFilePath, $certBytes) 
    Write-Output "Certificate saved to $OutputFilePath" 
} 
catch { 
    Write-Error "An error occurred: $_" 
} 
finally { 
    if ($RemoveSnapInWhenDone) { 
        Remove-PSSnapin Microsoft.Crm.PowerShell 
    } 
} 
```

## Upload existing certificate to Azure application certificates 

1. Open browser and go Azure portal for the Azure Active Directory app that was created in the first section. 

1. Expand **Manage** and select **Certificates & Secrets**.

1. Upload the created certificate file.

   1. Under the **Certificates** section, click on **Upload certificate**.

   1. Use **Upload a certificate** to select the certificate file that got created from the PowerShell script.

   1. Add the **Description** and select **Add**.

1. Newly created certificate will be shown in the **Certificates** list.
