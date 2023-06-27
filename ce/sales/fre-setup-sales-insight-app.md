---
title: "First-run setup experience in conversation intelligence application"
description: "Learn how to set up conversation intelligence for Teams meetings and calls through the conversation intelligence app."
ms.date: 09/01/2022
ms.topic: article
author: udaykirang
ms.author: udag
---

# First-run setup in conversation intelligence app

As an administrator, you can set up conversation intelligence&mdash;select storage, grant app permissions, and define organization-level tracked keywords and competitors&mdash;to suit your requirements.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Configure conversation intelligence

1.	Review the prerequisites. More information: [Prerequisites to setup conversation intelligence](prereq-sales-insights-app.md)  

2.	Sign in to the [Conversation intelligence app](https://sales.ai.dynamics.com/) as an administrator.  

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
