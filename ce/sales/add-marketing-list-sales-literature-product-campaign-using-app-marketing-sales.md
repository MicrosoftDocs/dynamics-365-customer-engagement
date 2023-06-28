---
title: "Add assets to campaigns using in-app marketing | MicrosoftDocs"
description: "Depending on the marketing context of a campaign, add assets such as a marketing list, sales literature, or product to a campaign using in-app marketing. "
ms.date: 11/12/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-list
  - D365-Entity-campaign
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Add a marketing list, sales literature, or product to a campaign using in-app marketing

Add all items to the campaign that your organization needs in this marketing context. Usually you need to add marketing lists, but you might also want to refer campaigns to products and related campaigns, or you might want to add sales literature that documents sales procedures.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## Add product list, product, or sales literature to a campaign

1. In the site map, select **Marketing Lists**.

2. Open a marketing list record, and then in the **Campaigns** area, open the campaign to which you want to add a list, product, or sales literature.

    The following table shows what you need to do to add each type of item.  


   |       To add       |                                      Do this                                      |
   |--------------------|-----------------------------------------------------------------------------------|
   |  A marketing list  | On the **Related** tab, select **Target Marketing Lists**, and then select **Add Existing Marketing List**. |
   |     A product      | On the **Related** tab, select **Target Products**, and then select **Add Existing Product**.        |
   |  Sales literature  | On the **Related** tab, select **Sales Literature**, and then select **Add Existing Sales Literature**.   |
   | A related campaign | On the **Related** tab, select **Related Campaigns**, and then select **Add Existing Campaign**.     |


3. Select the type of record you want in the **Lookup Records** panel. In the **Look for records** field, type the first few letters of the name of the record to narrow your search, and then select the **Search** icon ![Search icon.](media/search-icon.png "Search icon").  

4. Select the records that you want to add in the list of records that appears, and then select **Add**.  

5. Select **Save** or **Save and Close**.  

   > [!NOTE]
   >  To verify that the item you selected was added to the campaign, reopen the campaign. Under **Marketing**, select **Target Marketing Lists**, or under **Sales** select either **Target Products** or **Sales Literature**. The information you added appears in the list.  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See Also  
 [Get started with in-app marketing](../sales-enterprise/get-started-app-marketing-sales.md)   
 [Create a marketing list using in-app marketing](../sales-enterprise/create-marketing-list-using-app-marketing-sales.md)   
 [Create or edit a campaign using in-app marketing](../sales-enterprise/create-edit-campaign-using-app-marketing-sales.md)   
 [Create a quick campaign using in-app marketing](../sales-enterprise/create-quick-campaign-using-app-marketing-sales.md)   
 [Add an activity to a campaign using in-app marketing](../sales-enterprise/add-activity-campaign-using-app-marketing-sales.md)   
 [Track a marketing campaign response using in-app marketing](../sales-enterprise/track-marketing-campaign-response-using-app-marketing-sales.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
