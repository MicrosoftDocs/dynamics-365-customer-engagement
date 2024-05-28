---
title: Enable voice consult with Microsoft Teams users (preview)
description: Learn how to enable the consult experience between a voice channel agent and a Microsoft Teams user in Omnichannel for Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.date: 05/31/2024
ms.topic: how-to
ms.collection:
ms.custom: bap-template
---

# Enable voice consult with Microsoft Teams users (preview)

If you've updated your voice stack, you can enable your agents to consult with or transfer voice calls to subject matter experts (SMEs) in Microsoft Teams using Voice Over Internet Protocol (VOIP). This feature is available through Azure Communication Services Call Automation. With this feature, SMEs can participate in customer service conversations directly from Microsoft Teams without having to configure a phone number. Any Teams users in your tenant will be displayed in the Teams search box and will be able to receive calls from your agents. 
Calling services are charged on a per minute per participant basis at 0.004 per participant per minute and is less than the Public Switched Telephone Network (PSTN) charges of $0.013 per participant per minute.

## Prerequisites

- The following IP address ranges must be allowed:
   - Azure Communication Services: [Firewall configuration](/azure/communication-services/concepts/voice-video-calling/network-requirements#firewall-configuration)
   - Microsoft Teams: [Skype for Business Online and Microsoft Teams](/microsoft-365/enterprise/urls-and-ip-address-ranges?view=o365-worldwide#skype-for-business-online-and-microsoft-teams)
- The Teams users that are added to calls must have [Teams Phone System Licenses](/microsoftteams/setting-up-your-phone-system) assigned and Enterprise Voice must be enabled. Run the following Powershell commanf to enable Enterprise Voice:
    ```powershell
    Set-CSPhoneNumberAssignment –Identity [user email address] -EnterpriseVoiceEnabled $true
    ```
-  The [Teams and Azure Communication Services federation](/powershell/module/teams/set-csteamsacsfederationconfiguration?view=teams-ps) for a Teams tenant must be enabled and the Azure Communication Services resources that can connect to Teams must be specified. Perform the following steps:
Get the [immutable resource ID](/azure/communication-services/concepts/troubleshooting-info?tabs=csharp%2Cjavascript%2Cdotnet#getting-immutable-resource-id) of the Azure Communications Service resource, and then run the following PowerShell cmdlets on your computer:
  - Install Teams powershell module if missing:
      - Check if teams module exists by running Get-module *teams*
      - Then install Teams module if missing:
         - Install-Module -Name MicrosoftTeams
         - Update-Module MicrosoftTeams
  - Connect to Microsoft Teams and run `Connect-MicrosoftTeams`. This command opens a login window, have the customer login with their Microsoft Teams admin account.
  - Get Teams Azure Communication Services allow list:
     - Run `Get-CsTeamsAcsFederationConfiguration` and note the existing Azure Communication Services resource IDs in the allow list. These are existing ACS resource IDs for orgs that were enabled for Teams Azure Communications Service federation.
     - Add current ACS resource ID to these existing resource IDs when executing `Set-CsTeamsAcsFederationConfiguration` command in the next step.
 - Set Teams ACS allow list: 
     - Run `$allowlist = @('<UPDATED_ACS_RESOURCE_IDs>')
Set-CsTeamsAcsFederationConfiguration -EnableAcsUsers $True -AllowedAcsResources $allowlist`

## Supported software 

| Clients                                                    | Supported? |
|------------------------------------------------------------|------------|
| Microsoft Teams Desktop                                    | Yes        |
| Microsoft Teams Web                                        | No         |
| Microsoft Teams iOS                                        | No         |
| Microsoft Teams Android                                    | No         |
| Azure Communications Services signed in with Microsoft 365 | No         |

## Enable agents to consult with Microsoft Teams users

To allow the agents to consult with Microsoft Teams users, enable the **Consult with Microsoft Teams user** setting in the voice channel section of the workstream for voice. More information: [Configure the voice channel](../voice-channel-route-queues.md#configure-a-voice-channel)
