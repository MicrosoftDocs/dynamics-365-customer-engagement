---
title: "Report issues in agent app | MicrosoftDocs"
description: "Learn how you can report issues in the Contact Center workspace or the Customer Service workspace when you raise a support ticket with Microsoft."
ms.date: 09/10/2024
ms.topic: article
author: neeranelli
ms.author: v-slaik
---

# Report issues in agent app

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The report issues feature in the Contact Center workspace or the Customer Service workspace app allows you to capture a diagnostic report of the issues and share it with Microsoft.

> [!IMPORTANT]
> The report issues feature is not supported in the the Contact Center workspace or the Customer Service workspace on Unified Service Desk.

You can copy the information while communicating with a customer by using one of the following keyboard shortcuts.

- **Ctrl** + **Shift** + **Alt** + **d**
- **Ctrl** + **Shift** + **Alt** + **D**

## Capture diagnostic report

1. Sign in to the Contact Center workspace or the Customer Service workspace app.

2. Use the keyboard shortcut to copy the information. Repeat the step if a message indicates that the copy action was unsuccessful.

3. Open a notepad in your computer.

4. Paste the diagnostic report in the notepad, and save.

5. Share the diagnostic report when you contact [Microsoft support](/power-platform/admin/get-help-support).

## Diagnostic report information

The diagnostic report doesn't contain any of your personal information and contains the following information that's specific to the Contact Center workspace or the Customer Service workspace apps.

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

### Related information

[Use Contact Center workspace](/dynamics365/contact-center/use/ccw-overview)   
[Get started with Customer Service workspace](../implement/csw-overview.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
