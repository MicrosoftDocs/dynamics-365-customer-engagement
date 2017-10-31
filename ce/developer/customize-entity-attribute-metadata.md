---
title: "Customize entity attribute metadata (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about the AttributeMetadata class to retrieve existing attributes. This class is returned by the RetrieveAttributeRequest message. The AttributeMetadata class inherits from the abstract MetadataBase class. "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 89969adc-8577-424c-bfcc-7f65c5d4bd19
caps.latest.revision: 41
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Customize entity attribute metadata

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Use the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata> class to retrieve existing attributes. This class is returned by the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAttributeRequest> message. The `AttributeMetadata` class inherits from the abstract <xref:Microsoft.Xrm.Sdk.Metadata.MetadataBase> class.  

Use the following Web API query to retrieve entity attributes in the context of an entity by expanding the Attributes collection-valued navigation property. More information: [Querying EntityMetadata attributes](webapi/query-metadata-web-api.md#querying-entitymetadata-attributes)

```http
GET [Organization URI]/api/data/v9.0/EntityDefinitions(70816501-edb9-4740-a16c-6a5efbc05d84)?$select=LogicalName&$expand=Attributes($select=LogicalName;$filter=AttributeType eq Microsoft.Dynamics.CRM.AttributeTypeCode'Picklist')
```

Use the specific class for each attribute type with the <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest> message to update attributes or create custom attributes.  

  
> [!NOTE]
>  You can access custom attributes programmatically after you create them, but you must add them to an entity form and publish them before users can see them.  
  
## Attribute types  
 The following table lists each type of `Attribute` you can work with. Each attribute inherits from the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata> class.  
  
|Class|Application Label|Description|  
|-----------|-----------------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Metadata.BooleanAttributeMetadata>|Two Option|A Boolean attribute. You can specify the text for both options. When added to a form, the field properties control whether the attribute is displayed as two radio buttons, a check box, or a list.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.DateTimeAttributeMetadata>|Date and Time|A date and time attribute. You can specify the behavior to store date and time values with or without time zone information, and format to define the display format of the values. More information: [Behavior and format of the datetime attribute](behavior-format-date-time-attribute.md) **Note:**  If you are using [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement or [!INCLUDE[pn_crm_2016_onprem](../includes/pn-crm-2016-onprem.md)], all date and time attributes now support values as early as 1/1/1753 12:00 AM.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.DecimalAttributeMetadata>|Decimal Number|A decimal attribute. You can specify the level of precision up to ten decimal places and the minimum and maximum values from -100,000,000,000 to 100,000,000,000.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.DoubleAttributeMetadata>|Floating Point Number|A double attribute. You can specify the level of precision up to five decimal places and the minimum and maximum values from -100,000,000,000 to 100,000,000,000. **Note:**  `DoubleAttributeMetadata` replaces the `FloatAttributeMetadata` used in [!INCLUDE[pn_Microsoft_Dynamics_CRM_4.0](../includes/pn-microsoft-dynamics-crm-4-0.md)].|  
|<xref:Microsoft.Xrm.Sdk.Metadata.ImageAttributeMetadata>|Image|An image attribute. Each entity can have one image attribute. Certain system entities have image attributes and new image attributes cannot be added to system entities that do not have them. You can add an image attribute to custom entities<br /><br /> All image attributes have the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.SchemaName> ‘EntityImage’ and the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.LogicalName> ‘entityimage’. Custom image attributes will not use the solution publisher customization prefix in the name. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Entity images](introduction-entities.md#BKMK_EntityImages).|  
|<xref:Microsoft.Xrm.Sdk.Metadata.IntegerAttributeMetadata>|Whole Number|An integer attribute. You can specify the maximum and minimum values from -2,147,483,648 to 2,147,483,647.<br /><br /> This attribute can be formatted to create the following types of fields using the <xref:Microsoft.Xrm.Sdk.Metadata.IntegerFormat> enumeration:<br /><br /> - **Duration**: Displays a drop-down list that contains time intervals. A user can select a value from the list or type an integer value that represents the number of minutes.<br />- **TimeZone**: Displays a drop-down list that contains a list of time zones.<br />- **Language**: Displays a drop-down list that contains a list of languages that have been enabled for the organization. If no other languages have been enabled, the base language will be the only option. The value saved is the LCID value for the language.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.LookupAttributeMetadata>|Lookup|An attribute created when an entity relationship is created by using the <xref:Microsoft.Xrm.Sdk.Messages.CreateOneToManyRequest> message.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.MemoAttributeMetadata>|Multiple Lines of Text|A memo attribute. Displays as a text box field in a form. The maximum length is 1048576 characters.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.MoneyAttributeMetadata>|Currency|A money attribute. You can specify the maximum and minimum values between - 922,337,203,685,477 and 922,337,203,685,477.<br /><br /> The level of precision can be set by using the <xref:Microsoft.Xrm.Sdk.Metadata.MoneyAttributeMetadata.PrecisionSource> property:<br /><br /> -   When the precision is set to zero (0), the <xref:Microsoft.Xrm.Sdk.Metadata.MoneyAttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.MoneyAttributeMetadata.Precision> value is used.<br />-   When the precision is set to one (1), the `Organization.PricingDecimalPrecision` value is used.<br />-   When the precision is set to two (2), the `TransactionCurrency.CurrencyPrecision` value is used.| 
|<xref:Microsoft.Xrm.Sdk.Metadata.MultiSelectPicklistAttributeMetadata>|MultiSelect Option Set|A multi-select picklist attribute. Multi-select picklist attributes were added with the [!INCLUDE[../includes/pn-crm-9-0-0-online.md](../includes/pn-crm-9-0-0-online.md)]. This attribute provides a set of options that are displayed in a drop-down list. More than one option can be selected. You can create the this attribute so that it can contain its own options or use a global options set.|   
|<xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata>|Option Set|A picklist attribute. This attribute provides a set of options that are displayed in a drop-down list. You can create the picklist attribute so that it can contain its own options or use a global options set.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.StateAttributeMetadata>|Status|The state attribute is created automatically when the entity is created. **Note:**  The options available for this attribute are read-only.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.StatusAttributeMetadata>|Status Reason|The status attribute is created automatically when the entity is created. Each of the options must be associated with the `StateAttributeMetadata` attribute for the entity.  Use the <xref:Microsoft.Xrm.Sdk.Messages.InsertStatusValueRequest> message to update options available for this attribute. **Note:**  Each `StatusOption` must reference a specific state attribute value because status values depend on a specific state value.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata>|Single Line of Text|See [StringAttributeMetadata formats](customize-entity-attribute-metadata.md#BKMK_StringAttributeMetadataFormats).|  
  
<a name="BKMK_StringAttributeMetadataFormats"></a>   
### StringAttributeMetadata formats  
 String attributes can be formatted to allow links to initiate phone calls by using Lync or Skype. This change requires that a new <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata.FormatName> property be added to the <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata> class and the deprecation of the <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata.Format> property.  
  
 Using the <xref:Microsoft.Xrm.Sdk.Metadata.StringFormat> enumeration to define the format for <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata.Format> is deprecated. Instead, use the <xref:Microsoft.Xrm.Sdk.Metadata.StringFormatName> class to set the value of <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata.FormatName>.  
  
 This allows for setting the format value of `PhoneNumber`, which does not exist in the <xref:Microsoft.Xrm.Sdk.Metadata.StringFormat> enumeration.  
  
 For backwards compatibility, you can set a value to control how the attribute is formatted by using either the <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata.Format> or <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata.FormatName> property. Your existing code will continue to work if you only use <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata.Format>, but you will not be able to format an attribute as a phone number without using <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata.FormatName>. If both properties are set, the value set using <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata.FormatName> is the one that will be applied.  
  
 The <xref:Microsoft.Xrm.Sdk.Metadata.StringFormatName> class contains the following members; each member returns a string with the same value as the member name:  
  
|Member name and value|Description|  
|---------------------------|-----------------|  
|`Email`|The form field will validate the text value as an e-mail address and create a mailto link in the field.|  
|`PhoneNumber`|The form field will contain a link to initiate a phone call by using Skype.|  
|`PhoneticGuide`|For internal use only.|  
|`Text`|The form will display a text box.|  
|`TextArea`|The form will display a text area field.|  
|`TickerSymbol`|The form will display a link that will open to display a quote for the stock ticker symbol.|  
|`URL`|The form will display a link to open the URL.|  
|`VersionNumber`|For internal use only.|  
  
### See also  
 [Extend the Metadata Model for Dynamics 365](org-service/use-organization-service-metadata.md)   
 [Work with Attributes](org-service/work-attribute-metadata.md)   
 [Behavior and format of the datetime attribute](behavior-format-date-time-attribute.md)   
 [Entity Attribute Metadata Messages](entity-attribute-metadata-messages.md)   
 [Sample: Work with Attributes](org-service/sample-work-attribute-metadata.md)    
 [Sample: Dump Attribute Metadata to a File](org-service/sample-dump-attribute-metadata-file.md)   
 [Sample: Dump Attribute Picklist Metadata to a File](org-service/sample-dump-attribute-picklist-metadata-file.md)   
 [Sample: Convert date and time behavior](org-service/sample-convert-date-time-behavior.md)
