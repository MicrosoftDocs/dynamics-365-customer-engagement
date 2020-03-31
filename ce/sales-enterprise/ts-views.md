---
title: "Troubleshooting views (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with entity views in Dynamics 365 Sales."
ms.date: 03/24/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Troubleshooting entity views 

This article helps you troubleshoot and resolve issues related to entity views.

<a name="no_data_in_views"> </a>
## Issue: I can't see data in certain columns in entity views

**Reason:**
This error is occurring due to mismatch of column names between the `layoutxml` and `fetchxml` in the view ODATA file (*OrgUrl*/api/data/*Dynamics 365 version*/savedqueries(*ViewId*)). 

**Resolution:**
To resolve this issue, you must remove and add back the column that is causing this error. This will ensure that the column names in `layoutxml` and `fetchxml` are matched.

> [!NOTE]
> Before you start resolving the issue, take note of the view for which this error is occurring.

1. Go to **Settings** > **Customizations** > **Customize the System**.
2. Select the entity > **Views** and select the view that has this error. In this example, we are selecting the entity **Account** and view as **Accounts Being Followed**.

    > [!div class="mx-imgBorder"]
    > ![Choose a view from the entity](media/troubleshooting-column-entity-view-selection.png "Choose a view from the entity")

3. Select **More Actions** > **Edit**. 

    The view edit page opens.

    > [!div class="mx-imgBorder"]
    > ![Edit a view](media/troubleshooting-column-edit-view.png "Edit a view")

4. Select the column that is causing the issue and select **Remove**. In this example, we select the column **Email (Primary Contact)** to remove.

    > [!div class="mx-imgBorder"]
    > ![Remove column from view](media/troubleshooting-column-remove-column-view.png "Remove column from view")

    The column is removed from the view.

5. Add back the column that you have deleted. Select **Add Columns** and re-add the column that you removed. In this example, we are adding  the column **Email (Primary Contact)** that was removed.

    > [!div class="mx-imgBorder"]
    > ![Adding back the removed column](media/troubleshooting-column-add-back-column-view.png "Adding back the removed column")
   
    The data in the columns is displayed properly.

<a name="records_missing_in_views"> </a>
## Issue: I can't see some records in the entity views

**Reason:**
This error is occurring due to the filtering of data on a view. 

**Resolution:**
To resolve this issue, you must edit or remove filters for the view. This will ensure that filters are applied properly for the view.

> [!NOTE]
> Before you start resolving the issue, take note of the view for which this error is occurring.

1. Go to **Settings** > **Customizations** > **Customize the System**.
2. Select the entity > **Views** and select the view that has this error. In this example, we are selecting the entity **Account** and view as **Accounts I Follow**.

    > [!div class="mx-imgBorder"]
    > ![Choose a view from the entity](media/troubleshooting-record-entity-view-selection.png "Choose a view from the entity")

3. Select **More Actions** > **Edit**. 

    The view edit page opens.

    > [!div class="mx-imgBorder"]
    > ![Edit a view](media/troubleshooting-record-edit-view.png "Edit a view")

4. Select **Edit Filter Criteria** and recheck the filter condition either by updating or deleting.

    > [!div class="mx-imgBorder"]
    > ![Update or clear the filter criteria](media/troubleshooting-record-update-filter.png "Update or clear the filter criteria")
   
    The records in the views are displayed properly.


### See also

[Frequently asked questions](faqs-sales.md) </br>
[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  
