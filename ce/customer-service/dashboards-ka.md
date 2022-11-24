---
title: Monitor knowledge articles with dashboards
description: Monitor the status of knowledge articles using the dashboards,
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.service: dynamics-365
ms.topic: conceptual
ms.date: 11/24/2022
ms.custom: bap-template
---

# Dashboards for knowledge articles

Knowledge managers and authors can now monitor the status of knowledge articles using the two default dashboards available in the Customer Service Hub.

> [!NOTE]
>  If these dashboards don’t offer what you need, you can create new interactive dashboards. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure interactive experience dashboards](/previous-versions/dynamicscrm-2016/administering-dynamics-365/mt622067(v=crm.8))  

## My Knowledge Dashboard

This dashboard is designed to give authors a visual snapshot of the number and status of knowledge articles they’re working on. It helps them quickly know things like articles expiring in the month and articles in review.  
  
 ![My Knowledge Dashboard for authors.](../customer-service/media/v9-my-knowledge-dashboard.PNG "My Knowledge Dashboard for authors")  
  
-   **Streams** show data from views or queues. In the My Knowledge Dashboard, the stream shows the active articles assigned to the author.  
  
-   **Charts** provide a count of relevant records in the streams, such as articles by status, articles by owner, or articles by subject. They also act as visual filters. You can drill down in a chart to see data that interests you the most.  
  
-   **Tiles** give authors an aggregated view of data in the streams and help them monitor the volume of their knowledge articles.

## Knowlegde Manager

This dashboard is designed specifically for knowledge managers. As a knowledge manager, you can quickly know the most popular articles, articles that need review, highest-rated articles, or articles that are about to expire, and take necessary actions on the articles from here.  
  
 ![Dashboard for knowledge managers.](../customer-service/media/v9-knowledge-manager-dashboard.PNG "Dashboard for knowledge managers")  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use interactive dashboards to effectively manage service cases](customer-service-hub-user-guide-dashboard.md)

#### Manage versions in alternate keys for knowledge article entity

If you are creating an alternate key for a Knowledge article entity, include the major or minor version in the key to maintain uniqueness. Also, if you are using translations, include the language code along with the version in the key to ensure a seamless translation experience. To know more about alternate keys, see [Define alternate keys for an entity](../customerengagement/on-premises/developer/define-alternate-keys-entity.md).

## Knowledge management analytics

This dashboard consists of the Article insights dashboard and Search term insights dashboards and is meant for knowledge authors and supervisors. Supervisors can use these insights to improve their knowledge management system. For more information on knowledge management analytics, go to [Introduction to knowledge analytics](knowledge-search-analytics-cs.md#introduction-to-knowledge-analytics).
