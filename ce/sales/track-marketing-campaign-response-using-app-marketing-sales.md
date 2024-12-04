---
title: Track campaign responses by using in-app marketing
description: Learn how to track replies to your campaigns by using manual or automatic campaign responses in Dynamics 365 Sales.
ms.date: 06/20/2024
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - bap-template
  - evergreen
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-campaign
  - D365-Entity-campaignactivity
  - D365-Entity-campaignresponse
  - D365-Entity-bulkoperation
  - D365-UI-Form
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Track campaign responses by using in-app marketing

Record the replies you get from potential customers in response to a specific marketing campaign to make sure your team can act on the responses. Measure the success of specific campaign activities based on customer response rates. You can manually create campaign responses or have [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] generate them automatically.  

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## Create campaign responses manually  
  
1. In the site map, select **Marketing Lists**.
  
1. Open a marketing list record, and then in the **Campaigns** area, open the campaign to which you want to add campaign responses.
    > [!NOTE]
    > Alternatively, you can open a campaign from the **Campaigns** area in the Sales Hub site map.

1. On the **Related** tab, select **Campaign Responses**.

1. Select **New Campaign Response**.
  
1. In the **New Campaign Response** form, add the required information.
  
1. Select **Save**.  
  
## Create campaign responses automatically

**Prerequisite**: [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  

Set the **Create campaign responses for incoming email** option to **Yes** on the [Marketing Settings](configure-inapp-marketing.md) page. 

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]
  
## Related information

[System Settings dialog box - Marketing tab](/power-platform/admin/system-settings-dialog-box-marketing-tab)   
[Get started with in-app marketing](get-started-app-marketing-sales.md)   
[Create a marketing list using in-app marketing](create-marketing-list-using-app-marketing-sales.md)   
[Create or edit a campaign using in-app marketing](create-edit-campaign-using-app-marketing-sales.md)   
[Create a quick campaign using in-app marketing](create-quick-campaign-using-app-marketing-sales.md)   
[Add an activity to a campaign using in-app marketing](add-activity-campaign-using-app-marketing-sales.md)   
[Add a marketing list, sales literature, or product to a campaign using in-app marketing](add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)   



[!INCLUDE[footer-include](../includes/footer-banner.md)]
