---
title: Overview of data model customization
description: Learn what is data model customization and how it works
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 05/29/2023
ms.custom: bap-template
---

# Overview of data model customization

Data model customization helps you customize the out-of-the-box standard reports and add your own (key performance indicators) KPI and custom metrics to the reports to view the key metrics that are relevant to your organization.

As new features get added, metric definitions and calculations constantly need to be updated to account for additional workflows enabled by new features. Using the out-of-box model and creating only those metrics that are unique to your organization reduces the risk of metric definitions being outdated.

## What is data model model customization

Dynamics 365 Customer Service provides a suite of out-of-box analytic dashboards that are built on Power BI. These analytic solutions provide industry standard KPIs and metrics that can help you monitor and improve the performance of your contact center. Power BI solutions deploy two components – data model (sometimes referred as data set) and report. The data model houses the KPI while reports  help visualize this data for supervisors.  

### How does data model model customization help you

Every organization that has analytics enabled gets the analytics solution deployed and available only to them. Dynamics 365 leverages the data from Dataverse, performs transformation logic for each of the KPIs and makes these KPIs available for you within these data model, thus making these uneditable.

However, the reports that are deployed for your organization are editable and customizable. With visual customization, you can edit the reports to visualize the data available in the data set as required by your organization. For example, Dynamics 365 reads all the required data, performs the logic required to calculate the average handle time and makes it available for you in the data model. You can choose to edit and present this as a chart or a table, as required and drill down to see the average handle time for a queue or user. Visual customizations also give you the ability to reveal hidden metrics, create new pivots, and slice data with additional dimensions.  

### Scenario-based use cases

Sometimes, you may run into scenarios where you would like to modify the data available in the data set or the logic used to calculate the metrics in the dataset. These are typically driven by processes unique to your organization. Some common scenarios are:  

- **Scenario 1**: You are trying to create variants of metrics that we provide in the data set, that are similar but differ a little in logic. For example, while we provide Service level metrics for 10, 20, 30, 40, 60 and 120 seconds in the Omnichannel real-time reports, you have a team that promises service levels of 150 seconds and wants to see that metric on the reports.  

- **Scenario 2**: Your organization calculates a metric that is provided out-of-box differently (refer to OC metric) and would like to compute it based on your logic. For example,only the time spent by the primary agent (active agent who is owning and assigned to the conversation) is considered when calculating average handle time. Time spent by SMEs consulting is offered as a separate metric. Your organization wants to include this time in the handle time.

- **Scenario 3**: Your organization has customized attributes on out-of-box Dynamics entities or has custom entities to support your workflows and process and would like to include those attributes, metrics built on those attributes on the reports. In addition, your organization wants to report on out-of-box attributes that are not included in the reports or the data set by default. For example, your organization has customized user entity to include a region attribute and would like to get a drill down of resolution time by region.  

- Scenario 4: Your organization wants to build custom dashboard**Scenario 4**s that bring data from multiple applications your organization uses. For example, you might have an existing Power BI dashboard that brings operational data from your workforce management systems, and you would like to show Dynamics data like agent presence on these dashboards.  

## How does data model customization work

Model customization requires your organization have a paid Power BI service and uses two workspaces within your Power BI service.   

Managed workspace: This workspace is provisioned and maintained by Microsoft Dynamics 365 Customer Service. The Dynamics datasets are deployed into this workspace.  

When configuring real-time model customization, a workspace of name “Omnichannel Managed Workspace_<GUID>” is created. The real-time data model is hosted within this workspace. It uses TDS connector to pull data from Dynamics continuously and to calculate the real-time metrics.  

When configuring historical model customization, a workspace of name “Customer Service Managed Workspace__<GUID>” is created. The historical data model is hosted in this workspace. This model is refreshed daily with the latest data from the Azure data lake. Historical data from the last two years is processed daily and transformed into KPIs stored in the data lake.   
 
Note: This single data model supports both case analytics and conversation analytics. Knowledge analytics and Unified routing analytics are not available for customization.  

Every time the out-of-box model is updated as we release newer versions, the data model deployed to managed workspace is also updated to ensure that your organization gets the latest updates – including newer metrics, updates to logic of existing metrics and bug fixes.  
 
Note: We recommend treating the data set in the managed workspace as read-only. We recommend that you don't make changes to this dataset, as it might lead to the malfunctioning of the report. Any changes made to the model in the managed workspace will be overwritten whenever a newer version is released.  

Customer workspace: A copy of the out-of-box reports are created in this workspace. During the configuration, you can either create a new workspace or can specify an existing workspace. Depending on the features you have enabled, you may see up to three different reports created in the workspace you selected for historical model customization and one report in the real-time model customization. Each of the reports themselves are connected to their own composite data set that in turn connect to the data model in the managed workspace.
 
These report copies can be edited, and updated to suit your needs and are provided as a base for you build upon instead of having to build entire reports from scratch. These reports are created only when the feature is configured and are never updated. These reports will not be overwritten when out-of-box reports are updated.  
 
Note: You can choose to specify the same workspace for both historical and real-time analytics.


## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
