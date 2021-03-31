---
title: "Introduction to entity attributes (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 24de68ca-354b-48a2-b514-62c0d01ac3bb
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Introduction to entity attributes

Entities include a set of attributes that represent the data that can be included within each record. Developers need to understand the different types of attributes and how to work with them. The metadata for attributes describes the valid operations and behaviors of different types of attributes. Several types of attributes can be grouped by common behaviors.  

 The specific experience developers will have depends on their style of development. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Entity programming (early bound vs. late bound vs. developer extensions)](choose-development-style.md).  

> [!NOTE]
>  This topic includes references to many metadata properties. [!INCLUDE[metadata_browser](../includes/metadata-browser.md)]  

<a name="BKMK_ValidOperations"></a>   
## Valid operations on attributes  
 Each attribute has metadata that describes the operations it supports. You need to be aware of the operations that are valid for the attributes you work with.  

|AttributeMetadata property|Description|  
|--------------------------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.IsValidForCreate>|True if this attribute value is valid to be set when a record is created, otherwise false.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.IsValidForRead>|True if this attribute value can be retrieved, otherwise false.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.IsValidForUpdate>|True if this attribute value is valid to be set when a record is updated, otherwise false.|  

<a name="BKMK_TypesOfAttributes"></a>   
## Types of attributes  
 Attributes are defined in metadata and the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.AttributeTypeName> property contains the value describing the type. The static <xref:Microsoft.Xrm.Sdk.Metadata.AttributeTypeDisplayName> members provide the list of possible types.  

> [!NOTE]
>  The older <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.AttributeType> property contains data that is mostly aligned with `AttributeTypeName`, except that it shows `ImageType` attributes as `Virtual`. You should use the `AttributeTypeName` property rather than the `AttributeType` property.  

 The following section groups the types of attributes into the following categories so that you can more easily compare them:  

-   [Categorization data attributes](introduction-to-entity-attributes.md#BKMK_Categorization)  

-   [Collection data attributes](introduction-to-entity-attributes.md#BKMK_Collection)  

-   [Date and time data attribute](introduction-to-entity-attributes.md#BKMK_DateAndTime)  

-   [Image data attributes](introduction-to-entity-attributes.md#BKMK_Image)  

-   [Quantity data attributes](introduction-to-entity-attributes.md#BKMK_Quantity)  

-   [Reference data attributes](introduction-to-entity-attributes.md#BKMK_Reference)  

-   [String data attributes](introduction-to-entity-attributes.md#BKMK_StringAttributes)  

-   [Unique Identifier data attributes](introduction-to-entity-attributes.md#BKMK_UniqueIdentifier)  

-   [Virtual attributes](introduction-to-entity-attributes.md#BKMK_Virtual)  

<a name="BKMK_Categorization"></a>   
## Categorization data attributes  
 Each of the five attributes in this group inherit from a common <xref:Microsoft.Xrm.Sdk.Metadata.EnumAttributeMetadata> base class and use a pre-defined set of valid values to group records into categories.  

 Set Picklist, Status, and State attributes using an <xref:Microsoft.Xrm.Sdk.OptionSetValue> with a `Value` property set to an integer that represents a valid option within the metadata.  

 Set Boolean attributes using a Boolean value, but recognize that this is a categorization limited to just two options.  

 EntityName attributes use a string value that is constrained to be a valid entity logical name in the organization.  

 Custom Picklist and Boolean attributes can be defined as calculated attributes. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Calculated attributes](calculated-rollup-attributes.md#BKMK_Calculated).  


|                         Metadata Type                         | AttributeTypeName Value |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
|---------------------------------------------------------------|-------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|  <xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata>  |      PicklistType       |                                                                                                                                                                                                                                                                                                                                                                                                                                                             Valid values are set in the <xref:Microsoft.Xrm.Sdk.Metadata.OptionMetadata>.`Value` for that attribute defined within the <xref:Microsoft.Xrm.Sdk.Metadata.OptionSetMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.OptionSetMetadata.Options>.<br /><br /> Within the customization tools in the application these attributes are called **Option Set** fields.                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|   <xref:Microsoft.Xrm.Sdk.Metadata.StatusAttributeMetadata>   |       StatusType        | These system attributes are generally named `StatusCode`. Valid values are set in the <xref:Microsoft.Xrm.Sdk.Metadata.StatusOptionMetadata>.`Value` for that attribute defined within the <xref:Microsoft.Xrm.Sdk.Metadata.OptionSetMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.OptionSetMetadata.Options>.<br /><br /> The `StatusOptionMetadata.State` property for each option describes the valid value for the corresponding `StateCode` value. Before you set the `StatusCode` you should verify that it is valid for the current `StateCode` value. Use the <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> message to set the `StatusCode` and `StateCode` attribute values when you need to change the state of the record.<br /><br /> These attributes may have further restrictions on which values can be set. The <xref:Microsoft.Xrm.Sdk.Metadata.StatusOptionMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.StatusOptionMetadata.TransitionData> property may contain information on which options are allowed when the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.`EnforceTransitions` value is true. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define custom state model transitions](define-custom-state-model-transitions.md). |
|   <xref:Microsoft.Xrm.Sdk.Metadata.StateAttributeMetadata>    |        StateType        |                                                                                                                                                                                                                                                                                                  These system attributes are generally named `StatusCode`. Valid values are set in the <xref:Microsoft.Xrm.Sdk.Metadata.StateOptionMetadata>.`Value` for that attribute defined within the <xref:Microsoft.Xrm.Sdk.Metadata.OptionSetMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.OptionSetMetadata.Options>.<br /><br /> `StateCode` is not valid for update. After the record is created, the `StateCode` can only be set using the <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> message.<br /><br /> The `StateOptionMetadata.DefaultStatus` property for each option describes the default `StatusCode` that will be used if not set as a parameter in the `SetStateRequest`.                                                                                                                                                                                                                                                                                                  |
|  <xref:Microsoft.Xrm.Sdk.Metadata.BooleanAttributeMetadata>   |       BooleanType       |                                                                                                                                                                                                                                                   Boolean attributes can be set directly using a Boolean value, but like the others they also have an <xref:Microsoft.Xrm.Sdk.Metadata.BooleanAttributeMetadata.OptionSet> property with <xref:Microsoft.Xrm.Sdk.Metadata.BooleanOptionSetMetadata.FalseOption> and <xref:Microsoft.Xrm.Sdk.Metadata.BooleanOptionSetMetadata.TrueOption> properties that correspond to the Boolean options. Each of these properties define a set of localized labels that represent what true and false mean for the attribute. Within the customization tools in the application these attributes are called **Two Options** fields because the meaning for each option can be any mutually exclusive pair of options, not just true and false. For example, the options might be big and small.                                                                                                                                                                                                                                                   |
| <xref:Microsoft.Xrm.Sdk.Metadata.EntityNameAttributeMetadata> |     EntityNameType      |                                                                                                                                                                                                                                                                                                                                                                                                                                        These system attributes are generally paired with a unique identifier or reference attribute that is valid for multiple types. The value of this attribute is a string value representing the logical name of an entity. If the corresponding reference attribute is an <xref:Microsoft.Xrm.Sdk.EntityReference>, the value of this attribute is the same as the `EntityReference.Name` property value.                                                                                                                                                                                                                                                                                                                                                                                                                                        |

<a name="BKMK_Collection"></a>   
## Collection data attributes  
 These system attributes return collections of values.  

|AttributeTypeName Value|Description|  
|-----------------------------|-----------------|  
|CalendarRulesType|There are no actual attributes that use the `CalendarRulesType`. When using the early binding style, the code generation tool will create the following two simulated attributes that are not present in the metadata. These attributes actually represent a view of the calendar rules records associated in a one-to-many relationship to the entity instance.<br /><br /> -   `Calendar.CalendarRules` relationship: `calendar_calendar_rules`<br />-   `Service.CalendarRules` relationship: `service_calendar_rules`|  
|PartyListType|The following attributes allow for multiple <xref:Microsoft.Xrm.Sdk.EntityReference> to be set for various types of activities.<br /><br /> ActivityPointer.allparties<br />Appointment.OptionalAttendees<br />Appointment.Organizer<br />Appointment.requiredattendees<br />CampaignActivity.from<br />CampaignActivity.Partners<br />CampaignResponse.Customer<br />CampaignResponse.from<br />CampaignResponse.Partner<br />Email.bcc<br />Email.cc<br />Email.from<br />Email.to<br />Fax.from<br />Fax.to<br />Letter.bcc<br />Letter.cc<br />Letter.from<br />Letter.to<br />PhoneCall.from<br />PhoneCall.to<br />RecurringAppointmentMaster.OptionalAttendees<br />RecurringAppointmentMaster.Organizer<br />RecurringAppointmentMaster.RequiredAttendees<br />ServiceAppointment.Customers<br />ServiceAppointment.Resources<br />SocialActivity.From<br />SocialActivity.Resources<br />SocialActivity.To|  

<a name="BKMK_DateAndTime"></a>   
## Date and time data attribute  
 Attributes with the metadata `AttributeTypeName` value of `DateTimeType`. Set these attributes using `System.DateTime`.  

 The <xref:Microsoft.Xrm.Sdk.Metadata.DateTimeAttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.DateTimeAttributeMetadata.Format> property can be one of the following <xref:Microsoft.Xrm.Sdk.Metadata.DateTimeFormat> values:  

- `DateAndTime`: Display the date and time.  

- `DateOnly`: Display the date only  

  Custom Date and time attributes can be defined as calculated or rollup attributes. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Calculated and Rollup Attributes](calculated-rollup-attributes.md).  

<a name="BKMK_Image"></a>   
## Image data attributes  
 For those entities which support image attributes, the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.SchemaName> of the entity image attribute is always `EntityImage`.  

 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Image Attributes](image-attributes.md), [Entity images](introduction-entities.md#BKMK_EntityImages) and [Sample: Set and retrieve entity images](sample-set-retrieve-entity-images.md).  

<a name="BKMK_Quantity"></a>   
## Quantity data attributes  
 Attributes in this category use numerical data. Each of these attributes has a `MaxValue` and `MinValue` metadata property to set a range of valid values.  

 Custom Decimal, Integer, and Money attributes can be defined as calculated or rollup attributes. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Calculated and Rollup Attributes](calculated-rollup-attributes.md).  


|                       Metadata Type                        | AttributeTypeName Value |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
|------------------------------------------------------------|-------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| <xref:Microsoft.Xrm.Sdk.Metadata.BigIntAttributeMetadata>  |       BigIntType        |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      BigInt attributes are for internal use only.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| <xref:Microsoft.Xrm.Sdk.Metadata.DecimalAttributeMetadata> |       DecimalType       |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Use [decimal](/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types) values.<br /><br /> The <xref:Microsoft.Xrm.Sdk.Metadata.DecimalAttributeMetadata.Precision> metadata property sets the precision to be used for the attribute.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| <xref:Microsoft.Xrm.Sdk.Metadata.DoubleAttributeMetadata>  |       DoubleType        |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Use [double](/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types) values.<br /><br /> The <xref:Microsoft.Xrm.Sdk.Metadata.DoubleAttributeMetadata.Precision> metadata property sets the precision to be used for the attribute.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| <xref:Microsoft.Xrm.Sdk.Metadata.IntegerAttributeMetadata> |       IntegerType       |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           Use [int](/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) values.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
|  <xref:Microsoft.Xrm.Sdk.Metadata.MoneyAttributeMetadata>  |        MoneyType        | Use <xref:Microsoft.Xrm.Sdk.Money> which has a `decimal``Value` property.<br /><br /> Each Money attribute has a corresponding system calculated base  currency money attribute that is used to calculate the value in the organization’s base currency when multiple currencies have been enabled for the organization. The <xref:Microsoft.Xrm.Sdk.Metadata.MoneyAttributeMetadata.IsBaseCurrency> property identifies whether a money attribute represents the base currency. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Transaction Currency (Currency) Entity](transaction-currency-currency-entity.md).<br /><br /> Money attributes also have a <xref:Microsoft.Xrm.Sdk.Metadata.MoneyAttributeMetadata.PrecisionSource> metadata property that can specify the level of precision that should be used. The integer value in this property determines whether:<br /><br /> - **0**: The precision is determined by the <xref:Microsoft.Xrm.Sdk.Metadata.MoneyAttributeMetadata.Precision> metadata property.<br />- **1**: The `Organization.PricingDecimalPrecision` value.<br />- **2**: The `TransactionCurrency.CurrencyPrecision` that is associated with the current record. |

<a name="BKMK_Reference"></a>   
## Reference data attributes  
 These attributes are commonly referred to as lookup attributes and each of them contain an <xref:Microsoft.Xrm.Sdk.EntityReference> value. The difference between these attributes is the kinds of entities they can associate to. The <xref:Microsoft.Xrm.Sdk.Metadata.LookupAttributeMetadata.Targets> metadata property contains a `String[]` of the valid entity logical names that represent valid targets for the lookup. Custom lookup attributes can only have a single type in the `Targets` property.  

 The `PartyListType` also represent a kind of reference data attribute, but since they contain a collection of references, they are included in the [Collection data attributes](introduction-to-entity-attributes.md#BKMK_Collection).  

|Metadata Type|AttributeTypeName Value|Description|  
|-------------------|-----------------------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Metadata.LookupAttributeMetadata>|CustomerType|These system lookup attributes can link to Account or Contact entity records.<br /><br /> Contact.ParentCustomerId<br />Contract.BillingCustomerId<br />Contract.CustomerId<br />ContractDetail.CustomerId<br />CustomerOpportunityRole.CustomerId<br />CustomerRelationship.CustomerId<br />CustomerRelationship.PartnerId<br />Entitlement.CustomerId<br />Incident.CustomerId<br />Invoice.CustomerId<br />Lead.CustomerId<br />Opportunity.CustomerId<br />Quote.CustomerId<br />SalesOrder.CustomerId<br />SocialActivity.PostAuthor<br />SocialActivity.PostAuthorAccount<br />SocialProfile.CustomerId|  
|<xref:Microsoft.Xrm.Sdk.Metadata.LookupAttributeMetadata>|LookupType|These lookup attributes can be used to set references to a record of the type indicated by the <xref:Microsoft.Xrm.Sdk.Metadata.LookupAttributeMetadata.Targets> metadata property.<br /><br /> Some system lookups do not have a value set for the `Targets` property, but the intended entity should be apparent based on the entity relationship that is associated to the lookup.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.LookupAttributeMetadata>|OwnerType|These system lookups are always named `OwnerId` and each user-owned entity will have one. They can reference either SystemUser or Team records.|  

<a name="BKMK_StringAttributes"></a>   
## String data attributes  
 There are two types of attributes that use string data.  


|                       Metadata Type                       | AttributeTypeName Value |                                                                                                                                                                                                                                       Description                                                                                                                                                                                                                                        |
|-----------------------------------------------------------|-------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata> |       StringType        | An attribute for a string value to which a format can be applied. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [StringAttributeMetadata formats](customize-entity-attribute-metadata.md#BKMK_StringAttributeMetadataFormats).<br /><br /> Custom String attributes can be defined as calculated attributes. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Calculated attributes](calculated-rollup-attributes.md#BKMK_Calculated). |
|  <xref:Microsoft.Xrm.Sdk.Metadata.MemoAttributeMetadata>  |        MemoType         |                                                                                                                                                              An attribute for a string value intended for notes. This attributes is equivalent to String attributes with the `FormatName` property value set to `TextArea`.                                                                                                                                                              |

<a name="BKMK_UniqueIdentifier"></a>   
## Unique identifier data attributes  
 Attributes with the metadata `AttributeTypeName` value of `UniqueidentifierType` contain nullable [System.Guid](/dotnet/api/system.guid) values.  

 Each entity instance includes one attribute that represents the unique identifier for the record. This attribute has a schema name that follows the naming convention \<entity schema name>+Id. For example, the Account entity the schema name for the attribute representing the unique identifier is named `AccountId`. This value is also available directly using the <xref:Microsoft.Xrm.Sdk.Entity>.<xref:Microsoft.Xrm.Sdk.Entity.Id> property. This attribute is always returned when you retrieve an entity, even if you do not include it in the <xref:Microsoft.Xrm.Sdk.Query.ColumnSet> of a query. This value is null for a newly instantiated entity. While it is valid to set a Guid value to define the unique identifier when you create a new record, for best performance we recommend that you leave it null and allow the system to assign a value when the record is created. After a record is saved this value becomes read-only.  

 Entities may include other unique identifier attributes depending on the capabilities of the entity. For example, entities that are enabled for business processes will contain unique identifier attributes for `ProcessId` and `StageId` to track the current business process associated with the record. Certain system relationships that might normally use an <xref:Microsoft.Xrm.Sdk.EntityReference> value will use a unique identifier instead. For example the Account and Contact entities each have two unique identifier attributes (`Address1_AddressId` and `Address2_AddressId`) that correspond to CustomerAddress records created when an Account or Contact is created.  

<a name="BKMK_Virtual"></a>   
## Virtual attributes  
 The metadata for an entity will include some attributes with the metadata `AttributeTypeName` value of `VirtualType`. These attributes cannot be used in code.  

<a name="BKMK_LogicalAttributes"></a>   
## Logical attributes  
 Logical attributes contain values which are stored in different database tables than other attributes in the entity. In most cases this internal implementation is not relevant to working with Dynamics 365 Customer Engagement (on-premises). When you use logical attributes as sources for a calculated field the values in the calculated field cannot be sorted. Use the  <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.IsLogical> property to detect if an attribute is a logical attribute.  

 The most common logical attributes are those which store address information in several special entities: CompetitorAddress, CustomerAddress, InternalAddress, LeadAddress, and PublisherAddress. There are 8 system entities that include a complete set of attributes for two addresses using logical attributes. Each of these attributes begin with “Address*”, such as Address1_City or Address2_Latitude.  

### See also  
 [Introduction to Entities in Dynamics 365 Customer Engagement (on-premises)](introduction-entities.md)   
 [Image Attributes](image-attributes.md)   
 [Calculated and Rollup Attributes](calculated-rollup-attributes.md)   
 [Sample: Retrieve Valid Status Transitions](sample-retrieve-valid-status-transitions.md)   
 [Sample: Set and retrieve entity images](sample-set-retrieve-entity-images.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]