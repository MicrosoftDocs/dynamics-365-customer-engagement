---
title: In this release
description: This section describes the constraints in this version of Customer Insights.
keywords: dynamics 365; customer insights
Applies_to: Dynamics 365 for Customer Insights
author: jimholtz
ms.author: jimholtz
manager: brycho
ms.date: 07/03/2017
ms.topic: get-started-article
ms.service: customer-insights 
ms.assetid: aa7dac0d-a959-46ff-a7e0-dc06a429d419
---
In this release
===============
[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

The current release of [!include[pn-customer-insights](../../includes/pn-customer-insights-full.md)] has a few constraints. 

##Management interfaces

The current release supports management for [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] through:

-   The Azure portal

-   [REST APIs](../ref/progref.md)

##Data sources

In the Preview release, [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] supports ingestion of data through the following supported mechanisms:

-   From CSV files on Azure Storage

-   From a [!include[pn-crm-online-subsequent](../../includes/pn-crm-online-subsequent.md)] instance

-   Through [Hub Data](../ref/hubdataapiref.md) REST APIs

Additional data sources will be added later.

##Applications

The current release includes the [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] application, which provides rich, customizable visualization capabilities for your data and insights. Over a dozen different chart controls are included in this release. Additional controls will be added in future releases.

##Constraints and known issues

The current release of [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] has constraints on some behaviors:

-   PowerShell support <!-- and a .NET SDK for management of Customer Insights-->is available for Preview.

-   Only the creation and update of profile instances is supported. They cannot be deleted.

-   Interactions are immutable, and cannot be updated or deleted by design.

-   Links cannot be updated.

-   Roles can be created or deleted, but they cannot be edited.

-   KPIs are supported only on a single profile or interaction instance. Also, only a single operation is supported for each KPI.

-   KPI processing begins from the time that a KPI is defined. It applies only to the current and future periods from the time the KPI is added. KPI values are not computed for past computation windows.
