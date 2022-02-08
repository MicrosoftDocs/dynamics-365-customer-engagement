---
title: "Enable duplicate detection of leads"
description: "Enable duplicate detection of leads to help your sales team to maintain great relationships with customers and keep your leads clutter free."
ms.date: 02/11/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Preview: Enable duplicate lead detection 

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

Enable duplicate detection of leads to help your sales team to maintain great relationships with customers and keep your leads clutter free.

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## What is duplicate detection?

The duplicate detection feature in Dynamics 365 Sales helps your sales team to maintain great relationships with customers and keep your leads clutter free. By enabling the feature, you give control to the sellers to identify when a duplicate lead is created based on the following rules: 
-	Same email address 
-	Same phone number
-	Similar name and company name 
-	Similar name and the same email domain   

Further, sellers can compare and remove the duplicate leads from your organization. More information: [Manage duplicate leads](manage-duplicate-leads.md).

## Prerequisites

Before you enable the duplicate detection feature, verify that the Dataverse search is enabled in your organization. The defined AI model to detect the duplicate leads uses the Dataverse search for better results. More information: [Configure Dataverse search for your environment](/power-platform/admin/configure-relevance-search-organization)

## Enable the duplicate detection feature

1.	At the bottom of the site map, select **Change area** Icon > **App Settings**.
2.	On the site map, select **Data improvement** > **Duplicate detection (preview)**.

    >[!div class="mx-imgBorder"]
    >![Duplicate detection enablement page](media/lead-enable-duplicate-detection-page.png "Duplicate detection enablement page")    

3.	Turn on the **Enable rules** toggle to enable the feature.

    >[!div class="mx-imgBorder"]
    >![The duplicate detection feature is enabled](media/lead-duplicate-detection-feature-enabled.png "The duplicate detection feature is enabled")    

The duplicate detection feature is enabled in your organization and allows sellers to identify duplicate leads.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Manage duplicate leads](manage-duplicate-leads.md)
