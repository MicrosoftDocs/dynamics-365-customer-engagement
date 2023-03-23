---
title: "Access and interpret analytics (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to access and interpret real-time marketing analytics in Dynamics 365 Marketing."
ms.date: 02/21/2023
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

# Access and interpret analytics

Real-time marketing's dashboards and cross-journey insights show metrics, views, and insights summarized across single or multiple journeys, providing you with a deep understanding of journey, channel, and content performance. The built-in dashboards focus on measuring delivery, engagement and journey goal attainment, so you can fine-tune the effectiveness of your journeys, channels, and content.

## Real-time marketing analytics overview

With real-time marketing analytics, you can:

- Evaluate the effectiveness of journeys against your objectives.
- Troubleshoot journeys by identifying areas of friction.
- Discover what is working so that you can amplify or recreate the same approach elsewhere.
- Understand the effectiveness of various messages and channels of communication through key delivery and engagement insights.

### Journey operational analytics

Evaluate journey performance in near real time using built-in operational analytics. The Sankey view in the designer helps you understand the user flow through the journey, highlighting which branches are working well.

Select any journey component to view near real-time operational analytics in the right pane, including:

- **Goal analytics**: If a goal has been defined a target set, you can view how the journey is progressing toward its goal and if it has met the goal.

    > [!div class="mx-imgBorder"]
    > ![Goal analytics screenshot.](media/real-time-marketing-goal-analytics.png "Goal analytics screenshot")

- **Channel analytics**: For any message in the journey (email, text, or push notification), view the delivery funnel and additional metrics to diagnose the content performance.

    > [!div class="mx-imgBorder"]
    > ![Email channel analytics screenshot.](media/real-time-marketing-channel-analytics.png "Email channel analytics screenshot")

    To view delivery and interaction statistics, select the **Delivery and interaction details** link at the bottom of the channel analytics pane.

    > [!div class="mx-imgBorder"]
    > ![Delivery and interactions details screenshot.](media/real-time-marketing-analytics-interactions.png "Delivery and interactions details screenshot")

- **AI optimization**: Near real-time data to help you evaluate how applying AI optimization has helped your engagement rate.

    > [!div class="mx-imgBorder"]
    > ![AI optimization screenshot.](media/real-time-marketing-ai-optimization.png "AI optimization screenshot")

> [!NOTE]
> Data retention is 12 months for Goal analytics, Channel analytics (including delivery and interaction details), and AI optimization analytics.

### Aggregate cross-journey analytics

The built-in aggregate cross-journey analytics dashboard shows relevant metrics and insights for all your journey orchestrations in one place.

> [!div class="mx-imgBorder"]
> ![Aggregate cross-journey analytics dashboard.](media/real-time-marketing-aggregate-analytics.png "Aggregate cross-journey analytics dashboard")

Use the aggregate cross-journey analytics dashboard to review recent journey effectiveness and quickly share reports with stakeholders.

Learn more: [How to use aggregate cross-journey analytics](real-time-marketing-cross-journey-analytics.md).

### Aggregate channel analytics

The aggregate channel analytics dashboard shows metrics and insights related to delivery and engagement.

> [!div class="mx-imgBorder"]
> ![Aggregate channel analytics dashboard.](media/real-time-marketing-aggregate-channel-analytics.png "Aggregate channel analytics dashboard")

Use the aggregate channel analytics dashboard to measure campaign effectiveness and track the performance of your marketing assets.

Learn more: [How to use aggregate channel analytics](real-time-marketing-channel-analytics.md).

> [!NOTE]
> There is no retention policy for real-time marketing interactions in Aggregate cross-journey analytics and Aggregate channel analytics. Dataverse entities are limited to a two-year retention policy after their initial creation date. Keep in mind that the two-year Dataverse entity retention policy might impact analytics views associated with interaction data from Dataverse entities.

## Learn more

Here are some advanced resources for this topic:

- [Extracting Marketing Interactions in Dynamics 365 Marketing](https://community.dynamics.com/365/dynamics-365-fasttrack/b/dynamics-365-fasttrack-blog/posts/extracting-marketing-interactions-in-dynamics-365-marketing)