---
title: "Create or edit how business rules are initiated | MicrosoftDocs"
description: "Business rules allow for defining logic that takes place in a form. Business rules provide an alternative to form scripts because they can be defined within a user interface without writing code."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 250c9a3b-7ae1-480d-8bac-0ac72a32bc4f
caps.latest.revision: 12
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Create or edit how business rules are initiated

Business rules allow for defining logic that takes place in a form. Business rules provide an alternative to form scripts because they can be defined within a user interface without writing code. Business rules do not offer any opportunities for the actions they perform to be extended in this release, but by using the Process Trigger entity, you can modify how existing business rules are initiated or register an existing business rule to different events that will initiate it.

 [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create business rules and recommendations](../../customize/create-business-rules-recommendations-apply-logic-form.md)

## Registering business rules

 When you create a business rule, you must set the scope and configure conditions that will initiate the business rule. The business rule editor stores this information in the Process Trigger entity. You can read, create, update, and delete process trigger records to modify how business rules are initiated.

 The primary scenarios for working with the process trigger entity are:
- Clone a business rule that is applied to one or more forms to another form.
- Modify a business rule that is applied to one or more forms so that it applies to all forms.
- Modify a business rule that is applied to all forms so that it applies only to one or more specific forms.
- Register a business rule to be applied on the Save event.

> [!NOTE]
> If you use the business rule editor to modify a business rule that has been programmatically set to be applied on the Save event, it will revert to either load or change. You must re-apply the change programmatically to have the rule applied on the Save event.

 The following table describes relevant process trigger entity attributes.

|SchemaName|Type|Description|
|----------------|----------|-----------------|
|`ControlName`|String|Name of the attribute that a change event is registered for. For other events this value is null.|
|`ControlType`|Picklist|Type of the control to which this trigger is bound.<br /> The only valid value for this release is 1. This indicates that the control is an attribute. This value only applies when the `ControlName` is not null.|
|`Event`|String|There are three valid values to indicate the event:<br /> -   `load`<br />-   `change`<br />-   `save`|
|`FormId`|Lookup|ID of the form associated with the business rule.<br /> This value is null when the rule applies to all forms for the entity that supports business rules.|
|`IsCustomizable`|ManagedProperty|Information that specifies whether this component can be customized.<br /> You cannot change process trigger records included in a managed solution when the `IsCustomizable.Value` is false.|
|`PrimaryEntityTypeCode`|EntityName|Logical name for the entity that the business rule is applied on.|
|`ProcessId`|Lookup|ID of the process.|
|`ProcessTriggerId`|Uniqueidentifier|ID of the process trigger record.|

### See also

 [Create business rules and recommendations](../../customize/create-business-rules-recommendations-apply-logic-form.md)
 <!--
 Add back after Web API reference regen
 [ProcessTrigger Entity]/entities/processtrigger.md)
 -->


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]