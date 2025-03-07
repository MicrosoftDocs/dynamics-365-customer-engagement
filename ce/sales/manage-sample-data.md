---
title: Explore the sales accelerator with sample data
description: Sample data helps you visualize a product and its features. Learn how to add or remove sample data to explore sales accelerator.
ms.date: 09/20/2024
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
---
# Explore the sales accelerator with sample data 

Sample data helps you visualize a product and its features. Learn how to add or remove sample data to explore sales accelerator.

## Add sample data

You can add sample data any time you need, during or after the configuration of the sales accelerator.  

> [!NOTE]
> - The sample data adds basic Dynamics 365 Sales and Sales Premium record types. More information: [Record types updated with sample data](#record-types-updated-with-sample-data)  
> - To prevent unwanted results, sample data is available only in non-production environments.  
> - You can also add sample data from the quick setup panel (with the Dynamics 365 Sales Enterprise license). More information: [Set up sales accelerator](digital-selling-sales-accelerator.md#set-up-sales-accelerator)

1. Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **Sales Insights settings**.
1. Under **Sales accelerator**, select **Workspace**.  
1. On the **Sales accelerator workspace** page, under the **Manage access and record type** section, select **Configure**.  
    >[!NOTE]
    >If you're add the sample data during the first-run set up, on the **Sales accelerator quick setup** pane, select **Add sample data**.  
    >More information: [First-run set up](enable-configure-sales-accelerator.md#first-run-set-up)

1. From the **Sample data** section, select **Add sample data**.  

    :::image type="content" source="media/sample-data-popup.png" alt-text="Screenshot for select Add sample data from the Manage access and record type page.":::

1. Select **Update**.  

Adding of sample data may take few minutes. You can continue to work on the application while the sample data is being added. After the sample data is added, a confirmation message is displayed with the date and time it was added.

:::image type="content" source="media/sample-data-add-later-confirmation-message.png" alt-text="Screenshot for confirmation message of sample data added later.":::

## Sample data availability

By default, sample data is available for the administrator who adds it. The administrator can assign the records that are associated with sample data for other users to explore.

## Remove sample data

As an administrator, you can remove sample data that your organization no longer needs.

>[!NOTE]
>You can always add the sample data again, whenever you need it.

**To remove sample data**

1. Sign in to your sales app.  
1. Go to **Change area** in the lower-left corner of the page, and select **Sales Insight settings**.  
1. Under **Sales accelerator**, select **Workspace**.  
1. On the **Sales accelerator workspace** page, under the **Manage access and record type** section, select **Configure**.  
    :::image type="content" source="media/sa-setup-page.png" alt-text="Screenshot for sales accelerator setup page.":::  
1. Under the **Sample data** section, select **Remove sample data**.  
    :::image type="content" source="media/sample-data-add-later-confirmation-message.png" alt-text="Screenshot for confirmation message of sample data added later.":::  
1. On the confirmation message, select **Remove sample data**.  
    :::image type="content" source="media/sample-data-remove-confirmation-message.png" alt-text="Screenshot for confirmation message to remove sample data.":::  
1. Select **Update**.  

The application takes a few minutes to remove the sample data from your organization.

## Record types updated with sample data

When sample data is added to your organization, the following record types are updated with sample data:

- Account
- Action Card
- Appointment
- Competitor
- Contact
- Lead
- Opportunity
- Phone Call
- Price List
- Price List Item
- Product
- Sequence
- User

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Configure sales accelerator](enable-configure-sales-accelerator.md)
