---
title: "Best Practices Analyzer in Unified Service Desk | MicrosoftDocs"
description: "Learn about the Best Practices Analyzer that analyzes browser settings and configurations in Unified Service Desk."
ms.date: 04/24/2018
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
---
# Analyze best practices in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]



This topic describes the best practices or guidelines for system configurations or browser settings that we recommend when you use [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

Although deviating from best practices may not necessarily lead to a breakdown, they indicate crucial parameters that can result in poor performance, poor reliability, unexpected conflicts, increased security risks, or other potential issues. 

## What is [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] analyzes the compliance of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] with best practice rules in certain categories. The [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] displays the results of analysis in the form of a report with severity levels, description of the parameter, and mitigation for the non-compliant / problematic areas.

The following table lists the categories against which [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] analyzes the compliance of best practice rules.


|                                         Category name                                         |                                                                                                                                        Description                                                                                                                                        |
|-----------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Configurations | [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Configurations are the configurations (hosted controls, actions, events, and so on) that you configure for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] in Dataverse. |
|                                     System configurations                                     |                                          System configurations are the information about local computer hardware (RAM, operating system, and so on), and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] version.                                          |
|                                  Internet Explorer settings                                   |                                                                              Internet Explorer settings are the settings (General, Security, Advanced, and so on) that you configure for Internet Explorer.                                                                               |

The following table lists the results of Severity level analysis.


| Severity category |                                                                                                                                                                                      Description                                                                                                                                                                                       |
|-------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|       Pass        |                                                                                                                                                 The report displays a pass result when a parameter satisfies the recommended criteria.                                                                                                                                                 |
|      Warning      | The report displays a warning result when a parameter doesn't satisfy the recommended criteria and due to which [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can encounter potential issues. Using recommended value settings for parameters helps [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to perform better. |
|       Error       |                                                                                                                                             The report displays an error result when a parameter doesn't satisfy the recommended criteria.                                                                                                                                             |

## See also

[Download and install Best Practices Analyzer](../admin/download-install-best-practices-analyzer.md)

[Walkthrough: Configure Best Practices Analyzer](../admin/walkthrough-configure-best-practices-analyzer.md)

[Read Best Practices Analyzer report](../admin/read-best-practices-analyzer-report.md)

[List of rule categories and parameters](../admin/compliance-categories-parameters-bpa.md)

[System configurations](../admin/system-configurations-bpa.md)

[Internet Explorer settings](../admin/internet-explorer-settings-bpa.md)

[Unified Service Desk configurations](../admin/unified-service-desk-configurations-bpa.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
