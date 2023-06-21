---
title: "How to use aggregate channel analytics (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use and interpret real-time marketing aggregate channel analytics in Dynamics 365 Marketing."
ms.date: 02/21/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# How to use aggregate channel analytics

The built-in aggregate channel analytics dashboard shows important metrics and insights about the delivery and engagement of your marketing assets at any level of aggregation. You can access insights across all journeys and channels as well as zoom in on a particular channel or message. This helps you stay on top of your marketing campaign effectiveness and track the performance of your marketing assets.

:::image type="content" source="media/real-time-marketing-aggregate-channel-analytics.png" alt-text="Aggregate channel analytics dashboard." lightbox="media/real-time-marketing-aggregate-channel-analytics.png":::

> [!NOTE]
> Currently, only interaction data from real-time marketing journeys is used to populate the aggregate channel analytics dashboards. Data from outbound marketing customer journeys is not used.

## How to use the dashboard

The aggregate channel analytics dashboard allows you to assess important delivery and engagement metrics for your customer journeys, channels, and marketing assets. You can use the date, channel, journey, and “name” filters to learn about key delivery and engagement metrics at any level of aggregation. You can also use the charts in the dashboard to study metric trends over time and investigate any anomalies or spikes. The dashboard has four sections, each of which is described below.

> [!NOTE]
> Refer to the tooltips for each metric to learn about how they are computed. You can learn more about the insights terms (such as open rate, CTR, and click-to-open rate) mentioned below, by referring to the [Insights glossary](insights-glossary.md) article.

### Positive customer engagement

This section highlights the open rate, click-through rate, and click-to-open rate for the selected marketing communications. The trend chart shows the number of opens and clicks over the selected time. You can use this section to analyze the performance of all the links in your marketing communications. This will help you learn about the best and worst performing links in your campaigns. If applicable, the call-to-action (CTA) or link-text for each link is also showcased. For each link, the number of unique clicks for the link is highlighted along with the link’s click-through rate to depict its performance.

Opens aren't recorded for text messages; hence, the open rate and click-to-open rate metrics don't apply to text messages. Be mindful when text messages are selected in your filtering criteria, as the trend chart will potentially show clicks to be greater than opens since the text message opens aren't recorded.

### Delivery successes

This section highlights the inflow, send rate, and delivery rate for the selected marketing communications. The trend chart depicts the inflow and number of communications sent and delivered over the selected time.

All sent push notifications are delivered, therefore, push notifications aren't included in the delivery rate computation and “delivered” metric in the trend chart.

### Delivery issues

This section highlights the percentage of blocked communications, soft bounce, and hard bounce rate for emails as well as single bounce rate for text messages. The trend chart depicts the number of blocked communications, soft bounced emails, hard bounced emails, and single bounced text messages.

All sent push notifications are delivered, therefore, there's no bounce rate reported for push notifications.

### Negative customer engagement

This section highlights the spam rate and unsubscribe rate for emails. For text messages and push notifications, there's no signal to identify negative engagement, hence metrics in this section don't apply to such communications.

> [!NOTE]
> Depending on your selection of filters, you might see some metrics show “N/A.” This is because such metrics are not applicable for some or all of the communications based on your selected filters. In such scenarios, refer to the tooltip to learn about the types of communications that apply to a specific metric.

## Learn more

Here are some advanced resources for this topic:

- [Extracting Marketing Interactions in Dynamics 365 Marketing](https://community.dynamics.com/365/dynamics-365-fasttrack/b/dynamics-365-fasttrack-blog/posts/extracting-marketing-interactions-in-dynamics-365-marketing)

[!INCLUDE[footer-include](../includes/footer-banner.md)]