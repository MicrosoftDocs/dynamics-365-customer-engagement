---
title: "Create a LinkedIn Matched Audience based on a Dynamics 365 segment (Dynamics 365 for Marketing) | Microsoft Docs "
description: "How to use an existing Dynamics 365 segment to find matching LinkedIn users and create a LinkedIn Matched Audience"
keywords: "LinkedIn; Lead Gen Forms; lead; connector"
ms.date: 03/27/2018
ms.service: 
  - "dynamics-365-marketing"
ms.custom: 
  - "dyn365-marketing"
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 5737a6c8-24dc-4925-bf97-2c915f3041da
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer: renwe
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Market to [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] segments on [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] with [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Matched Audiences

[LinkedIn Matched Audiences](https://www.linkedin.com/help/lms/answer/86492/linkedin-matched-audiences-overview?lang=en) is a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] feature that lets you match a collection of contacts stored on an external system, like [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)], to an audience of [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] members with matching email addresses. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] comes ready to take advantage of this capability, so you can leverage your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] static segments to create a matching audiences of [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] members. Then, when you run a campaign on [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)], you can target the same segments that you set up in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] and also turn any leads generated on [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] into [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] leads through the [LinkedIn Lead Gen Forms integration](linkedin-lead-gen-integration.md) feature also offered by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

> [!IMPORTANT]
> To create a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Matched Audience, you must obtain an account from [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] and arrange with [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] to enable marketing activities using that account. Additional charges apply if you decide to use a Matched Audience to target an ad campaign or other sponsored content on [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)], as established in the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] terms of use. 

> [!IMPORTANT]
> [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] encrypts each email address using a one-way hash before sending it to Linked[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)]. [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] will be able to match these addresses to existing [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] members but cannot decode the email addresses themselves. This important technique helps protect the privacy of your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] contacts.

> [!IMPORTANT]
> [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] members can use their [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] settings to opt-out of having their data shared with external apps. [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] members that have enabled this opt-out option won't be matched to incoming [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] audiences and therefore won't be included in your [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Matched Audiences even if they would otherwise match your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] segment.

To create a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Matched Audience from a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] segment, the segment must meet the following requirements:

- The segment must be static (not dynamic).
- The segment must be live.
- [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] requires that Matched Audiences contain at least 300 contacts, so if fewer than 300 matches are found to your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] segment, the matched audience won't be usable on [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)].
- For best results we recommend segments of 10,000 contacts or more, but 300 matching contacts is the absolute minimum.

To create a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Matched Audience from a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] segment:

1. [Open your segment](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/segmentation-lists-subscriptions) in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)].

1. Open the **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Matched Audiences** tab.  
    ![The LinkedIn Matched Audiences tab in Dynamics 365](media/linkedin-segment.png "The LinkedIn Matched Audiences tab in Dynamics 365")

1. Select **Next** to initiate the matched-audience wizard, which will walk you through all the steps needed to sign into your [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] account and authorize the integration.

1. Follow the instructions on your screen to complete the integration. When you're done, you'll be in the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] campaign manager, where you can see your new audience and all the other audiences  you have uploaded so far.  
    ![Matched Audiences on LinkedIn](media/linkedin-matched-audiences.png "Matched Audiences on LinkedIn")

1. You can now use your new audience to target a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] campaign. Please see the [LinkedIn documentation](https://www.linkedin.com/help/lms) for details.

> [!NOTE]
> If your segment changes in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)], those changes won't be reflected in its [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Matched Audience. If you want to use an updated [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] segment on [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)], you must create a new Matched Audience using the previous procedure.

### See also
[LinkedIn Lead Gen Forms integration](linkedin-lead-gen-integration.md)  
[Configure LinkedIn Lead Gen](linkedin-configuration.md)  