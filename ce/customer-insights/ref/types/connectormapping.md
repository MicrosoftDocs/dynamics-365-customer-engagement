---
title: ConnectorMapping Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: Defines the metadata and data sources for each Profile or Interaction type. 
keywords: Customer Insights; type; Connector Mapping

author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 07/26/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: ea4f092a-4c15-418c-98c5-90c45325a8b9
---

ConnectorMapping Type Definition
================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Once a [Connector](connector.md) channel is established, a ConnectorMapping can be created to define the metadata and data sources for each associated [Profile](profile.md) or [Interaction](interaction.md) type. 


## Properties

Property names appended with asterisks* are required.

### ConnectorMapping properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|connectorName|string|Name of the associated connector (readonly)|
|connectorMappingName|string |Name of the mapping (readonly)|
|connectorType|string|[ "None" \| "CRM" \| "AzureBlob" \| "Salesforce" \| "ExchangeOnline" \| "Outbound" ]|
|created|string (Datetime)|Creation time of the mapping (readonly)|
|lastModified|string (Datetime)|Last modified time of the mapping (readonly)|
|displayName|string|Display name for the mapping|
|description|string|Description for the mapping|
|dataFormatId|string|Identifier of the data format (readonly)|
|entityType*|string|Mapped entity type ["None \| "Profile" \| "Interaction" \| "Relationship"]|
|entityTypeName*|string|Name of the mapped entity type|
|mappingProperties*|ConnectorMappingProperties[ ]|Collection of additional properties for the mapping (see below)|
|nextRunTime|string (Datetime)|Next run time based on customer's settings |
|runId|string|Execution identifier (readonly)|
|state|string|[ "Creating" \| "Created" \| "Ready" \| "Expiring" \| "Deleting" \| "Failed" ] \(readonly)|
|tenantId|string|Hub name (readonly)|
| | | |
<br/>

### ConnectorMappingProperties properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|folderPath|string|Folder path for the mapping|
|fileFilter|string|File filter for the mapping|
|hasHeader|boolean|Indicates whether the file contains header or not|
|availability*|ConnectorMappingAvailability|Availability of mapping property (see below)|
|completeOperation*|ConnectorMappingCompleteOperation|Operation to perform on import file after mapping (see below)|
|errorManagement*|ConnectorMappingErrorManagement|Error management behavior (see below)|
|format*|ConnectorMappingFormat|Format of mapping property (see below)|
|structure* |ConnectorMappingStructure[ ]|Ingestion mapping information at property level (see below)|
| | | |

### ConnectorMappingAvailability properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|frequency|string|Time unit: ["Minute" \| "Hour" \| "Day" \| "Week" \| "Month"]|
|interval*|int|Combined with Frequency to specify time interval. The minimal frequency we allowed is 15 minutes.|
| | | |

### ConnectorMappingCompleteOperation properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|completionOperationType|string|Operation to perform on the import file after successful mapping: [ "DoNothing" |\ "DeleteFile" \| "MoveFile" |
|destinationFolder|string|Destination folder where files are moved after importation (only valid for "MoveFile") |
| | | |

### ConnectorMappingErrorManagement properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|errorManagementType*|string|Specifies action on error: ["RejectAndContinue" \| "StopImport" \| "RejectUntilLimit"]|
|errorLimit|int|Specifies the maximum number of errors allowed in a data import operation|
| | | |

### ConnectorMappingFormat properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|formatType*|string|Type of formatting, currently only: "TextFormat"|
|columnDelimiter|string|Column delimiter used, e.g. ",", ";", "-"|
|acceptLanguage|string|OData language spec|
|quoteCharacter|string|Quote character to indicate enquoted fields|
|quoteEscapeCharacter|string|Escape character for quotes, if required|
|arraySeparator|string|Character to separate array elements|
| | | |

### ConnectorMappingStructure properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|propertyName*|string|Property name of the mapping entity|
|columnName*|string|Column name within the import file|
|customFormatSpecifier|string|Custom format specifier for input parsing|
|isEncrpted|boolean|True if the the column is encrypted; otherwise false|
| | | |


## JSON example
```{json}
{
    "connectorMappingName": "testMapping12491",
    "connectorName": "testConnector8858",
    "connectorType": "AzureBlob",
    "dataFormatId": "4619d4e7e8a64c1e9bc34907f9f46505",
    "description": "Test mapping for data #12491",
    "displayName": "Test Mapping #12491",
    "entityType": "Interaction",
    "entityTypeName": "TestInteractionType2967",
    "fileFilter": "unknown",
    "folderPath": "http://contoso.com/file",
    "hasHeader": false,
    "state": "Created",
    "tenantId": "sdktesthub"
	"type": "Microsoft.CustomerInsights/hubs/connectors/mappings"
    "mappingProperties": {
        "availability": {
            "frequency": "Hour",
            "interval": 5
        },
        "completeOperation": {
            "completionOperationType": "DeleteFile",
            "destinationFolder": "fakePath"
        },
        "errorManagement": {
            "errorLimit": 10,
            "errorManagementType": "StopImport"
        },
        "format": {
            "columnDelimiter": "|",
            "acceptLanguage": "",
            "quoteCharacter": "\\\"",
            "quoteEscapeCharacter": "\\\"",
            "formatType": "TextFormat",
            "arraySeparator": ";"
        },
        "structure": [{
            "columnName": "unknown1",
            "isEncrypted": false,
            "propertyName": "unknwon1"
            },
            {
            "columnName": "unknown2",
            "isEncrypted": true,
            "propertyName": "unknwon2"
        }]
	},
}

```
