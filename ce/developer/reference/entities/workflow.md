---
title: "Process (Workflow) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Process (Workflow) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Process (Workflow) table/entity reference (Microsoft Dynamics 365)

Set of logical rules that define the steps necessary to automate a specific business process, task, or set of actions to be performed.

> [!NOTE]
> The Microsoft Dynamics 365 Process (Workflow) table extends the [Microsoft Dataverse Process (Workflow) table](/power-apps/developer/data-platform/reference/entities/workflow).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_Category"></a> Category

Changes from [Category (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/workflow#BKMK_Category)

#### Category Choices/Options

|Value|Label|
|---|---|
|9000|**Web Client API Flow**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [lk_leadtoopportunitysalesprocess_processid](#BKMK_lk_leadtoopportunitysalesprocess_processid)
- [lk_msdyn_iottocaseprocess_processid](#BKMK_lk_msdyn_iottocaseprocess_processid)
- [lk_opportunitysalesprocess_processid](#BKMK_lk_opportunitysalesprocess_processid)
- [lk_phonetocaseprocess_processid](#BKMK_lk_phonetocaseprocess_processid)
- [msdyn_workflow_msdyn_entityroutingconfiguration_DeroutingProcess](#BKMK_msdyn_workflow_msdyn_entityroutingconfiguration_DeroutingProcess)
- [msdyn_workflow_msdyn_entityroutingconfiguration_RoutingProcess](#BKMK_msdyn_workflow_msdyn_entityroutingconfiguration_RoutingProcess)
- [msdyn_workflow_msdyn_macrosession_macroname](#BKMK_msdyn_workflow_msdyn_macrosession_macroname)
- [msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid](#BKMK_msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid)
- [msdyn_workflow_msdyn_timespent_businessprocessflow](#BKMK_msdyn_workflow_msdyn_timespent_businessprocessflow)

### <a name="BKMK_lk_leadtoopportunitysalesprocess_processid"></a> lk_leadtoopportunitysalesprocess_processid

Many-To-One Relationship: [leadtoopportunitysalesprocess lk_leadtoopportunitysalesprocess_processid](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`leadtoopportunitysalesprocess`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`workflow_leadtoopportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_iottocaseprocess_processid"></a> lk_msdyn_iottocaseprocess_processid

Many-To-One Relationship: [msdyn_iottocaseprocess lk_msdyn_iottocaseprocess_processid](msdyn_iottocaseprocess.md#BKMK_lk_msdyn_iottocaseprocess_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iottocaseprocess`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_iottocaseprocess_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_opportunitysalesprocess_processid"></a> lk_opportunitysalesprocess_processid

Many-To-One Relationship: [opportunitysalesprocess lk_opportunitysalesprocess_processid](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunitysalesprocess`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`workflow_opportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_phonetocaseprocess_processid"></a> lk_phonetocaseprocess_processid

Many-To-One Relationship: [phonetocaseprocess lk_phonetocaseprocess_processid](phonetocaseprocess.md#BKMK_lk_phonetocaseprocess_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`phonetocaseprocess`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`workflow_phonetocaseprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workflow_msdyn_entityroutingconfiguration_DeroutingProcess"></a> msdyn_workflow_msdyn_entityroutingconfiguration_DeroutingProcess

Many-To-One Relationship: [msdyn_entityroutingconfiguration msdyn_workflow_msdyn_entityroutingconfiguration_DeroutingProcess](msdyn_entityroutingconfiguration.md#BKMK_msdyn_workflow_msdyn_entityroutingconfiguration_DeroutingProcess)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityroutingconfiguration`|
|ReferencingAttribute|`msdyn_deroutingprocess`|
|ReferencedEntityNavigationPropertyName|`msdyn_workflow_msdyn_entityroutingconfiguration_DeroutingProcess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workflow_msdyn_entityroutingconfiguration_RoutingProcess"></a> msdyn_workflow_msdyn_entityroutingconfiguration_RoutingProcess

Many-To-One Relationship: [msdyn_entityroutingconfiguration msdyn_workflow_msdyn_entityroutingconfiguration_RoutingProcess](msdyn_entityroutingconfiguration.md#BKMK_msdyn_workflow_msdyn_entityroutingconfiguration_RoutingProcess)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityroutingconfiguration`|
|ReferencingAttribute|`msdyn_routingprocess`|
|ReferencedEntityNavigationPropertyName|`msdyn_workflow_msdyn_entityroutingconfiguration_RoutingProcess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workflow_msdyn_macrosession_macroname"></a> msdyn_workflow_msdyn_macrosession_macroname

Many-To-One Relationship: [msdyn_macrosession msdyn_workflow_msdyn_macrosession_macroname](msdyn_macrosession.md#BKMK_msdyn_workflow_msdyn_macrosession_macroname)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_macrosession`|
|ReferencingAttribute|`msdyn_macroname`|
|ReferencedEntityNavigationPropertyName|`msdyn_workflow_msdyn_macrosession_macroname`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid"></a> msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid

Many-To-One Relationship: [msdyn_productivityagentscriptstep msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid](msdyn_productivityagentscriptstep.md#BKMK_msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityagentscriptstep`|
|ReferencingAttribute|`msdyn_macroactionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workflow_msdyn_timespent_businessprocessflow"></a> msdyn_workflow_msdyn_timespent_businessprocessflow

Many-To-One Relationship: [msdyn_timespent msdyn_workflow_msdyn_timespent_businessprocessflow](msdyn_timespent.md#BKMK_msdyn_workflow_msdyn_timespent_businessprocessflow)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timespent`|
|ReferencingAttribute|`msdyn_businessprocessflow`|
|ReferencedEntityNavigationPropertyName|`msdyn_workflow_msdyn_timespent_businessprocessflow`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.workflow?displayProperty=fullName>
