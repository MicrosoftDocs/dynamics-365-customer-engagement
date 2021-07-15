---
title: "Using deal manager - Sales Enterprise | MicrosoftDocs"
description: "Deal manager is a dedicated workspace for sellers to efficiently manage their sales pipeline. Sellers can personalize the workspace for their needs."
ms.date: 07/15/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Using the deal manager workspace (Preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> A preview is a feature that is not complete, but is made available to you before general availability so you can evaluate the preview and provide feedback to Microsoft. Previews may have restricted functionality and may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, previews are not intended for production use, which means they are not meant for "live" Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Use of such data is at your sole risk and it's your sole responsibility to notify your end users about not including personal or sensitive information with their use of previews, as appropriate. We don't provide support for previews and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions. This preview, and any one-off support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty.

Deal manager is a dedicated workspace for sellers. As a seller, you can personalize the workspace depending on what you want to see in your workspace. You can organize opportunities in a way that makes sense to you, personalize your view, update information on the fly, add notes and tasks, and much more. You can also request your administrator to customize the experience further to improve your productivity.  

:::image type="content" source="media/deal-manager-overview-v1-small.png" alt-text="Screenshot showing the four main areas of the deal manager workspace as described in the following table." lightbox="media/deal-manager-overview-v1.png":::

|Number  |Feature  |Description  |
|---------|---------|---------|
|1     |  Metrics       |Lets you view key metrics or KPIs that you want to track. You can modify the metrics in this section to meet your needs. More information: [Personalize the deal manager workspace (Preview)](personalize-deal-manager.md#personalize-the-metrics)         |
|2     |Charts         |Charts give you a visual representation of the pipeline. <br><br>**Bubble chart** <br> The default bubble chart displays the following values:<ul><li>**x-axis:** Displays the opportunity score if you have Sales Insights; otherwise, it displays the deal probability.</li><li>**y-axis:** Displays the close date. A smart column that displays the actual close date or estimated close date, depending on whether the opportunity is closed.</li><li>**Size of the bubble:** Displays revenue. A smart column that displays the actual revenue or estimated revenue, depending on whether the opportunity is closed. More information: [What are smart columns?](personalize-deal-manager.md#what-are-smart-columns).</li><li> **Color of the bubble:** Indicates opportunity grade if you have Sales Insights; otherwise, it displays the pipeline phase.</li></ul> You can ask your administrator to customize the chart if you want to see different fields. More information: [Customize deal manager (Preview)](customize-deal-manager.md) <br><br> **Sales funnel chart** <br> The Sales funnel chart displays the following values. <ul><li>**x-axis:** Displays the pipeline phases.</li><li>**y-axis**: Displays the estimated revenue. Customization of the Sales funnel isn't supported in this release.</li></ul> When you filter the records, the chart is automatically updated.|
|3     |Editable grid         |Lets you view a list of opportunities and edit records inline. Select any linked column&mdash;such as **Name**, **Potential Customer**, or **Contact**&mdash;to view and quickly edit details in the side panel.<br><br>You can personalize the grid: add, remove, resize, hide, rearrange, sort, and group columns on the fly. More information: [Personalize deal manager (Preview)](personalize-deal-manager.md#personalize-the-grid)<br><br>You can also save the personalization in a view so that you can switch to it at anytime. More information: [Create a view](personalize-deal-manager.md#create-a-view) |
|4     |Side panel         |Lets you view and quickly edit details for the linked values such as **Opportunity Name**, **Potential Customer**, or **Contact**. You can also navigate from one object to another in the side panel. For example, while you're looking at the opportunity, you can select a contact to view their details, quickly make updates, and then return to the opportunity. You can ask your administrator to customize the side panel if you want to be able to view or update other fields in the panel. |

### See also

[Access the deal manager workspace (Preview)](access-deal-manager.md)  
[Personalize the deal manager workspace (Preview)](personalize-deal-manager.md)  
[Customize the deal manager workspace (Preview)](customize-deal-manager.md)
