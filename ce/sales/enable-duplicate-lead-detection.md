---
title: "Enable duplicate detection of leads"
description: "Enable duplicate detection of leads to help seller identify and address potential duplicate leads and keep the leads database clean."
ms.date: 02/11/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Preview: Enable duplicate lead detection 

Enable duplicate detection of leads to help your sellers identify and address potential duplicate leads.

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## What is duplicate detection?

The duplicate detection capability helps sellers to check for potential duplicate leads in the app. When you enable this capability, the AI model uses the following rules to identify duplicates:
-	Same email address 
-	Same phone number
-	Similar lead name and company name 
-	Similar lead name and the same email domain   

Further, sellers can compare and remove the duplicate leads in the organization. More information: [Manage duplicate leads](manage-duplicate-leads.md).

>[!NOTE]
>- If the Power Platform duplicate detection feature is enabled in your organization, a message is displayed as shown in the following image: 
>:::image type="content" source="media/lead-power-platform-duplicate-detection-enabled-message.png" alt-text="Screenshot showing message when Power Platform duplicate detection feature is enabled." lightbox="media/lead-power-platform-duplicate-detection-enabled-message.png":::
>- To know the difference between the Power Platform and Sales duplicate detection features, see [What is difference between Power Platform duplicate detection and Dynamics 365 Sales duplicate detection of leads?](faqs-sales.md#what-is-the-difference-between-power-platform-duplicate-detection-and-dynamics-365-sales-duplicate-detection-of-leads)
>- For an optimum experience for duplicate detection of leads in Dynamics 365 Sales, disable duplicate detection of leads in Power Platform. More information [Turn duplicate detection rules on or off for the whole organization](/power-platform/admin/turn-duplicate-detection-rules-off-whole-organization)  

## Prerequisites

Before you enable the duplicate detection feature, verify that the Dataverse search is enabled in your organization. The AI model to detect duplicate leads uses the Dataverse search for better results. More information: [Configure Dataverse search for your environment](/power-platform/admin/configure-relevance-search-organization)

## Enable the duplicate detection feature

1.	At the lower-left corner of the Sales Hub app, select the **Change area** Icon > **App Settings**.
2.	On the site map, select **Data improvement** > **Duplicate detection (preview)**.

    >[!div class="mx-imgBorder"]
    >![Duplicate detection enablement page](media/lead-enable-duplicate-detection-page.png "Duplicate detection enablement page")    

3.	Turn on the **Enable rules** toggle to enable the feature.

    >[!div class="mx-imgBorder"]
    >![The duplicate detection feature is enabled](media/lead-duplicate-detection-feature-enabled.png "The duplicate detection feature is enabled")    


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Manage duplicate leads](manage-duplicate-leads.md)
