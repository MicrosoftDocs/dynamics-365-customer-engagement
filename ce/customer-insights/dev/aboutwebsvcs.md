---
title: About Microsoft Dynamics 365 for Customer Insights Web Services (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: 
keywords: Customer Insights; web services; 
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/01/2016
ms.topic: get-started-article
ms.service: customer-insights 
ms.assetid: dad2bb65-a0f5-4b13-8342-12964c76cc40
---

About Customer Insights Web Services
====================================

[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]


## When you will use these web services
The service offers RESTful APIs to configure and consume, model, and report on your business data and processes. You would commonly use these APIs to do the following:
1. Automate the modeling, configuration of the system. Let’s say that you run a bank. For your business let’s say that you want to have deeper insights in about and across individual customers, bank branches, employees etc. You would create and model Profiles for those. Similarly, you would model the actions performed by these profiles as Customer Insights interactions. You would also define a few KPIs to be calculated on these. Now all of these you might want for a test system, production system, may be a different one for different region. APIs help you automate all of the modeling and configuration for Customer Insights
2. Consume the data. Customer Insights stores and computes insights for your business. You might want to consume the data in one of your existing portals, tools etc. Customer Insights provides performant and powerful APIs to query and consume the data.
3. Push new data. Let’s say for your bank customers leave feedback about their branch visit. You might want to send that data to Customer Insights in real time or submit files that are produced daily by your existing system. Customer Insights exposes fast, secure and reliable APIs for pushing data.
4. Create custom solutions. ISVs can build and configure models for different domains with data connectors using Customer Insights API. That enables a customer to just run an ISV solution and have the whole model created and system configured automatically.

## How you will use these web services  
Customer Insights currently offers the following ways to use the web services:  
1. REST APIs—the Azure Resource Manager [(ARM) API](../ref/armapiref.md) and the [Hub API](../ref/hubapiref.md)—described in this document. For more information, see [API Requests and Responses](../ref/requestreponse.md).
2. Azure PowerShell and [ARM templates](https://azure.microsoft.com/en-us/documentation/articles/resource-group-authoring-templates/) will be provided separately.  

## About the two REST APIs
Customer Insights APIs are divided in two sections: Azure Resource Manager (ARM) and Hub APIs.  

Dynamics 365 for Customer Insights is registered with [Azure Resource Manager](https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-overview) as a standard resource provider named "Microsoft.CustomerInsights". This provider exposes its own API—the Customer Insights Azure Resource Manager [(ARM) API](../ref/armapiref.md).  All of Customer Insights Azure portal, Azure PowerShell and Azure SDK functionality works on top of Customer Insights ARM APIs.

The Microsoft.CustomerInsights provider also declares primary resources named "Hub".  A hub represents a complete set of billable functionality. Each hub also exposes its own API—the Customer Insights [Hub API](../ref/hubapiref.md).

Much commonality exists between the functionality provided by these two APIs, as detailed in [Customer Insights API Quick Reference](../ref/apiquickref.md).


