---
title: Connector Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: Data connectors enable Customer Insights to consume different types of data sources, on an on-going basis and at scale.
keywords: Customer Insights; type; Connector
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 07/26/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f0ffd5a7-3cbe-4604-9ec3-3df0cfe03560
---

Connector Type Definition
===========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Data connectors enable Customer Insights to consume different types of data sources, on an on-going basis and at scale.   Connectors create, schedule, orchestrate 
and manage data pipelines. For the initial release, connectors for [Azure Storage](https://azure.microsoft.com/en-us/services/storage) (blob containers), 
[Dynamics 365](https://www.microsoft.com/en-us/dynamics/dynamics-365) (CRM Online), Microsoft Social Engagement, Exchange Online and Outbound connectors <!-- and [Salesforce](https://www.salesforce.com/) --> are (or will shortly be) provided. The exact functioning of a connector will largely depend on the nature of 
its data source and connecting channel. 

Connectors that handle dynamic data, including the Outbound Connector, will auto-refresh periodically (typically every 15 minutes by default). After their initial execution, they will only process records that are time-stamped after the previous execution. 

### Azure Storage Connector 
This connector automatically ingests blob containers which contain a comma-separated-values (CSV) data sets and has the following characteristics:
* Typically each blob is associated to a CSV file which is uploaded to Azure Storage, and filename patterns can be mapped to associated entities.
* Each blob is typically used to initialize instances of an [Interaction](./interaction.md) or [Profile](./profile.md) (via a [Link](./link.md)) type during the 
initial read, then periodically updates that entity as that blob is updated. 
* Each column is mapped to an entity property through attribute mappings.
* Access to the Azure Storage account is secured through the use of Azure [Key Vault](https://azure.microsoft.com/en-us/services/key-vault). 

### Dynamics 365 (CRM Online) Connector
This connector implicitly understands CRM schemas and entities, enabling CRM entities to be mapped to Profile or Interaction types. After such a mapping, the 
connector automatically keeps data and metadata changes synchronized between CRM and Customer Insights. Configuration requires CRM Organization Administration 
credentials.  

### Microsoft Social Engagement Connector
This connector brings in tweets from Microsoft Social Engagement service.The data is ingested into interaction type. To configure this, you would need [Microsoft Social Engagement Administration](https://docs.microsoft.com/dynamics365/customer-engagement/social-engagement/administer-microsoft-social-engagement) credentials.

### Exchange Online Connector
This connector extracts email and meeting data from Exchange Online and ingests it into interaction types. It also creates links between these interaction types and corresponding profiles that were chosen during configuration. [Exchange Online Administrator](https://support.office.com/article/About-the-Exchange-Online-admin-role-097ae285-c4af-4319-9770-e2559d66e4c8) credentials are needed to configure this.

### Outbound Connector
This connector exports Profile and KPI data to a specified Azure blob storage, where this data can be subsequently ingested by another application or service.  Each entity instance or KPI will be written as CSV entries in the following blobs:
* Type definition (metadata) for each entity type will be written to: `Metadata/<type>/<Name>/metadata.json`
* Profile instance data will be written to: `Profile/<profileName>/year=<yyyy>/month=<mm>/day=<dd>/hour=<hh>/min=<nn>/data.csv`, where minutes are in multiples of 15. An additional `System_ProcessingTime` field is added to each record that indicates when the profile instance was last processed in Customer Insights.
* KPI data will be similarly written to `KPI/<kpiName>/year=<yyyy>/month=<mm>/day=<dd>/hour=<hh>/min=<nn>/data.csv`

Each CSV blob have column names as the first (header) row. All values in a single record are comma-separated, with the exception of array types, where multiple values for a single field are semicolon separated.

The Profile scheduler will refresh every 15 minutes by default. The KPI scheduler will run daily to calculate KPIs, which it then exports. The Outbound Connector automatically deletes blobs older than 21 days. 


<!-- ### Salesforce Connector, Others?  -->

<br/>

## Connector properties

This entity type contains properties that are common to all connector types. Property names appended with asterisks* are required.

|**Property**|**JSON Type**|**Description**|
| --------------- | ---------- | ------------- |
|connectorId|integer|Identifier for the connector (readonly)|
|connectorName*|string|Connector name|
|connectorType*|string|Valid Connector type, currently [ "None" \| "CRM" \| "AzureBlob" \| "SocialEngagement" \| "ExchangeOnline" \| "Outbound" ] |
|displayName|string|Display name for the connector|
|description|string|Description of the connector|
|connectorProperties*|Dictionary\<string, object\>|Collection of additional properties for the connector (see below)|
|created|string (DateTime)|Date and time of creation of connector (readonly)|
|lastModified|string (DateTime)|Date and time when the connector was last modified (readonly)|
|state|string|Current status: [ "Creating" \| "Created" \| "Ready" \| "Expiring" \| "Deleting" \| "Failed" ] \(readonly)|
|tenantId|string|Hub name|
|isInternal|boolean|True if the connector is internal; otherwise false|
| | | |


## Specific connector properties

The property set contained in this type depends upon the connector category, for example Azure Blob, CRM, Outbound, and so on.


### AzureBlobConnectorProperties properties:

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|connectionKeyVaultUrl*|string|The Key Vault secret URL associated with the blob connection string|
| | | |

<br/>

### CrmConnectorProperties properties:

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|connectionString|string|The CRM connection string for the administrator account|
|organizationId*|string|CRM Organization ID|
|organizationUrl*|string|CRM Organization URL|
|entities|CrmConnectorEntities[ ]|CRM entities to synchronize (see below)|
|accessToken|string|The on-behalf access token|
| | | |


#### CrmConnectorEntities properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|logicalName*|string|logical name of the entity|
|displayName|string|Display name for the entity|
|isProfile|boolean|True if entity is type Profile |
| | | |


#### JSON example
```{json}
{ 
    "connectorId": 0,
    "ConnectorName":"ContosoCrmCon", 
    "ConnectorType": "Crm", 
    "DisplayName":"Contoso CRM Data Connector", 
    "Description":"Connector Description", 
        "connectorProperties": {
            "connectionKeyVaultUrl": {
                 "organizationId": "357",
                 "connectionString": "Url=https://contoso.crm.dynamics.com; Username=john.doe@contoso.onmicrosoft.com; Password=xxxxxx;",
                 "organizationUrl": "http://www.contoso.com"
						}
        }
}
```

<br/>

### MseConnectorProperties properties:
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|mseEndPointUrl|string|MSE service URL|
|searchTopics|MseSearchTopic[ ]|List of MSE search topics|
|typeSuffix|string|Type suffix used while creating interaction|
| | | |

#### MseSearchTopic properties:
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|id|string|MSE search topic ID|
|name|string|MSE search topic name|
| | | |


#### JSON example
```{json}
{
    "mseEndPointUrl": "<MSE solution endpoint URL>",
    "searchTopics": [
    {
        "id": "<MSE search topic ID>",
        "name": "<MSE search topic name>",
    }
    ]
}
```

<br/>
### ExchangeOnlineConnectorProperties properties:
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|accessToken|string|access token|
|customerProfileTypes|ExoConnectorProfileType[ ]|List of profile types representing customers|
|employeeProfileTypes|ExoConnectorProfileType[ ]|List of profile types representing employees|
|typeSuffix|string|Type suffix used while creating interactions for emails and meetings|
| | | |

#### ExoConnectorProfileType properties:
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|profileName|string|Profile type name|
|emailFieldNames|string[ ]|List of email field names present on the profile|
| | | |


#### JSON example
```{json}
{
    "accessToken": "<MSE solution endpoint URL>",
    "customerProfileTypes": [
    {
        "profileName": "<profile type name>",
        "emailFieldNames": [ "<email field name>" ],
    }
    ],
    "employeeProfileTypes": [
    {
        "profileName": "<profile type name>",
        "emailFieldNames": [ "<email field name>" ],
    }
    ],
    "typeSuffix": "<Type suffix used while creating interactions for emails and meetings>"
}
```


<br/>

### OutboundProperties properties:
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|entityList|OutboundTypeDefinition[ ]|List of profile and kpi types that is exported|
|outputBlobSASUri|string|Blob SAS URI that contains the exported data|
| | | |

#### OutboundTypeDefinition properties:
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|entityType|string|valid type, [ "Profile" \| "Kpi" ]|
|entityName|string|profile type name or kpi type name|
|fieldNames|string|field names on profile or kpi that are exported|
| | | |


#### JSON example
```{json}
{
    "entityList": [
    {
        "entityType": "<Profile | Kpi>",
        "entityName": "<profile type name or kpi type name>",
	"fieldNames": "<field names on profile or kpi>",
    }
    ],
}
```
