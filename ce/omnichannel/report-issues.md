---
title: "Report issues in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn how you can report issues in Omnichannel for Customer Service to when you raise a support ticket with Microsoft."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 06/03/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Report issues in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The report issues feature in the Omnichannel for Customer Service app allows administrators, agents, and supervisors to capture a diagnostic report and share it with Microsoft when they come across issues while using the app.

> [!IMPORTANT]
> The report issues feature is not supported in Omnichannel for Customer Service on Unified Service Desk.

The feature uses a keyboard shortcut to capture the information from the Omnichannel for Customer Service app. Users can capture the information when they are on the dashboard or while communicating with a customer.

| Keyboard shortcut |
|-------------------------|
| **Ctrl** + **Shift** + **Alt** + **d** |
| or |
|**Ctrl** + **Shift** + **Alt** + **D** |

## Capture diagnostic report

1. Sign in to Omnichannel for Customer Service.

2. Press the keys - **Ctrl** + **Shift** + **Alt** + **d** (or) |**Ctrl** + **Shift** + **Alt** + **D**.

    If the information copy is successful, you will see toast notification - **Your diagnostic report was copied to your clipboard.**

    If the information copy is unsuccessful, you will see toast notification - **Something went wrong. Please try copying your report again.**

    If unsuccessful, repeat step 2.

3. Open a notepad in your computer.

4. Paste the diagnostic report that was copied into the notepad, and save the notepad.

5. Share the diagnostic report when you contact [Microsoft support](https://docs.microsoft.com/power-platform/admin/get-help-support).

## Diagnostic report information

The diagnostic report contains the following information that is specific to Omnichannel for Customer Service and doesn't contain any of your personal information.

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

If the agent or supervisor is in a session communicating with a customer, and when the agent or supervisor captures the report, then with the details mentioned in the preceding table, the following global context and conversation context details will also be captured.

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

## See also

[Best practices to use Omnichannel for Customer Service](best-practices.md)
