---
title: "Sample: Migrate Service Activity entity(Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Service Activity is not directly available in the new scheduling experience. Read how you can migrate Service activity to the new scheduling experience."
ms.custom: ""
ms.date: 10/01/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 45CF1131-3FD0-48F8-8212-B6F0CFA519EF
author: "susikka"
ms.author: "susikka"
manager: "shujoshi"
---
# Sample: Migrate Service Activity entity

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

### Prerequisites

[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]

### Requirements

[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]

### Demonstrates

Service Activity entity in Service Scheduling cannot be migrated through UI. This sample shows how to migrate Service Activity entity to the new scheduling experience using Organization Service.

### Example

The below sample performs the following actions:
1. [Fetch Service Activity entity record](#bkmk_retrieve): It fetches Service Activity entity records from `serviceappointment` table.
2. [Create a new Requirement group by cloning or copying the existing Requirement group](#bkmk_requirementmapping): Then, for each of the retrieved `serviceappointment` records, we create a mapping between `newRequirementGroup` and `existingRequirementGroup`.
3. [Create new Resource Requirement record by copying or cloning the existing Resource Requirement record](#bkmk_resourcemapping): As we did in the above step, similarly, we will create a mapping between `newResourceRequirement` and `existingResourceRequirement`.
4. [Create a new Bookable Resource entity record for each Activity Party entity record](#bkmk_newbookableresourcerecord): We now create a new `BookableResourceBooking` entity record for each `ActivityParty` entity record, and map their attributes.

The complete sample for migrating Service Activity entity records, can be found here [Complete Service Activity migration sample](#bkmk_complete).

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
EntityReference existingRequirementGroupID = service.GetAttributeValue<EntityReference>("msdyn_requirementgroupid");
Entity existingRequirementGroup = _serviceProxy.Retrieve("msdyn_requirementgroup", existingRequirementGroupID.Id, new ColumnSet(true));


Entity newRequirementGroup = new Entity("msdyn_resourcerequirement");
EntityReference rgOwnerID = existingRequirementGroup.GetAttributeValue<EntityReference>("ownerid");
newRequirementGroup["ownerid"] = rgOwnerID.Id;
int rgOwnerIDType = existingRequirementGroup.GetAttributeValue<int>("owneridtype");
newRequirementGroup["owneridtype"] = rgOwnerIDType;
var rgStateCode = existingRequirementGroup.GetAttributeValue<OptionSetValue>("statecode");
newRequirementGroup["statecode"] = rgStateCode;
string rgName = existingRequirementGroup.GetAttributeValue<string>("msdyn_name");
newRequirementGroup["msdyn_name"] = rgName;
newRequirementGroup["msdyn_istemplate"] = 0;
                        
Guid _newRequirementGroupID = _service.Create(newRequirementGroup);

```
<a name="bkmk_resourcemapping"></a>

#### Create new Resource Requirement record by copying or cloning the existing Resource Requirement record

As we created a mapping between `newRequirementGroup` and `existingRequirementGroup` in the above code snippet, similarly, we will create a mapping between `newResourceRequirement` and `existingResourceRequirement`, that are records of entity `msdyn_resourcerequirement`.

```csharp
QueryExpression existingResourceRequirementQuery = new QueryExpression("msdyn_resourcerequirement");
existingResourceRequirementQuery.ColumnSet = new ColumnSet(true);
existingResourceRequirementQuery.Criteria = new FilterExpression();
existingResourceRequirementQuery.Criteria.AddCondition("msdyn_requirementgroupid", ConditionOperator.Equal, existingRequirementGroupID.Id);
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

<a name="bkmk_complete"></a>

#### Complete sample

The complete migration sample for `ServiceActivity` entity is shown below.

> [!NOTE]
> This sample demonstrates a basic example for migrating Service Activity entity. For this sample to work in your instance, you will have to modify the below code as per your data.

```csharp
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using System;

namespace Microsoft.Crm.Sdk.Samples
{
    class ServiceActivity
    {
        ///<summary>
        /// This program performs Service Activity Entity migration from legacy Dynamics 365
        /// to Service Scheduling using Dynamics 365 Organization Service
        ///</summary>
        /// <remarks>
        /// Before running this application you must modify configurations
        /// - All deployments: Provide connection string service URL for your organization. 
        ///   CRM Online: Replace the default app settings with your actual Azure AD values
        ///   List on Entity already migrated in order
        ///   -Sites
        ///   Equipment and Facility, Contact, User, Accounts
        ///   Service
        /// </remarks>

        #region Class Level Members
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;
        #endregion
        public void ServiceActivityMigration(ServerConnection.Configuration serverConfig)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri, serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                _service = (IOrganizationService)_serviceProxy;

                /// <summary>
                /// Retrieve all Service Activity records 
                /// for each Service Activity fetch service entity and Activity Entity
                /// - from the service record get RquirementGroupID and ResourceRequirementID(internal Entity)
                /// clone requirementGroup record and set 'msdyn_istemplate' as false
                /// clone ResourceRequirement record and set 'serviceappointment' = ServiceActivity.appointmentID
                /// -from the Activity.ID fetch all ActivityParty(internal entity) records
                /// for each ActivityParty records create a new BookableResourceBooking record
                /// -resource = BookableResourceID from BookableResource Entity for ActivityParty.PartyID
                /// -msdyn_resourcerequirementID from newly cloned/created ResourceRequirement
                /// and add a new record in BookableResource Entity
                /// resource type Equipment(4)
                /// </summary>
                QueryExpression serviceActivityQuery = new QueryExpression("serviceappointment");
                serviceActivityQuery.ColumnSet = new ColumnSet(true);

                EntityCollection serviceActivityCol;
                serviceActivityCol = _serviceProxy.RetrieveMultiple(serviceActivityQuery);

               if (serviceActivityCol.Entities != null && serviceActivityCol.Entities.Count > 0)
                {
                    foreach (Entity entity in serviceActivityCol.Entities)
                    {
                        Guid serviceID = entity.GetAttributeValue<EntityReference>("serviceid").Id;

                        Guid appointmentID = entity.GetAttributeValue<Guid>("activityid");

                        QueryExpression serviceQuery = new QueryExpression("service");
                        serviceQuery.ColumnSet = new ColumnSet(true);
                        serviceQuery.Criteria = new FilterExpression();
                        serviceQuery.Criteria.AddCondition("serviceid", ConditionOperator.Equal, serviceID);

                        Entity service = _serviceProxy.Retrieve("service", new Guid(serviceID.ToString()), new ColumnSet(true));

                        //Fetch the requirementGroupID for the service and clone the Requirement Group and resource requirement
                        EntityReference existingRequirementGroupID = service.GetAttributeValue<EntityReference>("msdyn_requirementgroupid");
                        Entity existingRequirementGroup = _serviceProxy.Retrieve("msdyn_requirementgroup", existingRequirementGroupID.Id, new ColumnSet(true));


                        Entity newRequirementGroup = new Entity("msdyn_resourcerequirement");
                        EntityReference rgOwnerID = existingRequirementGroup.GetAttributeValue<EntityReference>("ownerid");
                        newRequirementGroup["ownerid"] = rgOwnerID.Id;
                        int rgOwnerIDType = existingRequirementGroup.GetAttributeValue<int>("owneridtype");
                        newRequirementGroup["owneridtype"] = rgOwnerIDType;
                        var rgStateCode = existingRequirementGroup.GetAttributeValue<OptionSetValue>("statecode");
                        newRequirementGroup["statecode"] = rgStateCode;
                        string rgName = existingRequirementGroup.GetAttributeValue<string>("msdyn_name");
                        newRequirementGroup["msdyn_name"] = rgName;
                        newRequirementGroup["msdyn_istemplate"] = 0;
                        

                        Guid _newRequirementGroupID = _service.Create(newRequirementGroup);


                        
                        QueryExpression existingResourceRequirementQuery = new QueryExpression("msdyn_resourcerequirement");
                        existingResourceRequirementQuery.ColumnSet = new ColumnSet(true);
                        existingResourceRequirementQuery.Criteria = new FilterExpression();
                        existingResourceRequirementQuery.Criteria.AddCondition("msdyn_requirementgroupid", ConditionOperator.Equal, existingRequirementGroupID.Id);
                        EntityCollection existingResourceRequirement = _serviceProxy.RetrieveMultiple(existingResourceRequirementQuery);

                        // Create/clone records for each msdyn_resourcerequirement
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

                        // Create new Bookable Resource booking for each ActivityParty record
                        QueryExpression activityPartyQuery = new QueryExpression("activityparty");
                        activityPartyQuery.ColumnSet = new ColumnSet(true);
                        activityPartyQuery.Criteria = new FilterExpression();
                        activityPartyQuery.Criteria.AddCondition("activityid", ConditionOperator.Equal, appointmentID);
                        EntityCollection activityPartyCol =  _serviceProxy.RetrieveMultiple(activityPartyQuery);
                        foreach (Entity entityRR in activityPartyCol.Entities)
                        {
                            Entity newBookableResourceBooking = new Entity("bookableresourcebooking");
                            //fill all required fields 
                            newBookableResourceBooking["starttime"] = entityRR.GetAttributeValue<DateTime>("scheduledstart");
                            newBookableResourceBooking["endtime"] = entityRR.GetAttributeValue<DateTime>("scheduledend");
                            newBookableResourceBooking["msdyn_bookingsetupmetadataidname"] = "serviceappointment";
                            newBookableResourceBooking["msdyn_requirementgroupid"] = _newRequirementGroupID;
                            //newBookableResourceBooking["msdyn_resourcerequirementID"] is the new ID for respective newly created resource requirement
                            // newBookableResourceBooking["bookingstatus"] is the appropriate BookingStatusBase.BookingStatusId for ActivityPointer statuscode
                            newBookableResourceBooking["serviceappointment"] = appointmentID;
                         

                            Guid _newBookableResourceBookingID = _service.Create(newBookableResourceBooking);

                        }
                   }
                }
            }
        }
    }
}

```

### See also

[Service Scheduling overview](basics-service-service-scheduling.md)