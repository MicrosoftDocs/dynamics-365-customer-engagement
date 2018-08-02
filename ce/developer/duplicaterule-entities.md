---
title: "Duplicate rule entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "These entities contain data that define duplicate detection rules."
ms.custom: ""
ms.date: 11/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 332cef23-adaa-4975-96a7-3128dce359e4
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Duplicate Rule entities

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

For information about how to configure duplicate rules in the application, see [Administrators Guide: Set up duplicate detection rules to keep your data clean](../admin/set-up-duplicate-detection-rules-keep-data-clean.md).

Duplicate detection rules are defined using the following entities:

- [DuplicateRule](entities/duplicaterule.md)
- [DuplicateRuleCondition](entities/duplicaterulecondition.md)



These entities are related using the [DuplicateRule_DuplicateRuleConditions](entities/duplicaterule.md#BKMK_DuplicateRule_DuplicateRuleConditions) relationship.

The following writable attributes in these entities control the behavior of duplicate detection rules.

## DuplicateRule

|Attribute|Description|
|-|-|
|[BaseEntityName](entities/duplicaterule.md#BKMK_BaseEntityName)| Record type of the record being evaluated for potential duplicates.|
|[Description](entities/duplicaterule.md#BKMK_Description)|Description of the duplicate detection rule.|
|[DuplicateRuleId](entities/duplicaterule.md#BKMK_DuplicateRuleId)|Unique identifier of the duplicate detection rule.|
|[ExcludeInactiveRecords](entities/duplicaterule.md#BKMK_ExcludeInactiveRecords)|Determines whether to flag inactive records as duplicates.<br /> **Note**: <br />The default value is `false`. Set it to `true` if you do not want inactive records to be flagged as duplicates, even if they meet duplication detection rule criteria. <br /> More information: [Inactive states](#inactive-states)|
|[IsCaseSensitive](entities/duplicaterule.md#BKMK_IsCaseSensitive)|Indicates if the operator is case-sensitive.|
|[MatchingEntityName](entities/duplicaterule.md#BKMK_MatchingEntityName)|Record type of the records being evaluated as potential duplicates.|
|[Name](entities/duplicaterule.md#BKMK_Name)|Name of the duplicate detection rule.|
|[OwnerId](entities/duplicaterule.md#BKMK_OwnerId)|Unique identifier of the user or team who owns the duplicate detection rule.|
|[OwnerIdType](entities/duplicaterule.md#BKMK_OwnerIdType)|Whether the owner is a user or a team.|
|[StatusCode](entities/duplicaterule.md#BKMK_StatusCode)|Reason for the status of the duplicate detection rule.|

### Inactive states

Most system entities and all custom entities have two `StateCode` attribute options:

- `Value`: 0 `InvariantName`: `Active`
- `Value`: 1 `InvariantName`: `Inactive`

The label of the option may be changed, but the `InvariantName` value will not.

Some system entities will have more than one active or inactive state.The following table lists examples of entities with more than one active or inactive state.

|Entity StateCode |Active State(s)|Inactive State(s)|  
|--|--|--|  
|[Appointment.StateCode](entities/appointment.md#BKMK_StateCode)|`Open`, `Scheduled`|`Completed`, `Canceled`|  
|[CampaignActivity.StateCode](entities/CampaignActivity.md#BKMK_StateCode)|`Open`|`Closed`, `Canceled`|  
|[CampaignResponse.StateCode](entities/CampaignResponse.md#BKMK_StateCode)|`Open`|`Completed`, `Canceled`|  
|[Contract.StateCode](entities/Contract.md#BKMK_StateCode)|`Draft`, `Invoiced`, `On Hold`|`Canceled`, `Expired`|  
|[ContractDetail.StateCode](entities/ContractDetail.md#BKMK_StateCode)|`Existing`, `Renewed`|`Canceled`, `Expired`|  
|[Email.StateCode](entities/Email.md#BKMK_StateCode)|`Open`|`Completed`, `Canceled`|  
|[Fax.StateCode](entities/Fax.md#BKMK_StateCode)|`Open`|`Completed`, `Canceled`|  
|[Incident.StateCode](entities/Incident.md#BKMK_StateCode)|`Active`|`Resolved`, `Canceled`, `Closed`|  
|[Invoice.StateCode](entities/Invoice.md#BKMK_StateCode)|`Active`|`Closed`, `Paid`, `Canceled`|  
|[KbArticle.StateCode](entities/KbArticle.md#BKMK_StateCode)|`Draft`, `Unapproved`, `Published`|N/A|  
|[Lead.StateCode](entities/Lead.md#BKMK_StateCode)|`Open`|`Qualified`, `Disqualified`|  
|[Letter.StateCode](entities/Letter.md#BKMK_StateCode)|`Open`|`Completed`, `Canceled`|  
|[Opportunity.StateCode](entities/Opportunity.md#BKMK_StateCode)|`Open`|`Won`, `Lost`|  
|[PhoneCall.StateCode](entities/PhoneCall.md#BKMK_StateCode)|`Open`|`Completed`, `Canceled`|  
|[Quote.StateCode](entities/Quote.md#BKMK_StateCode)|`Draft`, `Active`|`Won`, `Closed`|  
|[SalesOrder.StateCode](entities/SalesOrder.md#BKMK_StateCode)|`Active`, `Submitted`, `Invoiced`|`Canceled`, `Fulfilled`|  
|[ServiceAppointment.StateCode](entities/ServiceAppointment.md#BKMK_StateCode)|`Open`, `Scheduled`|`Closed`, `Canceled`|  
|[Task.StateCode](entities/Task.md#BKMK_StateCode)|`Open`|`Completed`, `Canceled`|  

 For example, if you set the `ExcludeInactiveRecords` attribute to `true`, only `Active`, `Submitted`, and `Invoiced` sales orders will be considered for matching during duplicate detection. 


> [!NOTE]
> You can review the available `StateCode` options for an entity using the Metadata Browser described in [Browse the metadata for your organization](browse-your-metadata.md).
>
> To retrieve the `StateCode` options for an entity you can use the following Web API query  by substituting the `LogicalName` of the entity with `appointment` used below:
> ```HTTP
> GET [organization URI]/api/data/v9.0/EntityDefinitions(LogicalName='appointment')/Attributes(LogicalName='statecode')/Microsoft.Dynamics.CRM.StateAttributeMetadata/OptionSet?$select=Options
> ```

## DuplicateRule Special messages

[DuplicateRule](entities/duplicaterule.md) is a user-owned entity and normal create, retrieve, update, assign, and delete operations are allowed as well as operations to control access. More information: [DuplicateRule Messages](entities/duplicaterule.md#messages).

The following special messages can also be used:

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|CompoundUpdateDuplicateDetectionRule|<xref href="Microsoft.Dynamics.CRM.CompoundUpdateDuplicateDetectionRule?text=CompoundUpdateDuplicateDetectionRule Action" />|<xref:Microsoft.Crm.Sdk.Messages.CompoundUpdateDuplicateDetectionRuleRequest>|
|PublishDuplicateRule|<xref href="Microsoft.Dynamics.CRM.PublishDuplicateRule?text=PublishDuplicateRule Action" />|<xref:Microsoft.Crm.Sdk.Messages.PublishDuplicateRuleRequest>|
|PublishXml|<xref href="Microsoft.Dynamics.CRM.PublishXml?text=PublishXml Action" />|<xref:Microsoft.Crm.Sdk.Messages.PublishXmlRequest>|
|UnpublishDuplicateRule|<xref href="Microsoft.Dynamics.CRM.UnpublishDuplicateRule?text=UnpublishDuplicateRule Action" />|<xref:Microsoft.Crm.Sdk.Messages.UnpublishDuplicateRuleRequest>|


## DuplicateRuleCondition

|Attribute|Description|
|-|-|
|[BaseAttributeName](entities/duplicaterulecondition.md#BKMK_BaseAttributeName)|Field that is being compared.|
|[DuplicateRuleConditionId](entities/duplicaterulecondition.md#BKMK_DuplicateRuleConditionId)|Unique identifier of the condition.|
|[IgnoreBlankValues](entities/duplicaterulecondition.md#BKMK_IgnoreBlankValues)|Determines whether to consider blank values as non-duplicate values. <br /> **Note**: <br />The default value of this attribute is `false`. Set it to `true` if you do not want the duplicate detection rule to consider `null` values as equal. <br /> **Important**: <br /> For a duplicate detection rule with one condition, if you set the attribute value to `false`, it is treated by the system as a `true` value. |
|[MatchingAttributeName](entities/duplicaterulecondition.md#BKMK_MatchingAttributeName)|Field that is being compared with the base field.|
|[OperatorCode](entities/duplicaterulecondition.md#BKMK_OperatorCode)|Operator for this rule condition.<br /> **Important**: <br />If you set the `OperatorCode` attribute to `ExactMatch`, don’t set the `OperatorParam` attribute to any value|
|[OperatorParam](entities/duplicaterulecondition.md#BKMK_OperatorParam)|Parameter value of N if the operator is Same First Characters or Same Last Characters.<br /> **Important**: <br />Don’t set the `OperatorParam` to zero during create or update operations.|
|[RegardingObjectId](entities/duplicaterulecondition.md#BKMK_RegardingObjectId)|Unique identifier of the object with which the condition is associated.|

## DuplicateRuleCondition Special messages

[DuplicateRuleCondition](entities/duplicaterulecondition.md) is a child entity to `DuplicateRule`. Access to retrieve or modify these entities is dependant on access to the `DuplicateRule` it is associated with. More information: [DuplicateRuleCondition Messages](entities/duplicaterulecondition.md#messages).

The following special messages can also be used:

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|CompoundUpdateDuplicateDetectionRule|<xref href="Microsoft.Dynamics.CRM.CompoundUpdateDuplicateDetectionRule?text=CompoundUpdateDuplicateDetectionRule Action" />|<xref:Microsoft.Crm.Sdk.Messages.CompoundUpdateDuplicateDetectionRuleRequest>|


### See also
<xref href="Microsoft.Dynamics.CRM.duplicaterule?text=duplicaterule EntityType" /><br/><xref href="Microsoft.Dynamics.CRM.duplicaterulecondition?text=duplicaterulecondition EntityType" /><br/><a href="detect-duplicate-data-for-developers.md" data-raw-source="[Detect duplicate data](detect-duplicate-data-for-developers.md)">Detect duplicate data</a><br />
<a href="enable-disable-duplicate-detection.md" data-raw-source="[Enable and disable duplicate detection](enable-disable-duplicate-detection.md)">Enable and disable duplicate detection</a><br />
<a href="run-duplicate-detection.md" data-raw-source="[Run duplicate detection](run-duplicate-detection.md)">Run duplicate detection</a><br />
<a href="duplicate-detection-messages.md" data-raw-source="[Duplicate detection messages](duplicate-detection-messages.md)">Duplicate detection messages</a><br />
<a href="org-service/sample-enable-duplicate-detection-and-retrieve-duplicates.md" data-raw-source="[Sample: Enable duplicate detection and retrieve duplicates](org-service/sample-enable-duplicate-detection-and-retrieve-duplicates.md)">Sample: Enable duplicate detection and retrieve duplicates</a><br />
<a href="org-service/sample-use-duplicate-detection-when-creating-and-updating-records.md" data-raw-source="[Sample: Use duplicate detection when creating and updating records](org-service/sample-use-duplicate-detection-when-creating-and-updating-records.md)">Sample: Use duplicate detection when creating and updating records</a><br />
<a href="org-service/sample-detect-multiple-duplicate-records.md" data-raw-source="[Sample: Detect multiple duplicate records](org-service/sample-detect-multiple-duplicate-records.md)">Sample: Detect multiple duplicate records</a><br />



