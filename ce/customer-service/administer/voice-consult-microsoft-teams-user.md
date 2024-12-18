---
title: Enable voice consult with Microsoft Teams user for the voice channel
description: Learn how to enable the consult experience between a voice channel customer service representative and a Microsoft Teams user.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 12/14/2024
ms.topic: how-to
ms.collection:
ms.custom: bap-template
---

# Enable voice consult with Microsoft Teams users

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[azure-ad-rename](../../includes/cc-azure-ad-rename.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


Customer service is not always limited to contact centers. Employees within the enterprise are often required to assist customer service representatives (service representative or representative) in customer service scenarios and talk to customers directly for highly technical or VIP engagements. You can enable your s to consult with or transfer voice calls in Omnichannel for Customer Service to subject matter experts (SMEs) in Microsoft Teams.

The SMEs can participate in customer service conversations directly from Microsoft Teams to help representatives in Dynamics 365 and customers on the phone call to resolve issues expertly.

You can transfer and consult with Teams users by assigning phone numbers to users or through Voice Over Internet Protocol (VOIP).

## Enable representatives to consult with Microsoft Teams users via PSTN

> [!NOTE]
> Consult and transfer to Microsoft Teams users or Azure guest users via PSTN in the Teams tab isn't supported in the enhanced voice experience. Use the external tab to call numbers via PSTN.

To allow the representatives to consult with Microsoft Teams users, enable the **Consult with Microsoft Teams user** setting in the voice channel section of the workstream for voice. More information: [Configure the voice channel](../voice-channel-route-queues.md#configure-a-voice-channel). 

The following prerequisites must be set for the Microsoft Teams users:

- **Assign phone numbers to SMEs in Microsoft Teams**: Must have a phone number assigned to them in Microsoft Teams to participate in the voice call as an SME consult. More information: [Assign, change, or remove a phone number for a user](/microsoftteams/assign-change-or-remove-a-phone-number-for-a-user).

  To update the Teams phone number in the user profile, perform the following steps: 
    1. Sign in to the Azure portal and go to **Microsoft Entra ID**.
    1. Select **Manage** > **Users**
    1. Select the required user and select **Edit** to add the phone number in the **Contact info** > **Office phone** field.
    
> [!NOTE]
> When you're adding a business phone number, make sure that you prefix the number with the plus sign (+) followed by the country code.

- **Update the Azure profile for SMEs with phone number**: Add SMEs with phone numbers as guest users to the Microsoft Entra ID for them to participate in a voice call as an SME consult. To add a guest user and update a phone number in the user profile, perform the following steps:

     1. Add a guest user in the Azure portal. More information: [Add a new guest user](/entra/external-id/b2b-quickstart-add-guest-users-portal)
     2. On the guest user profile page, select **Edit** to add the phone number in the **Contact info** > **Office phone** field.

  Dynamics 365 uses Graph API to retrieve the number in the **Office phone** field. Representatives can then search for the guest user in the Teams tab of transfer or consult.

## Enable representatives to consult with Microsoft Teams users via VOIP

If you've updated to the enhanced voice experience, you can enable your representatives to consult with or transfer voice calls to subject matter experts (SMEs) in Microsoft Teams using Voice Over Internet Protocol (VOIP). This feature is available through Azure Communication Services Call Automation. With this feature, SMEs can participate in customer service conversations directly from Microsoft Teams without having to configure a phone number. Any Teams users in your tenant who is displayed in the Teams search box can receive calls from your representatives.

Calling services are charged on a per minute per participant basis at 0.004 per participant per minute and is less than the Public Switched Telephone Network (PSTN) charges of $0.013 per participant per minute.

> [!NOTE]
> - Representatives can transfer or consult with Microsoft Teams users on certain Teams clients only. Learn more at [Supported Teams clients](/azure/communication-services/concepts/call-automation/call-automation-teams-interop#supported-teams-clients).
> - If the Teams user rejects the call or is unavailable, there isn't an option to leave a voicemail for the caller and the call isn't forwarded to another number. This is because the call from Dynamics 365 is considered a group call, and Teams doesn't honor voicemail or call forwarding settings when adding a Teams user to a group call.

To allow the representatives to consult with Microsoft Teams users, enable the **External Microsoft Teams users** in **Consult** and **Transfer** setting in the voice channel section of the voice workstream.

To enable the consult and transfer experience through VOIP, perform the following prerequisites:

- The enhanced voice channel must be enabled for your organization.
- The following IP address ranges must be allowed:
   - Azure Communication Services: [Firewall configuration](/azure/communication-services/concepts/voice-video-calling/network-requirements#firewall-configuration)
   - Microsoft Teams: [Skype for Business Online and Microsoft Teams](/microsoft-365/enterprise/urls-and-ip-address-ranges#skype-for-business-online-and-microsoft-teams)
- The Teams users who are added to calls must have [Teams Phone System Licenses](/microsoftteams/setting-up-your-phone-system) assigned.
-  Enterprise Voice must be enabled. Run the following Powershell command to enable Enterprise Voice.
    ```powershell
    Set-CSPhoneNumberAssignment –Identity [user email address] -EnterpriseVoiceEnabled $true
    ```
-  [External Access Policy](/azure/communication-services/concepts/interop/enable-interoperability-teams#4-enable-tenant-policy) must be enabled.  Run the following Powershell command to enable External Access:
    ```powershell
    Set-CsExternalAccessPolicy -Identity Global -EnableAcsFederationAccess $true
    ```
-  The [Teams and Azure Communication Services federation](/azure/communication-services/concepts/interop/enable-interoperability-teams#enable-interoperability-in-your-teams-tenant) for a Teams tenant must be enabled and the Azure Communication Services resources that can connect to Teams is specified. Perform the following steps:
Get the [immutable resource ID](/azure/communication-services/concepts/troubleshooting-info#getting-immutable-resource-id) of the Azure Communications Service resource, and then run the following PowerShell cmdlets on your computer.
- Run `Get-module *teams*` to verify if the Microsoft Teams is installed. If it isn't installed, perform the following steps:
    - `Install-Module -Name MicrosoftTeams`
    - `Update-Module MicrosoftTeams`
- Connect to Microsoft Teams and run `Connect-MicrosoftTeams`. This command opens a login window. The user must login with their Microsoft Teams admin account.
- Get Microsoft Teams Azure Communication Services allow list.
    - Run `Get-CsTeamsAcsFederationConfiguration` and note the existing Azure Communication Services resource IDs in the allow list. These are existing Azure Communication Services resource IDs for orgs that were enabled for Teams Azure Communications Service federation.
    - Add current Azure Communications Service resource ID to these existing resource IDs when you run the `Set-CsTeamsAcsFederationConfiguration` command in the next step.
 - Set Teams Azure Communications Service allow list.
     - Run `$allowlist = @('<UPDATED_ACS_RESOURCE_IDs>') Set-CsTeamsAcsFederationConfiguration -EnableAcsUsers $True -AllowedAcsResources $allowlist`

### Related information

[Introduction to the voice channel](voice-channel.md)  
[Agent consult with Microsoft Teams users](../use/voice-channel-transfer-consult.md)  
