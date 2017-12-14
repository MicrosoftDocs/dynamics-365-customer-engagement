---
title: Azure Resource Manager (ARM) API Reference
description: These APIs are exposed by the Customer Insights Azure Resource Provider.
keywords: Customer Insights; ARM API;
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 4efa104f-032c-4eb5-b731-5a2122b7e32f
---
Azure Resource Manager (ARM) API Reference
==========================================

[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

These APIs are exposed by the Customer Insights Azure Resource Provider, and for callers are only accessible through Azure Resource Manager 
([ARM](https://azure.microsoft.com/en-us/documentation/articles/resource-group-overview/)). (Note that the 
[Azure Resource Manager REST API](https://msdn.microsoft.com/en-us/library/azure/dn790568.aspx) is provided for programmatically working with this parent service directly.)

Because Customer Insights is a standard Azure service, its ARM APIs are available in two supplemental forms:
* Client libraries are included in the language-specific [Azure SDKs](https://azure.microsoft.com/downloads/).
* The [Swagger](http://swagger.io/) definition file, along with samples, can be downloaded from the [azure-rest-api-specs](https://github.com/Azure/azure-rest-api-specs/tree/master/arm-customer-insights) GitHub repository.  

The Customer Insights ARM API provides RESTful services to perform the following functions:
* Manage the Customer Insights Hub
* Manage access policies and roles assignments for a hub 
* Manage the customer Insights Data Connectors
* Manage application views and widgets
* Work with Customer Insights Profiles, Interaction, Links, and KPI types
* Associate images with entity types and instances

Once a Customer Insights Hub is programmatically or administratively created, the hub endpoint can then be used to call the [Hub APIs](hubapiref.md). There is much functionality overlap between the ARM and Hub APIs, as detailed in [Customer Insights API Quick Reference](apiquickref.md).  

## Authentication to ARM APIs
Authentication is through Azure Active Directory ([AAD](https://azure.microsoft.com/en-us/services/active-directory/)), just as for any other APIs based upon the ARM Resource 
Provider (RP).  For more information see the following articles:
* [How to use Azure Active Directory and Resource Manager to manage a customer’s resources](https://azure.microsoft.com/en-us/documentation/articles/resource-manager-api-authentication/)
* [Authenticating Azure Resource Manager requests](https://msdn.microsoft.com/en-us/library/azure/dn790557.aspx)

