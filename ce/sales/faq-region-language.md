---
title: Region and language FAQs
description: Find answers to frequently asked questions about regions and languages.
ms.date: 03/02/2026
ms.topic: faq
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
  - references_regions
---

# Region and language FAQs

This article answers frequently asked questions about region and language support in Dynamics 365 Sales.

## In which country/region is Sales Premium available?

Sales Premium is only available in the following countries or regions:

- Asia Pacific (APJ)
- Canada (CAN)
- Europe, the Middle East, and Africa (EMEA)
- France (FRA)
- Germany (GER)
- Great Britain (GBR)
- India (IND)
- Japan (JPN)
- North America (NAM)
- Oceania (OCE)
- South Africa (ZAF)
- South America (SAM)
- Switzerland (CHE)
- United Arab Emirates (UAE)

Sales Premium isn't available in all other regions and Government Community Cloud (GCC), including USG.

## In which country/region are Sales Premium features available?

The following table lists the regions in which Sales Premium features are available.

| Feature | NAM | EMEA | GBR | APJ | CAN | IND | JPN | OCE | CHE | FRA | GER | SAM | ZAF | UAE |
|---------|-----|------|-----|-----|-----|-----|-----|-----|-----|-----|-----|-----|-----|-----|
| [Assistant](assistant.md) | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| [Conversation intelligence](dynamics365-sales-insights-app.md) | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| [Email engagement](email-engagement.md) | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No | Yes | Yes | Yes |
| [Notes analysis](notes-analysis.md) | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| [Premium forecasting](configure-premium-forecasting.md) | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No | No | Yes | Yes | Yes |
| [Predictive lead scoring](work-predictive-lead-scoring.md) | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| [Predictive opportunity scoring](work-predictive-opportunity-scoring.md) | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| [Sales accelerator](digital-selling-sales-accelerator.md) | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| [Relationship analytics (Basic)](relationship-analytics-overview.md#basic-relationship-insights) | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| [Relationship analytics (Enhanced)](relationship-analytics-overview.md#enhanced-relationship-insights)\* | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| [Who knows whom (Basic)](who-knows-whom.md#basic-who-knows-whom-information) | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| [Who knows whom (Enhanced)](who-knows-whom.md#enhanced-who-knows-whom-information) | Yes | Yes | Yes | Yes | Yes | No | No | No | No | Yes | No | No | No | No |

\* To use Exchange data for relationship analytics (enhanced), your organization's Office 365 data location must be in one of the [supported locations](#in-which-regions-is-exchange-integration-available).

## Which version of Exchange is supported for features in Sales Premium?

The following table lists the supported Exchange versions for Sales Premium features.

| Feature | Exchange Online | Exchange Server 2013 and above | Is Exchange data mandatory? |
|---------|-----------------|--------------------------------|-----------------------|
| Relationship analytics (Basic) | Yes | No | No |
| Relationship analytics (Enhanced) | Yes | No | No\*\* |
| Who knows whom (Basic)| Yes | No | No |
| Who knows whom (Enhanced)| Yes | No | Yes |
| Assistant | Yes | No | No |
| Email engagement | Yes | Yes | Yes |

\*\* Exchange data is optional for relationship analytics (enhanced). We recommend that you enable Exchange integration to get more accurate and complete relationship information. For example, the response time KPI is generated from the data in Exchange only. If you don't enable Exchange integration, the response time KPI is blank.

## In which regions is Exchange integration available?

Exchange integration is only available in specific regions. To use Exchange data for relationship analytics and the who-knows-whom feature, your organization's Office 365 data location must be in one of the following locations. Region-specific data center locations aren't supported.

- Global Geography 1 – EMEA (Austria, Finland, France, England, Ireland, Netherlands).
- Global Geography 2 – Asia Pacific (Hong Kong SAR, Japan, Malaysia, Singapore, South Korea).
- Global Geography 3 – Americas (Brazil, Chile, United States).

If your organization's Office 365 data is in any other region, who-knows-whom insights aren't available. However, relationship analytics are available based on data stored in Dynamics 365.

To learn more on data center locations, see [Data Center Locations](/microsoft-365/enterprise/o365-data-locations?view=o365-worldwide#data-center-locations&preserve-view=true).

## Which languages are supported for Sales Premium features?

The following table shows the supported languages for Sales Premium features.

| Feature | Language supported |
|---------|--------------------|
| Assistant, assistant studio, email engagement, predictive lead scoring, predictive opportunity scoring, premium forecasting, relationship analytics, sales accelerator, and who knows whom | Arabic, Basque, Bulgarian, Catalan, Chinese Simplified (PRC), Chinese Traditional (Hong Kong SAR), Chinese Traditional (Taiwan), Croatian, Czech, Danish, Dutch, English, Estonian, Finnish, French, Galician, German, Greek, Hebrew, Hindi, Hungarian, Indonesian, Italian, Japanese, Kazakh, Korean, Latvian, Lithuanian, Malay, Norwegian, Polish, Portuguese (Brazil), Portuguese (Portugal), Romanian, Russian, Serbian (Cyrillic), Serbian (Latin), Slovakian, Slovenian, Spanish, Swedish, Thai, Turkish, Ukrainian, and Vietnamese. |
| Notes analysis | English, French, German, Italian, and Dutch for machine learning models. |
| Exchange insight cards in assistant | Only English - United States (en-US) for machine learning models. |
| Conversation intelligence | Go to [Languages supported for conversation intelligence](language-support-conversation-intelligence.md) |

[Learn more about infrastructure availability (PDF)](https://aka.ms/dynamics_365_international_availability_deck).

## Which languages are supported by Copilot in Dynamics 365 Sales?

Copilot in Dynamics 365 Sales is available in regions and languages listed in the [Copilot international availability report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport). For more information about how to use the report and how Copilot responds in different scenarios, review [Geographical availability and languages supported](copilot-overview.md#geographical-availability-and-languages-supported).
