<!-- 
This content should remain aligned with https://learn.microsoft.com/power-apps/developer/data-platform/reference/about-entity-reference
-->

This reference includes only those tables where:

- **IsPrivate** equals `false`
  - This excludes tables where no external use cases exist. [Learn more about private tables](/power-apps/developer/data-platform/entities#private-tables)

- **IsIntersect** equals `false` or **IsIntersect** equals `true` and the table contains more than 4 columns.
  - Most intersect tables contain just the 4 columns necessary to support the Many-to-Many relationship. They are not useful. Intersect tables with more than four columns are more interesting.

## Messages

The messages in this list are applicable for the entity. For example, user-owned tables support the `Assign`, `GrantAccess`, `ModifyAccess`, and `RevokeAccess` messages while organization-owned tables do not.

### SDK for .NET

When using the SDK for .NET, you can usually invoke the corresponding request class which will belong to either the [Microsoft.Crm.Sdk.Messages](xref:Microsoft.Crm.Sdk.Messages) or [Microsoft.Xrm.Sdk.Messages](xref:Microsoft.Xrm.Sdk.Messages) namespaces. These classes have names that include the `Request` prefix added to the message name.

Some messages are added as [custom actions](/power-apps/developer/data-platform/custom-actions) for the solutions they support.  These messages are not defined within the SDK assemblies but [there are several ways you can use them](/power-apps/developer/data-platform/org-service/use-messages).

### Web API

When using the Web API, you can find the common Dataverse OData functions and actions defined in these reference:

- [Web API Action Reference](/power-apps/developer/data-platform/webapi/reference/actions)
- [Web API Function Reference](/power-apps/developer/data-platform/webapi/reference/functions)

For these functions and actions, and any additional one added, you can discover how to use these by:

1. Examine the [$metadata service document](/power-apps/developer/data-platform/webapi/web-api-service-documents#csdl-metadata-document) for details on the parameters and return values. See [Action definitions](/power-apps/developer/data-platform/webapi/web-api-actions) and [Function definitions](/power-apps/developer/data-platform/webapi/web-api-functions) for details.
1. Invoke actions and functions. See [Use Web API actions](/power-apps/developer/data-platform/webapi/use-web-api-actions) and [Use Web API functions](/power-apps/developer/data-platform/webapi/use-web-api-functions) for details.

## Events

Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it. You can subscribe to events in several different ways, for example:

- Use the Power Automate Dataverse connector using the [When an action is performed](/connectors/commondataserviceforapps/#when-an-action-is-performed) trigger.
- [Register a Dataverse plug-in to respond to the event](/power-apps/developer/data-platform/register-plug-in).
- [Send event data to Azure or a web hook with Dataverse Azure integration](/power-apps/developer/data-platform/azure-integration)

## Properties

This section includes selected entity properties rather than all of them. Only those properties expected to be most useful for developers are included. Some entity property values can be changed.

## Columns

Columns are listed in two separate sections: **Writable columns/attributes** and **Read-only columns/attributes**. The purpose of this separation is to focus on the columns a developer can set when creating or updating rows in a table. Understanding these columns helps a developer understand what they can do with the table beyond just retrieving the values.

The columns in the **Writable columns/attributes** section return true for *either*  the **IsValidForCreate** or **IsValidForUpdate** properties, (usually both). If either of these properties return false, this is indicated.

**Read-only columns/attributes** always return false for the **IsValidForCreate** *and* **IsValidForUpdate** properties.

Choice column options in this reference documentation come from a deployment where English is the base language. Some choice options can vary depending on the base language selected when the environment is created. These differences more closely align to options that best suite the language or culture. You are free to customize these options by changing the labels or adding and removing options as needed.

## Relationships

The [EntityMetadata](/dotnet/api/microsoft.xrm.sdk.metadata.entitymetadata) class includes three properties to represent relationships:

|Property| Type  |Description  |
|---------|---------|---------|
|[OneToManyRelationships](/dotnet/api/microsoft.xrm.sdk.metadata.entitymetadata.onetomanyrelationships#Microsoft_Xrm_Sdk_Metadata_EntityMetadata_OneToManyRelationships)|[OneToManyRelationshipMetadata](/dotnet/api/microsoft.xrm.sdk.metadata.onetomanyrelationshipmetadata)[]|Gets the array of one-to-many relationships for the entity.|
|[ManyToOneRelationships](/dotnet/api/microsoft.xrm.sdk.metadata.entitymetadata.manytoonerelationships#Microsoft_Xrm_Sdk_Metadata_EntityMetadata_ManyToOneRelationships)|[OneToManyRelationshipMetadata](/dotnet/api/microsoft.xrm.sdk.metadata.onetomanyrelationshipmetadata)[]|Gets the array of many-to-one relationships for the entity.|
|[ManyToManyRelationships](/dotnet/api/microsoft.xrm.sdk.metadata.entitymetadata.manytomanyrelationships#Microsoft_Xrm_Sdk_Metadata_EntityMetadata_ManyToManyRelationships)|[ManyToManyRelationshipMetadata](/dotnet/api/microsoft.xrm.sdk.metadata.manytomanyrelationshipmetadata)[]|Gets the array of many-to-many relationships for the entity.|

> [!NOTE]
> It is important to keep in mind that while each table lists those relationships that apply to it, each relationship is shared by both tables. The relationships exist *between* the tables. While One-To-Many relationships exist, *Many-to-One* relationships are simply a view of a One-To-Many relationship from the referencing table.

### Many-to-One relationships

Includes these `OneToManyRelationship` properties:

|Property|Description|
|---------|---------|
|`ReferencedEntity`|The logical name of the related table.|
|`ReferencedAttribute`|The logical name of primary key of the related table.|
|`ReferencingEntity`|The logical name of the related table that has the lookup column.|
|`ReferencingAttribute`|The logical name of the lookup column in the related table that contains a reference to primary key of the primary table.|
|`IsHierarchical`|Whether the relationship represents a self-referential hierarchical relationship|
|`CascadeConfiguration`|Data that describes which operations performed on the parent entity will cascade down to related entities.<br />More information: [Cascade configuration](/power-apps/developer/data-platform/configure-entity-relationship-cascading-behavior)|


### One-to-many relationships

Includes these `OneToManyRelationship` properties:

|Property|Description|
|---------|---------|
|`ReferencingEntity`|The logical name of the related table.|
|`ReferencingAttribute`|The logical name of the column in the related table that contains a reference to primary key of the primary table.|
|`IsCustomizable`|Whether the properties of the relationship can be changed.|
|`ReferencedEntityNavigationPropertyName`|The name of the Web API collection-valued navigation property for this relationship.<br />More information: [Web API Navigation Properties](/power-apps/developer/data-platform/webapi/web-api-navigation-properties)|
|`AssociatedMenuConfiguration`|Data used by model-driven apps to control whether and how the related entity data can be accessed in the UI from the primary entity.|


### Many-to-many relationships

Each many-to-many relationship includes [Entity1LogicalName](/dotnet/api/microsoft.xrm.sdk.metadata.manytomanyrelationshipmetadata.entity1logicalname) and [Entity2LogicalName](/dotnet/api/microsoft.xrm.sdk.metadata.manytomanyrelationshipmetadata.entity2logicalname). For this documentation, relationship details are provided in the context of the current table. Whether it is `Entity1` or `Entity2` isn't really important.

For each many-to-many relationship the following properties are included:

|Property|Description|
|---------|---------|
|`IntersectEntityName`|The logical name of the intersect table that supports this many-to-many relationship.<br />[You can use this value when joining table columns using FetchXml](/power-apps/developer/data-platform/fetchxml/join-tables#many-to-many-relationships)|
|`IsCustomizable`|Whether the properties of the relationship can be changed.|
|`SchemaName`|The schema name of the relationship.|
|`IntersectAttribute`|The name of the column in the intersect table that is the primary key for records of this type.|
|`NavigationPropertyName`|The name of the Web API collection-valued navigation property for this relationship.<br />More information: [Web API Navigation Properties](/power-apps/developer/data-platform/webapi/web-api-navigation-properties)|
|`AssociatedMenuConfiguration`|Data used by model-driven apps to control whether and how the second table data can be accessed in the UI from this table.|


In the rare case where a many-to-many relationship is self-referencing, such as for [Connection Role (ConnectionRole) connectionroleassociation_association](/power-apps/developer/data-platform/reference/entities/connectionrole#BKMK_connectionroleassociation_association), `Entity1` or `Entity2` is prepended to the property.

|Property|Value|
|---|---|
|`Entity1IntersectAttribute`|The name of the column in the intersect table that is the primary key for records of this type as the first table.|
|`Entity2IntersectAttribute`|The name of the column in the intersect table that is the primary key for records of this type as the second table.|
|`Entity1NavigationPropertyName`|The name of the Web API collection-valued navigation property for this relationship as the first table.|
|`Entity2NavigationPropertyName`|The name of the Web API collection-valued navigation property for this relationship as the second table.|
|`Entity1AssociatedMenuConfiguration`|Data used by model-driven apps to control whether and how the second table data can be accessed in the UI from this table as the first table.|
|`Entity2AssociatedMenuConfiguration`|Data used by model-driven apps to control whether and how the second table data can be accessed in the UI from this table as the second table|