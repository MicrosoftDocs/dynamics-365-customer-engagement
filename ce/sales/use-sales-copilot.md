---
title: Use Copilot in Dynamics 365 apps
description: Learn how to use Copilot to summarize sales records, catch up on recent changes, prepare for meetings, and enrich your leads with data from different sources.
ms.date: 12/18/2023
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
 - AI-contribution
ms.custom:
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:10/04/2023
 - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
---

# Use Copilot in Dynamics 365 apps

Copilot is an AI assistant that helps you be more productive and efficient in your daily work in Dynamics 365 Sales apps. Copilot can summarize information about your leads and opportunities, help you catch up on recent changes to your records, prepare for meetings, and enrich your leads with information from other sources.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [Any primary sales role, such as Salesperson or Sales Manager](security-roles-for-sales.md#primary-sales-roles) |

## Prerequisites

Your admin has [turned on and set up Copilot](enable-setup-copilot.md).

## Open Copilot

You can open Copilot in a [side pane](#open-copilot-in-a-side-pane)&mdash;side-by-side with a record such as, an opportunity or a lead&mdash;or in a [full-screen view](#open-copilot-in-full-screen-view-preview).

### Open Copilot in a side pane

Open the Copilot side pane when you want to get quick insights about a record or ask Copilot to summarize other records, display recent changes, and prepare for meetings without leaving the current page.

1. Select the **Copilot** icon (:::image type="icon" source="media/copilot-icon.png" border="false":::) on the right side of your app. You can open the **Copilot** side pane from any page in your app except the **Copilot** page.

1. Select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) to get a list of suggested requests, or *prompts*, that Copilot can help you with.

### Open Copilot in an immersive, full-screen view (preview)

[!INCLUDE [preview-banner-section](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note.md)]

Open the Copilot page in a full-screen view when you want more space and focus to chat with Copilot and ask questions.

1. Select **Copilot** in your sitemap.

    :::image type="content" source="media/sales-copilot-pane.png" alt-text="Screenshot of the Copilot page showing suggested requests, with the Copilot icons in the left and right side panes highlighted.":::

    If it isn't there, ask your admin to [turn on Copilot preview features](copilot-preview-features.md#enable-all-preview-features-for-copilot). If you're using a custom app, ask your admin to [add the Copilot page to your app's sitemap](enable-setup-copilot.md#add-the-copilot-page-to-custom-apps-preview).

2. Select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) to get a list of suggested requests, or *prompts*, that Copilot can help you with.


## Chat with Copilot

Use predefined prompts to get the most out of Copilot. The following table provides a quick reference to predefined prompts.

| Prompt name | Prompt navigation | Description |
|---------|---------|---------|
| [Show my pipeline](copilot-get-information.md#show-my-pipeline) | **Get info** > **Show my pipeline** | Get a list of opportunities that you own, sorted by the estimated close date. |
| [Summarize lead or summarize opportunity](copilot-get-information.md#summarize-a-lead-or-opportunity) | **Get info** > **Summarize lead** or **Summarize opportunity** | Get a list of opportunities that you own, sorted by the estimated close date. |
| [Get latest news for account](copilot-get-information.md#show-the-latest-news-about-an-account) | **Get info** > **Get latest news for account** | Get a list of opportunities that you own, sorted by the estimated close date. |
| [What's new with my sales records](copilot-ask-questions.md#whats-new-with-my-sales-records) | **Ask questions** > ****What's new with my sales records**** | Get a list of your sales records that were updated in the last seven days. |
| [What's newly assigned to me](copilot-ask-questions.md#whats-newly-assigned-to-me) | **Ask questions** > ****What's newly assigned to me**** | Get a list of leads and opportunities that were assigned to you in the last 15 days. |
| [Show recent changes](copilot-ask-questions.md#get-recent-changes-to-a-lead-or-opportunity) | **Ask questions** > ***Show recent changes for opportunity or Show recent changes for lead** | Get a list updates to your opportunity or lead records in the last seven days or since you last signed in. |
| [Prepare for sales appointments](copilot-stay-ahead.md#prepare-for-upcoming-sales-appointments) | **Stay ahead** >  **Prepare for sales appointments** | Prepare better for your sales appointment with a summary of notes from the last three months and the most recent email thread on the timeline of the related record. |
| [Show emails that need follow up](copilot-stay-ahead.md#show-emails-you-havent-replied-to) | **Stay ahead** >  **Show emails that need follow up** | Get a list of emails that you haven't replied to. |


### See also

- [Get information from Copilot](copilot-get-information.md)
- [Ask questions to Copilot](copilot-ask-questions.md)
- [Stay ahead with Copilot](copilot-stay-ahead.md)
