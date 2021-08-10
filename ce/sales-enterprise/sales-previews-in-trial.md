---
title: "Preview features in trial - Sales Enterprise | MicrosoftDocs"
description: "Learn about the preview features in your Sales trial app and how to disable them if needed."
ms.date: 07/15/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
# Preview features in trial 

This page lists the upcoming preview features that will be enabled by default in your trial app. Review the information in this page to understand what's coming up.

> [!IMPORTANT]
> A preview is a feature that is not complete, but is made available to you before general availability so you can evaluate the preview and provide feedback to Microsoft. Previews may have restricted functionality and may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, previews are not intended for production use, which means they are not meant for "live" Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Use of such data is at your sole risk and it's your sole responsibility to notify your end users about not including personal or sensitive information with their use of previews, as appropriate. We don't provide support for previews and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions. This preview, and any one-off support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty.  

The following preview features will be automatically enabled in your trial app when they become available:  

- A new view for contacts, opportunities, leads, and accounts with editable and customizable grid and side panel, along with the filter, sort, and group by options. The opportunities view, also known as the deal manager workspace, includes customizable charts and metrics. For more information, see [Using the deal manager workspace (preview)](deal-manager-seller-overview.md). 

- An enhanced experience for adding products to opportunities, quotes, orders, and invoices. The enhanced experience lets sellers select multiple products, filter by product families, compare products, and so on. For more information, see [Preview: Add products to an opportunity by using the enhanced experience](add-products-enhanced-experience.md). 

## Switch to classic view for contacts, opportunities, leads, and accounts

As your trial app is enabled for preview features, you will see the new interface for contacts, opportunities, leads, and accounts by default. 

If, for some reason, you want to switch to the classic list view, follow these steps:

1.  Select **Sales Trial** at the top-left corner of the Sales trial app.

1.  In the **Apps** page, go to the Sales Trial app, select the **More options (…)** icon and select **OPEN IN APP DESIGNER**:

    :::image type="content" source="media/open-in-app-designer.png" alt-text="Screenshot highlighting the Open in App Designer option":::

3.  In the App Designer, edit the **Site Map** object.

4.  Go to **Sales** > **Sales records** and select the page for which you want to switch the view. For example, to switch over accounts to classic view, select **Accounts**.

    > [!TIP]
    > Alternatively, you can create a new group and area for the classic view and leave the new interface as-is.

5.  Modify the following fields in the side panel:

    **Type**: Select **Entity**.

    **Entity**: Select the entity name that you want to associate such as Contact, Opportunity, Lead, or Account.

    :::image type="content" source="media/sitemap-designer.png" alt-text="Screenshot of the sitemap designer page":::

6.  Save and publish the changes.

7.  Access the Sales Trial app and go to the corresponding page.
    The page should display the list as shown in the following screenshot:
    
    :::image type="content" source="media/listview.png" alt-text="Screenshot of the classic list view":::

## Switch to the new view for contacts, opportunities, leads, and accounts

If you've switched over to the classic view and now want to revert to the new interface, follow these steps:

1.  Select **Sales Trial** at the top-left corner of the Sales trial app.

2.  In the **Apps** page, go to the Sales Trial app, select the **More options (…)** icon and select **OPEN IN APP DESIGNER**

3.  In the App Designer, edit the **Site Map** object.

4.  Go to **Sales** > **Sales records** and select the page for which you want to switch the view. For example, to switch over Contacts to the new view, select **Contacts**.

5.  Modify the following fields in the side panel:

    **Type**: Select **URL**.

    **URL**: Specify one of the following URLs depending on the page:

    | **Page**    | **URL**                                                                 |
    |-------------|-------------------------------------------------------------------------|
    | Opportunity | /main.aspx?pagetype=control&controlName=MscrmSales.WorkspaceOpportunity |
    | Contacts    | /main.aspx?pagetype=control&controlName=MscrmSales.WorkspaceContact     |
    | Leads       | /main.aspx?pagetype=control&controlName=MscrmSales.WorkspaceLead        |
    | Accounts    | /main.aspx?pagetype=control&controlName=MscrmSales.WorkspaceAccount     |

6.  Save and publish the changes.

7.  Access the Sales Trial app and go to the corresponding page.

    The page should display the new interface as shown in the following screenshot:
    :::image type="content" source="media/new-view-in-cola.png" alt-text="Screenshot of the new view":::
  
### See also

- [Preview: Enable or disable the enhanced experience for adding products](enable-enhanced-add-product-experience.md) 
