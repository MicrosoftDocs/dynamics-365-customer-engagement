---
title: Create a marketing list using in-app marketing
description: A marketing list can include any one type of customer record, such as leads, accounts, or contacts. Add members to the list statically or dynamically.
ms.date: 03/12/2026
ms.update-cycle: 1095-days
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
  - D365-Entity-campaignactivity
  - D365-Entity-campaignresponse
  - D365-Entity-bulkoperation
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Create a marketing list using in-app marketing

Your marketing list is the core of running a successful marketing campaign. It can include any one type of customer record, such as leads, accounts, or contacts.

You can create two types of marketing lists:

- **Static** Use a static list if you prefer to add and update members manually.
- **Dynamic** Use a dynamic marketing list if you want the list to return a list of members dynamically when needed, based on search criteria you set. For example, if you want to run a campaign to members of a specific city, use a dynamic list. A dynamic marketing list retrieves the updated list of members each time you open the list, create a quick campaign from the list, or distribute a campaign activity for a campaign associated with the list.

## Create a marketing list

1. In the site map, select **Marketing Lists**.
2. Select **New**.
3. On the **Summary** tab, add the required information.

    :::image type="content" source="media/marketing-list-summary-example.png" alt-text="Screenshot of marketing list summary area.":::

    > [!NOTE]
    >  To look up records in the **Owner** field, first select **Save**, or you lose your changes.

4. In the **Targeted at** field, select the type of record you want to include in the marketing list. You can't change this field after you save the record.

1. Select **Save** so you can enter information in other areas of the form.
1. Select the **Notes** tab to add any other information that applies to your marketing list.
1. Select **Save**.

## Manage members in a static marketing list

You can manage members in a static marketing list by using one of the following options:

- [Add using Lookup](#add-using-lookup)
- [Add using Advanced Find](#add-using-advanced-find)
- [Remove using Advanced Find](#remove-using-advanced-find)
- [Evaluate using Advanced Find](#evaluate-using-advanced-find)

> [!NOTE]
> - You can only add active records to a static marketing list.
> - To add more than 30,000 members to a static marketing list, you must either be a part of the Salesperson security role or higher, or have the **List Operation** permission.
> - :::image type="content" source="media/listoperation.png" alt-text="Screenshot of List operation permission in the custom entities tab.":::
> -  When you add up to 30,000 members to the marketing list, the add operation is performed synchronously. However, when the number of members exceeds 30000, the add operation is performed asynchronously in batches of 1000.
> - You can add up to 120,000 members to a static marketing list through a single Add operation. If you need to add more than 120,000 members to a static marketing list, split those members and perform multiple add operations. One way to do this is by using the [Advanced Find](#add-using-advanced-find) dialog to create queries that return less than 120,000 members. Alternatively, depending on your scenario, you can also consider using a dynamic marketing list instead of static list. More information: [Create a dynamic marketing list](#define-the-member-selection-criteria-for-a-dynamic-marketing-list)

### Add using Lookup

This option allows you to add members to a marketing list by searching through the records.

1. Open a marketing list.
1. On the command bar, select **Manage Members** > **Add using Lookup**.
1. In the **Lookup Records** dialog box, select your search criteria.
1. Select the records that you want to add, and then select **Add**.

### Add using Advanced Find

This option allows you to add members to a marketing list in bulk based on a search criteria.

1. Open a marketing list, select the three-dot menu on the command bar.
2. Select the right arrow next to **Manage Members** and then select **Add using Advanced Find**.
3. In the **Add members using advanced find** dialog box, the entity that the marketing list is targeted at is automatically selected.
1. In the **Use Saved View** drop-down box, select a view for the selected entity. The filter criteria defined in the view are displayed in the filter area. You can use the existing filter criteria or modify them to meet your needs. 
1. If you want to filter further, select **Add**, and then select **Add row**, to define the search criteria. For example, to find all the contacts in the Seattle city, in the first box select the field as **Address 1: City**. Then, in the second box, select the query relational operator as **Equals**. In the third box, type **Seattle**. You can select fields from the current record type, or from related record types.
   :::image type="content" source="media/advanced-find-marketing-list.png" alt-text="Screenshot of the Add members using advanced find dialog box with the targeted entity pre-selected.":::
1. Select **Find**.
   A list of records that match the search criteria is displayed.
1. Select **Add all** to add all the records or select the records that you want to add and then select **Add selected**.

### Remove using Advanced Find

This option allows you to remove members from a marketing list in bulk based on a search criteria.

1. Open a marketing list, 
1. On the command bar, select **Manage Members** > **Remove using Advanced Find**.
1. In the **Remove members using advanced find** dialog box, the entity that the marketing list is targeted at is automatically selected.
1. In the **Use Saved View** drop-down box, select a view for the selected entity. The filter criteria defined in the view are displayed in the filter area. You can use the existing filter criteria or modify them to meet your needs.
1. If you want to filter further, select **Add**, and then select **Add row**, to define the search criteria. 
1. Select **Find**.
1. Select **Remove all** to remove all the records or select the records that you want to remove and then select **Remove selected**.
    
> [!NOTE]
> For the better performance of application and avoid time outs, remove the members in the marketing list in groups of 10000 at a time. For example, if there are 20,000 members in a marketing list and you want to remove the members. Remove 10,000 members first and then remove the other 10000.

### Evaluate using Advanced Find

After you add members to a marketing list, you can evaluate which members to keep in the marketing list based on search criteria. This option is useful when you want to keep only those members who meet certain criteria.

1. Open a marketing list. 
1. On the command bar, select **Manage Members** > **Evaluate using Advanced Find**.
1. In the **Evaluate members using advanced find** dialog box, the entity that the marketing list is targeted at is automatically selected.
1. In the **Use Saved View** drop-down box, select a view for the selected entity. The filter criteria defined in the view are displayed.
1. If you want to filter further, select **Add**, and then select **Add row**, to define the search criteria. 
1. Select **Find**.
1. Select **Keep all** to keep all the records or select the records that you want to keep and then select **Keep selected**. The records that you don't select are removed from the marketing list.
    
## Define the member selection criteria for a dynamic marketing list

1. Open a dynamic marketing list.
1. On the command bar, select **Manage Members**.
1. In the **Manage Dynamic List Members** dialog box, the entity that the marketing list is targeted at is automatically selected.
1. In the **Use Saved View** drop-down box, select a view for the selected entity. The filter criteria defined in the view are displayed.
1. If you want to filter further, select **Add**, and then select **Add row**, to define the search criteria. For example, to find all the contacts in the Seattle city, in the first box select the field as **Address 1: City**. Then, in the second box, select the query relational operator as **Equals**. In the third box, type **Seattle**. You can select fields from the current record type, or from related record types.
1. Select **Find**.
1. Select **Use Query** to add the matching records to your marketing list.
   The list of members is updated each time you open or use the list, based on the search criteria you set.

## Associate an existing campaign to a marketing list

1. Open a marketing list.
1. In the **Campaigns** area on the **Summary** tab, select **Add Existing Campaign** and search for the campaign you want to associate to this marketing list.
1. Select the campaign, and then select **Add**.

You can't associate an existing quick campaign to a marketing list. You must create the quick campaign from the marketing list to have it associated with the marketing list. For more information, see [Create a quick campaign using in-app marketing](create-quick-campaign-using-app-marketing-sales.md).

## Customized marketing list form

If you're using a custom form for a marketing list that doesn't include certain fields, you see the following message: 'The form is missing the following elements: 'query', 'membertype', 'accountsUCI', 'contactsUCI', 'leadsUCI', 'dynamic_accounts', 'dynamic_contacts', 'dynamic_leads'. Functionalities will be affected.

The elements listed in the message are required to populate the members list that is included in the default form. If your custom form doesn't display the members list, you can ignore the message.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

- [Get started with in-app marketing](get-started-app-marketing-sales.md)
- [Create or edit a campaign using in-app marketing](create-edit-campaign-using-app-marketing-sales.md)
- [Create a quick campaign using in-app marketing](create-quick-campaign-using-app-marketing-sales.md)
- [Add an activity to a campaign using in-app marketing](add-activity-campaign-using-app-marketing-sales.md)
- [Add a marketing list, sales literature, or product to a campaign using in-app marketing](add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)
- [Track a marketing campaign response using in-app marketing](track-marketing-campaign-response-using-app-marketing-sales.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]