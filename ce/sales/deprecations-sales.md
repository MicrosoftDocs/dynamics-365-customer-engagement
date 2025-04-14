---
title: Removed or deprecated features in Dynamics 365 Sales
description: Visit this page to see the deprecating features in Dynamics 365 Sales.
ms.date: 01/09/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-sales
---
# Removed or deprecated features in Dynamics 365 Sales

The features that have been removed or deprecated in  Dynamics 365 Sales are listed in this article. For more information on other deprecations that impact all the Dynamics 365 customer engagement apps, see [Important changes (deprecations) coming in Power Apps, Power Automate, and customer engagement apps](/power-platform/important-changes-coming).

> [!IMPORTANT]
> "Deprecated" means we intend to remove the feature or capability in a major future release. The feature or capability continues to work and is fully supported until it's officially removed. This deprecation notification might span a few years. After removal, the feature or capability will no longer work. We're notifying you now so that you have sufficient time to plan and update your code before the feature or capability is removed.  

<a name='exchange-integration-for-ra'></a>
## Exchange integration for relationship intelligence

Effective April 2025, the native Exchange integration for relationship intelligence is deprecated. If you want Dynamics 365 Sales to use emails and meetings from Exchange to generate insights, [enable server-side synchronization for Exchange](configure-email.md). Otherwise, insights are generated only using emails and data stored in Dynamics 365.


## Copilot for email in side pane

Effective January 2025 (app/solution version 9.2.24124.0010), composing and sending email using Copilot side pane isn't supported and is being removed in a phased manner. This effects the users who have enabled the email copilot preview. However, you can use the [Copilot email assist](enable-copilot-email-assist.md) feature to compose and [send emails through the rich text editor](/power-apps/maker/model-driven-apps/use-copilot-email-assist).  

## Assistant card templates

Effective August 1, 2024, templates to create new assistant cards won't be available. The existing cards that are created using the templates continue to work as-is. You can continue to use the Microsoft Power Automate flow to create your custom cards. [Learn more](create-insight-cards-flow.md).

<a name='snapshot-deprecation'></a>
## Snapshots in sales forecasting

Effective June 30, 2024, the snapshot capability in sales forecasting is deprecated. Snapshots and related charts such as deal flow, trend chart, and forecast grid history are no longer available. As an alternative, you can use the [Forecast API](developer/reference/custom-actions/msdyn_ForecastApi.md) to set up daily data sync to pull forecast data.

## Set seller availability using Outlook calendar

Effective April 1, 2024, the feature allowing configuration of seller availability through the Outlook calendar in work assignments is deprecated. This deprecation helps enhance the safety and security of your organization's data. Alternatively, you can use the Dynamics 365 CRM calendar to configure the seller availability. [Learn more](wa-manage-seller-availability.md)

## Exchange-based cards are deprecated

Effective October 1, 2023, the following Exchange-based cards are deprecated and no longer available in Dynamics 365 Sales:
 
-	Send Content Request Card
-	Task Due Today Exchange Card
-	Upcoming Meeting Exchange Card 
-	Recent Meeting Exchange Card
-	Lead Detection Card
-	Meeting Today Exchange Card
-	Missed Email Card
-	Issue Detection Card
-	Meeting Request Card 
-	Yes or No Card

You can create your own cards using Power Automate. [Learn more](create-insight-cards-flow.md).

## Rank optimization of insight cards is deprecated

Effective October 1, 2023, the rank optimization feature of insights cards is deprecated. Any ranking rules that you might have set up are no longer available and won't apply to insight cards. To optimize and prioritize the cards, turn off those cards that aren't in use.

<a name='playbooks'></a>
## Playbooks is deprecated

Effective July 2023, the playbooks feature is deprecated. You can no longer access, create, or launch playbooks. If you've added playbook entries to your custom app, remove them manually. Playbooks are replaced by sequences. [Learn more about sequences](create-manage-sequences.md).  

<a name='talking-points'></a>
## Talking points is deprecated

Effective August 2022, the talking points feature is deprecated. After the feature is deprecated, you’ll stop getting talking point suggestions on the contact and lead pages. To continue getting suggestions, you can buy the LinkedIn Sales Navigator license and integrate it with Dynamics 365 Sales. For more information on what you get with the integration, see [View and work with LinkedIn Sales Navigator controls on forms](../linkedin/view-sales-navigator-forms.md) and for instructions on how to integrate, see [Integrate LinkedIn Sales Navigator solutions for Dynamics 365 Sales](../linkedin/integrate-sales-navigator.md). 

## Premium auto capture is deprecated

Effective July 2022, premium auto capture is deprecated. The deprecation impacts customers who have enabled the premium auto capture preview. This feature enables users to get activity and contact suggestions. 

You can switch to basic auto capture to get activity suggestions. However, no alternative is available for contact suggestions currently. For more information about basic auto capture, see [Capture customer-related activities with auto capture](auto-capture.md). 

> [!NOTE]
> If you’ve added the premium auto capture suggestion grid to your custom app, remove it manually. The grid won't show any suggestions after the feature is deprecated.  

## Dynamics 365 assistant cards - Opportunity at Risk (sentiment detection) and Opportunity at Risk (phrase detection)

Effective March 31, 2022, the Opportunity at Risk (sentiment detection) and Opportunity at Risk (phrase detection) cards are deprecated. After May 30, 2022, these cards will no longer be supported.     
The Opportunity at Risk cards, both sentiment detection and phrase detection, have been disabled from the backend and insights are no longer generated. However, these cards are still visible through the Settings page. When users are trying to activate these cards, activation fails.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
