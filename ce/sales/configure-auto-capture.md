---
title: "Enable and configure auto capture"
description: "Configure auto capture to helps your sellers to get suggestions on relevant customer activities by capturing emails and meetings from Outlook."
ms.date: 02/17/2023
ms.custom: 
ms.topic: article
ms.assetid: d4d130c5-3494-4677-9093-0a0e0124d953
author: udaykirang
ms.author: udag
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 1
topic-status: Drafting
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
---

# Enable and configure auto capture 

Configure auto capture to help your sellers to get suggestions on relevant customer activities by capturing emails and meetings from the user's Exchange account that's in the same tenant as Dynamics 365.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Configure auto capture

When you enable auto capture, you help salespeople in your organization by suggesting relevant customer activities in Microsoft Dynamics 365 Sales by capturing emails and meetings from Outlook.

> [!IMPORTANT]
> By enabling this feature, you consent to share data about your customers' email activity with an external system. Data imported from external systems into Sales Insights are subject to the [Microsoft Privacy Statement](https://go.microsoft.com/fwlink/?linkid=2116778).


## How to enable auto capture

Enable auto capture by following these steps:

1.	[Review prerequisites for auto capture](#prerequisites-for-auto-capture).

2.	[Enable auto capture](#enable-auto-capture).

### Prerequisites for auto capture

Before you enable auto capture, perform the following tasks: 

-	Enable Sales Insights. To learn more, see [Enable and configure standard Sales Insights features](intro-admin-guide-sales-insights.md#enable-and-configure-standard-sales-insights-features).

- Use Exchange as the server and Outlook as the mail client. 
- Approve the email addresses of users to allow queries against their Exchange data (this requires tenant-level admin privileges). To learn more, see [Approve email](/dynamics365/customer-engagement/admin/connect-exchange-online#approve-email). 
-	[Set up server-side synchronization](/power-platform/admin/email-message-filtering-correlation).

### Enable auto capture

1.	Sign in to the Dynamics 365 Sales Hub app, and go to **Change area** > **Sales Insights settings**.

2.	On the site map under **Productivity intelligence**, select **Auto capture**. 

3.	Turn on the **Enable basic auto capture** toggle.

> [!div class="mx-imgBorder"]
> ![Enable or disable auto capture](media/si-admin-auto-capture-enable-disable.png "Enable or disable auto capture")

> [!NOTE]
> For more information about auto capture and how it can help your users, see [Capture customer-related activities with auto capture](auto-capture.md).


### Untracked emails and meetings

From version 9.2.24031.0010, Dynamics 365 Sales follows the [principle of least privilege access](/entra/identity-platform/secure-least-privileged-access), which blocks access to untracked emails and meetings for users who have [conditional access policies](/entra/identity/conditional-access/concept-conditional-access-policy-common?tabs=secure-foundation) on their tenants. If a user is unable to see untracked emails and meetings, verify whether the issue is due to a conditional access policy. 

1. Sign in to the Microsoft Entra admin center as at least a Conditional Access Administrator.
2. Go to **Identity** > **Monitoring & health** > **Sign-in logs**.
3. Switch to the **User sign-ins (non-interactive)** tab and add the following filters: 
   - **Application** contains **Dataverse**
   - **Resource** contains **Microsoft Graph** 
   - **Status** equals **Failure** 
    
    If there are any results for the affected users, then the issue is due to a conditional access policy. As an alternative, users can use [Microsoft Copilot for Sales in Outlook](/microsoft-sales-copilot/save-outlook-activities-crm) or you can configure [server-side synchronization](/power-platform/admin/email-message-filtering-correlation) to track all emails and meetings automatically.



[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Introduction to administering Sales Insights](intro-admin-guide-sales-insights.md)  
[Auto capture FAQs](faqs-sales-insights.md#auto-capture)


[!INCLUDE[footer-include](../includes/footer-banner.md)]

