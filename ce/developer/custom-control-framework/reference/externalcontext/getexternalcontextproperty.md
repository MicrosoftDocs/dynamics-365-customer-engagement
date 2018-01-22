# getExternalContextProperty

[!INCLUDE [getexternalcontextproperty-description](includes/getexternalcontextproperty-description.md)]

## Syntax

`getExternalContextProperty(externalContextId,externalContextPropertyId,options)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|externalContextId|`string`|yes|Placeholder description|
|externalContextPropertyId|`string`|yes|Placeholder description|
|options|`object`|no|Placeholder description|

## Return Value

Type: `Promise<object>`

<!-- ExternalContextSuccessResponse -->
The resolution of the promise will return the requested external context property. 

## Remarks
<!-- ExternalContextPropertyOptions -->
The `options` parameter is an object with the following properties:

|Name|Type|Required|Description|
|----|----|--------|-----------|
|`args`|`object`|no|Any arguments that should be used when retrieving the property.|
|`updateListener`|`function`|no|A listener for updates to the result.|

> [!NOTE]
> The `updateListener` will not be called for the initial result. That will come through the returned promise. Only subsequent updates to the result will trigger the listener.

<!-- QUESTION: This seems pretty complex. Will probably need much more explaination and an example here. --->




### Related topics

[ExternalContext](../externalcontext.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />