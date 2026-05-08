---
title: Sync Teams phone numbers to Dynamics 365 (preview)
description: Learn how to retrieve environment IDs, convert numbers, create resource accounts, license them, and sync Teams phone numbers to Dynamics 365.
ms.date: 03/30/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Sync Teams phone numbers to Dynamics 365 (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

To enable calling in the Sales Hub Dialer, you must provision Teams phone numbers as service numbers, create resource accounts for each number, license those accounts, and sync everything to Dynamics 365. This article walks through each step.

This article focuses on specific guidance for syncing Teams phone numbers to Dynamics 365 for use with the Sales Hub Dialer. For general guidance on configuring Teams Phone in the voice channel, see [Configure Teams Phone in voice channel](/dynamics365/contact-center/administer/configure-teams-phone-in-voice-channel).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Retrieve the Azure Communication Services resource ID and Dynamics App ID

These identifiers are required throughout the remaining configuration steps. Store them in a safe location.

1. Open the Sales Hub app, and select **Change area** > **Sales Hub Dialer settings**.
2. Select **Channels** > **Phone Numbers** > **Manage** > **Advanced**.
3. Note the **Azure Communication Services resource ID** and **Dynamics App ID**. Store these IDs for use in the subsequent steps.

## Convert user numbers to service numbers

The voice channel requires **Service** number types. If your phone numbers are currently assigned as **User (Subscriber)** numbers, convert them to service numbers before proceeding.

> [!NOTE]
> This conversion works for both Operator Connect and Direct Routing numbers.

1. Open the [Teams Admin Center](https://admin.teams.microsoft.com/).
1. Go to **Voice** > **Phone numbers**.
1. Select an unassigned number.
1. Select **Change usage** and set it to **Service / Voice App**.

For more information, see [Manage the usage of a phone number](/microsoftteams/manage-the-usage-of-a-phone-number).

## Create Teams resource accounts

A Teams resource account must be created for each service phone number. Repeat the steps in this section for every number.

### Option A: Teams Admin Center

1. Open the [Teams Admin Center](https://admin.teams.microsoft.com/).
1. Go to **Voice** > **Resource accounts**.
1. Select **+ Add**.
1. Set **Resource account type** to **Call Queue**.
1. Complete the remaining fields and save.

### Option B: Teams PowerShell

Ensure the [Microsoft Teams PowerShell module](/microsoftteams/teams-powershell-install) is installed and up to date. Run the following commands in an elevated PowerShell session, changing the email address and display name for each number:

```powershell
# Install the MicrosoftTeams module if not already installed
if (-not (Get-Module -ListAvailable -Name MicrosoftTeams)) {
    Install-Module -Name MicrosoftTeams -Force -AllowClobber
}

# Sign in to Teams
Connect-MicrosoftTeams

# Create the resource account for the Dynamics 365 application ID
New-CsOnlineApplicationInstance `
    -UserPrincipalName "<NewResourceAccountEmail>" `
    -DisplayName "<ResourceAccountDisplayName>" `
    -ApplicationID "<Dynamics App ID>"
```

Replace the placeholders:

| Placeholder | Description |
|---|---|
| `<NewResourceAccountEmail>` | A new email address using your tenant domain (for example, `ra-sales01@contoso.com`). |
| `<ResourceAccountDisplayName>` | A descriptive display name for the resource account. |
| `<Dynamics App ID>` | The value you saved in the [Retrieve IDs](#retrieve-the-azure-communication-services-resource-id-and-dynamics-app-id) step. |

## Assign licenses to resource accounts

Each resource account must be licensed before a phone number can be assigned to it. Repeat for every resource account.

### Option A: Microsoft 365 admin center

1. Open the [Microsoft 365 admin center](https://admin.cloud.microsoft/).
1. Go to **Users** > **Active Users** and search for the resource account.
1. Open the resource account and select **Manage product licenses** > **Licenses and apps**.
1. Assign the following licenses:
   - **Microsoft Teams Phone Resource Account**
   - **Microsoft Teams Domestic and International Calling Plan** (required for call forwarding)
1. Save your changes.

> [!NOTE]
> If you encounter a region-related error, verify that the resource account's usage location matches the phone number's region.

### Option B: PowerShell

```powershell
# Install the Microsoft.Graph module if not already installed
if (-not (Get-Module -ListAvailable -Name Microsoft.Graph)) { 
    Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser 
    Install-Module Microsoft.Graph -Scope CurrentUser -Repository PSGallery -Force 
} 

# Sign in 
Connect-MgGraph -Scopes "Directory.Read.All","User.ReadWrite.All","Organization.Read.All","Group.ReadWrite.All" 

# Get Teams Phone Number Resource Account License Sku 
try { 
    $ResourceAccountSku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'PHONESYSTEM_VIRTUALUSER' 
    $CallForwardSku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'MCOPSTN2' 
    Write-Host "Get Teams Phone Number Resource Account License successfully." -ForegroundColor Green 
} catch { 
    Write-Host "Failed to get Teams Phone Number Resource Account License: $_" -ForegroundColor Red 
    exit 
} 

# Assign Teams phone resource account license to the resource account. 
try { 
    # Uncomment below two commands if you need to update license region code 
    # $SetUserRegionOutput = Update-MgUser -UserId $UserPrincipalName -UsageLocation <IsoCountryCode> 
    # Write-Host "Update Resource Account Region successfully: $setUserLicenseOutput" -ForegroundColor Green 
    $setUserLicenseOutput = Set-MgUserLicense -UserId $UserPrincipalName -AddLicenses @{SkuId=$ResourceAccountSku.skuId} -RemoveLicenses @() 
    $setUserLicenseOutput2 = Set-MgUserLicense -UserId $UserPrincipalName -AddLicenses @{SkuId=$CallForwardSku.skuId} -RemoveLicenses @() 
    Write-Host "Assign license successfully: $setUserLicenseOutput $setUserLicenseOutput2" -ForegroundColor Green 
} catch { 
    Write-Host "Failed to assign license: $_" -ForegroundColor Red 
    exit 
}
```

Replace `$UserPrincipalName` with the resource account email address. 

## Assign service numbers to resource accounts

Each service number must be mapped to its corresponding resource account. Repeat for every number.

### Option A: Teams Admin Center

1. Open the [Teams Admin Center](https://admin.teams.microsoft.com/).
1. Go to **Voice** > **Resource accounts**.
1. Select the resource account.
1. Select **Assign/unassign**.
1. Search for and assign the phone number.

For details, see [Manage resource accounts for service numbers](/microsoftteams/manage-resource-accounts#assign-a-phone-number).

### Option B: PowerShell

```powershell
Connect-MicrosoftTeams

# Assign the phone number to the resource account
try { 

    $setPhoneNumberOutput = Set-CsPhoneNumberAssignment -Identity $TeamsResourceAccountId -PhoneNumber <NumberWithoutPlus> -PhoneNumberType <NumberType> 

    Write-Host "Assign Phone Number successfully: $setPhoneNumberOutput" -ForegroundColor Green 

} catch { 

    Write-Host "Failed to assign phone number: $_" -ForegroundColor Red 

    exit 

}
```    

Replace the placeholders:

| Placeholder | Description |
|---|---|
| `$TeamsResourceAccountId` | The Teams resource account identity (email address). |
| `<NumberWithoutPlus>` | The phone number without the `+` prefix. |
| `<NumberType>` | The number type shown on the Teams phone numbers page (for example, `CallingPlan`). |


## Sync Teams resource accounts to Sales Hub Dialer Voice Channel 

This step binds the Azure Communication Services resource to each Teams resource account. There isn't a UI for this step—you must use PowerShell to complete it. Repeat for every resource account.

> [!IMPORTANT]
> Complete this PowerShell sync before you run the sync in the Sales Hub Dialer settings. 

```powershell
Connect-MicrosoftTeams

# Configure the application instance with Dynamics and ACS identifiers
Set-CsOnlineApplicationInstance `
    -Identity "<ResourceAccountEmail>" `
    -ApplicationId "<Dynamics App ID>" `
    -AcsResourceId "<Azure Communication Services resource ID>"

$teamsResourceAccount = Get-CsOnlineApplicationInstance `
    -Identity "<ResourceAccountEmail>"

# Sync the application instance
Sync-CsOnlineApplicationInstance `
    -ObjectId $teamsResourceAccount.ObjectId `
    -ApplicationId "<Dynamics App ID>" `
    -AcsResourceId "<Azure Communication Services resource ID>"
```

## Confirm the sync in Sales Hub Dialer settings

After the PowerShell sync completes, finalize the phone number records in Dynamics 365.

> [!IMPORTANT]
> Don't perform this step until all PowerShell commands in the previous section run successfully.

1. Open the Sales Hub app, and select **Change area** > **Sales Hub Dialer settings**.
1. Select **Phone numbers** and then select **Manage** > **Advanced**.
1. On the **Manage telephony** page, go to the **Teams telephony** tab.  
   The Azure Communication Services resource ID and Dynamics 365 Application ID are displayed.
1. Select **Sync** to create the phone number records for your Teams service numbers.
   :::image type="content" source="media/manage-telephony-settings.png" alt-text="Screen capture of the Manage telephony settings page showing the Sync button.":::
        
## Next step

> [!div class="nextstepaction"]
> [Configure the Omnichannel dialer in Channel Integration Framework](sales-hub-dialer-configure-cif.md)

## Related information

- [Enable and configure the Sales Hub Dialer](configure-sales-hub-dialer.md)
- [Configure Teams Phone in voice channel](/dynamics365/contact-center/administer/configure-teams-phone-in-voice-channel)
