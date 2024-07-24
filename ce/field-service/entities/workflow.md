---
title: "Process (Workflow) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Process (Workflow) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Process (Workflow) table/entity reference

Set of logical rules that define the steps necessary to automate a specific business process, task, or set of actions to be performed.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Process (Workflow) table extends the [Microsoft Dataverse Process (Workflow) table](/power-apps/developer/data-platform/reference/entities/workflow).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [Category](#BKMK_Category)
- [ThrottlingBehavior](#BKMK_ThrottlingBehavior)

### <a name="BKMK_Category"></a> Category

Changes from [Category (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/workflow#BKMK_Category)

#### Category Choices/Options

|Value|Label|
|---|---|
|9000|**Web Client API Flow**|

### <a name="BKMK_ThrottlingBehavior"></a> ThrottlingBehavior

Changes from [ThrottlingBehavior (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/workflow#BKMK_ThrottlingBehavior)

|Property|Value|
|---|---|
|DefaultFormValue||


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [adx_adx_cloudflowconsumer_ProcessId_workflow](#BKMK_adx_adx_cloudflowconsumer_ProcessId_workflow)
- [lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_processid](#BKMK_lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_processid)
- [lk_leadtoopportunitysalesprocess_processid](#BKMK_lk_leadtoopportunitysalesprocess_processid)
- [lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid](#BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid)
- [lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid](#BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid)
- [lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid](#BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid)
- [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid](#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid)
- [lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid](#BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid)
- [lk_msdyn_iottocaseprocess_processid](#BKMK_lk_msdyn_iottocaseprocess_processid)
- [lk_msdyncrm_leadtoopportunity_processid](#BKMK_lk_msdyncrm_leadtoopportunity_processid)
- [lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_processid](#BKMK_lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_processid)
- [lk_opportunitysalesprocess_processid](#BKMK_lk_opportunitysalesprocess_processid)
- [lk_phonetocaseprocess_processid](#BKMK_lk_phonetocaseprocess_processid)
- [msdyn_workflow_msdyn_entityroutingconfiguration_DeroutingProcess](#BKMK_msdyn_workflow_msdyn_entityroutingconfiguration_DeroutingProcess)
- [msdyn_workflow_msdyn_entityroutingconfiguration_RoutingProcess](#BKMK_msdyn_workflow_msdyn_entityroutingconfiguration_RoutingProcess)
- [msdyn_workflow_msdyn_macrosession_macroname](#BKMK_msdyn_workflow_msdyn_macrosession_macroname)
- [msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid](#BKMK_msdyn_workflow_msdyn_prod_agentscriptstep_macroactionid)
- [msdyn_workflow_msdyn_timespent_businessprocessflow](#BKMK_msdyn_workflow_msdyn_timespent_businessprocessflow)
- [msdyncrm_workflow_msdyncrm_launchworkflowactivity](#BKMK_msdyncrm_workflow_msdyncrm_launchworkflowactivity)
- [msdynmkt_JourneyWorkflowMapping_WorkflowId](#BKMK_msdynmkt_JourneyWorkflowMapping_WorkflowId)

### <a name="BKMK_adx_adx_cloudflowconsumer_ProcessId_workflow"></a> adx_adx_cloudflowconsumer_ProcessId_workflow

Many-To-One Relationship: [adx_cloudflowconsumer adx_adx_cloudflowconsumer_ProcessId_workflow](adx_cloudflowconsumer.md#BKMK_adx_adx_cloudflowconsumer_ProcessId_workflow)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_cloudflowconsumer`|
|ReferencingAttribute|`adx_processid`|
|ReferencedEntityNavigationPropertyName|`adx_adx_cloudflowconsumer_ProcessId_workflow`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_processid"></a> lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_processid

Many-To-One Relationship: [adx_bpf_c2857b638fa7473d8e2f112c232cebd8 lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_processid](adx_bpf_c2857b638fa7473d8e2f112c232cebd8.md#BKMK_lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_bpf_c2857b638fa7473d8e2f112c232cebd8`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_processid"></a> lk_leadtoopportunitysalesprocess_processid

Many-To-One Relationship: [leadtoopportunitysalesprocess lk_leadtoopportunitysalesprocess_processid](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`leadtoopportunitysalesprocess`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`workflow_leadtoopportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid"></a> lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid

Many-To-One Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid"></a> lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid

Many-To-One Relationship: [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid"></a> lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid

Many-To-One Relationship: [msdyn_bpf_989e9b1857e24af18787d5143b67523b lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid"></a> lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid

Many-To-One Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid"></a> lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid

Many-To-One Relationship: [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_iottocaseprocess_processid"></a> lk_msdyn_iottocaseprocess_processid

Many-To-One Relationship: [msdyn_iottocaseprocess lk_msdyn_iottocaseprocess_processid](msdyn_iottocaseprocess.md#BKMK_lk_msdyn_iottocaseprocess_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iottocaseprocess`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_iottocaseprocess_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyncrm_leadtoopportunity_processid"></a> lk_msdyncrm_leadtoopportunity_processid

Many-To-One Relationship: [msdyncrm_leadtoopportunity lk_msdyncrm_leadtoopportunity_processid](msdyncrm_leadtoopportunity.md#BKMK_lk_msdyncrm_leadtoopportunity_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_leadtoopportunity`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyncrm_leadtoopportunity_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_processid"></a> lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_processid

Many-To-One Relationship: [msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_processid](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md#BKMK_lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_processid`|
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

### <a name="BKMK_msdyncrm_workflow_msdyncrm_launchworkflowactivity"></a> msdyncrm_workflow_msdyncrm_launchworkflowactivity

Many-To-One Relationship: [msdyncrm_launchworkflowactivity msdyncrm_workflow_msdyncrm_launchworkflowactivity](msdyncrm_launchworkflowactivity.md#BKMK_msdyncrm_workflow_msdyncrm_launchworkflowactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_launchworkflowactivity`|
|ReferencingAttribute|`msdyncrm_workflowid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_workflow_msdyncrm_launchworkflowactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_JourneyWorkflowMapping_WorkflowId"></a> msdynmkt_JourneyWorkflowMapping_WorkflowId

Many-To-One Relationship: [msdynmkt_journeyworkflowmapping msdynmkt_JourneyWorkflowMapping_WorkflowId](msdynmkt_journeyworkflowmapping.md#BKMK_msdynmkt_JourneyWorkflowMapping_WorkflowId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyworkflowmapping`|
|ReferencingAttribute|`msdynmkt_workflowid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_JourneyWorkflowMapping_WorkflowId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.workflow?displayProperty=fullName>
