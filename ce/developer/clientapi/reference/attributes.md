---
title: "Attributes in Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about working with attributes in Customer Engagement using client API."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 32e8d1d0-4093-4588-a517-2930eec34dce
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Attributes (Client API reference)

Attributes contain data in the Customer Engagement form or grids. Use the `formContext.data.entity.attributes` collection or the `formContext.getAttribute` shortcut method to access a collection of attributes. For more information about collections, see [Collections (Client API reference)](collections.md). 

To access an attribute within the collection, you pass either the name (string) or the index value (number) of the attribute as an argument to the method. For example: `formContext.getAttribute(arg)`

Attributes are categorized by type. You can determine the type of an attribute by using the [getAttributeType](attributes/getAttributeType.md) method. Certain attribute methods are only available for specific types of attributes.

This topic provides information about the methods available per attribute type. 

## All attribute types

|||||
|----|---|---|---|----|
|[addOnChange](attributes/addOnChange.md)|[controls](attributes/controls-collection.md)|[fireOnChange](attributes/fireOnChange.md)|[getAttributeType](attributes/getAttributeType.md)|
|[getFormat](attributes/getFormat.md)|[getIsDirty](attributes/getIsDirty.md)|[getName](attributes/getName.md)|[getParent](attributes/getParent.md)|
|[getRequiredLevel](attributes/getRequiredLevel.md)|[getSubmitMode](attributes/getSubmitMode.md)|[getUserPrivilege](attributes/getUserPrivilege.md)|[getValue](attributes/getValue.md)|
|[isValid](attributes/isValid.md)|[removeOnChange](attributes/removeOnChange.md)|[setRequiredLevel](attributes/setRequiredLevel.md)|[setSubmitMode](attributes/setSubmitMode.md)|
|[setValue](attributes/setValue.md)||||

## Boolean attribute type
In addition to the methods available for all attribute types, the following method is available for the **boolean** attribute:

[getInitialValue](attributes/getInitialValue.md)

## Lookup attribute type
The following method is available only for the **lookup** attribute:

[getIsPartyList](attributes/getIsPartyList.md)

## MultiSelectOptionSet and OptionSet attribute types

The following methods are available only for the **multiselectoption** and **optionset** attributes:

|||||
|----|---|---|---|----|
|[getInitialValue](attributes/getInitialValue.md)|[getOption](attributes/getOption.md)|[getOptions](attributes/getOptions.md)|[getSelectedOption](attributes/getSelectedOption.md)|
|[[getText](attributes/getText.md)||||

## Number attribute type (decimal, double, integer, money)
The following methods are available only for the **decimal**,  **double**, and **integer** attributes:

|||||
|----|---|---|---|----|
|[getMax](attributes/getMax.md)|[getMin](attributes/getMin.md)|[getPrecision](attributes/getPrecision.md)|[setPrecision](attributes/setPrecision.md)|

## String attribute type
The following method is available only for the **string** attribute:

[getMaxLength](attributes/getMaxLength.md)

### Related topics

[Understand Xrm object model](../understand-clientapi-object-model.md)

[Controls (Client API reference)](controls.md)




