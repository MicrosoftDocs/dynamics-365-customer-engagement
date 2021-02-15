---
title: Universal FetchXML | Microsoft Docs
description: Advanced query language to extend Universal Resource Scheduling
author: FieldServiceDave
ms.author: daclar
ms.date: 06/14/2018
ms.reviewer: krbjoran
ms.service: crm-online
ms.topic: article
ms.custom: 
  - dyn365-projectservice
  - dyn365-fieldservice
search.app: 
  - D365CE
  - D365PS
  - D365FS
---

# Universal FetchXML

UFX is an advanced query language that allows you to query data using dynamic FetchXML, shape, and prepare the resulting data for consumption by the **Universal Resource Scheduling (URS)** solution. 
This query language enables you to create custom queries to customize and extend the schedule board and schedule assistant filters to meet the unique business needs of the organization. 

UFX consists of two components UFX Bag and UFX Query. 

## Simple UFX Bag

A UFX Bag contains static typed data. In memory, it's represented as a dictionary with keys and values. It can be serialized to JSON and XML. Having the data typed allows a **UFX Query** to query data from it, and client UI to bind to it.

> For practical and performance reasons the in-memory bag is implemented on top of the Dynamics 365 apps SDK `Entity` object.

 Sample bag containing two values.

In memory:

key | value | type
--- | --- | ---
name | John | string
age | 36 | int

In JSON:

```json
{
    "name": "John",
    "age": 36
}
```
In XML:

```xml
<bag>
    <name ufx-type="string">John</name>
    <age ufx-type="int">36</age>
</bag>
```

## UFX supported types

A UFX Bag can contain values of many types. They are categorized in three type classes:

Category | Value
---  | ---
Simple types  | `bool (Boolean)`, `int (Int32)`, `long (Int64)`, `double (Double)`, `decimal (Decimal)`, `datetime (DateTime)`, `guid (Guid)`, `string (String)`<br />Dynamics 365 specific simple types: `money (Money)`, `option (OptionSet)`, `lookup (EntityReference)`
Other Bags | `bag (Entity)`
List of Bags | `list (EntityCollection)`


Here's a sample JSON bag containing more types:
```json
{
    "citizen": true,          // implicit bool
    
    "age": 36,                // explicit int
    "age@ufx-type": "int",

    "name": {                 // nested bag
        "first": "John",
        "last": "Doe"
    },

    "children": [             // list of bags
        { "name": "Sam" },
        { "name": "Judy" }
    ]
}
```

The same bag in XML:
```xml
<bag>
    <citizen ufx-type="bool">true</citizen>

    <age ufx-type="int">36</age>

    <name ufx-type="bag">
        <first ufx-type="string">John</first>
        <last ufx-type="string">Doe</last>
    </name>

    <children ufx-type="list">
        <bag>
            <name ufx-type="string">Sam</name>
        </bag>
        <bag>
            <name ufx-type="string">Judy</name>
        </bag>
    </children>
</bag>
```

<a name="ufx-queries"></a>
## Introduction to UFX Queries

UFX Queries are written as XML-based **UFX Bags**. Properties in the bag can contain **UFX directives** to query data dynamically. A UFX Query executes on in-memory objects, not XML. Only the directives are written in XML. Its output can be serialized to JSON or XML.

The following UFX Query defines the `accounts` property in the bag with the `source` UFX directive. This results in the inline FetchXML to be executed by Dynamics 365 and the `accounts` property to become a list of bags, or an `EntityCollection`, with each bag being an instance of an account record from Dynamics 365.
```xml
<bag xmlns:ufx="https://schemas.microsoft.com/dynamics/2017/universalfetchxml">
    <accounts ufx:source="fetch">
        <fetch top="10">
            <entity name="account" />
        </fetch>
    </accounts>
</bag>
```
A UFX Query is processed sequentially and can contain many FetchXML queries.

Here's a snippet of the result of the previous UFX Query serialized to XML. Observe some values have metadata further describing them.
```xml
<bag>
  <accounts ufx-type="list">
    <bag ufx-id="166e39dd-34a1-e611-8111-00155d652f01" ufx-logicalname="account">
      <accountid ufx-type="guid">166e39dd-34a1-e611-8111-00155d652f01</accountid>
      <accountnumber ufx-type="string">ABSS4G45</accountnumber>
      <name ufx-type="string">Fourth Coffee (sample)</name>
      <statecode ufx-type="option" ufx-formatvalue="Active">0</statecode>
      <websiteurl ufx-type="string">https://www.fourthcoffee.com/</websiteurl>
      <primarycontactid ufx-type="lookup" ufx-formatvalue="Yvonne McKay (sample)" ufx-logicalname="contact">7c6e39dd-34a1-e611-8111-00155d652f01</primarycontactid>
      ...
    </bag>
    <bag ufx-type="bag" ufx-id="186e39dd-34a1-e611-8111-00155d652f01" ufx-logicalname="account">
      <accountid ufx-type="guid">186e39dd-34a1-e611-8111-00155d652f01</accountid>
      <accountnumber ufx-type="string">ACTBBDC3</accountnumber>
      <name ufx-type="string">Litware, Inc. (sample)</name>
      <statecode ufx-type="option" ufx-formatvalue="Active">0</statecode>
      <websiteurl ufx-type="string">https://www.litwareinc.com/</websiteurl>
      <primarycontactid ufx-type="lookup" ufx-formatvalue="Susanna Stubberod (sample)" ufx-logicalname="contact">7e6e39dd-34a1-e611-8111-00155d652f01</primarycontactid>
      ...
    </bag>
    ...
  </accounts>
</bag>
```

The `select` UFX directive takes an XPath expression that selects values from the current bag.
```xml
<bag xmlns:ufx="https://schemas.microsoft.com/dynamics/2017/universalfetchxml">
    <accounts ufx:source="fetch">
        <fetch top="10">
            <entity name="account" />
        </fetch>
    </accounts>

    <first_account_name ufx:select="accounts/bag[1]/name" />

    <!-- null values remove properties from the bag -->
    <accounts ufx:select="$null" />
</bag>
```
The resulting bag in XML:
```xml
<bag>
    <first_account_name ufx-type="string">Fourth Coffee (sample)</first_acount_name>
</bag>
```
Certainly the most powerful aspect of a UFX Query is its ability to dynamically generate FetchXML based on input data.

In the sample below, we search for accounts by a value supplied by the user and available as a UFX Bag through the XPath `$input` variable. Notice the UFX **if** and **value** directives on the `condition` element.

```xml
<bag xmlns:ufx="https://schemas.microsoft.com/dynamics/2017/universalfetchxml">
    <accounts ufx:source="fetch">
        <fetch top="10">
            <entity name="account">
                <filter>
                    <condition attribute="name" operator="like" ufx:if="$input/NameFilter">
                        <ufx:value select="$input/NameFilter" attribute="value" />
                    </condition>
                </filter>
            </entity>
        </fetch>
    </accounts>
</bag>
```
If the `NameFilter` property in the input bag contained `%city%` the produced FetchXML condition executed by Dynamics 365 would look like this.
```xml
<condition attribute="name" operator="like" value="%city%" />
```
## Keys, values, and metadata
A UFX Bag contains keys and values, with some values having additional metadata further describing them.

An example might be a value of type `lookup (EntityReference)`. When queried from Dynamics 365 through FetchXML, it will return the logical name of the entity as well as the formatted display name of the record. The UFX Bag preserves these additional information as metadata attached to the primary value.

Serialized to JSON, a `lookup` with metadata looks like this:
```json
{
    "primarycontactid": "7e6e39dd-34a1-e611-8111-00155d652f01",
    "primarycontactid@ufx-type": "lookup",
    "primarycontactid@ufx-logicalname": "contact",
    "primarycontactid@ufx-formatvalue": "Susanna Stubberod (sample)"
}
```
In XML:
```xml
<primarycontactid ufx-type="lookup" ufx-formatvalue="Susanna Stubberod (sample)" ufx-logicalname="contact">7e6e39dd-34a1-e611-8111-00155d652f01</primarycontactid>
```

## XPath over Dynamics 365 data
Having the data in a UFX Bag typed, allows a UFX Query to see it in a structured format and use XPath to traverse over the data and select values from it.

An XPath expression specified in a UFX directive sees the data in the bag similar to the structure of the bag in XML-serialized form. However, the data is stored in in-memory .NET objects (in instances of `Entity` and `EntityCollection` types) and not in XML documents.


## Appendix A: UFX type reference

**Note:** All UFX Types support the `ufx-type` and `ufx-formatvalue` metadata. Additional metadata are described next to each type in the table below.

UFX Name | Attribute Type Code | .NET Name | UFX Metadata
--- | --- | --- | ---
bool | Boolean | Boolean |
int | Integer | Int32 |
long | BigInt | Int64 |
double  | Double | Double |
decimal | Decimal | Decimal |
datetime | DateTime | DateTime |
guid | Uniqueidentifier | Guid |
string | Memo | String |
money | Money | Money |
option | Picklist | OptionSetValue |
lookup | Lookup | EntityReference | `ufx-logicalname`
bag | N/A | Entity | `ufx-id`<br />`ufx-logicalname`
list | N/A | EntityCollection |
N/A | N/A | AliasedValue | `ufx-aliasentity`<br />`ufx-aliasattribute`

## Appendix B: UFX Query directives
UFX directives can be used on bag properties and on XML elements of a FetchXML query.

UFX Bag directives

Attribute | Value | Description
--- | --- | ---
`ufx:if` | XPath | Tests the XPath expression and only processes the property if the test returns true
`ufx:source` | `fetch` | Executes the inline `<fetch>` XML element and assigns the result to the property
`ufx:select` | XPath | Executes the XPath expression and assigns the result to the property<br />When querying for a `bag` or `list` an optional child `bag` in XML form can be specified to transform the result of the XPath expression

UFX FetchXML directives

Element | Attribute | Value | Description
--- | --- | --- | ---
All elements | `ufx:if` | XPath | Tests the XPath expression and only emits the XML element if the tests succeed
`ufx:apply` | `select` | XPath | Loops over the nodeset returned by the XPath expression and outputs the child XML elements once for each node
`ufx:value` | `select` | XPath | Executes the XPath expression and outputs the result in the current XML element
`ufx:value` | `attribute` | attribute name | Assigns the XPath expression result to the specified attribute name on the current XML element


## Appendix C: UFX XPath functions

UFX adds a number of new functions in addition to the ones available natively in XPath.

### datetime()

- datetime(): Returns the current time in UTC

### list()

- list(bag | list, ...[bag | list]): Takes a number of `bag` or `list` values as input and flattens them into a single `list`

### lookup-to-list()

- lookup-to-list(lookup, ...[lookup]): Takes a number of `lookup` values, converts each of them to a `bag` with the `ufx-id` and `ufx-logicalname` metadata set, and flattens them into a single `list`

### option-to-list()

- option-to-list(option, ...[option]): Takes a number of `option` values, converts each of them to a `bag` with a single `option` property, and flattens them into a single `list`

### order()

- order(list, string, bool): Orders a list by a property in each bag. The property is specified in argument 2, descending is specified in argument 3.
- order(list, list): Order a list by multiple sort orders specified as a list in argument 2. Each `bag` in the second list can have a `name` and `descending` property

### iif()

- iif(any, any, any): If argument 1 is true, returns argument 2, otherwise returns argument 3


## Appendix D: UFX XPath variables

Name | Description
--- | ---
$input | A `bag` available to the UFX Query with input values
$null | A null constant. Selecting `$null` on a property removes the property from the bag
$current | Reference to the current bag being processed by the UFX Query

### See also

[Understanding and customizing resource matching in Universal Resource Scheduling](understanding-and-customizing-resource-matching-in-urs.md)

[Universal Resource Scheduling extensibility release notes](extensibility-release-notes.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]