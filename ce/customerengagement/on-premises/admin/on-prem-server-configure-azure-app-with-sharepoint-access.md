---
title: "Create an Azure application for Dynamics 365 Customer Engagement (on-premises) with SharePoint permissions"
description: "Follow these steps to create an Azure application to enable integration between Dynamics 365 Customer Engagement (on-premises) and SharePoint Online."
ms.reviewer: "matp"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.author: aorth
author: adrianorth
---

# Configure Azure app for SharePoint access

Using the **SharePoint Documents** entity in a Dynamics 365 organization outside of the documents grid in a Dynamics 365 Customer Engagement (on-premises) app requires an Azure application to grant access. An example of this access includes use within Dynamics 365 Customer Engagement API calls. The setup uses the Power Platform Managed Identities with Azure to grant access.

> [!IMPORTANT]
> Starting in March 2025, the current access is removed to enhance system protection. To ensure continued access, follow these steps to create an Azure application with the necessary SharePoint permissions, set up managed identities in your Dynamics 365 Customer Engagement (on-premises) organization, and configure federated credentials.

## Create an Azure application with SharePoint permissions 

Create an app registration with API permission to SharePoint. Learn more about registering an app and SharePoint access in [Azure Quickstart Register App](/entra/identity-platform/quickstart-register-app?tabs=certificate) and [SharePoint access via Azure AD App-Only](/sharepoint/dev/solution-guidance/security-apponly-azuread). 

1. Open the [Azure portal](https://azure.microsoft.com).

1. Under **Azure services**, select **App registrations**.

1. Select **New registration**. 

1. Enter a **Name** for the application.

1. Under **Supported account types**, select **Accounts in this organizational directory only**.

   > [!NOTE]
   > Other account types aren't currently supported.

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

1. Apply update from [Service Update 1.36 for Microsoft Dynamics CRM (on-premises) 9.1 - Microsoft Support](https://support.microsoft.com/en-us/topic/service-update-1-36-for-microsoft-dynamics-crm-on-premises-9-1-c5ff4dd4-1fbd-427e-b35a-3680b79bbe0f)

1. Download the NuGet package for assembly "Microsoft.Identity.Client" version 4.11.0.
   1. Open https://www.nuget.org/packages/Microsoft.Identity.Client/4.11.0#readme-body-tab
   1. Under **About**, select **Download package**

1. Rename the downloaded package from "microsoft.identity.client.4.11.0.nupkg" to **microsoft.identity.client.4.11.0.zip**.

1. Run extract on **microsoft.identity.client.4.11.0.zip**.

1. Within the extracted directory, open the **lib/net45** folder and find the files "Microsoft.Identify.Client.dll" and "Microsoft.Identify.Client.xml" to use in a later step.

1. On the Windows Server where the Dynamics 365 Customer Engagement (on-premises) web application server role is running, open **Internet Information Services Manager**.
   1. Open the **Run** prompt from the Windows task bar **Start** menu.
   1. Type *inetmgr*, and then press Enter.

1. Expand the **Sites** section in the **Connections** pane.

1. Right-click the **Microsoft Dynamics CRM** site, select **Explore**, and then open the **CRMWeb** folder.

1. Open the **bin** folder.

1. Copy the two files "Microsoft.Identity.Client.dll" and "Microsoft.Identity.Client.xml" from the extracted NuGet package directory, and then paste both into the **bin** folder.

## Create Azure application record in PartnerApplicationBase table in Dynamics 365 Customer Engagement organization database

1. Open **SQL Server Management Studio** and copy in this SQL script.

```SQL
-- Set transaction isolation level to READ UNCOMMITTED.
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
 
--Customer need to provide the AAD app id that is to be used for authentication to SharePoint online.
DECLARE @byoaAppId NVARCHAR(36) = '<appId>';
--Customer need to provide the tenant id for SharePoint online.
DECLARE @tenantId NVARCHAR(36) = '<tenantId>';
 
-- Validate required parameters
IF ((@byoaAppId IS NULL OR TRY_CONVERT(UNIQUEIDENTIFIER, @byoaAppId) IS NULL)
    OR (@tenantId IS NULL OR TRY_CONVERT(UNIQUEIDENTIFIER, @tenantId) IS NULL))
        THROW 51001, 'Both Customer AAD App ID and Tenant ID must be provided and valid UNIQUEIDENTIFIERs.', 1;
 
SET @byoaAppId = CONVERT(UNIQUEIDENTIFIER, @byoaAppId);
SET @tenantId = CONVERT(UNIQUEIDENTIFIER, @tenantId);
 
IF (SELECT COUNT(*)
    FROM OrganizationBase) <> 1
      THROW 51000, 'Organization records does not equal 1', 1
 
DECLARE @organizationId UNIQUEIDENTIFIER  = (SELECT OrganizationId
                                             FROM OrganizationBase);
DECLARE @utcNow DATETIME = GetUtcDate();
DECLARE @sharePointOnlinePrincipalId UNIQUEIDENTIFIER = '00000003-0000-0ff1-ce00-000000000000';
DECLARE @sharePointOnlineAppId UNIQUEIDENTIFIER = '38616d01-8e81-42dd-82fb-b68f2cecac3a';
DECLARE @applicationName NVARCHAR(100) = 'Microsoft SharePoint Online';
 
BEGIN TRY
    BEGIN TRANSACTION InsertRows;
 
    -- Handle Microsoft-provided SharePoint Online app
    -- Check current state of Microsoft SharePoint Online record
    DECLARE @microsoftAppExists BIT = 0;
    DECLARE @microsoftAppNeedsUpdate BIT = 0;
 
    SELECT @microsoftAppExists = 1,
           @microsoftAppNeedsUpdate = CASE 
                 WHEN TenantId IS NULL OR TenantId <> @tenantId THEN 1 
                 ELSE 0 
                 END
    FROM PartnerApplicationBase
    WHERE PrincipalId = @sharePointOnlinePrincipalId
         AND OrganizationId = @organizationId
         AND Name = @applicationName
         AND PartnerApplicationId = @sharePointOnlineAppId;
 
    IF @microsoftAppExists = 1 AND @microsoftAppNeedsUpdate = 1
    BEGIN
        -- Update existing Microsoft record with correct TenantId
        UPDATE PartnerApplicationBase
        SET TenantId = @tenantId,
            ModifiedOn = @utcNow
        WHERE PrincipalId = @sharePointOnlinePrincipalId
              AND OrganizationId = @organizationId
              AND Name = @applicationName
              AND PartnerApplicationId = @sharePointOnlineAppId;
    END
    ELSE IF @microsoftAppExists = 1
    BEGIN
        SELECT 'Partner Application record already exists and is correct for Microsoft SharePoint Online with app ID ' + CAST(@sharePointOnlineAppId AS NVARCHAR(36)) AS Message;
    END
    ELSE
    BEGIN
        -- Insert new Microsoft record
        INSERT INTO [dbo].[PartnerApplicationBase]
           ([PrincipalId], [StateCode], [Name], [UseAuthorizationServer], [PartnerApplicationId],
           [StatusCode], [ApplicationRole], [Organizationid], [CreatedOn], [ModifiedOn], [TenantId])
        VALUES
           (@sharePointOnlinePrincipalId, 0, @applicationName, 1, @sharePointOnlineAppId,
            1, 1, @organizationId, @utcNow, @utcNow, @tenantId);
    END
 
    -- Handle customer-provided AAD app
    IF NOT EXISTS (
        SELECT 1
        FROM PartnerApplicationBase
        WHERE PrincipalId = @sharePointOnlinePrincipalId
              AND OrganizationId = @organizationId
              AND Name = @applicationName
              AND PartnerApplicationId = @byoaAppId)
    BEGIN
        -- Insert customer AAD app record
        INSERT INTO [dbo].[PartnerApplicationBase]
           ([PrincipalId], [StateCode], [Name], [UseAuthorizationServer], [PartnerApplicationId],
           [StatusCode], [ApplicationRole], [Organizationid], [CreatedOn], [ModifiedOn], [TenantId])
        VALUES
           (@sharePointOnlinePrincipalId, 0, @applicationName, 1, @byoaAppId,
            1, 1, @organizationId, @utcNow, @utcNow, @tenantId);
    END
    ELSE
    BEGIN
        SELECT 'Partner Application record already exists for Microsoft SharePoint Online with app ID ' + CAST(@byoaAppId AS NVARCHAR(36)) AS Message;
    END
 
    COMMIT TRANSACTION InsertRows;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION InsertRows;
 
    -- Log error details for script-level errors
    SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_SEVERITY() AS ErrorSeverity,
    ERROR_STATE() AS ErrorState,
    ERROR_LINE() AS ErrorLine;
END CATCH
```

2. In the script, update the **@byoaAppId** and **@tenantId** variables with the **Application ID** and **Tenant ID** values you copied earlier from the Microsoft Azure portal in the [Create an Azure application with SharePoint permissions](#create-an-azure-application-with-sharepoint-permissions) section of this article.

3. Verify the database and then execute the script.

4. Confirm by running the select query `SELECT *  FROM [PartnerApplicationBase]`and verifying the **PartnerApplicationId** and **TenantId** fields.

## Add the server-to-server certificate to the local certificate store and Customer Engagement (on-premises) configuration database

1. Open a PowerShell command session on all servers where the Dynamics 365 Server Full Server role is installed. 

   > [!IMPORTANT]
   > If you have a server role deployment, you must run the command described here on all Dynamics 365 servers where the Web Application Server role is running.

2. Change your location to the \<*drive*\>:\\Program Files\\Microsoft Dynamics CRM\\Tools folder.

3. Run the CertificateReconfiguration.ps1 Windows PowerShell script as explained here:

   - **certificateFile** *path\\Personalcertfile.pfx* . Required parameter that specifies the full path to the personal information exchange file (.pfx). More information: Working with digital certificates
    
   - **password** *personal\_certfile\_password*. Required parameter that specifies the private certificate password.
    
   - **certificateType S2STokenIssuer**. Required parameter that specifies the type of certificate. For Customer Engagement (on-premises) and SharePoint server-based integration, only **S2STokenIssuer** is supported.
    
   - **serviceAccount** '*DomainName\\UserName*' or 'Network Service'. Required parameter that specifies the identity for the Web Application Server role. The identity is either a domain user account, such as *contoso\\CRMWebAppServer*, or Network Service. The identity will be granted permission to the certificate.

   - **updateCrm**. Adds the certificate information to the Microsoft Customer Engagement (on-premises) configuration database.

    > [!IMPORTANT]
    > Even if you have multiple Web Application Server or Asynchronous Service roles deployed, you only need to run the command with the `updateCrm` parameter once.

   - **storeFindType FindBySubjectDistinguishedName**. Specifies the type of certificate store. By default, this value is `FindBySubjectDistinguishedName` and is recommended when you run the script.

   > [!IMPORTANT]
   > Although the `updateCrm` and `StoreFindType` parameters are optional to run the command, these parameters are required for server-based SharePoint integration so that certificate information is added to the certification database.

   Example:

   ``` powershell
   .\CertificateReconfiguration.ps1 -certificateFile c:\Personalcertfile.pfx -password personal_certfile_password -updateCrm -certificateType S2STokenIssuer -serviceAccount Domain\UserName -storeFindType FindBySubjectDistinguishedName
   ```

## Upload certificate in Azure app certificates

Fetch the existing Dynamics 365 Customer Engagement (on-premises) certificate using this script.

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

If the PowerShell script returns "No certificate found with CertificateType 'S2STokenIssuer'.", then 

1. Find the CRM server with the deployment tools role
1. Log on using a CRM deployment administrator
1. Replace **@crmCertFile** with the full path certificate file and run the PowerShell script as an administrator
   
   ```PowerShell
   add-pssnapin microsoft.crm.powershell
   
   $CrmCertificate = "@crmCertFile" 

   Params = @{
       CertificateType = S2STokenIssuer
       StoreName = My
       StoreLocation = LocalMachine
       StoreFindType = FindBySubjectDistinguishedName
       DataFile = $CrmCertificate
   }
   Set-CrmCertificate @Params
   ```
      
## Upload the existing certificate to Azure application certificates 

1. Open a web browser and go to the Azure portal for the Azure AD app that was created in the first section.

1. Expand **Manage**, and then select **Certificates & Secrets**.

1. Upload the created certificate file.

   1. Under the **Certificates** section, select **Upload certificate**.

   1. Use **Upload a certificate** to select the certificate file that was created from the PowerShell script.

   1. Add the **Description**, and then select **Add**.

The newly created certificate is shown in the **Certificates** list.
