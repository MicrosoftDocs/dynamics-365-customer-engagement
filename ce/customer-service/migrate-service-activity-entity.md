---
title: "Migrate Service Activity entity (Developer Guide for Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Service Activity is not directly available in the new scheduling experience. Read how you can migrate Service Activity to the new scheduling experience."
author: "susikka"
ms.author: "susikka"
manager: "shujoshi"
ms.date: 11/27/2018
ms.topic: "get-started-article"
ms.service: 
  - crm-online
---

# Migrate Service Activity entity

The Service Activity entity in Service Scheduling can't be migrated through the UI. You can use Dynamics 365 Web API or Organization Service to do this. This topic shows how to use Dynamics 365 Organization Service to migrate the Service Activity entity.

This sample performs the following actions:

<a href="#bkmk_retrieve"><b>Fetch Service Activity entity record</b></a><br />
It fetches Service Activity entity records from the `serviceappointment` table.<br />

<a href="#bkmk_requirementmapping"><b>Create a new Requirement group by cloning or copying the existing Selection Rules</b></a><br />
Then, for each of the retrieved `serviceappointment` records, we create a mapping between `newRequirementGroup` and `existingSelectionRule`.<br />

<a href="#bkmk_resourcemapping"><b>Create a new Resource Requirement record by copying or cloning the existing Selection Rules</b></a><br />
As in the previous step, here we create a mapping between `newResourceRequirement` and `existingSelectionRule`.<br />

<a href="#bkmk_newbookableresourcerecord"><b>Create a new Bookable Resource entity record for each Activity Party entity record</b></a><br />
We now create a new `BookableResourceBooking` entity record for each `ActivityParty` entity record, and map their attributes.<br />

The complete sample for migrating Service Activity entity records can be found here [Sample: Migrate Service Activity entity](migrate-service-activity-org-service.md).

<a name="bkmk_retrieve"></a>

## Fetch Service Activity entity records

The following code snippet shows how we can fetch Service Activity entity records from `serviceappointment` table. 

```csharp
QueryExpression serviceActivityQuery = new QueryExpression("serviceappointment");
serviceActivityQuery.ColumnSet = new ColumnSet(true);

EntityCollection serviceActivityCol;
serviceActivityCol = _serviceProxy.RetrieveMultiple(serviceActivityQuery);
```

<a name="bkmk_requirementmapping"></a>

## Create a new Requirement Group record by cloning or copying the existing Requirement Group record

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

## Create a new Resource Requirement record by copying or cloning the existing Selection Rules

As in the previous code snippet, where we created a mapping between `newRequirementGroup` and `existingSelectionRule`, here we will create a mapping between `newResourceRequirement` and `existingResourceRequirement` that are records of entity `msdyn_resourcerequirement`.

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

## Create a new BookableResourceBooking entity record for each ActivityParty entity record

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

## See also

[Service Scheduling overview](basics-service-service-scheduling.md)<br />
[Sample: Migrate Service Activity entity](migrate-service-activity-org-service.md)
