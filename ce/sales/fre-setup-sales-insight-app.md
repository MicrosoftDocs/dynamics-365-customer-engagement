---
title: Set up the conversation intelligence app
description: Configure conversation intelligence to suit your requirements by setting up storage, granting app permissions, and defining tracked keywords and competitors.
ms.date: 02/27/2026
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/08/2023
---

# Set up the conversation intelligence app

> [!IMPORTANT]
> Starting June 2024, Conversation intelligence uses Microsoft Azure OpenAI Service to process call data and transcripts. If your Dynamics 365 Sales organization is in a region where Azure OpenAI Service isn't available, the nearest region where Azure OpenAI Service is available processes your call data and transcripts.

As an administrator, connect the conversation intelligence app to your Dynamics 365 Sales organization to fetch call data and enable sellers to view call insights.

> [!NOTE]
> Conversation intelligence tracks and processes phone calls made through the Teams dialer or a third-party dialer, regardless of whether the call is made from the Sales Hub app or a custom model-driven app. To enable the dialer in a custom app, see [Configure Microsoft Teams dialer](configure-microsoft-teams-dialer.md).

## Prerequisites

Before you can set up the Conversation intelligence app, set up conversation intelligence from the Sales Hub app and configure storage, app permissions, and tracked keywords and competitors. This setup is mandatory to use conversation intelligence in the Sales Hub app and Conversation intelligence app. For more information, see [Set up conversation intelligence from the Sales Hub app](fre-setup-ci-sales-app.md).

## Configure conversation intelligence

1.	Sign in to the [Conversation intelligence app](https://sales.ai.dynamics.com/) as an administrator.  

1.	Select **Connect your data** and then select the Power Platform environment that hosts Dynamics 365 Sales, to connect with the application.  
    > [!div class="mx-imgBorder"]
    > ![Select the environment.](media/si-app-admin-connect-d365-organization.png "Select the environment")  
    
    The application detects your environment.  
5.	In the **Terms and conditions** dialog, carefully read the [Microsoft privacy statement](https://privacy.microsoft.com/privacystatement), and select the checkbox for the [terms and conditions](https://www.microsoft.com/licensing/product-licensing/products). Select **Next**.
  
    The application takes a few minutes to connect to your environment and data, during which a progress dialog is displayed.

1.	Select **Finish** to complete the setup. 

The Conversation intelligence app is now ready to use. Managers and sellers can use it to [view call insights](view-and-understand-call-summary.md).

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

## Related information

[Introduction to administering conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)  
[Conversation Intelligence FAQs](faq-conversation-intelligence.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
