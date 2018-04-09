---
title: "Work with Best Practices Analyzer (Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about how to work with Best Practices Analyzer and access and read the Best Practices Analyzer report."
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
ms.assetid: 4BACD2D6-A17D-468D-A2CB-F4BEEF06AE5E
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Work with [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] (Dynamics 365 Customer Engagement)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] is a hosted control that helps you analyze the various parameters of your local computer (system configurations and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]), [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations in Dynamics
365, and Internet Explorer settings in your local computer. After the analysis, [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] displays a report that recommends mitigation steps in case of a warning or error.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when you handle the warning and error as recommended—this helps you to serve your customers without interruption.

## Start analysis

To analyze parameters on your computer, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations, and internet settings, against the best practices rules:

1.  Sign in to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Client application.

2.  On the toolbar, select the **[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)]** button.

3.  To see the report, select **Start Analysis** in the leftmost pane.
<!--Editing: Please check the changes in the following sentence for technical accuracy. -->
[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] displays the report—it can help you determine your next steps.

> [!Note]
> When you relaunch [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and select **BEST PRACTICES ANALYZER**, the last report that was generated appears in the report area.

## Read [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] report

This section describes the layout of the [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] report and provides information to help you understand the results of the analysis.

The report displays the following elements:

| Element| Description |
|---------------------|-----------------|
| Computer name       | Local computer name on which [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] performed the analysis. |
| Analysis Start Time | The time at which the you start analysis. The format of the Analysis Start Time appears as a timestamp in the format <MM-DD-YYYY> <HH:MM:SS>. |
| Analysis Time       | The time taken in seconds to complete the analysis. |
| Score               | Number of parameters passed / Total number of parameters. |
| Parameter           | The parameter name against which [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] performs analysis. |
| Category            | The category name under which best practices rules classifies the parameter. |
| Result              | The analysis result of the parameter. |

You must expand a parameter to see the details, which illustrate the following:

| Element | Description |
|---------|-------------|
| Current Value | This is the value you configure. |
| Recommended Value | This is the value that [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] recommends configuring. |
| Description | This is the description about the parameter. |
| Mitigation Steps | These are the steps that you must perform to mitigate the issue.</br> **Note:** The mitigation steps appear when the report displays an error or warning.|

## Locate Best Practices Analyzer report

The Best Practices Analyzer reports that you generate are maintained at the following location on the client computer:

`C:\Users\\\<User>\AppData\Roaming\Microsoft\Microsoft
Dynamics® 365 Unified Service Desk\\\<Version>\BPA\BPALogs\`

