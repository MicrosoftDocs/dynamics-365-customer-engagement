---
title: Hub Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: The Hub type represents the Azure Hub resource.
keywords: Customer Insights; type; hub
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/31/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: d58558ce-33f3-4c61-b0c2-55523b5c18a1
---

Hub Type Definition
====================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

The Hub type represents the Azure Hub resource. It is allocated and managed according to the standard [Azure Resource Manager](https://docs.microsoft.com/azure/azure-resource-manager/resource-group-overview) model.

## Properties

Property names appended with asterisks* are required.

### Hub properties

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|id|string|Hub resource identifier (readonly)|
|name*|string|Hub name (readonly)|
|type|string|Azure resource type|
|location|string|[Azure hosting region](https://azure.microsoft.com/regions/)|
|properties|HubPropertiesFormat[ ]|Additional properties of the hub (see below)|
|tags|map[string, string]|Resource tags|
| | | |


### HubPropertiesFormat properties

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|apiEndpoint|string|URL of the API endpoint for the hub (readonly)|
|webEndpoint |string|URL of the web application endpoint associated with this hub (readonly)|
|provisioningState|string|Hub provisioning state: ["Provisioning" \| "Succeeded" \| "Expiring" \| "Deleting" \| "HumanIntervention" \| "Failed" ] \(readonly)|
|tenantFeatures|integer|Bit flags for enabled hub features: 1 indicates enabled whereas 0 indicates disabled. Bit 0-graph; bit 1-hub; other bits are reserved.|
|hubBillingInfo|HubBillingInfo|Customer billing information for the hub (see below)|
| | | |

### HubBillingInfo properties

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|skuName|string|The Stock Keeping Unit that uniquely identifies the service plan|
|minUnits|integer|Minimum number of billable units|
|maxUnits|integer|Maximum number of billable units|
| | | |

The billing schedule for Customer Insight usage has not been finalized, but may be based upon the size of the data store, the number of ingestion, analysis and reporting operations, and so on. 


## JSON example
```{json}
{
    "id": "testHub2839",
    "location": "East US",
    "name": "TestHub2839",
    "type": "Microsoft.CustomerInsights/hubs",
    "tags": {
    },
    "properties": {
        "apiEndpoint": "https://testHub2839.api.azurecustomerinsights.com",
        "webEndpoint": "https://testHub2839.apps.azurecustomerinsights.com",
        "provisioningState": "Creating",
        "hubBillingInfo": {
            "skuName": "B0",
            "minUnits": 1,
            "maxUnits": 5
        },
        "tenantFeatures": 0
    }
}
```
