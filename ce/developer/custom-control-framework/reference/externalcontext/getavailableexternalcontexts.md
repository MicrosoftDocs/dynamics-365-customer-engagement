# getAvailableExternalContexts

[!INCLUDE [getavailableexternalcontexts-description](includes/getavailableexternalcontexts-description.md)]

## Syntax

`getAvailableExternalContexts()`


## Return Value

Type: `collection`

## Remarks

The return value is a *collection* of objects. More information [Collections (Client API reference)](../../../clientapi/reference/collections.md)

The objects returned have the following properties:

<!-- ExternalContextDescriptor -->

|Name|Type|Description|
|----|----|-----------|
|`actions`|`collection`| A collection of string values representing the actions available on the context. |
|`id`|`string`|The id of the context.|
|`properties`|`collection`|A collection of actions available on the context.|

### Related topics

[ExternalContext](../externalcontext.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />