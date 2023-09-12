---
title: Set up conversation intelligence from the standalone app
description: Configure conversation intelligence to suit your requirements by setting up storage, granting app permissions, and defining tracked keywords and competitors.
ms.date: 09/08/2023
ms.topic: article
author: udaykirang
ms.author: udag
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/08/2023
---

# Set up conversation intelligence from the standalone app

As an administrator, you can set up conversation intelligence to suit your requirements by setting up storage, granting app permissions, and defining tracked keywords and competitors.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Prerequisites

Verify the following requirements before setting up conversation intelligence for your organization:

- Set up conversation intelligence from the Sales Hub app to select storage, grant app permissions, and define organization-level tracked keywords and competitors. This setup is mandatory to use conversation intelligence in the Sales Hub app and Conversation intelligence app. For more information, see [Set up conversation intelligence from the Sales Hub app](fre-setup-ci-sales-app.md).

## Configure conversation intelligence

1.	Sign in to the [Conversation intelligence app](https://sales.ai.dynamics.com/) as an administrator.  

3.	Select **Connect your data** and then select the Power Platform environment that hosts Dynamics 365 Sales, to connect with the application.  
    > [!div class="mx-imgBorder"]
    > ![Select the environment.](media/si-app-admin-connect-d365-organization.png "Select the environment")  
    
    The application detects your environment.  
5.	In the **Terms and conditions** dialog, carefully read the [Microsoft privacy statement](https://privacy.microsoft.com/privacystatement), and and select the checkbox for the [terms and conditions](https://www.microsoft.com/licensing/product-licensing/products). Select **Next**.
  
    The application takes a few minutes to connect to your environment and data, during which a progress dialog is displayed.

9.	Select **Finish** to complete the setup. 

The Conversation intelligence app is now ready to use. Managers and sellers can use it to [view call insights](view-and-understand-call-summary.md).

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Introduction to administering conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)  
[Conversation Intelligence FAQs](faqs-sales-insights.md#conversation-intelligence)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
