---
title: "Known issues in real-time marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about known issues in real-time marketing and how to work around them."
ms.date: 08/02/2021
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

As we continue to work on the real-time marketing features and refine the experience, we've become aware of some outstanding issues for you to bear in mind. These issues are summarized in the table below.

## Analytics

- In the aggregate cross-journey analytics dashboard, an extra step is needed to load the Power BI report in the Android and iPad native apps. To load the report, go to **Analytics**, then select a row, select the **Show as from** sub menu, then select **CC_Analytics_ReportingControl**.
- Data retention is 3 months for added details of operational data (such as contacts impacted by delivery and interaction issues), and 12 months for all other metrics (including operational and aggregate analytics).
- Some strings in the Power BI aggregate analytics dashboard are not localized.

## Channel optimization

- The AI model cannot currently consider availability and consent. If a customer blocks a specific channel (for example, a text message) or has not provided consent to be reached through a specific channel, the AI model will not have access to this information and may send them down the blocked path.

## Consent

- Only one email address can be checked for consent for contacts.
- Only one physical address field is available for commercial emails.

## Dynamics 365 Customer Insights

-	Data from Customer Insights environments that use the Azure Data Lake Gen v2 storage is not accessible in real-time marketing. To use Customer Insights data in real-time marketing, you must create a new environment using a copy of the existing environment, then use the Customer Insights storage option and enable data sharing with the Dataverse org on which Dynamics 365 Marketing is installed.
-	Segments and profiles in Customer Insights are not evaluated in real time. Segments and profiles can be set to refresh on a schedule defined by the Customer Insights admin. When a customer journey uses profiles from Customer Insights, the earliest you can engage with a new customer is when their profile is created on the next scheduled refresh. Similarly, when you use segments from Customer Insights, new customers will only enter the journey on the next scheduled refresh.
-	Once you start using Customer Insights data in customer journeys, you cannot remove the profile attributes being used from the data unification process (Map-Match-Merge). Doing so might break customer journeys and personalization tokens that reference those attributes.

## Email editor

- The real-time marketing email editor *does not* contain the following capabilities from the outbound marketing email editor: video, custom code, content blocks, QR codes, Teams check-in links, marketing page links, or the Send now function.
- Emails created in outbound marketing need to be recreated in the real-time marketing email designer to be used in real-time marketing.

## Event triggers

- You cannot instrument C# apps in real-time marketing. If you choose to use an alternate language like Python, you will have to manage an infra to run Python.

## Journey and orchestration

- Segment-based journeys will only work with segments that are less than 100,000 members. If you try to use a segment with more than 100,000 members, only the first 100,000 will enter the journey.
- The journey goal only counts unique profiles. Unique profiles are the number of unduplicated (counted only once) people that enter the journey. This means that in cases where the journey is a repeating journey, the total inflow will not match the number of unique profiles with which the goal attainment is calculated.
- The journey goal met in analytics currently counts the number of unique profiles that met the goal divided by the total inflow. This will be fixed soon to count unique profiles that met the goal divided by total unique profiles.
- After a real-time marketing journey is migrated, restored, or copied, its state is changed from **Live** to **Stopped**. To restart a migrated, restored, or copied journey, you need to first duplicate the journey, and then execute it.

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
