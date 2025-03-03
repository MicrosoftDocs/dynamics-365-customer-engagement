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

## Create an Azure application with SharePoint permissions 

Create an App registration with API permission to SharePoint. Learn more about registering an app and SharePoint access in Azure Quickstart Register App and SharePoint access via Azure AD App-Only. 

1. Open the Azure portal.

1. Under **Azure services**, select **App registrations**. 

1. Select **New registration**. 

1. Enter a Name for the application. 

1. Under **Supported account types**, select **Accounts** in this organizational directory only. 

   Note: Other types aren't supported at this time. 

1. Select **Register** to create the App registration. 

1. Note the Application (client) ID and Directory (tenant) ID: 
   1. Under **Essentials**, copy the **Application (client) ID** and **Directory (tenant) ID** values for use in the next section. 
   1. In the navigation list, select **Overview**. 

1. In the navigation list, select **Manage** > **API permissions**. 

1. Under **Configured permissions**, select **Add a permission** to open the **Request API permissions** panel. 
   1. Select **SharePoint**. 
   1. Under **What type of permissions does your application require?**, select **Application permissions**. 
   1. Under Select permissions, select **Sites.FullControl.All**. 
   1. Select **Add permissions** to create the SharePoint permission. 
   1. Select **Grant admin consent** for the tenant name. 

1. Capture the following IDs, which to be used in later steps: 
   Application ID  
   Tenant ID 

## Server setup prerequisites 

1. Download NuGet for assembly "Microsoft.Identity.Client" version 4.11.0 package from https://www.nuget.org/packages/Microsoft.Identity.Client/4.11.0#readme-body-tab

1. Rename the downloaded package from "microsoft.identity.client.4.11.0.nupkg" to "microsoft.identity.client.4.11.0.zip"

1. Run extract "microsoft.identity.client.4.11.0.zip".

1. Go to the net45 folder and the assembly with the mapping xml will be present: 

1. Now on the web server open Internet Information Services Manager (run command for windows and type inetmgr + enter)

1. Expand the sites section in Internet Information Services Manager

1. Right click on the **CRM site** and click on **Explore** 

1. It takes to the **CRMWeb** folder:

1. Open bin folder and copy the two files from step c and paste to the bin folder: 

## Create Azure application record in PartnerApplicationBase table in CRM database 

1. Open **SQL Server Management Studio** then open the SQL script "PartnerAppBaseUpdate.sql"  

1. Update the two variables for Application ID and Tenant ID from Step 1 section b) and execute (Ensure it points to the right database) : 

1. Confirm by running the select query - "SELECT *  FROM [PartnerApplicationBase]": 

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

1. Now open browser and go Azure portal for the AAD app that was created in Step 1: 
1. Expand Manage and click on Certificates & Secrets:
1. Go to certificates section:
1. Click on upload certificate and select the cert that got created as part of step o and give a suitable description and click on add:
1. Post successful addition it is shown as below: 
