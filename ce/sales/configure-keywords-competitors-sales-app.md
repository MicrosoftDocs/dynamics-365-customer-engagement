---
title: "Configure keywords and competitors in Dynamics 365 Sales"
description: "Configure conversation content such as, keywords and competitors to track in conversation intelligence in Dynamics 365 Sales."
ms.date: 09/30/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---

# Configure conversation content in Sales Hub app    

Configure conversation content such as, keywords and competitors to track in conversation intelligence in Dynamics 365 Sales organization.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Add keywords and competitors      
Configure tracked keywords and competitors that are relevant to you and your organization so you can track them in calls. Whenever the defined keywords or competitors are mentioned in a call, conversation intelligence will gather the data and display it appropriately on the dashboard.  

>[!NOTE]
>- As a sales manager, you can define tracked keywords and competitors that are specific to your team. That is, you want to track these keywords and competitors only for your team member calls. <br/>
>- The changes you made apply only to your team. They don't impact the administrator-defined settings for your organization.    

1.	Review the prerequisites. To learn more, see [Prerequisites to configure conversation intelligence](prereq-sales-insights-app.md).     
2. Go to **Change area** in the lower-left corner of the page and select **Sales Insights settings**.    
    > [!div class="mx-imgBorder"]
    > ![Select Sales Insights settings](media/si-admin-change-area-sales-insights-settings.png "Select Sales Insights settings")  
    
3.	On the configuration page, under **Productivity**, select **Conversation intelligence**.  
    > [!div class="mx-imgBorder"]
    > ![Conversation intelligence configuration page](media/ci-admin-config-page.png "Conversation intelligence configuration page")
    
4.	Select **Conversation tracking**.           
5. On the **Tracked keywords** section, enter a keyword in **Add a keyword** and then press **Enter**.  
    > [!div class="mx-imgBorder"]
    > ![Tracked keywords section](media/si-app-admin-enter-tracked-keywords.png "Tracked keywords section")   
6.	Repeat **step 2** to add other keywords.  
7.	In the **Competitors** section, enter a competitor's name in **Add a competitor** and then press **Enter**.   
    > [!div class="mx-imgBorder"]
    > ![Competitors section](media/si-app-admin-enter-competitors.png "Competitors section")    
8.	Repeat **step 4** to add other competitors' names.  
9.	Select **Save**.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Administer conversation intelligence](./intro-admin-guide-sales-insights.md)   
[Prerequisites to configure conversation intelligence](prereq-sales-insights-app.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
