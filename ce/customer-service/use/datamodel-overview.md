---
title: Overview of data model customization
description: Learn about data model customization and how it can help you with your organization's metrics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 02/03/2025
ms.custom: bap-template
---

# Overview of data model customization

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

> [!Note]
> Case information is applicable to Customer Service only.


Data model customization helps you customize the out-of-the-box standard reports and add your own key performance indicators (KPIs) and custom metrics. This customization allows you to use the data that's most relevant to your organization.

As new features are added, metric definitions and calculations continually need to be updated to account for more workflows that new features enable. To reduce the risk of metric definitions becoming outdated, use the out-of-the-box model and create only those metrics that are unique to your organization.

## What is data model customization?

Dynamics 365 Customer Service provides a suite of out-of-the-box analytic dashboards that are built on Power BI. These analytic solutions provide industry standard KPIs and metrics that can help you monitor and improve the performance of your contact center. Power BI solutions deploy two components: a data model (sometimes referred as a dataset) and a report. The data model houses the KPIs, while reports help visualize this data for supervisors.  

Every organization that has analytics enabled gets the analytics solution deployed and available only to them. Dynamics 365 uses the data from Dataverse, performs transformation logic for each of the KPIs, and makes these KPIs available for you within these data models, so you can't edit them.

However, the reports that are deployed for your organization can be edited and customized. With [visual customization](customize-reports.md), you can edit the reports to present the available data as per your organizational requirements. For example, Dynamics 365 reads all the required data, performs the logic required to calculate the average handle time, and makes it available for you in the data model. You can choose to edit and present this data as a chart or a table as required, and drill down to see the average handle time for a queue or user. Visual customizations also give you the ability to apply out-of-the-box metrics that aren't directly exposed, create new pivots, and analyze data with more dimensions.

At times, you might have scenarios where you want to modify the data that's available in the dataset or the logic used to calculate the metrics in the dataset. The following section describes scenarios where you might need to modify the available data or the logic used to calculate the metrics in the dataset. Processes that are unique to your organization typically drive these scenarios.

### Scenario-based use cases

- **Scenario 1**: You need to create variants of the default metrics provided in the dataset that are similar but use a different logic. For example, while service-level metrics for 10, 20, 30, 40, 60, and 120 seconds are provided in the Omnichannel real-time reports, you have a team that works on service levels of 150 seconds and wants to see that metric on the reports.  

- **Scenario 2**: Your organization calculates a metric provided differently by default, but would like to compute it based on your organization's logic. For example, only the time spent by the primary customer service representatives (service representatives or representatives).  Only active service representative who owns and is assigned to the conversation is considered when calculating average handle time. Learn more in [Use report metrics](oc-metrics-dimensions.md). The time SMEs spend consulting is offered as a separate metric. Your organization wants to include this time in the handle time.

- **Scenario 3**: Your organization has customized attributes on the out-of-the-box Dynamics 365 entities, or has custom entities to support your workflows and process and would like to include those attributes, or has metrics built on those attributes in the reports. In addition, your organization wants to report on out-of-the-box attributes that aren't included by default in the reports or the dataset. For example, your organization has a customized user entity to include a region attribute and would like to get a drill-down of the resolution time by region.  

- **Scenario 4**: Your organization wants to build a custom dashboard that brings data from multiple applications that your organization uses. For example, you might have an existing Power BI dashboard that brings operational data from your workforce management systems, and you'd like to show Dynamics 365 data, like service representative presence, on this dashboard.

## How data model customization helps you

Data model customization helps you with [scenarios](#scenario-based-use-cases) and more. Data model customization deploys a copy of the dataset used by out-of-the-box reports into your organization’s Power BI workspace, allowing you to build [composite models](/power-bi/transform-model/desktop-composite-models#enable-the-preview-feature).

For the historical data model, the dataset connects to the Azure Data Lake that hosts the transformed historical Dynamics 365 data and exposes the metrics. For a real-time data model, the dataset uses TDS connectors to connect directly to your Dynamics 365 database and executes the logic required to compute the real-time metrics.

By creating a local model within your workspace that connects to the Dynamics 365 data model, you can create new metrics while retaining all the out-of-the-box metrics, thus saving time and effort. You can add the Dynamics 365 data model to existing reports without having to rebuild them.
 
By using the model and not recreating metrics that are available in the out-of-the-box model, you also ensure that the logic used to calculate these metrics always stays updated.
  
## How data model customization works

Data model customization requires your organization to have a paid Power BI service, and uses two workspaces within your Power BI service.

### Managed workspace

Dynamics 365 Customer Service provisions and maintains this workspace. The Dynamics 365 datasets are deployed into this workspace.  

- For real-time data model configuration, a workspace named **Omnichannel Managed Workspace_(GUID)** is created. The real-time data model is hosted within this workspace. It uses a TDS connector to extract data from Dynamics 365 continually and to calculate real-time metrics.  

- For historical data model configuration, a workspace named **Customer Service Managed Workspace__(GUID)** is created. The historical data model is hosted in this workspace. This data model is refreshed daily with the latest data from the Azure Data Lake. Historical data from the last two years is processed daily and transformed into KPIs stored in the data lake.

> [!NOTE]
> This single data model supports both case and conversation analytics. Knowledge analytics and unified routing analytics aren't available for customization.  

Each time the out-of-the-box data model is updated because of newer release versions, the data model that's deployed to the managed workspace is also updated to ensure that your organization gets the latest updates, which include newer metrics, updates to logic of existing metrics, and bug fixes.  
 
> [!NOTE]
> We recommend treating the dataset in the managed workspace as read-only. We recommend that you don't make changes to this dataset, as it might lead to report malfunction. Any changes made to the data model in the managed workspace will be overwritten whenever a newer version is released. 

### Customer workspace

A copy of the out-of-the-box reports is created in this workspace. During the configuration, you can either create a new workspace or specify an existing workspace.

Depending on the features you enabled, you may see up to three different reports created in the workspace you selected for historical data model customization and one report in the real-time data model customization.

### [Historical data model customization](#tab/historicaldatamodelcustomization)

:::image type="content" source="../media/custom-hist.png" alt-text="Customer workspace for historical data model":::

### [Real-time data model customization](#tab/realtimedatamodelcustomization)

:::image type="content" source="../media/custom-realtime.png" alt-text="Customer workspace for real-time data model":::

---

Each report is connected to its own composite dataset, which in turn connects to the data model in the managed workspace.
 
These report copies can be edited and updated to suit your needs, and are provided as a base for you to build on instead of having to build entire reports from scratch. These reports are created only when the feature is configured, and are never updated. These reports aren't overwritten when out-of-the-box reports are updated.  

You can choose to specify the same workspace for both historical and real-time analytics.

> [!NOTE]
> Supervisor actions like assign, transfer, monitor, and force close aren't available for model customized reports.

## Related information
[Dataverse entities used in historical and real-time analytics](dataverse-entities.md#dataverse-entities-used-in-historical-and-real-time-analytics)  
[Customize data models of historical and real-time analytics reports](../administer/model-customize-reports.md#customize-data-models-of-historical-and-real-time-analytics-reports)  
[Customize visual display](customize-reports.md#customize-visual-display)
