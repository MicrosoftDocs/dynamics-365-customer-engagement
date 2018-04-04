---
title: "Work with Best Practices Analyzer | MicrosoftDocs"
description: "Learn about how to work with Best Practices Analyzer and access and read the Best Practices Analysis report."
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
ms.assetid: "4BACD2D6-A17D-468D-A2CB-F4BEEF06AE5E"
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Work with Best Practices Analyzer

Best Practices Analyzer is a hosted control that help you analyze the
various parameters of your local computer (System Configurations and
Unified Service Desk), Unified Service Desk configurations in Dynamics
365, and Internet Explorer settings in your local computer. After the
analysis, Best Practices Analyzer displays a report that recommends
mitigation steps in case of warning or error.

Unified Service Desk works best when you handle the warning and error as
per the recommendation, which helps you to serve your customers without
interruption.

## Start Analysis

To analyze parameters on your computer, Unified Service Desk
Configurations, and Internet Settings, against the best practices rules, perform the following:

1.  Log on to Unified Service Desk Client application.

2.  Click **BEST PRACTICES ANALYZER** button in the toolbar area.

3.  Click **Start Analysis** button in the leftmost pane to see the
    report.

Best Practices Analyzer displays the report for you to help make the
next steps.

**Note:** When you relaunch Unified Service Desk and click on **BEST
PRACTICES ANALYZER**, the last report that was generated appears in the
report area.

## Read Best Practices Analyzer Report

The section describes the layout of Best Practices Analyzer report and
how to understand the results of the analysis.

The report displays the following elements:

| **Element**         | **Description**                                                                                                                                           |
|---------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------|
| Computer Name       | Local computer name on which Best Practices Analyzer performed the analysis.                                                                              |
| Analysis Start Time | The time at which the you start analysis. The format of the Analysis Start Time appears as a timestamp in the format &lt;MM-DD-YYYY&gt; &lt;HH:MM:SS&gt;. |
| Analysis Time       | The time taken in seconds to complete the analysis.                                                                                                       |
| Score               | Number of parameters passed / Total number of parameters.                                                                                                 |
| Parameter           | The parameter name against which Best Practices Analyzer performs analysis.                                                                               |
| Category            | The category name under which best practices rules classifies the parameter.                                                                              |
| Result              | The analysis result of the parameter.                                                                                                                     |

You must expand a parameter to see the details which illustrates the
following:

<table>
<thead>
<tr class="header">
<th><strong>Element</strong></th>
<th><strong>Description</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>Current Value</td>
<td>This is the value you configure.</td>
</tr>
<tr class="even">
<td>Recommended Value</td>
<td>This is the value that Best Practices Analyzer recommends configuring.</td>
</tr>
<tr class="odd">
<td>Description</td>
<td>This is the description about the parameter.</td>
</tr>
<tr class="even">
<td>Mitigation Steps</td>
<td><p>These are the steps that you must perform to mitigation the issue.</p>
<p><strong>Note:</strong> The Mitigation steps appear when the report displays error or warning.</p></td>
</tr>
</tbody>
</table> 

## Locate Best Practices Analysis Report

The best practices analysis report that you generate are maintained at
the following location on the client computer:

**C:\\Users\\&lt;User&gt;\\AppData\\Roaming\\Microsoft\\Microsoft
Dynamics® 365 Unified Service Desk\\&lt;Version&gt;\\BPA\\BPALogs\\**

