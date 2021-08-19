---
title: "Using deal manager - Sales Enterprise | MicrosoftDocs"
description: "Deal manager is a dedicated workspace for sellers to efficiently manage their sales pipeline. Sellers can personalize the workspace for their needs."
ms.date: 07/15/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Preview: Using the deal manager workspace

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

> [!NOTE]
> This feature is being rolled out in a phased manner across different regions. To verify the feature availability in your region, see the **Next Refresh Scheduled Date** for version 9.0.21072.10001 in the [Latest version availability](/dynamics365/released-versions/dynamics365sales) section. 

The deal manager workspace offers a new way to manage opportunities in Dynamics 365 Sales. As a seller, you can personalize the workspace depending on what you want to see. You can organize opportunities in a way that makes sense to you, personalize your view, update information on the fly, add notes and tasks, and much more. You can also ask your administrator to customize the experience further to improve your productivity. 

> [!NOTE]
> A similar experience is also available for contacts, opportunities, leads, and accounts - an editable grid that you can personalize and a side panel that you can customize. For information on switching to the new experience, see [Switch to the new view for contacts, opportunities, leads, and accounts](sales-previews-in-trial.md#switch-to-the-new-view-for-contacts-opportunities-leads-and-accounts)

:::image type="content" source="media/deal-manager-overview-v1-small.png" alt-text="Screenshot showing the four main areas of the deal manager workspace as described in the following table." lightbox="media/deal-manager-overview-v1.png":::

|Number  |Feature  |Description  |
|---------|---------|---------|
|1     |  Metrics       |View key metrics or KPIs that you want to track. You can modify the metrics in this section to meet your needs. More information: [Personalize the deal manager workspace](personalize-deal-manager.md#personalize-the-metrics)         |
|2     |Charts         |Get a visual representation of the pipeline. <br><br>**Bubble chart** <br> The default bubble chart displays the following values:<ul><li>**x-axis:** Displays the opportunity score if you have Sales Insights; otherwise, it displays the deal probability.</li><li>**y-axis:** Displays the close date. A smart column that displays the actual close date or estimated close date, depending on whether the opportunity is closed.</li><li>**Size of the bubble:** Displays revenue. A smart column that displays the actual revenue or estimated revenue, depending on whether the opportunity is closed. More information: [What are smart columns?](personalize-deal-manager.md#what-are-smart-columns).</li><li> **Color of the bubble:** Indicates opportunity grade if you have Sales Insights; otherwise, it displays the pipeline phase.</li></ul> You can ask your administrator to customize the chart if you want to see different fields. More information: [Customize the deal manager workspace](customize-deal-manager.md) <br><br> **Sales funnel chart** <br> The Sales funnel chart displays the following values. <ul><li>**x-axis:** Displays the pipeline phases.</li><li>**y-axis**: Displays the estimated revenue. Customization of the Sales funnel isn't supported in this release.</li></ul> When you filter the records, the chart is automatically updated.|
|3     |Editable grid         |View a list of opportunities and edit them inline. Select any linked column&mdash;such as **Name**, **Potential Customer**, or **Contact**&mdash;to view and quickly edit details in the side panel.<br><br>You can personalize the grid: add, remove, resize, hide, rearrange, sort, and group columns on the fly. More information: [Personalize the deal manager workspace](personalize-deal-manager.md#personalize-the-grid)<br><br>You can also save the personalization in a view so that you can switch to it at anytime. More information: [Create a view](personalize-deal-manager.md#create-a-view) |
|4     |Side panel         |View and quickly edit details for the linked values such as **Opportunity Name**, **Potential Customer**, or **Contact**. You can also navigate from one object to another in the side panel. For example, while you're looking at the opportunity, you can select a contact to view their details, quickly make updates, and then return to the opportunity. You can ask your administrator to customize the side panel if you want to be able to view or update other fields in the panel. |

### See also

[Access the deal manager workspace](access-deal-manager.md)  
[Personalize the deal manager workspace](personalize-deal-manager.md)  
[Customize the deal manager workspace](customize-deal-manager.md)

