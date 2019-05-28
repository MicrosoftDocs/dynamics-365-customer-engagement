---
title: "Set up social listening (Dynamics 365 for Marketing) | Microsoft Docs "
description: "How to integrate with Microsoft Social Engagement to enable social listening in Dynamics 365 for Marketing"
keywords: 
ms.date: 10/16/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: f424d10e-3e6e-43a1-86e2-8639c40d2013
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Set up social listening and add it to any record

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Social listening in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] enables you to embed charts, information, and analytics from  [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-long.md)] into any type of [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] record to see how people on social media are reacting to your campaigns, events, brands, and more.

![Social listening in Dynamics 365 for Marketing](media/social-listening-panel.png "Social listening in Dynamics 365 for Marketing")

To use this feature, your organization must purchase the [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-long.md)] product (also available separately) and integrate it with your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance. For a detailed introduction to [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-short.md)], see [Connect with customers. Empower your organization. Create real results.](../social-engagement/overview.md).

## Add social listening to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

To add social listening to your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] app, your system administrator or system customizer must do the following:

1. Purchase a license for [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-long.md)] and add it to your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] users don't require a [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-short.md)] license to view and select social listening displays in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], but you'll need at least one licensed [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-short.md)] user to configure the system and set up relevant search terms in [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-short.md)]. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Manage licenses for Social Engagement](../social-engagement/manage-licenses.md)
1. Add your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] domain to the list of allowed domains in [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-long.md)]. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Connect Social Engagement to other domains](../social-engagement/connect-other-domains.md)
1. Connect your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance to [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-short.md)] to enable the integration. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Integrate Social Engagement with Dynamics 365](../social-engagement/integrate-social-engagement-dynamics-365.md)
1. Customize each dashboard or entity in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] where you want to show social listening features by adding the social insights control to an appropriate section or tab. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Integrate Social Engagement with Dynamics 365](../social-engagement/integrate-social-engagement-dynamics-365.md)

When these steps are complete, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] users will be able to choose which search terms and widgets from [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-short.md)] they would like to see for any type of record where the system admin or customizer has made social listening available.

## Choose widgets and search terms for a record

Any time you create or edit a type of record that includes social listening, you can choose which search terms and widgets you think are most relevant for that record. For example, if you are working with an event, then you might choose terms that match the name of the event. If you are working with a customer journey, then you might choose terms that match the name of the campaign, brand, and/or product being promoted by that journey. You could even set up social listening on an important account to see how they are being perceived on social media.

To set up social listening for a record:

1. Make sure that the search terms, visualizations, and other resources that you need are set up in [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-short.md)]. If you have a [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-short.md)] user license, then you can set these up yourself as described in [Set up searches to listen to social media conversations](../social-engagement/set-up-searches.md) and [Analyze social data using widgets](../social-engagement/analyze-social-data-using-widgets.md).

1. Open [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], go to the record where you want to set up social listening displays, and go to the tab where your admin or customizer added the social listening control.

1. Select the **Configure Social Engagement** button ![The Configure Social Engagement button](media/social-listening-setup-button.png "The Configure Social Engagement button") in the upper corner of the **Social Insights** area.

    ![Location of the Configure Social Engagement button](media/social-listening-empty.png "Location of the Configure Social Engagement button")

1. The **Configure Social Insights** dialog box opens.

    ![Configure social insights](media/social-listening-configure.png "Configure social insights")

    Make the following settings:

    - Under **Choose topic or category**, select an existing [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-short.md)] topic or category that you want to show. Choose the topic or category that best matches the record you are working with in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. If an appropriate topic or category isn't yet available, then select the **Create new …** link to go to [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-short.md)] and set up a new one (a [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-short.md)] user license is required). [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up searches to listen to social media conversations](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/social-engagement/set-up-searches)
    - Under **Visualization**, make a selection from the **Choose visual** drop-down list and then select **Add** to add that visual to the page. Your selected visual is added to the list at the bottom of the dialog.
    - Continue to add each visualization that you want to include. You can rearrange them by selecting an existing visualization in the list and then using the up, down, or delete buttons at the top of the list.

1. Select **Apply**.
