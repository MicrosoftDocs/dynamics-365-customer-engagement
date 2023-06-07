---
title: Overview of data model customization
description: Learn what is data model customization and how does it work to help you.
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

## What is data model model customization?

Dynamics 365 Customer Service provides a suite of out-of-box analytic dashboards that are built on Power BI. These analytic solutions provide industry standard KPIs and metrics that can help you monitor and improve the performance of your contact center. Power BI solutions deploy two components – data model (sometimes referred as data set) and report. The data model houses the KPI while reports  help visualize this data for supervisors.  

Every organization that has analytics enabled gets the analytics solution deployed and available only to them. Dynamics 365 leverages the data from Dataverse, performs transformation logic for each of the KPIs and makes these KPIs available for you within these data model, thus making these uneditable.

However, the reports that are deployed for your organization are editable and customizable. With visual customization, you can edit the reports to present the available data available as per your organizational requirements. For example, Dynamics 365 reads all the required data, performs the logic required to calculate the average handle time and makes it available for you in the data model. You can choose to edit and present this as a chart or a table, as required and drill down to see the average handle time for a queue or user. Visual customizations also give you the ability to reveal hidden metrics, create new pivots, and analyze data with additional dimensions. 

### Scenario-based use cases

The following section describes scenarios where you might need to modify the available data or the logic used to calculate the metrics in the dataset. These are typically driven by processes unique to your organization.

- **Scenario 1**: You need to create variants of the default metrics provided in the data set, that are similar, but are different in the logic used. For example, while service-level metrics for 10, 20, 30, 40, 60 and 120 sec are provided in the Omnichannel real-time reports, you have a team that works on service levels of 150 seconds and wants to see that metric on the reports.  

- **Scenario 2**: Your organization calculates a metric that is provided differently by default, but would like to compute it based on your organization's logic. For example, only the time spent by the primary agent (active agent who is owning and assigned to the conversation) is considered when calculating average handle time. For more information,on metrics, go to: [Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics). Time spent by SMEs consulting is offered as a separate metric. Your organization wants to include this time in the handle time.

- **Scenario 3**: Your organization has customized attributes on the out-of-the-box Dynamics entities or has custom entities to support your workflows and process and would like to include those attributes, metrics built on those attributes on the reports. In addition, your organization wants to report on out-of-box attributes that aren't included in the reports or the data set by default. For example, your organization has customized user entity to include a region attribute and would like to get a drill down of the resolution time by region.  

- **Scenario 4**: Your organization wants to build custom dashboards that bring data from multiple applications that your organization uses. For example, you might have an existing Power BI dashboard that brings operational data from your workforce management systems, and you would like to show Dynamics data like agent presence on these dashboards.

## How data model customization helps you

Data model customization helps you with [scenarios](#scenario-based-use-cases) and more. Data model customization deploys a copy of data set used by out-of-the-box reports into your organization’s Power BI workspace, allowing you to build [composite models](/power-bi/transform-model/desktop-composite-models#enable-the-preview-feature).

For historical data model, the dataset connects to the Azure Data Lake that hosts the transformed historical Dynamics data and exposes the metrics. For real-time data model, the data set uses TDS connectors to connect directly to your Dynamics database and executes the logic needed to compute the real-time metrics.

By creating a local model within your workspace that connects to the Dynamics data model, you can create new metrics while retaining all the out-of-the-box metrics, thus saving time and effort. You can add the Dynamics data model to existing reports without having to rebuild them.  
 
By leveraging the model and not recreating metrics that are available in out-of-the-box model, also ensures that the logic used to calculate these metrics always stay updated.
  
## How data model customization works

Data model customization requires your organization to have a paid Power BI service and uses two workspaces within your Power BI service.

### Managed workspace

This workspace is provisioned and maintained by Microsoft Dynamics 365 Customer Service. The Dynamics datasets are deployed into this workspace.  

- For real-time data model configuration, a workspace named **Omnichannel Managed Workspace_(GUID)** is created. The real-time data model is hosted within this workspace. It uses TDS connector to extract data from Dynamics continuously and to calculate real-time metrics.  

- For historical data model configuration, a workspace named **Customer Service Managed Workspace__(GUID)** is created. The historical data model is hosted in this workspace. This data model is refreshed daily with the latest data from the Azure Data Lake. Historical data from the last two years is processed daily and transformed into KPI stored in the data lake.

> [!NOTE]
> This single data model supports both case and conversation analytics. Knowledge analytics and unified routing analytics aren't available for customization.  

Each time the out-of-the-box data model is updated because of newer release versions, the data model deployed to managed workspace is also updated to ensure that your organization gets the latest updates, which includes newer metrics, updates to logic of existing metrics and bug fixes.  
 
> [!NOTE]
> We recommend treating the data set in the managed workspace as read-only. We recommend that you don't make changes to this dataset, as it might lead to the malfunctioning of the report. Any changes made to the data model in the managed workspace will be overwritten whenever a newer version is released.  

### Customer workspace

A copy of the out-of-the-box reports are created in this workspace. During the configuration, you can either create a new workspace or can specify an existing workspace. 

Depending on the features you have enabled, you may see up to three different reports created in the workspace you selected for historical model customization and one report in the real-time model customization. Each report is connected to its own composite data set, which in turn connects to the data model in the managed workspace.
 
These report copies can be edited and updated to suit your needs and are provided as a base for you to build upon, instead of having to build entire reports from scratch. These reports are created only when the feature is configured and are never updated. These reports will not be overwritten when out-of-the-box reports are updated.  
 
You can choose to specify the same workspace for both historical and real-time analytics.

## See also
[Customize data models of historical analytics reports in Customer Service](model-customize-reports.md#customize-data-models-of-historical-analytics-reports-in-customer-service)  
[Customize visual display](customize-reports.md#customize-visual-display)
