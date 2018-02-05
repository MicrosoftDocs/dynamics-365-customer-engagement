# property element

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [property-description](includes/property-description.md)]

## Attributes

|Name|Description|Type|Required|
|--|--|--|--|
|`name`|Placeholder description property.name|`string`|yes|
|`display-name-key`|Placeholder description property.display-name-key|`string`|yes|
|`of-type`|Placeholder description property.of-type|See [Remarks](#remarks)|no|
|`usage`|Placeholder description property.usage|`bound`,`input` or `output`|no|
|`required`|Placeholder description property.name|`boolean`|no|
|`hidden`|Placeholder description property.name|`boolean`|no|
|`of-type-group`|Placeholder description property.name|`string`|no|
|`of-same-type-as`|Placeholder description property.name|`string`|no|
|`default-value`|Placeholder description property.name|`string`|no|
|`description-key`|Placeholder description property.name|`string`|no|

### Remarks

The `of-type` attribute value must be one of the following:

[!INCLUDE [type-table](includes/type-table.md)]

## Parent Elements

|Element|Description|
|--|--|
|[manifest](manifest.md)|[!INCLUDE [manifest-description](includes/manifest-description.md)]|

## Child Elements

|Element|Description|Occurrences|
|--|--|--|
|[manifest](manifest.md)|[!INCLUDE [manifest-description](includes/manifest-description.md)]|0 or more|

### Related topics

[Custom Control Framework Manifest Schema Reference](index.md)<br />
[Custom Control Framework API Reference](../reference/index.md)<br />
[Custom Control Framework Overview](../custom-control-framework-overview.md)