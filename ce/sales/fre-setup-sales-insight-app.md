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
    > [!div class="mx-imgBorder"]
    > ![Administrator conversation intelligence home page.](media/si-app-admin-home-page-admin-signin.png "Administrator conversation intelligence home page")   
3.	Select **Set up Conversation intelligence**.   
4.	In the **Connect your data** dialog, select the Power Platform environment that hosts Dynamics 365 Sales to connect with the application.  
    > [!div class="mx-imgBorder"]
    > ![Select the environment.](media/si-app-admin-connect-d365-organization.png "Select the environment")    
    The application detects your environment.  
5.	In the **Terms and conditions** dialog, carefully read the [Microsoft privacy statement](https://privacy.microsoft.com/privacystatement), and read and select the checkbox for the [terms and conditions](https://www.microsoft.com/licensing/product-licensing/products). Select **Agree and continue**.  
    > [!div class="mx-imgBorder"]
    > ![Accept terms and conditions.](media/si-app-admin-accept-tandc.png "Accept terms and conditions")  
    >[!NOTE]
    >Selecting the first checkbox allows Microsoft to collect your organization's data to improve the quality of insights. This is optional. 
    The application takes a few minutes to connect to your data, during which a progress dialog is displayed.
    > [!div class="mx-imgBorder"]
    > ![Environment connection progress.](media/si-app-admin-connection-progress-d365-org.png "Environment connection progress")    
6.	In the **Connect your call data** dialog, enter the **Storage connection string** and **Container name**, and then select **Connect**. To learn more on how to get these **Storage connection string** and **Container name** values, see [Create a call recording repository in Azure](create-azure-repo.md)
    > [!div class="mx-imgBorder"]
    > ![Enter values to connect call data.](media/si-app-admin-connect-call-data.png "Enter values to connect call data")   

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
[Conversation Intelligence FAQs](faqs-sales-insights.md#conversation-intelligence)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
