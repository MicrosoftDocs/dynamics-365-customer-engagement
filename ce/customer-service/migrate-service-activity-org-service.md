---
title: "Sample  Migrate Service Activity entity (Developer Guide for Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Service Activity is not directly available in the new scheduling experience. Read how you can migrate Service Activity to the new scheduling experience."
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 11/20/2018
ms.topic: get-started-article
ms.service: 
  - crm-online
---
# Sample: Migrate Service Activity entity

### Prerequisites

[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]

### Requirements

[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]

### Demonstrates

The Service Activity entity in Service Scheduling can't be migrated through the UI. This sample shows how to migrate the Service Activity entity to the new scheduling experience using Organization Service.

### Example

> [!NOTE]
> This sample demonstrates a basic example for migrating the Service Activity entity. For this sample to work in your instance, you will have to modify the following code as per your data.

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
        /// This program performs Service Activity Entity migration 
        /// to Service Scheduling using Organization Service
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


                        
                        QueryExpression existingResourceRequirementQuery = new QueryExpression("msdyn_resourcerequirement");
                        existingResourceRequirementQuery.ColumnSet = new ColumnSet(true);
                        existingResourceRequirementQuery.Criteria = new FilterExpression();
                        existingResourceRequirementQuery.Criteria.AddCondition("msdyn_requirementgroupid", ConditionOperator.Equal, existingSelectionRuleID.Id);
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

[Service Scheduling overview](basics-service-service-scheduling.md)<br />
[Migrate Service Activity entity](migrate-service-activity-entity.md)
