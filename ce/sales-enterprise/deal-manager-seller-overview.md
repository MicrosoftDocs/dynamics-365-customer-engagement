---
title: "Using deal manager workspace - Sales Enterprise | MicrosoftDocs"
description: "Deal manager is a dedicated workspace for sellers to efficiently manage their sales pipeline. Sellers can personalize the workspace for their needs."
ms.date: 07/15/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Using deal manager workspace (Preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> A preview is a feature that is not complete, but is made available to you before general availability so you can evaluate the preview and provide feedback to Microsoft. Previews may have restricted functionality and may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, previews are not intended for production use, which means they are not meant for "live" Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Use of such data is at your sole risk and it's your sole responsibility to notify your end users about not including personal or sensitive information with their use of previews, as appropriate. We don't provide support for previews and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions. This preview, and any one-off support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty.

Deal manager is a dedicated workspace for sellers. As a seller, you can personalize the workspace depending on what you want to see in your workspace. You can organize opportunities in a way that makes sense to you, personalize your view, update information on-the-fly, add notes and tasks, and many more. You can also request your administrator to customize the experience further to improve your productivity.  

:::image type="content" source="media/deal-manager-overview-v1-small.png" alt-text="Screenshot of deal manager workspace in a nutshell" lightbox="media/deal-manager-overview-v1.png":::


|No in the image  |Feature  |Description  |
|---------|---------|---------|
|1     |  Metrics       |Lets you view key metrics or KPIs that you want to track. You can modify the metrics in this section as per your need. See [Personalize deal manager (Preview)](personalize-deal-manager.md#personalize-the-metrics).         |
|2     |Charts         |Gives you a visual representation of the pipeline. <br> **Bubble chart** <br> The default bubble chart displays the following values: <br> **x-axis:** Displays opportunity score if you've Sales insights, else displays the deal probability <br> **y-axis:** Displays close date - A smart column that displays the actual close date or estimated close date depending on whether the opportunity is closed or not.<br> **Size of the bubble:** Displays revenue - A smart column that displays the actual revenue or estimated revenue depending on whether the opportunity is closed or not.  For more information, see [What are Smart columns](personalize-deal-manager.md#what-are-smart-columns). <br> **Color of the bubble:** Indicates opportunity grade if you've Sales Insights, else displays pipeline phase. <br> You can request your administrator to customize the chart if you want to see different fields in the chart. See [Customize deal manager (Preview)](customize-deal-manager.md). <br> **Sales funnel chart** <br> The Sales funnel chart displays the following values. <br> **x-axis:** Displays the Pipeline phases. **y-axis**: Displays the Estimated revenue. Customization of the Sales funnel is not supported in this release. <br> When you filter the records, the chart is automatically updated.|
|3     |Editable grid         |Lets you view a list of opportunities and edit records inline. Select any linked column, such as Name, Potential Customer, or Contact, to view and edit quick details in the side panel. You can personalize the grid; add, remove, resize, hide, rearrange, sort, and group columns on-the-fly. See [Personalize deal manager (Preview)](personalize-deal-manager.md). You can also save the personalization in a view so that you can switch to it at anytime. See [Create a view](personalize-deal-manager.md).  
|4     |Side panel         |Lets you view and edit quick details for the linked values such as Opportunity Name, Potential Customer, or Contact. You can also navigate from one object to another in the side panel. For example, while you're looking at the opportunity, you can click on a contact to view their quick details, make updates, and then return to the opportunity. You can request your administrator to customize the side panel if you want to be able to view or update other fields in the panel.

### See also
- [Access deal manager workspace (Preview)](access-deal-manager.md)
- [Personalize deal manager workspace (Preview)](personalize-deal-manager.md)
- [Customize deal manager workspace (Preview)](customize-deal-manager.md)
