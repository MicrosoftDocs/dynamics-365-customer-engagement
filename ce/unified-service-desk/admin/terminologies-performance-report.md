---
title: "Terminologies in the performance report | MicrosoftDocs"
description: "Learn about the terminologies used in the Unified Service Desk Performance Report generated using Unified Service Desk Performance Analyzer"
author: mh-jaya
ms.author: v-jmh
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

# Public Preview: Terminologies in the performance report

[!INCLUDE[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

When you view the performance report, you may come across certain terminologies. Understanding the terminologies help you to read and analyze the performance report effectively and take a better course of action.

| Terms | Description |
|-------|-------------|
| Operation | The name of the operation executed during a performance session. It consists of multiple methods executed in various classes. |
| Count | The number of times an operation is executed in one performance session. In the consolidated report, it represents the total number of times a operation is executed across multiple performance sessions. |
| Percentile | The number of times the particular operation is executed within the time mentioned. 50 percentile means 50% of the time the operation executed in t milliseconds. |
| Performance Session ID | A unique identifier assigned to an end-to-end session in which perfomance logging is enabled. This includes session creations, form loading, actions and so on. |
| Category | The operation category – we divide USD into chunks for example KB search, Form Loading, Boot etc. We split the operations into these buckets for better understanding. |
| Correlation ID | A unique Identifier assigned to correlate the start and end of a particular operation. |
| Action | The name of the operation. |
| Start time | The start time of the operation with respect to the start of the performance session. |
| End time | The end time of the operation with respect to the end of the performance session. |
| Total duration | The difference between the end time and start time of the operation in milliseconds. |
| Method | The method executed in a particular class for an operation. |
| Class | The classes for a particular operation. |

> [!div class="nextstepaction"]
> [View, read, and compare performance report](view-read-compare-performance-report.md)

## See also

[Overview of Unified Service Desk Performance Analyzer](overview-performance-analyzer.md)

[Download Unified Service Desk Performance Analyzer](download-performance-analyzer.md)

[Generate (collect) performance data log](performance-data-collection-using-keyboard-shortcut.md)

[Generate performance report](generate-performance-report.md)

[Overview of performance report user interface](overview-performance-report-user-interface.md)

[Categories and operations](operations-categories.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]