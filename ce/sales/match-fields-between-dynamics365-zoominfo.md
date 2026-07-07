---
title: Match Dynamics 365 fields with ZoomInfo fields
description: Learn how to map the fields between Dynamics 365 and ZoomInfo to avoid mismatches when exporting data from the app to your organization.
ms.date: 07/07/2026
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
---

# Match fields between Dynamics 365 and ZoomInfo 

When you export data from the ZoomInfo app to your Dynamics 365 Sales organization, certain corresponding fields might not match. You might not see updated values for these fields. To avoid these mismatches, map the corresponding fields between Dynamics 365 and ZoomInfo for accounts, contacts, and leads.

## Prerequisites

Before you start, make sure you meet the following prerequisites:

- You install the ZoomInfo app on your Dynamics 365 Sales organization. For more information, see [Install ZoomInfo app](install-zoominfo-app.md).   
-	You have a license to use the ZoomInfo app.

## Map the fields     

1. Open your Dynamics 365 Apps page and then open the ZoomInfo app.    
1. On the left navigation pane, select **ZoomInfo** > **ZoomInfo**.   
    >[!NOTE]
    >The app might prompt you to enter credentials. Select either Google, Office, or enter your ZoomInfo credentials if you have an account with ZoomInfo.  

    :::image type="content" source="media/zoominfo-login-page.png" alt-text="Screenshot of the ZoomInfo sign-in page.":::

1. On the top-right corner of the page, select **More** > **Admin Portal**.
1. On the **Admin Portal** page, select **Dynamics Settings**.

    :::image type="content" source="media/zoominfo-select-dynamics-settings.png" alt-text="Screenshot of selecting Dynamics Settings from the Admin Portal in ZoomInfo.":::

1. Select the **Mapping** tab and then choose the **Accounts**, **Contacts**, or **Leads** tab to map the fields.   

    >[!NOTE]
    >In this example, use **Accounts**.  

    You can view the default or configured corresponding field between the ZoomInfo app and Dynamics 365.

    :::image type="content" source="media/zoominfo-select-mapping-tab-account.png" alt-text="Screenshot of selecting the Mapping tab to choose fields for Accounts.":::
    
1. Map the fields as required. Each column is described with its functionality in the following table:   

    | Column name | Description |
    |-------------|-------------|
    | ZoomInfo Field | Displays a list of ZoomInfo fields that you can map with Dynamics 365 fields. |
    | Dynamics Field | Displays a list of Dynamics 365 fields that you can map. The list also includes your custom fields. |
    | Example | Displays an example of value for the selected ZoomInfo field. |
    | Update Option | Select one of the following options for the field:<ul><li>**Complete if missing**: Choose this option to only complete with ZoomInfo data if nothing exists in Dynamics 365. By default, this option is selected.</li><li>**Overwrite field**: Choose this option to overwrite existing data in Dynamics 365 with ZoomInfo data.</li></ul> |
    
    >[!NOTE]
    >-	Select **Add Rows** to add more fields to the mapping table.
    >-	To set the mapped values to default, select **Back to default preferences**.  

1. Select **Verify and Save**.    

    The ZoomInfo app validates the corresponding mapped values and saves the mappings. If there are any mismatches in the mapping, an error is displayed to resolve the issue.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

## Related information

[Install ZoomInfo app](install-zoominfo-app.md)   

