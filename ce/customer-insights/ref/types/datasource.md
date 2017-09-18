---
title: DataSource Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: The DataSource type identifies the source for data used to create instances.
keywords: Customer Insights; type; data source
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 07/26/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: d58558ce-33f3-4c61-b0c2-55223b5c18a0
---

DataSource Type Definition
===========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

The DataSource type identifies the source of information that is used to create entity instances, required because a single type can have data coming in from multiple sources. Within activities, this information is used to determines precedence rules. Instances of this type are automatically created for and lifetime managed by connector mapping or link enrichment processes.

## DataSource properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|name*|string |Name of the data source, typically either the connector name or the Link defined for the activity (readonly)|
|dataSourceType|string|Type of the data source: ["Connector" \| "LinkInteraction" \| "SystemDefault"] \(readonly)|
|status|string|Data source status: ["None" \| "Active" \| "Deleted "]|
|id|integer|Identifier of the data source (readonly)|
|dataSourceReferenceId|string|Data source reference id (readonly)|
| | | |

