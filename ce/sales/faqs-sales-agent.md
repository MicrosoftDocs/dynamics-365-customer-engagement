---
title: FAQs about using Sales agent in Microsoft 365 Copilot from Dynamics 365 Sales
description: Learn about frequently asked questions regarding the configuration and usage of Sales agent in Microsoft 365 Copilot from Dynamics 365 Sales.
ms.date: 06/30/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# FAQs about using Sales agent in Microsoft 365 Copilot from Dynamics 365 Sales

This article provides answers to frequently asked questions about configuring and using the Sales agent in Microsoft 365 Copilot from Dynamics 365 Sales. 

## Frequently asked questions about configuration

The following sections provide answers to questions that administrators might have when configuring the Sales agent in Microsoft 365 Copilot from the Sales Hub app.

### Why aren't the customizations applied to the Sales agent when I access it from Dynamics 365 Sales?

When you set up the Sales agent in Microsoft 365 Copilot from Dynamics 365 Sales, make sure that you select the correct environment in the Sales agent settings page. Your customizations are environment-specific, so you need to configure them for each environment that you want to use the Sales agent in. 

To verify, follow these steps:
1. [Open the Sales agent setup experience](sales-agent-settings-saleshub.md#open-the-sales-agent-setup-experience)
1. Make sure that the environment selected in the Sales Hub app is the same as the one selected in the Sales agent settings page in Outlook. If not, select the correct environment and apply your customizations again.

### Why can't I access the Sales agent settings page in Outlook?

When you select the [Sales agent settings in the Sales Hub app](sales-agent-settings-saleshub.md), it opens the settings page in Outlook. If you can't access the settings page or you see a blank page, it could be due to one of the following reasons:

- You don't have the necessary permissions to access the Sales agent settings. Learn more in [Privileges required for Dynamics 365 administrators](/microsoft-sales-copilot/privileges#privileges-required-for-dynamics-365-customers).
- You blocked pop-ups in your browser. Make sure that pop-ups are allowed for the Outlook web app. 

## Frequently asked questions about usage

The following sections provide answers to questions that users might have when using the Sales agent in Microsoft 365 Copilot from the Sales Hub app.

<a name="cant-see-agent"></a>
### Why don't I see the Sales agent?

If you don't see the Sales agent in the Sales Hub app, the agent might not be installed in Microsoft 365 Copilot. For more information about agent installation, see [Install Sales agent in Outlook and Microsoft 365 Copilot](/microsoft-sales-copilot/install-sales-as-an-integrated-app).

<a name="no-response-from-agent"></a>
### Why don't I get any responses from the Sales agent?

If you can see the Sales agent in the Sales Hub app but don't get any response from the agent, you might not have the necessary permissions to access the Sales agent. Learn more in [Privileges required for Dynamics 365 sellers](/microsoft-sales-copilot/privileges#dynamics-365-sellers).


