# invokeExternalContextAction

[!INCLUDE [invokeexternalcontextaction-description](includes/invokeexternalcontextaction-description.md)]

## Syntax

`invokeExternalContextAction(externalContextId,externalContextActionId,options)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|externalContextId|`string`|yes|Placeholder description|
|externalContextActionId|`string`|yes|Placeholder description|
|options|`object`|no|Placeholder description|

## Return Value

Type: `Promise<object>`

<!-- ExternalContextSuccessResponse -->
The resolution of the promise will return the requested external context property. 

## Remarks
 The `options` parameter is an object with the following properties:
<!-- ExternalContextActionOptions -->
|Name|Type|Required|Description|
|----|----|--------|-----------|
|`args`|`object`|no|Any arguments that should be used when invoking the action.|

<!-- QUESTION: This seems pretty complex. Will probably need much more explaination and an example here. --->

### Related topics

[IExternalContext](../iexternalcontext.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />