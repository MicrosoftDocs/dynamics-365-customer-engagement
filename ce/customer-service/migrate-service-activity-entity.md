---
title: "Migrate Service Activity entity(Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Service Activity is not directly available in the new scheduling experience. Read how you can migrate Service activity to the new scheduling experience."
ms.custom: ""
ms.date: 11/27/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0965FCB8-22B4-47B6-931B-D0AE31722E30
author: "susikka"
ms.author: "susikka"
manager: "shujoshi"
---
# Migrate Service Activity entity

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Service Activity entity in Service Scheduling cannot be migrated through UI. We can use Dynamics 365 Web API or Organization Service to do this. This topic shows how we can using Dynamics 365 Organization Service to migrate the Service Activity entity.

The below sample performs the following actions:
1. [Fetch Service Activity entity record](#bkmk_retrieve): It fetches Service Activity entity records from `serviceappointment` table.
2. [Create a new Requirement group by cloning or copying the existing Selection Rules](#bkmk_requirementmapping): Then, for each of the retrieved `serviceappointment` records, we create a mapping between `newRequirementGroup` and `existingSelectionRule`.
3. [Create new Resource Requirement record by copying or cloning the existing Selection Rules](#bkmk_resourcemapping): As we did in the above step, similarly, we will create a mapping between `newResourceRequirement` and `existingSelectionRule`.
4. [Create a new Bookable Resource entity record for each Activity Party entity record](#bkmk_newbookableresourcerecord): We now create a new `BookableResourceBooking` entity record for each `ActivityParty` entity record, and map their attributes.

The complete sample for migrating Service Activity entity records, can be found here [Sample: Migrate Service Activity entity](migrate-service-activity-org-service.md).

<a name="bkmk_retrieve"></a>

#### Fetch Service Activity entity records

The below code snippet shows how we can fetch Service Activity entity records from `serviceappointment` table. 

```csharp
QueryExpression serviceActivityQuery = new QueryExpression("serviceappointment");
serviceActivityQuery.ColumnSet = new ColumnSet(true);

EntityCollection serviceActivityCol;
serviceActivityCol = _serviceProxy.RetrieveMultiple(serviceActivityQuery);
```

<a name="bkmk_requirementmapping"></a>

#### Create a new Requirement Group record by cloning or copying the existing Requirement Group record

```csharp
Guid serviceID = entity.GetAttributeValue<EntityReference>("serviceid").Id;

Guid appointmentID = entity.GetAttributeValue<Guid>("activityid");

QueryExpression serviceQuery = new QueryExpression("service");
serviceQuery.ColumnSet = new ColumnSet(true);
serviceQuery.Criteria = new FilterExpression();
serviceQuery.Criteria.AddCondition("serviceid", ConditionOperator.Equal, serviceID);

Entity service = _serviceProxy.Retrieve("service", new Guid(serviceID.ToString()), new ColumnSet(true));

//Fetch the requirementGroupID for the service and clone the Requirement Group and resource requirement
EntityReference existingSelectionRuleID = service.GetAttributeValue<EntityReference>("msdyn_requirementgroupid");
Entity existingSelectionRule = _serviceProxy.Retrieve("msdyn_requirementgroup", existingSelectionRuleID.Id, new ColumnSet(true));


Entity newRequirementGroup = new Entity("msdyn_resourcerequirement");
EntityReference rgOwnerID = existingSelectionRule.GetAttributeValue<EntityReference>("ownerid");
newRequirementGroup["ownerid"] = rgOwnerID.Id;
int rgOwnerIDType = existingSelectionRule.GetAttributeValue<int>("owneridtype");
newRequirementGroup["owneridtype"] = rgOwnerIDType;
var rgStateCode = existingSelectionRule.GetAttributeValue<OptionSetValue>("statecode");
newRequirementGroup["statecode"] = rgStateCode;
string rgName = existingSelectionRule.GetAttributeValue<string>("msdyn_name");
newRequirementGroup["msdyn_name"] = rgName;
newRequirementGroup["msdyn_istemplate"] = 0;
                        
Guid _newRequirementGroupID = _service.Create(newRequirementGroup);

```
<a name="bkmk_resourcemapping"></a>

#### Create new Resource Requirement record by copying or cloning the existing Selection Rules

As we created a mapping between `newRequirementGroup` and `existingSelectionRule` in the above code snippet, similarly, we will create a mapping between `newResourceRequirement` and `existingResourceRequirement`, that are records of entity `msdyn_resourcerequirement`.

```csharp
QueryExpression existingResourceRequirementQuery = new QueryExpression("msdyn_resourcerequirement");
existingResourceRequirementQuery.ColumnSet = new ColumnSet(true);
existingResourceRequirementQuery.Criteria = new FilterExpression();
existingResourceRequirementQuery.Criteria.AddCondition("msdyn_requirementgroupid", ConditionOperator.Equal, existingSelectionRuleID.Id);
EntityCollection existingResourceRequirement = _serviceProxy.RetrieveMultiple(existingResourceRequirementQuery);

// Create/clone records for each msdyn_resourcerequirement entity record
foreach (Entity entityRR in existingResourceRequirement.Entities)
{
       Entity newResourceRequirement = new Entity("msdyn_resourcerequirement");
        newResourceRequirement["msdyn_requirementgroupid"] = _newRequirementGroupID;
        newResourceRequirement["serviceappointment"] = appointmentID;
        EntityReference rrOwnerID = entityRR.GetAttributeValue<EntityReference>("ownerid");
        newResourceRequirement["ownerid"] = rrOwnerID.Id;
        int rrOwnerIDType = entityRR.GetAttributeValue<int>("owneridtype");
        newResourceRequirement["owneridtype"] = rrOwnerIDType;
        var rrStateCode = entityRR.GetAttributeValue<OptionSetValue>("statecode");
        newResourceRequirement["statecode"] = rrStateCode;
        Guid _newResourceRequirementID = _service.Create(newResourceRequirement);
}

```
<a name="bkmk_newbookableresourcerecord"></a>

#### Create a new `BookableResourceBooking` entity record for each `ActivityParty` entity record

```csharp
// Create new Bookable Resource booking for each ActivityParty entity record
QueryExpression activityPartyQuery = new QueryExpression("activityparty");
activityPartyQuery.ColumnSet = new ColumnSet(true);
activityPartyQuery.Criteria = new FilterExpression();
activityPartyQuery.Criteria.AddCondition("activityid", ConditionOperator.Equal, appointmentID);
EntityCollection activityPartyCol =  _serviceProxy.RetrieveMultiple(activityPartyQuery);
foreach (Entity entityRR in activityPartyCol.Entities)
{
             Entity newBookableResourceBooking = new Entity("bookableresourcebooking");
             //Fill all required fields 
             newBookableResourceBooking["starttime"] = entityRR.GetAttributeValue<DateTime>("scheduledstart");
             newBookableResourceBooking["endtime"] = entityRR.GetAttributeValue<DateTime>("scheduledend");
             newBookableResourceBooking["msdyn_bookingsetupmetadataidname"] = "serviceappointment";
             newBookableResourceBooking["msdyn_requirementgroupid"] = _newRequirementGroupID;
             //newBookableResourceBooking["msdyn_resourcerequirementID"] is the new ID for respective newly created resource requirement
             //newBookableResourceBooking["bookingstatus"] is the appropriate BookingStatusBase.BookingStatusId for ActivityPointer statuscode
             newBookableResourceBooking["serviceappointment"] = appointmentID;

             Guid _newBookableResourceBookingID = _service.Create(newBookableResourceBooking);
}

```

## See Also

[Service Scheduling overview](basics-service-service-scheduling.md)<br />
[Sample: Migrate Service Activity entity](migrate-service-activity-org-service.md)