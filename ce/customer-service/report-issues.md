---
title: "Report issues in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn how you can report issues in Omnichannel for Customer Service to when you raise a support ticket with Microsoft."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 06/03/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Report issues in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The report issues feature in the Omnichannel for Customer Service app allows you to capture a diagnostic report of the issues and share it with Microsoft.

> [!IMPORTANT]
> The report issues feature is not supported in Omnichannel for Customer Service on Unified Service Desk.

You can copy the information while communicating with a customer by using one of the following keyboard shortcuts.

- **Ctrl** + **Shift** + **Alt** + **d**
- **Ctrl** + **Shift** + **Alt** + **D**

## Capture diagnostic report

1. Sign in to Omnichannel for Customer Service.

2. Use the keyboard shortcut to copy the information. Repeat the step if a message indicates that the copy action was unsuccessful.

3. Open a notepad in your computer.

4. Paste the diagnostic report in the notepad, and save.

5. Share the diagnostic report when you contact [Microsoft support](https://docs.microsoft.com/power-platform/admin/get-help-support).

## Diagnostic report information

The diagnostic report doesn't contain any of your personal information and contains the following information that's specific to Omnichannel for Customer Service.

| Name | Display name in the report |
|---------------------|-----------------------------|-----------------------------|
|Timestamp | timestamp |
|Provider name | activeProviderName |
|Client URL| ClientUrl| 
|App URL|AppUrl| 
|Organization locale ID|OrgLcid| 
|Organization unique name|OrgUniqueName| 
|Organization Id|OrgId| 
|User locale Id|UserLcid|
|User roles Id|User roles|
|CRM version|crmVersion|
|Tenant Id|TenantId|

If you, as an agent or supervisor, are in a session with a customer, and capture the report, then with the details mentioned in the preceding table, the following global context and conversation context details are also copied.

| Name | Display name in the report |
|---------------------|-----------------------------|-----------------------------|
|Timestamp | timestamp |
|Provider name | activeProviderName |
|Client URL| ClientUrl| 
|App URL|AppUrl|
|Organization locale Id|OrgLcid|
|Organization unique name|OrgUniqueName|
|Organization Id|OrgId| 
|User locale Id|UserLcid|
|User roles Id|User roles|
|CRM version|crmVersion|
|Tenant Id|TenantId|
| Omnichannel API URL|ocApiUrl|
| Conversation Id | conversationId |
| Session Id | sessionId
| Conversation Type | conversationType|
|Transaction Id | transactionId|
| Transaction parameters|transactionParameters|
|Live work item Id |liveWorkItemId|
|Channel Id |channelId |

### See also

[Best practices to use Omnichannel for Customer Service](best-practices.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]