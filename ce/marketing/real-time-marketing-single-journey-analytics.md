---
title: "Access and interpret single journey analytics (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to access and interpret real-time marketing single journey analytics in Dynamics 365 Marketing."
ms.date: 04/01/2021
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

# Access and interpret single journey analytics

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that is subject to legal or regulatory compliance requirements.

Single journey analytics provide the ability to understand how your orchestrated journey is doing even in a short time-horizon. This allows you to discontinue under-performing journeys early, or identify ways to optimize and increase a journey’s performance as it continues.

The single journey analytics dashboard is the perfect place to check in on the performance of a single orchestrated journey. Within the dashboard, there are widgets to help:

- Understand the goal performance of a journey over its lifetime
- Identify possible friction points where customers are getting stalled in a journey
- Identify the steps in a journey where customers are especially engaged
- Check in on the experiments that have been run in a journey, as well as the optimization that has been applied
- Gain insights into how a journey's performance compares to others, which channels work well in the journey, and when the journey is expected to reach its goal, if applicable

The following sections describe each which in greater depth.

## Overall effectiveness

Here, you're given a clear view of how a journey's performance has been trending over time. The performance chart can show you if your journey is gaining or losing steam. If your journey has a goal target (for example, 1,000 completions), the target will be represented on the chart.

You can also see the inflow and outflow of the journey. On the inflow bar, you can see the total number of entries, as well as which audience segments the users come from. In the exits bar, you can see why individuals are exiting. There are multiple reasons an individual could exit, for example, if they successfully completed the journey, or if they went stale.

## Possible friction points

Here, if your journey has four or more messages with a redirect link (for example, an email with a link to your website), you're presented those messages in the journey that had the highest delivery failure rate, unopened rate, and unsubscribe rate compared to other steps in the journey. These statistics don't always mean that the journey is doing poorly. Rather, the metrics indicate that the other steps in the journey performed better.

If you select the title of one of the steps, you will be shown detailed statistics about the performance of that message.

## Highpoints of engagement

Here, you can see the steps in journey that your audience responded best to. If your journey has four or more messages with a redirect link (for example, an email with a link to your website), you're presented those messages in the journey that had the highest delivery rate, opened rate, and click through rate compared to other steps in the journey.

If you select the title of one of the steps, you will be shown detailed statistics about the performance of that message.

## Content performance

If you have fewer than four messages with a redirect link (for example, an email with a link to your website), the **Content performance** widget will replace the **Possible friction points** and **Highpoints of engagement** widgets. For each of the messages that meet the above criteria, you will see the delivery rate, open rate, and click through rate. This allows you to compare these messages to see if any are lagging or performing well.

If you select the title of one of the steps, you will be shown detailed statistics about the performance of that message.

## Experimentation

Here, you can see each of the variant experiments that have been run for the journey, as well as the outcomes. By leveraging this information, you can gain insights into what your audience preferences.

If you select the title of one of the experiments, you will be shown detailed statistics about the outcome or progress of that experiment.

## Insights

The insights widget performs the heavy lifting of analysis for you by presenting insights into the journey's performance and your audience. If applicable, you will see:

- Which channels worked best for the journey
- Possible ways to improve engagement, such as changing the timing of when messages are delivered
- How the journey's performance compares to other orchestrated journeys
- If the journey has a goal target, when it's expected to reach the target