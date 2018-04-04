---
title: "Analyze best practices in Unified Service Desk | MicrosoftDocs"
description: "Learn about the best practices analyzer which performs analysis on the internet explorer settings, Unified Service Desk configurations in Dynamics 365, and system configurations on which you install Unified Service Desk, and displays a report to review and mitigate the issues."
ms.custom: ""
ms.date: 04/15/2018
ms.service: "usd"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: "8ED5D0F6-4A3E-49FA-A399-0AEDFF2236AA"
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Analyze best practices in Unified Service Desk

Best practices are the guidelines about System configurations, Unified Service Desk, Internet Explorer settings, and Unified Service Desk configurations in Dynamics 365 Customer Engagement. You need to consider these guidelines are a recommended way to use Unified Service Desk and serve your customers.

Although deviating from best practices are not necessarily a break down, but they indicate crucial parameters that can result in poor performance, poor reliability, unexpected conflicts, increased security risks, or other potential problems.

## What is Best Practices Analyzer (BPA) for Unified Service Desk

Best Practices Analyzer (BPA) analyzes the compliance of Unified Service Desk with best practice rules in certain categories. The BPA displays the results of analysis in the form of report with severity levels, description of the parameter, and mitigation for the problematic areas.

The categories against which BPA analyzes the compliance of best practice rules are as follows.

|Category Name| Description|
|--------------------------|-------------------------------|
|Unified Service Desk Configurations | These are the configurations (Hosted controls, Actions, Events, and so on) that you configure for Unified Service Desk in Dynamics 365.|
|System Configurations | System Configurations are the information about local computer hardware (RAM, Operating System and so on), Unified Service Desk version, and Network Statistics. |
|Internet Explorer Settings|These are the settings (General, Security, Advanced, and so on) that you configure for the Internet Explorer browser.|

Results of analysis can be any of the severity levels as show in the
following table.

|Severity Category|Description|
|-------------------|-----------------|
| Pass | The report displays pass result when a parameter satisfies the best practices rule.|
| Error| The report displays error result when a parameter does not satisfy best practices rule.|
| Warning| The report displays warning result when a parameter is non-compliant with the best practices rules and due to which Unified Service Desk can encounter potential issues. Setting the value of a parameter as per the recommendation helps Unified Service Desk to perform better.|

## Best Practices Analyzer Support Matrix 

The matrix provides information about how you can obtain and use Best
Practices Analyzer based on Unified Service Desk existence.

|Scenario|Description|Unified Service Desk|
|-----------------|------------------|----------------|
|New installation|BPA is part of Unified Service Desk – Microsoft Dynamics 365 Web Client and Unified Service Desk – Microsoft Dynamics 365 Unified Client | Unified Service Desk 3.3 |
|Existing installation|BPA is available as a download package.| Unified Service Desk 3.2 |
|                       || Unified Service Desk 3.1 |
|                       || Unified Service Desk 3.0 |
|                       || Unified Service Desk 2.2 |

