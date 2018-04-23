---
title: "Analyze best practices in Unified Service Desk (Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about the best practices analyzer, which performs analysis on the Internet Explorer settings, Unified Service Desk configurations in Dynamics 365, and system configurations on which you install Unified Service Desk, and displays a report to review and mitigate the issues."
ms.custom: ""
ms.date: 04/24/2018
ms.service: "usd"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 8ED5D0F6-4A3E-49FA-A399-0AEDFF2236AA
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Analyze best practices in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]

Best practices are the guidelines about System Configurations, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], Internet Explorer settings, and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations in Dynamics 365 Customer Engagement. Consider these guidelines as our recommended way to use [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and serve your customers.

Although deviating from best practices may not necessarily lead to a breakdown, they indicate crucial parameters that can result in poor performance, poor reliability, unexpected conflicts, increased security risks, or other potential problems. 

## What is [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] analyzes the compliance of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] with best practice rules in certain categories. The [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] displays the results of analysis in the form of a report with severity levels, description of the parameter, and mitigation for the non-compliant / problematic areas.

The following table lists the categories against which [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] analyzes the compliance of best practice rules.

| Category name | Description |
|--------------------------|-------------------------------|
|[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Configurations | [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Configurations are the configurations (hosted controls, actions, events, and so on) that you configure for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] in Dynamics 365.|
|System configurations | System configurations are the information about local computer hardware (RAM, operating system, and so on), and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] version.|
|Internet Explorer settings|Internet Explorer settings are the settings (General, Security, Advanced, and so on) that you configure for Internet Explorer.|

The following table lists the results of Severity level analysis.

| Severity category | Description |
|-------------------|-----------------|
| Pass | The report displays a pass result when a parameter satisfies the recommended criteria.|
| Warning| The report displays a warning result when a parameter doesn't satisfy the recommended criteria and due to which [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can encounter potential issues. Using recommended value settings for parameters helps [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to perform better.|
| Error| The report displays an error result when a parameter doesn't satisfy the recommended criteria.|

## [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] support matrix 

The matrix provides information about how you can obtain and use the [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] based on [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] existence.

| Scenario | Description | [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] |
|-----------------|------------------|----------------|
| New installation or Upgrade of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] |[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] is part of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] – Microsoft Dynamics 365 Web Client and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] – Microsoft Dynamics 365 Unified Client | [!INCLUDE[pn-unified-service-desk-3-3](../../includes/pn-unified-service-desk-3-3.md)] |
|Existing installation of [!INCLUDE[pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md) or lower version|[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] is available as a download package.| [!INCLUDE[pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)]<br> [!INCLUDE[pn-unified-service-desk-3-1](../../includes/pn-unified-service-desk-3-1.md)]<br>[!INCLUDE[pn-unified-service-desk-3-0](../../includes/pn-unified-service-desk-3-0.md)] <br>[!INCLUDE[pn-unified-service-desk-2-2dot2](../../includes/pn-unified-service-desk-2-2dot2.md)] | 

## See also

[Download and install Best Practices Analyzer](../admin/download-install-best-practices-analyzer.md)

[Walkthrough: Configure Best Practices Analyzer](../admin/walkthrough-configure-best-practices-analyzer.md)

[Read Best Practices Analyzer report](../admin/read-best-practices-analyzer-report.md)

[Compliance categories and parameters](../admin/compliance-categories-parameters-bpa.md)

[System configurations](../admin/system-configurations-bpa.md)

[Internet Explorer settings](../admin/internet-explorer-settings-bpa.md)

[Unified Service Desk configurations](../admin/unified-service-desk-configurations-bpa.md)
