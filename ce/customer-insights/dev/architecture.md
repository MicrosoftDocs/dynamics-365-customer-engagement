---
title: Microsoft Dynamics 365 for Customer Insights Architecture (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: 
keywords: Customer Insights; web services; architecture
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/31/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: dad2bb65-a035-4bc3-8342-12964c76fc41
---

Customer Insights Architecture
==============================

[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

The following diagram depicts the high-level logical architecture of Customer Insights.

![High-level logical architecture](../media/HighLevelArch.png "High-level logical architecture") 

This diagram contains the following components:

|**Component**|**Description**|
| --------------- | ---------- |
|_Dynamics 365 for Customer Insights Applications_|Represents applications that are built upon or rely upon the _Customer Insights Service_. This includes client applications generated in the Microsoft Azure Portal for this service, but also vertical applications and features built into Dynamics 365 (such as [Relationship Insights](https://www.microsoft.com/dynamics/crm-customer-center/preview-feature-relationship-insights-overview.aspx)), and third-party applications and solutions. Customer Insights applications are online-only applications typically accessed through URLs of the form:  <br> `https://<app-name>.apps.azurecustomerinsights.com/`
|_Data Sources_|Represents the wide range of possible information that Customer Insights can consume, which include data from other Microsoft Dynamics applications, third party applications, other Azure web services, and general online data sources|
|_Customer Insights Service_|The Azure service that provides the processing for all of the applications on a Customer Insights Hub. At its core is the Data Layer, which provides data representation and storage. Next, the data services layer enables importation and analysis of that data. Finally, the top data access layer provides input/output (i/o), user experience (UX), and programmatic interfaces.|
|_Azure Infrastructure_|The required standard Azure management and runtime services, including:  <br>  ● [Azure Service Fabric](https://docs.microsoft.com/azure/service-fabric/service-fabric-overview) provides the reliable and scalable foundation.  <br>  ● [Azure Resource Manager](https://docs.microsoft.com/azure/azure-resource-manager/resource-group-overview) provides a consistent, integrated management and deployment model. Customer Insights exposes a large percentage of its programmatic surface in its associated Customer Insights [Azure Resource Manager (ARM) API](../ref/armapiref.md).  <br>  ● [Azure Active Directory (AD)](https://msdn.microsoft.com/library/azure/mt168838.aspx) provides the primary authentication mechanism for Dynamics 365 Online applications.  <br>  ● [Azure SQL](https://docs.microsoft.com/azure/sql-database/sql-database-technical-overview) provides a widely used data storage service.  <br>  ● [Azure SDKs](https://azure.microsoft.com/downloads/) provide optional language-specific bindings and supplemental materials. |
|_Shared Findings_|Although the Customer Insights application provides the primary analysis and reporting UX, data and analysis results can be exported as Azure blobs, to [Power BI](https://powerbi.microsoft.com), or embedded with Customer Insights UX widgets.|
| | |

For more information about data sources, ingestion, modeling and analysis, see [Working with Data in Customer Insights](./workingwithdata.md). 

