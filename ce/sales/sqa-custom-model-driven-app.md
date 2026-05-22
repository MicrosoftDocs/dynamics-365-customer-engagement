---
title: Use Sales Qualification Agent in custom model-driven apps
description: Custom model-driven apps need extra setup for Sales Qualification Agent. Follow this guide to enable agent views and insights for your sales team.
ms.date: 05/29/2026
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: udaykirang
ms.author: udag
ms.reviewer: udag
ai-usage: ai-assisted
---

# Use Sales Qualification Agent in custom model-driven apps


Sales Qualification Agent supports both the **Sales Hub app** and **custom model-driven apps (MDAs)**. If you're using a custom app, you must complete additional configuration steps to ensure that agent views and insights are visible to sellers.

## Considerations

Keep the following points in mind when configuring Sales Qualification Agent views in a custom model-driven app:

- **Views visible in the designer might not appear in the app.** If views show up in the app designer but aren't visible to sellers in the running app, confirm that the views are [added to the app](#add-sales-qualification-agent-views-to-a-custom-model-driven-app), that the app is published after any changes, and that users have the required security roles.

- **Some Sales Qualification Agent views might not appear in solution explorer.** Certain Sales Qualification Agent views don't surface in solution explorer the same way as standard views. Add these views through the app designer rather than relying solely on solution explorer.

- **A missing AI *record type* views error indicates required views aren't available to users.** Ensure that all required Sales Qualification Agent views are active, visible to users, and included in the app.

## Add Sales Qualification Agent views to a custom model-driven app

To make the agent insights available in a custom model-driven app, add the required views to the app.

1. Sign in to [Power Apps](https://make.powerapps.com/).
1. Select **Apps**.
1. Open your custom model-driven app in **Edit** mode.
1. In the app designer, select the required table. For example, **Lead**.
1. Select **Views**.
1. Add all Sales Qualification Agent-related views for the table.
1. Save and publish the app.

## Verify views in the custom model-driven app

After adding the views to your custom model-driven app, verify that they're visible and that AI-generated insights are displayed properly.

1. Open the custom model-driven app.
1. Go to the relevant table such as **Leads**.
1. Verify that:
   - The Sales Qualification Agent views are available in the view selector.
   - AI-generated insights, such as research or summaries, are visible.

## Best practices

Most organizations use custom model-driven apps instead of the Sales Hub. Without properly configuring Sales Qualification Agent views, sellers might not see AI-generated insights, agent capabilities might appear unavailable, and adoption can be impacted. Follow these recommendations to ensure a smooth configuration and consistent seller experience:

- **Use the Sales Hub app as a reference implementation.** Compare your custom app's configuration against Sales Hub to identify gaps.
- **Replicate out-of-box (OOB) view configurations.** If needed, mirror the configuration of OOB views in your custom app to preserve agent functionality.
- **Maintain consistency across environments.** Use solutions and application lifecycle management (ALM) processes to keep configuration consistent across development, test, and production environments.

## Related information

- [Configure Sales Qualification Agent](configure-sales-qualification-agent.md)  
- [Requirements for Sales Qualification Agent](configure-requirements-for-sqa-agent.md)
