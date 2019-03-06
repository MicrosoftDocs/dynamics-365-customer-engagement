---
title: "msdyn_forecastdefinition EntityType | MicrosoftDocs"
description: "Entity reference for msdyn_forecastdefinition EntityType"
keywords: 
ms.date: 03/05/2019
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 069F9158-8D8A-4892-BD41-3CA6E7EF16D9
author: susikka
ms.author: susikka
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 22
topic-status: Drafting
---
# msdyn_forecastdefinition EntityType

[!INCLUDE[msdyn_forecastdefinition-description](../includes/msdyn_forecastdefinition-description.md)]

Entity Set Path: `[organizationURI]/api/data/v9.1/msdyn_forecastdefinitions`<br />
Display Name: Forecast definition <br />
Primary key: msdyn_forecastdefinitionid <br />
Operations supported: Create, Retrieve, Update and Delete<br />

## Properties

Properties represent fields of data stored in the entity. Some properties are read-only.

|Name|Type|
|-----|-----|
|timezoneruleversionnumber|Edm.Int32|
|msdyn_forecastdefinitionid|Edm.Guid|
|overriddencreatedon|Edm.DateTimeOffset|
|_owninguser_value|Edm.Guid|
|_msdyn_metricid_value|Edm.Guid|
|msdyn_fiscalquarter|Edm.Int32|
|msdyn_quotasource|Edm.Int32|
|importsequencenumber|Edm.Int32|
|msdyn_fiscalmonth|Edm.Int32|
|utcconversiontimezonecode|Edm.Int32|
|msdyn_forecastdefinitionname|Edm.String" Unicode="false|
|msdyn_numberofrecurrences|Edm.Int32|
|statecode|Edm.Int32|
|_msdyn_rollupquery_value|Edm.Guid|
|versionnumber|Edm.Int64|
|msdyn_forecastperiodtype|Edm.Int32|
|createdon|Edm.DateTimeOffset|
|_modifiedonbehalfby_value|Edm.Guid|
|_owningteam_value|Edm.Guid|
|msdyn_validto|Edm.Date|
|msdyn_fiscalyear|Edm.Int32|
|modifiedon|Edm.DateTimeOffset|
|msdyn_validfrom|Edm.Date|
|_owningbusinessunit_value|Edm.Guid|
|statuscode|Edm.Int32|
|_createdby_value|Edm.Guid|
|_ownerid_value|Edm.Guid|
|_modifiedby_value|Edm.Guid|
|_createdonbehalfby_value|Edm.Guid|

## Navigation properties

|Name|Type|Partner|
|-----|-----|-----|
|createdby|mscrm.systemuser|lk_msdyn_forecastdefinition_createdby|
|createdonbehalfby|mscrm.systemuser|lk_msdyn_forecastdefinition_createdonbehalfby|
|modifiedby|mscrm.systemuser|lk_msdyn_forecastdefinition_modifiedby|
|modifiedonbehalfby|mscrm.systemuser|lk_msdyn_forecastdefinition_modifiedonbehalfby|
|owninguser|mscrm.systemuser|user_msdyn_forecastdefinition|
|owningteam|mscrm.team|team_msdyn_forecastdefinition|
|ownerid|mscrm.principal|owner_msdyn_forecastdefinition|
|owningbusinessunit|mscrm.businessunit|business_unit_msdyn_forecastdefinition|
|msdyn_forecastdefinition_SyncErrors|Collection(mscrm.syncerror)|regardingobjectid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_DuplicateMatchingRecord|Collection(mscrm.duplicaterecord)|duplicaterecordid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_DuplicateBaseRecord|Collection(mscrm.duplicaterecord)|baserecordid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_AsyncOperations|Collection(mscrm.asyncoperation)|regardingobjectid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_MailboxTrackingFolders|Collection(mscrm.mailboxtrackingfolder)|regardingobjectid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_ProcessSession|Collection(mscrm.processsession)|regardingobjectid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_BulkDeleteFailures|Collection(mscrm.bulkdeletefailure)|regardingobjectid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_PrincipalObjectAttributeAccesses|Collection(mscrm.principalobjectattributeaccess)|objectid_msdyn_forecastdefinition|
|msdyn_metricid|mscrm.metric|msdyn_metric_msdyn_forecastdefinition_metricid|
|msdyn_msdyn_forecastdefinition_msdyn_forecastinstance|Collection(mscrm.msdyn_forecastinstance)|msdyn_forecastdefinitionid|
|msdyn_rollupquery|mscrm.goalrollupquery|msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery|
|msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence|Collection(mscrm.msdyn_forecastrecurrence)|msdyn_ForecastDefinitionId|

## See also

[Custom actions for Manual forecasting](../custom-actions-manual-forecasting.md)<br />
[msdyn_forecastinstance EntityType](msdyn_forecastinstance.md)<br />
[msdyn_forecastrecurrence EntityType](msdyn_forecastrecurrence.md)