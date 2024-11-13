---
title: Use knowledge insights for customer Knowledge management agent (preview)
description:
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection:
ms.date: 11/13/2024
ms.custom: bap-template
---

# Use knowledge insights for customer knowledge management agent (preview)

[This article is prerelease documentation and is subject to change.]

The effectiveness of Copilot is closely linked to the quality of the knowledge base. To create and sustain high-quality knowledge, supervisors rely on valuable insights. Analysing how the articles are created, where they are in the review and publish workflow, whether they're used in copilot responses, and if the customer service representatives find them useful in their day-to-day work provide actionable insights to supervisors. Actionable insights help supervisors identify improvement areas, enhancing the overall knowledge repository quality to optimize Copilot performance.

> [!IMPORTANT]
>
> - This is a preview feature.
> - Preview features aren’t meant for production use and might have restricted functionality. These features are available before an official release so that customers can get early access and provide feedback.

Supervisors and content managers can view the **Overall performance dashboard** from **Knowledge analytics** in Customer Service workspace to get analytics reports on customer knowledge management agent.

## Benefits of knowledge insights

- Confident self-service article publishing, and greater resource control reduce support and content management costs.
- Understanding the performance of Copilot-drafted content can ensure transitioning to fully autonomous harvesting.
- Customer service representatives can provide feedback through a five-star rating approach with suggested prompts. This helps the system and the content managers identify and act on low quality articles more efficiently.

## Prerequisites

- You must have [customer knowledge management agent turned on in the Customer Service admin center](../administer/admin-km-agent.md#manage-knowledge-harvesting-preview). You must also have the **Real-time creation** and **Creation from historical cases** turned on for knowlegde harvesting.

- To enable collection of interaction data for your own reporting, you must have selected the **Record user interactions with AI, including user actions and their feedback on AI suggestions** option, on the **Customer knowledge management agent (preview)** > **User experience data** section.

## Overall performance dashboard

:::image type="content" source="../media/overall-performance.png" alt-text="Screenshot of the overall performance dashboard for customer knowledge management agent":::

## Metrics in Overall performance dashboard

The Overall Performance dashboard represents the following metrics.


|Metrics  |Description  |
|---------|---------|
|Total articles published    |    The sum of knowledge articles published by Copilot or manually.     |
|Articles by status   |  A pie-chart that shows all knowledge articles broken down by article status. It shows the number of articles in various states  that were either created by Copilot or manually.  |
|Average quality score| The average feedback rating from customer service representatives on the quality of knowledge articles, indicated through thumbs up or thumbs down.|
|Articles to revise| The amount of knowledge articles with a quality score less than or equal to two, over a specified period of time.|
|Usage by copilot|The number of times a knowledge article is referenced when agents chat with Copilot, and whether those articles were created by Copilot or manually.|
|Quality score trend|The performance of knowledge articles based on customer service representatives feedback over time, that shows copilot created articles versus articles created manually.|

## Related information

[Introduction to knowledge analytics](../use/knowledge-search-analytics-cs.md#introduction-to-knowledge-analytics)

