---
title: "Enable the new experience for contacts, opportunities, leads, and accounts - Sales Enterprise | MicrosoftDocs"
description: "The new experience includes an editable grid and a side panel that can be customized to your needs. Filter, search, group fields to narrow down records."
ms.date: 08/12/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
## Preview: Enable the new experience for contacts, opportunities, leads, and accounts

The new experience includes an editable grid and a side panel that can be customized to your needs. It also provides the ability to apply advanced filters, search within the grid, and group fields to narrow down records. The new experience is similar to the deal manager workspace. 

**To enable the new experience**:

1.  Select the app name (**Sales Hub** or **Sales Trial**) at the upper-left corner of your app.  

2.  In the **Apps** page, go to your specific app, select the **More options (…)** icon and select **OPEN IN APP DESIGNER**

3.  In the App Designer, edit the **Site Map** object.

4.  Go to **Sales** > **Sales records** and select the page for which you want to enable the new experience. For example, to enable it for contacts, select **Contacts**.

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

7.  Access the app and go to the corresponding page.

    The page should display the new interface as shown in the following screenshot:
    :::image type="content" source="media/new-view-in-cola.png" alt-text="Screenshot of the new experience":::

# Switch to classic view for contacts, opportunities, leads, and accounts

If you want to switch to the classic list view, follow these steps:

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

