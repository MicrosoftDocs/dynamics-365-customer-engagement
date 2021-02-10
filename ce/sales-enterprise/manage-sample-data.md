---
title: "Use sample data to explore the sales accelerator | MicrosoftDocs"
description: "Learn how to explore the sales accelerator with sample data."
ms.date: 01/11/2021
ms.service: crm-online
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Explore the sales accelerator with sample data

Sample data helps you visualize a product and its features, by enabling you to understand end-to-end business scenarios and get started with the sales insights for Dynamics 365 Sales. You can add the sample data during or after the configuration of the sales accelerator. Also, you can remove the sample data from your organization when you don't need it. 

>[!NOTE]
>To prevent unwanted results, sample data is available only for non-production environments. 

## Add sample data

You can add sample data any time you need, during or after the configuration of the sales accelerator.    
>[!NOTE]
>- The sample data adds basic Dynamics 365 Sales and Sales Premium record types. More information: [Reference](#reference)     
>- You must have a Sales Insights, Sales Premium, production, or trial license to use the sample data.

1. Sign in to your sales app.   
2. Go to **Change area** in the lower-left corner of the page, and select **Sales Insight settings**.    
3. Under **Sales accelerator**, select **Setup**.    
4. Select **Get started**.    
5. In the **Explore with sample data?** dialog box, select **Add sample data**.    
    > [!div class="mx-imgBorder"]
    > ![Select Add sample data](media/sample-data-popup.png "Select Add sample data")   
    It might take a few minutes to add the sample data to your organization.   
    > [!div class="mx-imgBorder"]
    > ![Progress of sample data installation](media/sample-data-installation-progress.png "Progress of sample data installation")     
6. After the sample data is added to your organization, you can start using it to play around with the sales accelerator and other Sales Premium features.   
    > [!div class="mx-imgBorder"]
    > ![Confirmation message that sample data has been added](media/sample-data-confirmation-message.png "Confirmation message that sample data has been added")     
    You can also add sample data after you've configured the sales accelerator. Select **Add sample data**.     
    > [!div class="mx-imgBorder"]
    > ![Add sample data later](media/sample-data-add-later.png "Add sample data later")    

After the sample data is added to your organization, a confirmation message is displayed with the date and time it was added.    

> [!div class="mx-imgBorder"]
> ![Confirmation message of sample data added later](media/sample-data-add-later-confirmation-message.png "Confirmation message of sample data added later")    

## Sample data availability

By default, sample data is available for the administrator who adds it. The administrator can assign the records that are associated with sample data for other users to explore.

## Distinguish between sample and actual data

After you add sample data, you can distinguish between the sample and your organization's actual data: sample data is always followed by **(sample)**. For example, sample contacts are added as **Michelle Harris (sample)** and **Alex Baker (sample)**.

## Remove sample data

As an administrator, you can remove sample data that your organization no longer needs.

>[!NOTE]
>You can always add the sample data again, whenever you need it.

**To remove sample data**

1. Sign in to your sales app.   
2. Go to **Change area** in the lower-left corner of the page, and select **Sales Insight settings**.    
3. Under **Sales accelerator**, select **Setup**.    
4.	On the setup page, select **Remove sample data**.    
    > [!div class="mx-imgBorder"]
    > ![Remove sample data](media/sample-data-remove.png "Remove sample data")       
5.	In the **Remove sample data?** confirmation message, select **Remove sample data**.   
    > [!div class="mx-imgBorder"]
    > ![Confirmation message to remove sample data](media/sample-data-remove-confirmation-message.png "Confirmation message to remove sample data")     

The application takes a few seconds to remove the sample data from your organization.

## Reference

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

### See also

[Configure sales accelerator](enable-configure-sales-accelerator.md)
