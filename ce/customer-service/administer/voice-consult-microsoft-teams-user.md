---
title: Enable voice consult with Microsoft Teams user for the voice channel
description: Learn how to enable the consult experience between a voice channel agent and a Microsoft Teams user.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.date: 05/31/2024
ms.topic: how-to
ms.collection:
ms.custom: bap-template
---

# Enable voice consult with Microsoft Teams users

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


[!INCLUDE[azure-ad-rename](../../includes/cc-azure-ad-rename.md)]

Customer service is not always limited to contact centers. Employees within the enterprise are often required to assist agents in customer service scenarios and talk to customers directly for highly technical or VIP engagements. You can enable your agents to consult with or transfer voice calls in Omnichannel for Customer Service to subject matter experts (SMEs) in Microsoft Teams.

The SMEs can participate in customer service conversations directly from Microsoft Teams to help agents in Dynamics 365 and customers on the phone call to resolve issues expertly.

You can transfer and consult with Teams users by assigning phone numbers to users or through Voice Over Internet Protocol (VOIP).


## Enable agents to consult with Microsoft Teams users via PSTN

To allow the agents to consult with Microsoft Teams users, enable the **Consult with Microsoft Teams user** setting in the voice channel section of the workstream for voice. More information: [Configure the voice channel](../voice-channel-route-queues.md#configure-a-voice-channel). 

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

  Dynamics 365 uses Graph API to retrieve the number in the **Office phone** field. Agents can then search for the guest user in the Teams tab of transfer or consult.

## Enable agents to consult with Microsoft Teams users via VOIP

If you've updated to the enhanced voice experience, you can enable your agents to consult with or transfer voice calls to subject matter experts (SMEs) in Microsoft Teams using Voice Over Internet Protocol (VOIP). This feature is available through Azure Communication Services Call Automation. With this feature, SMEs can participate in customer service conversations directly from Microsoft Teams without having to configure a phone number. Any Teams users in your tenant is displayed in the Teams search box can receive calls from your agents.

Calling services are charged on a per minute per participant basis at 0.004 per participant per minute and is less than the Public Switched Telephone Network (PSTN) charges of $0.013 per participant per minute.

> [!NOTE]
> Agents can transfer or consult with Microsoft Teams users only on certain clients.  Please see [Supported Teams clients](/azure/communication-services/concepts/call-automation/call-automation-teams-interop#supported-teams-clients) for more details.

To allow the agents to consult with Microsoft Teams users, enable the **External Microsoft Teams users** in **Consult** and **Transfer** setting in the voice channel section of the voice workstream.

To enable the consult and transfer experience through VOIP, perform the following prerequisites:

- The enhanced voice channel must be enabled for your organization.
- The following IP address ranges must be allowed:
   - Azure Communication Services: [Firewall configuration](/azure/communication-services/concepts/voice-video-calling/network-requirements#firewall-configuration)
   - Microsoft Teams: [Skype for Business Online and Microsoft Teams](/microsoft-365/enterprise/urls-and-ip-address-ranges#skype-for-business-online-and-microsoft-teams)
- The Teams users that are added to calls must have [Teams Phone System Licenses](/microsoftteams/setting-up-your-phone-system) assigned.
-  Enterprise Voice must be enabled. Run the following Powershell command to enable Enterprise Voice:
    ```powershell
    Set-CSPhoneNumberAssignment –Identity [user email address] -EnterpriseVoiceEnabled $true
    ```
-  The [Teams and Azure Communication Services federation](/powershell/module/teams/set-csteamsacsfederationconfiguration) for a Teams tenant must be enabled and the Azure Communication Services resources that can connect to Teams is specified. Perform the following steps:
Get the [immutable resource ID](/azure/communication-services/concepts/troubleshooting-info#getting-immutable-resource-id) of the Azure Communications Service resource, and then run the following PowerShell cmdlets on your computer.
- Run `Get-module *teams*` to verify if the Microsoft Teams is installed. If it isn't installed, perform the following steps:
    - `Install-Module -Name MicrosoftTeams`
    - `Update-Module MicrosoftTeams`
- Connect to Microsoft Teams and run `Connect-MicrosoftTeams`. This command opens a login window. The user must login with their Microsoft Teams admin account.
- Get Microsoft Teams Azure Communication Services allow list:
    - Run `Get-CsTeamsAcsFederationConfiguration` and note the existing Azure Communication Services resource IDs in the allow list. These are existing ACS resource IDs for orgs that were enabled for Teams Azure Communications Service federation.
    - Add current Azure Communications Service resource ID to these existing resource IDs when executing `Set-CsTeamsAcsFederationConfiguration` command in the next step.
 - Set Teams Azure Communications Service allow list: 
     - Run `$allowlist = @('<UPDATED_ACS_RESOURCE_IDs>') Set-CsTeamsAcsFederationConfiguration -EnableAcsUsers $True -AllowedAcsResources $allowlist`


### Related information

[Introduction to the voice channel](voice-channel.md)  
[Agent consult with Microsoft Teams users](../use/voice-channel-transfer-consult.md)  
