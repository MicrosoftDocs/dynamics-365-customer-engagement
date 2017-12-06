---
title: DataFormat Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: The DataFormat type represents information in a datasource, typically a CSV file uploaded into a blob.
keywords: Customer Insights; type; data format
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: d58558ce-33f3-4c61-b0c2-55223b5c889d
---

DataFormat Type Definition
===========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

The DataFormat complex type is used to represent information in a datasource, for example a CSV file uploaded into a blob.

## DataFormat properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|hasHeader|boolean|Specifiess whether a column header is included in the datasource|
|columnSeparator|string|Character used to separate the data columns|
|propertyMappings|PropertyMappings[ ]|A description of each column and its matching property (see below)|
| | | |


### PropertyMappings properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|ColumnName|string|Name of the data column|
|PropertyName|string|Name of the mapped property|
|IsEncrypted|Bool|Indicates whether the column is encrypted|
|MappingPropertyKind|string|Indicates the kind of column-to-property mapping, either: ["Property" (default)|"ProfileKeyPropertyInRelationship"|"RelatedProfileKeyPropertyInRelationship"].|
| | | |


## JSON Examples

### Example #1
```{json}
{ 
    'HasHeader':true, 
    'ColumnSeparator':',', 
    'PropertyMappings': 
    [ 
        { 
            'ColumnName':'f_name', 
            'PropertyName':'FirstName', 
            'IsEncrypted':false,
            'MappingPropertyKind': 'Property' 
        }, 
        { 
            'ColumnName':'l_name', 
            'PropertyName':'LastName', 
            'IsEncrypted':false
        } 
    ] 
}
```

### Example #2
```{json}
{
    'HasHeader':true,
    'ColumnSeparator':',',
    'PropertyMappings':
    [
        {
            'ColumnName':'deviceid',
            'PropertyName':'DeviceId',
            'IsEncrypted':false,
            'MappingPropertyKind': 'ProfileKeyPropertyInRelationship' 
        },
        {
            'ColumnName':'ownerid',
            'PropertyName':'UserId',
            'IsEncrypted':false,
            'MappingPropertyKind': 'RelatedProfileKeyPropertyInRelationship'
        }
        {
            'ColumnName':'Price',
            'PropertyName':'DevicePrice',
            'IsEncrypted':false 
        }
    ]
}

