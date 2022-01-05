---
title: "First-run setup experience in conversation intelligence application"
description: "First-run configuration of conversation intelligence in conversation intelligence application for your Dynamics 365 Sales environment."
ms.date: 01/07/2022
ms.custom: 
ms.topic: article
ms.assetid: 3e099e3a-f6cb-42cf-b84e-9f8b0c6ee9db
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 1
topic-status: Drafting
---

# First-run setup in conversation intelligence app

After you sign in to conversation intelligence app as an administrator, you can set up conversation intelligence&mdash; select storage, grant app permissions, and define organization-level tracked keywords and competitors to be used by conversation intelligence.  

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System Administrator <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Configure conversation intelligence

1.	Review the prerequisites. More information: [Prerequisites to setup conversation intelligence](prereq-sales-insights-app.md)  
2.	Sign in to the conversation intelligence application as an administrator.  
    > [!div class="mx-imgBorder"]
    > ![Administrator conversation intelligence home page.](media/si-app-admin-home-page-admin-signin.png "Administrator conversation intelligence home page")   
3.	Select **Set up Conversation intelligence**.   
4.	In the **Connect your data** dialog, select your Dynamics 365 Sales environment to connect with the application.  
    > [!div class="mx-imgBorder"]
    > ![Select Dynamics 365 Sales environment.](media/si-app-admin-connect-d365-organization.png "Select Dynamics 365 Sales environment")    
    The application detects your environment.  
5.	In the **Terms and conditions** dialog, carefully read the [Microsoft privacy statement](https://privacy.microsoft.com/privacystatement), and read and select the checkbox for the [terms and conditions](https://www.microsoft.com/licensing/product-licensing/products). Select **Agree and continue**.  
    > [!div class="mx-imgBorder"]
    > ![Accept terms and conditions.](media/si-app-admin-accept-tandc.png "Accept terms and conditions")  
    >[!NOTE]
    >Selecting the first checkbox allows Microsoft to collect your organization's data to improve the quality of insights. This is optional. 
    The application takes a few minutes to connect to your data, during which a progress dialog is displayed.
    > [!div class="mx-imgBorder"]
    > ![Environment connection progress.](media/si-app-admin-connection-progress-d365-org.png "Environment connection progress")    
6.	In the **Connect your call data** dialog, enter the **Storage connection string** and **Container name**, and then select **Connect**. More information: [Configure conversation intelligence to connect call data](configure-conversation-intelligence-call-data.md)  
    > [!div class="mx-imgBorder"]
    > ![Enter values to connect call data.](media/si-app-admin-connect-call-data.png "Enter values to connect call data")   
7.	If you want to turn on access to preview features, in the **Coming soon** dialog, select the checkbox and then select **Agree and continue**.  
    > [!div class="mx-imgBorder"]
    > ![Turn on preview features.](media/si-app-admin-enable-preview-feature.png "Turn on preview features")   

    > [!NOTE]
    > If you don't want to enable the preview feature for your organization, skip this step. You can always enable preview features later. More information: [Enable coming soon features](enable-preview-features-sales-insights-app.md)  
8.	In the **Keyword and competitor tracking** dialog, add the keywords and competitors that you want to track on the call. You can update these keywords and trackers later if your organization's requirements change. More information: [Configure conversation content](../sales/configure-keywords-competitors.md)      
    > [!NOTE]
    > You can also skip adding the keywords and competitors at this point. You can always add them later.  
    
    > [!div class="mx-imgBorder"]
    > ![Add tracked keywords and competitors.](media/si-app-admin-keywords-and-competitor-tracking.png "Add tracked keywords and competitors")   
9.	Select **Finish** to complete the setup of conversation intelligence for your organization.
    The status message will be displayed at the top of the page.  
    > [!div class="mx-imgBorder"]
    > ![Setup progress message.](media/si-app-admin-status-message-set-up.png "Setup progress message")

Now your conversation intelligence application is ready, and managers and sellers can use it to view this data.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Introduction to administering conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)  
[Prerequisites to configure conversation intelligence](prereq-sales-insights-app.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
