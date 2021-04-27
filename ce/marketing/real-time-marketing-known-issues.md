---
title: "Known issues in real-time marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about known issues in real-time marketing and how to work around them."
ms.date: 04/27/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Known issues in real-time marketing

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

As we continue to work on the real-time marketing preview and refine the experience, we've become aware of some outstanding issues for you to bear in mind. These issues are summarized in the table below.

## Analytics

- In the aggregate cross-journey analytics dashboard, an extra step is needed to load the Power BI report in the Android and iPad native apps. To load the report, go to **Analytics**, then select a row, select the **Show as from** sub menu, then select **CC_Analytics_ReportingControl**.
- Data retention is 3 months for operational analytics and 12 months for the aggregate cross-journey analytics dashboard.
- In some cases of error, funnel numbers are adjusted for sanitization (for example, the delivered shouldn't exceed sent).

## Channel optimization

- The AI model cannot consider availability and consent at the time of public preview. If a customer blocks a specific channel (for example, a text message) or has not provided consent to be reached through a specific channel, the AI model will not have access to this information and may send them down the blocked path.

## Consent

- Only one email address can be checked for consent for contacts.
- Only one physical address field is available for commercial emails.

## Dynamics 365 Customer Insights

- Before installing Dynamics 365 Marketing in the Dataverse environment, you need to enable data sharing with Dataverse in the Customer Insights environment you intend to use with Marketing. To enable data sharing, refer to step 6 in the [Edit an existing environment CI documentation](/customer-insights/audience-insights/manage-environments#edit-an-existing-environment). Optionally, you can also create a new CI environment using a copy of your existing environment and enable data sharing in the former. If you have already installed Dynamics 365 Marketing before doing this step, rerun the Dynamics 365 Marketing provisioning after you have enabled data sharing.
- Existing CI customers will need to set up a new CI environment using **Copy config**.
- You cannot instrument C# apps in real-time marketing. If you choose to use an alternate language like Python, you will have to manage an infra to run Python.
- Customer Insights cannot create profiles with BigInt type and may silently fail to create particular profiles that have values out of the normal int range. Out of the box, Contact and Lead entities have two such fields that should be removed from final customer profile objects.

## Email editor

- The real-time marketing email editor *does not* contain the following capabilities from the outbound marketing email editor: video, custom code, content blocks, QR codes, Teams check-in links, marketing page links, or the Send now function.
- Emails created in outbound marketing need to be recreated in the real-time marketing email designer to be used in real-time marketing.

## Journey & orchestration

- Segment-based journeys will only work with segments that are less than 100,000 members. If you try to use a segment with more than 100,000 members, only the first 100,000 will enter the journey.

## Natural language

-	Natural language for journey conditions is not compatible with events or behavioral attributes.
    - "Customers that opened an email" is not a phrase we currently support.
-	The entity type of the journey will follow the entity type the journey is bound to.
    - If the journey is contact-bound, the natural language will also require the term "contact."
    - If the journey is customer profile-bound, the natural language will also require the term "customer."

## SMS

- Currently limited to one phone number.
- Only United States numbers are issued (even when using the app in the United Kingdom).
- Dynamics 365 Customer Voice survey links are not supported in SMS messages.