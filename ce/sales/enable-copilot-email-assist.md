---
title: Enable Copilot email assist
description: Enable Copilot email assist to generate personalized, high-quality emails tailored to specific needs.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 07/07/2023
ms.custom: bap-template 
---

# Enable Copilot email assist (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The Copilot for email assist feature helps sellers to generate content for emails that is specific to customer’s needs with clarity, conciseness, and compelling content.

> [!NOTE]
> - Copilot email assist is supported only for lead and opportunity records through the Dynamics 365 email. For more information about email experience, see [Understand the email experience](/power-apps/user/view-create-email).
> - Copilot email assist doesn’t require Microsoft Viva Sales license.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/sales/relationship-sales/)<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Enable the Copilot email assist feature

1.	Sign into [Power Apps](https://make.powerapps.com/).
2.	On the left pane, select **Apps**, and then select your app.
3.	Select **More commands** (**...**) > **Edit** to open the modern app designer.
4.	On the command bar, select **Settings**.
5.	On the **Upcoming** tab, set the **Enable Copilot Email Assist** toggle to **Yes** and then select **Save**.
6.	Publish the app.

Copilot is enabled in your app and sellers can use the feature to compose emails. 

### See also

[Use Copilot for email messages](use-copilot-email.md)  
[Compose and send email messages using Copilot](compose-send-email-copilot.md)
