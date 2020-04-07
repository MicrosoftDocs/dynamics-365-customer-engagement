---
title: "Report issues in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn how you can report issues in Omnichannel for Customer Service to when you raise a support ticket with Microsoft."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/06/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Report issues in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The Omnichannel for Customer Service app is where users work, and when they encounter an issue, users want to report the issue with Microsoft. 

The Report issues feature in Omnichannel for Customer Service is feature where anyone like administrator, agent, and supervisor using Omnichannel for Customer Service can capture diagnostic report and share it with Microsoft.

The feature uses a keyboard shortcut to capture the information from the Omnichannel for Customer Service app. Users can capture the information when they are in dashboard or while communicating with a customer.

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

4. Open a Notepad in your computer.

5. Paste the diagnostic report that was copied into the notepad, and save the notepad.

When your organization reaches out to [Microsoft support](https://docs.microsoft.com/power-platform/admin/get-help-support), share the diagnostic report. The report helps us to fasten the diagnosis process.

## Diagnostic report information

The diagnostic report contains information specific to Omnichannel but doesn't contain any of your personal information.

If the agent or supervisor is on dashboard or homepage, and when the agent or supervisor captures the report, then we display the following details:

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


If the agent or supervisor is on a session communicating with a customer, and when the agent or supervisor captures the report, then along with the above-mentioned details, we display the global context and conversation context details such as:

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