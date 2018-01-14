# IPropBag

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [ipropbag-description](includes/ipropbag-description.md)]


## accessibility

Placeholder description: IPropBag.accessibility

**Type**: [IAccessibility](iaccessibility.md)



## children

Placeholder description: IPropBag.children

**Type**: `any`

**Optional**

## client

Placeholder description: IPropBag.client

**Type**: [IClient](iclient.md)



## communicationChannel

Placeholder description: IPropBag.communicationChannel

**Type**: [ICommunicationChannel](icommunicationchannel.md)



## decorators

Placeholder description: IPropBag.decorators
<!-- IDecorators seems to be no more than a dictionary
	interface IDecorators
	{
		//Multiple decorators where parent can pass to child control
		[key: string]: System.Dictionary;
	}

 -->

**Type**: `dictionary`

**Optional**

## diagnostics

Placeholder description: IPropBag.diagnostics

**Type**: [Diagnostics](diagnostics.md)



## externalContext

Placeholder description: IPropBag.externalContext

**Type**: [IExternalContext](iexternalcontext.md)



## factory

Placeholder description: IPropBag.factory

**Type**: [IFactory](ifactory.md)



## formatting

Placeholder description: IPropBag.formatting

**Type**: [IFormatting](iformatting.md)



## learningPath

Placeholder description: IPropBag.learningPath

<!-- 
I don't think we should document ILearningPath as an interface in our TOC.
We can document it in-line with this property.

interface ILearningPath
{
	/**
	 * DOM attribute name.
	 */
	DOMAttributeName: string;

	/**
	 * Identifier for the base control.
	 */
	baseControlId: string;
}

-->

**Type**: `object`

### Remarks
The object has the following `string` properties:
|Name|Description|
|----|-----------|
|DOMAttributeName|DOM attribute name.|
|baseControlId|Identifier for the base control.|

## mode

Placeholder description: IPropBag.mode

**Type**: [IMode](imode.md)



## navigation

Placeholder description: IPropBag.navigation

**Type**: [INavigation](inavigation.md)



## offline

Placeholder description: IPropBag.offline

**Type**: [Offline](offline.md)



## orgSettings

Placeholder description: IPropBag.orgSettings

**Type**: [IOrgSettings](iorgsettings.md)



## page

Placeholder description: IPropBag.page

**Type**: [IPage](ipage.md)



## parameters

Placeholder description: IPropBag.parameters

**Type**: `any`



## performance

<!-- 
All methods provided by IPerformance are internal
--->

[!INCLUDE [internal](../../../includes/internal.md)]

## refs

Placeholder description: IPropBag.refs

**Type**: `object`

**Optional**

## name

Placeholder description: IPropBag.name

**Type**: [Name](name.md)



## reporting

Placeholder description: IPropBag.reporting

**Type**: [Reporting](reporting.md)



## resources

Placeholder description: IPropBag.resources

**Type**: [IResources](iresources.md)



## theming

Placeholder description: IPropBag.theming

**Type**: [IThemingBag](ithemingbag.md)



## updatedProperties

Placeholder description: IPropBag.updatedProperties

**Type**: `string[]`



## userSettings

Placeholder description: IPropBag.userSettings

**Type**: [IUserSettings](iusersettings.md)



## utils

Placeholder description: IPropBag.utils

**Type**: [IUtility](iutility.md)



## webAPI

Placeholder description: IPropBag.webAPI

**Type**: [WebApi](webapi.md)







