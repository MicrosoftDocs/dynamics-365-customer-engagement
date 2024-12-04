---
title: Create or edit campaign using in-app marketing
description: Learn how to create campaigns to store your marketing information and activities, and to measure the success of your efforts through in-app marketing.
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
  - D365-Entity-list
  - D365-Entity-campaign
  - D365-Entity-bulkoperation
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Create or edit a campaign using in-app marketing

Promote your business, expand your reach to new customers, and improve sales by using campaigns in [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]. Use campaigns to store all your marketing information and activities, and to measure the success of your efforts. Campaigns contain planning tasks and campaign activities you need to manage for the marketing campaigns.  
  
 Add strategic campaign information to your campaign, such as:  
  
- Budgets and expenses  
  
- Promotion codes  
  
- Target products  
  
- Marketing collateral, including sales literature  
  
- Target marketing lists  
  
Campaigns can include planning activities that you want to perform before you launch the campaign, and other campaign activities that you want to manage as part of the campaign. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add an activity to a campaign using in-app marketing](../sales-enterprise/add-activity-campaign-using-app-marketing-sales.md)  

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## Create or edit a campaign

> [!NOTE]
> - The number of campaign emails you can send in a day depends on your organization's limit for outgoing emails from Exchange. 
> - The average time for distributing a campaign activity to 100,000 members is 24 hours. For larger campaigns and faster activity distribution, use Dynamics 365 Marketing. For more information, go to [Dynamics 365 Marketing documentation](/dynamics365/customer-insights/journeys/customer-journeys-create-automated-campaigns).
  
1. In the site map, select **Marketing Lists**.

2. Open a marketing list record, and then in the **Campaigns** area, select **New Campaign**. To edit an existing campaign, open a campaign from the list.

    > [!NOTE]
    > Alternatively, you can create a campaign from the **Campaigns** area in the Sales Hub site map. Select **New** to create a new campaign or select an existing campaign to edit.
  
3. In the **Campaign** section, enter the campaign details such as, name, type, and the expected response rate.  

4. In the **Schedules** section, enter the proposed and actual start and end dates of the campaign.

5. Go to the **Details** tab and enter the **Allocated Budget** and **Misc. Cost** of the campaign. **Actual cost** is automatically calculated based on the the value of Actual cost of all activities related to the campaign. **Total cost** is the sum of **Actual cost** and **Misc. Cost**.  

6. Select **Save**. 
 
7. In the **Timeline** section, add activities to track conversations in the planning phase of the campaign. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use timeline](/powerapps/user/add-activities)    

8. To add a marketing list to the campaign, go to the **Marketing Lists** section, select vertical ellipses, and then select **Add Existing Marketing List**. In the **Lookup Records** panel, find and select a marketing list.
  
6. To create planning and campaign activities for your campaign, for example, identifying advertising channels or prepare campaign communications to send to the members on the marketing lists, see [Add an activity to a campaign using in-app marketing](add-activity-campaign-using-app-marketing-sales.md).  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information  
 [Create a marketing list using in-app marketing](../sales-enterprise/create-marketing-list-using-app-marketing-sales.md)   
 [Create a quick campaign using in-app marketing](../sales-enterprise/create-quick-campaign-using-app-marketing-sales.md)   
 [Add an activity to a campaign using in-app marketing](../sales-enterprise/add-activity-campaign-using-app-marketing-sales.md)   
 [Add a marketing list, sales literature, or product to a campaign using in-app marketing](../sales-enterprise/add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)   
 [Track a marketing campaign response using in-app marketing](../sales-enterprise/track-marketing-campaign-response-using-app-marketing-sales.md)   
 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
