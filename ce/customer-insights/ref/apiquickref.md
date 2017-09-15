---
title: Microsoft Dynamics 365 for Customer Insights API Quick Reference | MicrosoftDocs
description: 
keywords: Customer Insights; quick reference; Hub API; ARM API;
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 07/26/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 4ec09442-5d10-4cd7-b367-3254a27d683b
---
Customer Insights API Quick Reference
=====================================

[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Customer Insights offers two different sets of RESTful Web interfaces for programmers: the Azure Resource Manager [(ARM) API](./armapiref.md) and the [Hub API](./hubapiref.md), 
with considerable overlap in functionality between the two. The following sets of tables enumerate these APIs by area of coverage and by functionality within each.  The 
tables in the middle section contain the functionality that is common between the two API sets, which represents the majority of the interfaces. This tables also maps the 
equivalent operations between the two APIs.  

>[!NOTE]
>To maximize comprehension and to save space, the requests in the following tables do not include supplemental query parameters, such as **api-version** or **locale**.


For ARM requests (with the exception of the [List Hub in Subscription](./arm/hublist.md) operation), `<CI-endpoint>` represents the following partial URL:

&emsp;`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights`  

For Hub requests, `<Hub-endpoint>` is a Customer Insights Hub URL of the form:

&emsp;  `https://<Hub-name>.api.azurecustomerinsights.com`

<br/>

----------
## ARM API Exclusive Functionality
The following table lists the operations only available through the Customer Insights ARM API. 

|**Operation**|**Request**|  
|-------------|---------------|
|***Hub CRUD Operations***| | 
|[Create/Update Hub](./arm/hubcreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>`|
|[Update Hub](./arm/hubupdate.md)|`PATCH <CI-endpoint>/hubs/<hubName>`|
|[Get Hub](./arm/hubget.md)|`GET <CI-endpoint>/hubs/<hubName>`|
|[List Hub in Sub](./arm/hublist.md)|`GET  https://management.azure.com/subscriptions/<subId>/providers/Microsoft.CustomerInsights/hubs`|
|[List Hub in RG](./arm/hublist.md)|`GET <CI-endpoint>/hubs`|
|[Delete Hub](./arm/hubdelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>`|
| | |

<br/>

------

## ARM API and Hub API Overlapping Functionality
The following table maps the operations that are available both through the ARM and Hub APIs.

|**Operation**|**API Set**|**Request**|  
|-------------|-----------|---------------|
|***SAS Policy Management Operations*** | | | 
|Create Or Update SAS Policy|[ARM](./arm/authzpolicycreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/authorizationPolicies/<policyName>`| 
|    &nbsp;   |[Hub](./hub/authzpolicycreateupdate.md)|`PUT <hub-endpoint>/manage/sas/policies/<policyName>`| 
|Get SAS Policy|[ARM](./arm/authzpolicyget.md)|`GET <CI-endpoint>/hubs/<hubName>/authorizationPolicies/<policyName>`| 
|    &nbsp;   |[Hub](./hub/authzpolicyget.md)|`GET <hub-endpoint>/manage/sas/policies/<policyName>`| 
|List SAS Policies|[ARM](./arm/authzpolicylist.md)|`GET <CI-endpoint>/hubs/<hubName>/authorizationPolicies`| 
|    &nbsp;   |[Hub](./hub/authzpolicylist.md)|`GET <hub-endpoint>/manage/sas/policies`| 
|Regenerate Policy Primary Key|[ARM](./arm/authzpolicyregenprimkey.md)|`POST <CI-endpoint>/hubs/<hubName>/authorizationPolicies/<policyName>/regeneratePrimaryKey`| 
|    &nbsp;   |[Hub](./hub/authzpolicyregenprimkey.md)|`POST <hub-endpoint>/manage/sas/policies/<policyName>/regeneratePrimaryKey`| 
|Regenerate Policy Secondary Key|[ARM](./arm/authzpolicyregenseckey.md)|`POST <CI-endpoint>/hubs/<hubName>/authorizationPolicies/<policyName>/regenerateSecondaryKey`| 
|    &nbsp;   |[Hub](./hub/authzpolicyregenseckey.md)|`POST <hub-endpoint>/manage/sas/policies/<policyName>/regenerateSecondaryKey`| 
| | | | 
|***RBAC Management Operations***| | | 
|Create or Update Role Assignment|[ARM](./arm/rbacroleasgncreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/roleAssignments/<assignmentName>`| 
|    &nbsp;   |[Hub](./hub/rbacroleasgncreateupdate.md)|`PUT <hub-endpoint>/manage/rbac/roleAssignments/<assignmentName>`| 
|Get Role Assignment Type|[ARM](./arm/rbacroleasgnget.md)|`GET <CI-endpoint>/hubs/<hubName>/roleAssignments/<assignmentName>`| 
|    &nbsp;   |[Hub](./hub/rbacroleasgnget.md)|`GET <hub-endpoint>/manage/rbac/roleAssignments/<assignmentName>`| 
|List Role Assignment Types|[ARM](./arm/rbacroleasgnlist.md)|`GET <CI-endpoint>/hubs/<hubName>/roleAssignments`| 
|    &nbsp;   |[Hub](./hub/rbacroleasgnlist.md)|`GET <hub-endpoint>/manage/rbac/roleAssignments`| 
|Delete Role Assignment|[ARM](./arm/rbacroleasgndelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>/RoleAssignments/<assignmentName>`| 
|    &nbsp;   |[Hub](./hub/rbacroleasgndelete.md)|`DELETE <hub-endpoint>/manage/rbac/roleAssignments/<assignmentName>`| 
|List Role Types|[ARM](./arm/rbacrolelist.md)|`GET <CI-endpoint>/hubs/<hubName>/roles`| 
|    &nbsp;   |[Hub](./hub/rbacrolelist.md)|`GET <hub-endpoint>/manage/rbac/roles`| 
| | | | 
|***Fundamental Type Modeling Operations***| | |
|Create Or Update Profile Type|[ARM](./arm/profilecreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/profiles/<profileName>`| 
|    &nbsp;   |[Hub](./hub/profilecreateupdate.md)|`PUT <Hub-endpoint>/manage/model/profiles/<profileName>`| 
|Get Profile Type|[ARM](./arm/profileget.md)|`GET <CI-endpoint>/hubs/<hubName>/profiles/<profileName>`| 
|    &nbsp;   |[Hub](./hub/profileget.md)|`GET <Hub-endpoint>/manage/model/profiles/<profileName>`| 
|Get Enriching KPIs for Profile|[ARM](./arm/profileget.md)|`GET <CI-endpoint>/hubs/<hubName>/profiles/<profileName>/getEnrichingKpis`| 
|    &nbsp;   |[Hub](./hub/profileget.md)|`GET <Hub-endpoint>/manage/model/profiles/<profileName>/getEnrichingKpis`| 
|List Profile Types|[ARM](./arm/profilelist.md)|`GET <CI-endpoint>/hubs/<hubName>/profiles`| 
|    &nbsp;   |[Hub](./hub/profilelist.md)|`GET <Hub-endpoint>/manage/model/profiles`| 
|Delete Profile Type|[ARM](./arm/profiledelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>/profiles/<profileName>`| 
|    &nbsp;   |[Hub](./hub/profiledelete.md)|`DELETE <Hub-endpoint>/manage/model/profiles/<profileName>`| 
|Create Or Update Interaction Type|[ARM](./arm/interactioncreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/interactions/<interactionName>`| 
|    &nbsp;   |[Hub](./hub/interactioncreateupdate.md)|`PUT <Hub-endpoint>/manage/model/interactions/<interactionName>`| 
|Get Interaction Type|[ARM](./arm/interactionget.md)|`GET <CI-endpoint>/hubs/<hubName>/interactions/<interactionName>`| 
|    &nbsp;   |[Hub](./hub/interactionget.md)|`GET <Hub-endpoint>/manage/model/interactions/<interactionName>`| 
|List Interaction Types|[ARM](./arm/interactionlist.md)|`GET <CI-endpoint>/hubs/<hubName>/interactions`| 
|    &nbsp;   |[Hub](./hub/interactionlist.md)|`GET <Hub-endpoint>/manage/model/interactions`| 
|Suggest Relationships|[ARM](./arm/interactionsugrellinks.md)|`POST <CI-endpoint>/hubs/<hubName>/interactions/<interactionName>/suggestRelationshipLinks`| 
|    &nbsp;   |[Hub](./hub/interactionsugrellinks.md)|`POST <Hub-endpoint>/manage/model/interactions/<interactionName>/suggestRelationshipLinks`| 
|Create Or Update Relationship Type|[ARM](./arm/relationshipcreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/relationships/<relationshipName>`| 
|    &nbsp;   |[Hub](./hub/relationshipcreateupdate.md)|`PUT <Hub-endpoint>/manage/model/relationships/<relationshipName>`| 
|Get Relationship Type|[ARM](./arm/relationshipget.md)|`GET <CI-endpoint>/hubs/<hubName>/relationships/<relationshipName> `| 
|    &nbsp;   |[Hub](./hub/relationshipget.md)|`GET <Hub-endpoint>/manage/model/relationships/<relationshipName>`| 
|List Relationship Types|[ARM](./arm/relationshiplist.md)|`GET <CI-endpoint>/hubs/<hubName>/relationships`| 
|    &nbsp;   |[Hub](./hub/relationshiplist.md)|`GET <Hub-endpoint>/manage/model/relationships`| 
|Delete Relationship Type|[ARM](./arm/relationshipdelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>/relationships/<relationshipName> `| 
|    &nbsp;   |[Hub](./hub/relationshipdelete.md)|`DELETE <Hub-endpoint>/manage/model/relationships/<relationshipName>`| 
| | | |
|***Link Management Operations***| | | 
|Create or Update Link Type|[ARM](./arm/linkcreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/links/<linkName>`| 
|    &nbsp;   |[Hub](./hub/linkcreateupdate.md)|`PUT <hub-endpoint>/manage/model/links/<linkName>`| 
|Get Link Type|[ARM](./arm/linkget.md)|`GET <CI-endpoint>/hubs/<hubName>/links/<linkName>`| 
|    &nbsp;   |[Hub](./hub/linkget.md)|`GET <hub-endpoint>/manage/model/links/<linkName>`| 
|List Link Types|[ARM](./arm/linklist.md)|`GET <CI-endpoint>/hubs/<hubName>/links`| 
|    &nbsp;   |[Hub](./hub/linklist.md)|`GET <hub-endpoint>/manage/model/links`| 
|Delete Link|[ARM](./arm/linkdelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>/links/<linkName>`| 
|    &nbsp;   |[Hub](./hub/linkdelete.md)|`DELETE <hub-endpoint>/manage/model/links/<linkName>`| 
|Create Or Update Relationship Link Type|[ARM](./arm/relationshiplinkcreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/relationshipLinks/<relationshipLinkName>`| 
|    &nbsp;   |[Hub](./hub/relationshiplinkcreateupdate.md)|`PUT <Hub-endpoint>/manage/model/relationshipLinks/<relationshipLinkName>`| 
|Get Relationship Link Type|[ARM](./arm/relationshiplinkget.md)|`GET <CI-endpoint>/hubs/<hubName>/relationshipLinks/<relationshipLinkName> `| 
|    &nbsp;   |[Hub](./hub/relationshiplinkget.md)|`GET <Hub-endpoint>/manage/model/relationshipLinks/<relationshipLinkName>`| 
|List Relationship Link Types|[ARM](./arm/relationshiplinklist.md)|`GET <CI-endpoint>/hubs/<hubName>/relationshipLinks`| 
|    &nbsp;   |[Hub](./hub/relationshiplinklist.md)|`GET <Hub-endpoint>/manage/model/relationshipLinks`| 
|Delete Relationship Link Type|[ARM](./arm/relationshiplinkdelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>/relationshipLinks/<relationshipLinkName> `| 
|    &nbsp;   |[Hub](./hub/relationshiplinkdelete.md)|`DELETE <Hub-endpoint>/manage/model/relationshipLinks/<relationshipLinkName>`| 
| | | |
|***Segmentation Management Operations***| | | 
|Create or Update Dynamic Segment Type|[ARM](./arm/segdyncreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/segments/dynamic/<segmentName>`| 
|    &nbsp;   |[Hub](./hub/segdyncreateupdate.md)|`PUT <hub-endpoint>/manage/model/segments/dynamic/<segmentName>`| 
|Create or Update Static Segment Type|[ARM](./arm/segstatcreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/segments/static/<segmentName>`| 
|    &nbsp;   |[Hub](./hub/segstatcreateupdate.md)|`PUT <hub-endpoint>/manage/model/segments/static/<segmentName>`| 
|Get Segment Type|[ARM](./arm/segget.md)|`GET <CI-endpoint>/hubs/<hubName>/segments/<segmentName>`| 
|    &nbsp;   |[Hub](./hub/segget.md)|`GET <Hub-endpoint>/manage/model/segments/<segmentName>`| 
|List Segment Types|[ARM](./arm/seglist.md)|`GET <CI-endpoint>/hubs/<hubName>/segments`| 
|    &nbsp;   |[Hub](./hub/seglist.md)|`GET <Hub-endpoint>/manage/model/segments`| 
|Delete Segment Type|[ARM](./arm/segdelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>/segments/<segmentName>`| 
|    &nbsp;   |[Hub](./hub/segdelete.md)|`DELETE <hub-endpoint>/manage/model/segments/<segmentName>`| 
| | | |
|***KPI Management Operations***| | | 
|Create or Update KPI Type|[ARM](./arm/kpicreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/kpi/<kpiName>`| 
|    &nbsp;   |[Hub](./hub/kpicreateupdate.md)|`PUT <hub-endpoint>/manage/model/kpi/<kpiName>`| 
|Get KPI Type|[ARM](./arm/kpiget.md)|`GET <CI-endpoint>/hubs/<hubName>/kpi/<kpiName>`| 
|    &nbsp;   |[Hub](./hub/kpiget.md)|`GET <hub-endpoint>/manage/model/kpi/<kpiName>`| 
|List KPI Types|[ARM](./arm/kpilist.md)|`GET <CI-endpoint>/hubs/<hubName>/kpi`| 
|    &nbsp;   |[Hub](./hub/kpilist.md)|`GET <hub-endpoint>/manage/model/kpi`| 
|Delete KPI Type|[ARM](./arm/kpidelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>/kpi/<kpiName>`| 
|    &nbsp;   |[Hub](./hub/kpidelete.md)|`DELETE <hub-endpoint>/manage/model/kpi/<kpiName>`| 
|Reprocess KPI|[ARM](./arm/kpireprocess.md)|`POST <CI-endpoint>/hubs/<hubName>/kpi/<kpiName>/reprocess`| 
|    &nbsp;   |[Hub](./hub/kpidelete.md)|`POST <hub-endpoint>/manage/model/kpi/<kpiName>/reprocess`| 
| | | |
|***Predictive Analysis (Scoring) Management Operations***| | | 
|Create or Update Prediction Type|[ARM](./arm/predscoringcreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/predictions/<predictionName>`|
|    &nbsp;   |[Hub](./hub/predscoringcreateupdate.md)|`PUT <hub-endpoint>/manage/model/predictions/<predictionName>`| 
|Get Prediction Type|[ARM](./arm/predscoringget.md)|`GET <CI-endpoint>/hubs/<hubName>/predictions/<predictionName>`|
|    &nbsp;   |[Hub](./hub/predscoringget.md)|`GET <Hub-endpoint>/manage/model/predictions/<predictionName>`| 
|List Prediction Types|[ARM](./arm/predscoringlist.md)|`GET <CI-endpoint>/hubs/<hubName>/predictions`|
|    &nbsp;   |[Hub](./hub/predscoringlist.md)|`GET <Hub-endpoint>/manage/model/predictions`| 
|Delete Prediction Type|[ARM](./arm/predscoringdelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>/predictions/<predictionName>`|
|    &nbsp;   |[Hub](./hub/predscoringdelete.md)|`DELETE <Hub-endpoint>/manage/model/predictions/<predictionTypeName>`| 
|Create or Update Model Status Type|[ARM](./arm/predscoringcreateupdatemodelstatus.md)|`POST <CI-endpoint>/hubs/<hubName>/predictions/<predictionName>/modelStatus`|
|    &nbsp;   |[Hub](./hub/predscoringcreateupdatemodelstatus.md)|`POST <Hub-endpoint>/manage/model/predictions/<predictionName>/modelStatus`| 
|Get Model Status|[ARM](./arm/predscoringgetmodelstatus.md)|`POST <CI-endpoint>/hubs/<hubName>/predictions/<predictionName>/getModelStatus`|
|    &nbsp;   |[Hub](./hub/predscoringgetmodelstatus.md)|`POST <Hub-endpoint>/manage/model/predictions/<predictionName>/getModelStatus`| 
|Get Training Results|[ARM](./arm/predscoringgettrainingresults.md)|`POST <CI-endpoint>/hubs/<hubName>/predictions/<predictionName>/getTrainingResults`|
|    &nbsp;   |[Hub](./hub/predscoringgettrainingresults.md)|`POST <Hub-endpoint>/manage/model/predictions/<predictionName>/getTrainingResults`| 
| | | |
|***Image Management Operations***| | |
|Get Image Upload URL for Metadata|[ARM](./arm/imagegetuploadurlmetadata.md)|`POST <CI-endpoint>/hubs/<hubName>/media/getEntityTypeImageUploadUrl`| 
|    &nbsp;   |[Hub](./hub/imagegetuploadurlmetadata.md)|`POST <Hub-endpoint>/manage/model/media/getEntityTypeImageUploadUrl`| 
|Get Image Upload URL for Instance|[ARM](./arm/imagegetuploadurlinstance.md)|`POST <CI-endpoint>/hubs/<hubName>/media/getDataImageUploadUrl`| 
|    &nbsp;   |[Hub](./hub/imagegetuploadurlinstance.md)|`POST <Hub-endpoint>/manage/model/media/getDataImageUploadUrl`| 
| | | | 
|***Data Connector Management Operations*** | | | 
|Create or Update Data Connector|[ARM](./arm/dataconcreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/connectors/<connectorName>`| 
|    &nbsp;   |[Hub](./hub/dataconcreateupdate.md)|`PUT <hub-endpoint>/manage/connectors/<connectorName>`| 
|Get Data Connector |[ARM](./arm/dataconget.md)|`GET <CI-endpoint>/hubs/<hubName>/connectors/<connectorName>`| 
|    &nbsp;   |[Hub](./hub/dataconget.md)|`GET <hub-endpoint>/manage/connectors/<connectorName>`| 
|List Data Connectors|[ARM](./arm/dataconlist.md)|`GET <CI-endpoint>/hubs/<hubName>/connectors`| 
|    &nbsp;   |[Hub](./hub/dataconlist.md)|`GET <hub-endpoint>/manage/connectors`| 
|Delete Data Connector|[ARM](./arm/datacondelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>/connectors/<connectorName>`| 
|    &nbsp;   |[Hub](./hub/datacondelete.md)|`DELETE <hub-endpoint>/manage/connectors/<connectorName>`| 
|Create or Update Data Connector Mapping|[ARM](./arm/dataconmapcreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/connectors/<connectorName>/mappings/<mappingName>`| 
|    &nbsp;   |[Hub](./hub/dataconmapcreateupdate.md)|`PUT <hub-endpoint>/manage/connectors/<connectorName>/mappings/<mappingName>`| 
|Get Data Connector Mapping|[ARM](./arm/dataconmapget.md)|`GET <CI-endpoint>/hubs/<hubName>/connectors/<connectorName>/mappings/<mappingName>`| 
|    &nbsp;   |[Hub](./hub/dataconmapget.md)|`GET <hub-endpoint>/connectors/<connectorName>/mappings/<mappingName>`| 
|List Data Connector Mappings|[ARM](./arm/dataconmaplist.md)|`GET <CI-endpoint>/hubs/<hubName>/connectors`| 
|    &nbsp;   |[Hub](./hub/dataconmaplist.md)|`GET <hub-endpoint>/manage/connectors`| 
|Delete Data Connector Mapping|[ARM](./arm/dataconmapdelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>/connectors/<connectorName>/mappings/<mappingName>`| 
|       &nbsp;       |[Hub](./hub/dataconmapdelete.md)|`DELETE <hub-endpoint>/connectors/<connectorName>/mappings/<mappingName>`| 
| | | | 
|***App Packaging Management Operations***| | | 
|Get Widget Type|[ARM](./arm/apppackwidgetget.md)|`GET <CI-endpoint>/hubs/<hubName>/widgetTypes/<widgetName>`| 
|    &nbsp;   |[Hub](./hub/apppackwidgetget.md)|`GET <hub-endpoint>/manage/widgetTypes/<widgetName>`| 
|List Widget Types|[ARM](./arm/apppackwidgetlist.md)|`GET <CI-endpoint>/hubs/<hubName>/widgetTypes`| 
|    &nbsp;   |[Hub](./hub/apppackwidgetlist.md)|`GET <hub-endpoint>/manage/widgetTypes`| 
|Create or Update App View|[ARM](./arm/apppackviewcreateupdate.md)|`PUT <CI-endpoint>/hubs/<hubName>/views/<viewName>`| 
|    &nbsp;   |[Hub](./hub/apppackviewcreateupdate.md)|`PUT <hub-endpoint>/manage/views/<viewName>&userId=<userId>`| 
|Get App View|[ARM](./arm/apppackviewget.md)|`GET <CI-endpoint>/hubs/<hubName>/views/<viewName>`| 
|    &nbsp;   |[Hub](./hub/apppackviewget.md)|`GET <hub-endpoint>/manage/views/<viewName>&userId=<userId>`| 
|List App Views|[ARM](./arm/apppackviewlist.md)|`GET <CI-endpoint>/hubs/<hubName>/views`| 
|    &nbsp;   |[Hub](./hub/apppackviewlist.md)|`GET <hub-endpoint>/manage/views&userId=<userId>`| 
|Delete App View|[ARM](./arm/apppackviewdelete.md)|`DELETE <CI-endpoint>/hubs/<hubName>/views/<viewName>`| 
|    &nbsp;   |[Hub](./hub/apppackviewdelete.md)|`DELETE <hub-endpoint>/manage/views/<viewName>&userId=<userId>`| 
| | | | 

<br/> 

------

## Hub API Exclusive Functionality
The following table lists the operations only available through the Customer Insights Hub API. These include operations on entity instances, grouped in the section [Hub Data APIs](./hubdataapiref.md).  The following examples use "Contacts" as a custom Profile entity-set type.

|**Operation**|**Request**|  
|-------------|---------------|
|***Predicitive Matching Policy Management Operations***| | 
|Create or Update Predictive Match Policy|`PUT <hub-endpoint>/manage/model/predictiveMatchPolicies/<policyName>`| 
|Get a Predictive Match Policy Type|`GET <hub-endpoint>/manage/model/predictiveMatchPolicies/<policyName>`| 
|List Predictive Match Policy Types|`GET <hub-endpoint>/manage/model/predictiveMatchPolicies`|
|Delete Predictive Match Policy|`DELETE <hub-endpoint>/manage/model/predictiveMatchPolicies/<policyName>`|
| | |
|***Hub Data Operations***| | 
|[Create Profile instance](./hubdata/profilecreateinstance.md)|`POST <hub-endpoint>/data/Contacts`|
|[List All Profile Instances](./hubdata/profilelistinstances.md)|`GET <hub-endpoint>/data/Contacts`|
|[Get Profile Instance by ID](./hubdata/profilegetinstanceid.md)|`GET <hub-endpoint>/data/Contacts('<spid>')`|
|[Create Interaction Instance](./hubdata/interactioncreateinstance.md)|`POST <hub-endpoint>/data/Interactions`|
|[List Interactions associated with Profile Type](./hubdata/interactionlistviaprofile.md)|`GET <hub-endpoint>/data/Contacts('<contactid>')/Interactions`|
|[Create Relationship instance](./hubdata/relationshipcreateinstance.md)|`POST <hub-endpoint>/data/Relationship`| 
|[Delete Relationship instance](./hubdata/relationshipdeleteinstance.md)|`POST <hub-endpoint>/data/Relationships` with custom header `X-HTTP-Method: DELETE`| 
|[List Relationship Instances](./hubdata/relationshiplistinstance.md)| _[various]_ |
|[List all Segment Instances](./hubdata/seggetinstance.md)|`GET <hub-endpoint>/data/segments(<segmentName>)`|
|[List Segment Members](./hubdata/seglistmembers.md)|`GET <hub-endpoint>/data/segments/<segmentName>/members`|
|[List Added Segment Members](./hubdata/seglistaddedmembers.md)|`GET <Hub-endpoint>/data/segments/<segmentName>/addedMembersDelta?continuationToken=<continuationToken>&batchSize=<batchSize>`|
|[Estimate Segment Result Count](./hubdata/segestimation.md)|`POST <Hub-endpoint>/data/segments/estimation`|
|[Segmentation Query Evaluation](./hubdata/segqueryeval.md)|`POST <Hub-endpoint>/data/segments/evaluation`|
|[Create Blob Bulk Ingestion Job](./hubdata/bulkingestcreate.md)|`POST <hub-endpoint>/data/BlobIngestionJobs`|
|[Query Blob Bulk Ingestion Jobs](./hubdata/bulkingestquery.md)|`GET hub-endpoint>/data/BlobIngestionJobs`|
|[Query KPI Data](./hubdata/kpiquerydata.md)|`GET <hub-endpoint>/data/KPIs(KpiName='<kpiName>',WindowType='<period>')/Values`|
|[Get KPI data for Profile ID](./hubdata/kpigetviaprofileid.md)|`GET <hub-endpoint>/data/Contacts('<contactId>')/KPIs(KpiName='<kpiName>',WindowType='<period>')/Values`| 
| | |

<br/> 

