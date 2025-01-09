---
title: Customer Service dashboards | Microsoft Docs
description: Learn about the various dashboards and reports for historical operational metrics and KPIs to manage contact centers.
ms.date: 02/12/2024
ms.topic: overview
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
ms.collection: get-started
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Customer Service dashboards

The insights dashboards for Customer Service contain various charts and metrics to help you understand the factors that can improve customer service for your organization. Key performance indicators and visual breakdowns of your organization's support cases are coupled with AI-generated insights on cases and topics that contribute to overall trends.

The Customer Service dashboards give you a performance summary and detailed reports on cases, agents, and topics. You can make changes to the visual display of the dashboards and also save your personalized views as bookmarks.

## Manage dashboards

To manage the dashboards, go to: [Manage historical analytics reports in Customer Service](../administer/configure-cs-historical-analytics-csh.md).

## Customer Service historical analytics reports

The following dashboard reports are available for Customer Service historical analytics:

### Summary

The Summary dashboard gives you a broad overview of the customer service experience in your organization. It uses AI technology to show you topics that are generating the highest volume and emerging topics with the highest rate of change in volume. More information: [Summary dashboard](summary-dashboard-cs.md)

### Agent

The Agent dashboard shows charts and KPIs for individual agents and overall agent performance. More information: [Agent dashboard](agent-dashboard-cs.md)

### Case Topics

The Case Topics dashboard shows a detailed breakdown of cases and their assigned topics. More information: [Topics dashboard](case-topics-dashboard-cs.md)

## Reports refresh and data retention

See [Analytics reports refresh and data retention](info-analytics-reports.md#analytics-reports-refresh-and-data-retention)

## Supported tables

The following tables are used for Customer Service historical analytics:

- incident
- incidentresolution
- appmodule
- organization
- msfp_surveyresponse
- msfp_question
- msfp_questionresponse
- msdyn_casetopic
- msdyn_casetopic_incident
- msdyn_casetopicsetting
- Queue
- QueueItem
- Subject
- SystemUser

> [!NOTE]
> A report might be blank if you've customized any of the listed entities or aren't using out-of-the-box entities.

### Related information

[Introduction to Customer Service insights](../implement/introduction-customer-service-analytics.md)    
[Configure Customer Service insights for Customer Service Hub and Customer Service workspace](../administer/configure-customer-service-analytics-insights-csh.md)   
[Manage bookmarks](manage-bookmarks.md)  
[Customize visual display](customize-reports.md#customize-visual-display)  
[Customize data models of historical analytics reports in Customer Service](../administer/model-customize-reports.md)   
[Tracked keywords in Dynamics 365 Sales](../../sales/dynamics365-sales-insights-app-home-page.md#tracked-keywords)    


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
