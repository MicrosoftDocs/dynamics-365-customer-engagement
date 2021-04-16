---
title: "Track a marketing campaign response using in-app marketing (Dynamics 365 Sales Professional) | MicrosoftDocs"
description: "Record the replies you get from potential customers in response to a specific marketing campaign to make sure your team can act on the responses in Dynamics 365 Sales Professional."
ms.date: 12/06/2019
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdyn_salespro
  - D365-Entity-list
  - D365-Entity-campaign
  - D365-Entity-campaignresponse
  - D365-Entity-bulkoperation
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Track a marketing campaign response using in-app marketing (Sales Professional)

Record the replies you get from potential customers in response to a specific marketing campaign to make sure your team can act on the responses. Measure the success of specific campaign activities based on their response rates. You can manually create campaign responses or have [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] generate them automatically.  
  
## Create campaign responses manually  
  
1. In the site map, select **Marketing Lists**.
  
2.  Open a marketing list record, and then in the **Campaigns** area, open the campaign to which you want to add campaign responses, and on the **Related** tab, select **Campaign Responses**.

3. Select **New Campaign Response**.
  
4. Add information in the **Campaign Response** form.  
  
5. Select **Save**.  
  
## Create campaign responses automatically  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
2. In your app, on the navigation bar, select the **Settings** icon ![Settings icon on the navigation bar](../sales-enterprise/media/settings-icon.png "Settings icon on the navigation bar"), and then select **Advanced Settings**.

3. On the navigation bar, select **Settings**, and then select **Administration**.

4. Select **System Settings**, and then select the **Marketing** tab.  
  
5. Set the **Create campaign responses for incoming email** option to **Yes**.  

> [!NOTE]
> If there are multiple email replies from a customer to an email sent out from a campaign activity, only the first reply is tracked as a campaign response in the campaign.

  
### See also  
[System Settings dialog box - Marketing tab](/power-platform/admin/system-settings-dialog-box-marketing-tab)   
[Get started with in-app marketing](get-started-app-marketing-sp.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
