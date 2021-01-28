---
title: "Overview of Unified Service Desk Performance Analyzer | MicrosoftDocs"
description: "Learn about the introduction and overview of Unified Service Desk Analyzer. What are the value propositions, support matrix, and download link of Unified Service Desk Performance Analyzer."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 10/31/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
monikerRange: '>= dynamics-usd-3'
---

# Public Preview: Overview of Unified Service Desk Performance Analyzer

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Unified Service Desk Performance Analyzer is a powerful performance monitoring tool that analyzes the
operations of your Unified Service Desk client from the performance data logs and generates in-depth
report to identify the problematic areas. The report provides a detailed analysis like the duration of
every operation so that you focus on these areas to troubleshoot the issues effectively.

## Existing challenges

Unified Service Desk provides a configurable framework for quickly building the contact center agent
application. You configure various elements like hosted controls, events, action calls, custom scripts to
define the user experience in the client application. However, if you encounter performance issues with
Unified Service Desk, it is hard to identify due to which elements the issue occurred. The issues may
have occurred due network, Microsoft Dataverse, Unified Service Desk configuration elements like hosted
controls, custom scripts, action calls and so on.

## Advantages or value proposition of the performance analyzer

The advantages or value proposition of the Unified Service Desk performance analyzer are as follows:

- Visual representation of performance data logs, in charts and table, which helps in the following:
    - Reduce the time spent on troubleshooting
    - Review the end-to-end performance of the client application from timeline.
- Report for operations performed in the client application.
- Comparative analysis of the different performance reports (generated out of performance data logs).
- Ease of access to the reports for future reference.

> [!div class="mx-imageBorder"]
> ![Performance analyzer value propositions](../media/performance-analyzer-value-propositions.PNG "Performance analyzer value propositions")

## Support matrix
The Unified Service Desk Performance Analyzer supports Unified Service Desk 4.0 and later.

> [!div class="nextstepaction"]
> [Download Unified Service Desk Performance Analyzer](download-performance-analyzer.md)

## See also

[Generate (collect) performance data log](performance-data-collection-using-keyboard-shortcut.md)

[Generate performance report](generate-performance-report.md)

[Overview of performance report user interface](overview-performance-report-user-interface.md)
