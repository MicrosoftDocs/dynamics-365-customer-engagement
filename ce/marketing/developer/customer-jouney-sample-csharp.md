---
title: "Create custom journey using c#| Microsoft Docs" # Intent and product brand in a unique string of 43-59 chars including spaces
description: The Customer journey sample shows how to use the APIs."" # 115-145 characters including spaces. This abstract displays in the search result.
ms.custom: ""
ms.date: 03/01/2019
ms.reviewer: ""
ms.service: "D365CE"
ms.topic: "article"
author: "nkrb" # GitHub ID
ms.author: "nabuthuk" # MSFT alias of Microsoft employees only
manager: "kvivek" # MSFT alias of manager or PM counterpart
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---
# Create a Custom Journey using code

The Customer Journey Sample and SDK is a **.NET** managed code sample that shows how to use the **Customer Journey APIs**. The sample focuses on using the Customer Journey SDK from a chosen **.NET** process, that can be called from plugin code. 

Download the sample from [here](). 

Extract the zip file that you have downloaded, you will see three projects in it

1. **Microsoft.Dynamics.Marketing.SDK** defines the basic reusable functionality which simplifies accessing Customer Journey APIs. It contains 
    - Organized constants simplifying reference to metadata elements like entities and option sets. 
    - A builder to simplify construction of Customer Journey designs (a programmatic equivalent of Customer Journey designer). 
    - Encapsulation of data contracts (requests and responses) for most  of important marketing operations like checking for Customer Journey errors. 
2. **Microsoft.Dynamics.Marketing.SDK.Tests** contains unit tests which assure quality of **Microsoft.Dynamics.Marketing.SDK** and can also be used to understand how some parts of the SDK can be consumed. 
3. **Microsoft.Dynamics.Marketing.Samples** is an executable which can be run to execute the actual samples, which include, 
      - Creating a Customer Journey from an existing template record. 
      - Creating a sample Customer Journey with a segment and email. 
      - Publishing the existing Customer Journey record. 
      - Validating the existing Customer Journey record.

## Requirements

You need to have access to a Microsoft Dynamics 365 Customer Engagement organization with Dynamics 365 for Marketing product installed. 
More information [How to install Dynamics 365 with Marketing]().

## How to run the sample

Download and extract the sample. 
- Open **Microsoft.Dynamics.Marketing.Samples.sln** in **Visual Studio**. The main sample project Microsoft.Dynamics.Marketing.Samples is a .NET console application. 
- Implement [GetOrganizationService]() method in `Program.cs`. This is required to log into a specific Microsoft Dynamics 365 Customer Engagement environment. 
- Select one of the preferred samples in command line parameters for example customerjourneycreate for creating a sample Customer Journey with a segment and email. 
- If you don’t specify any parameter, the usage screen will be printed. 
- Press **F5** to run the sample. 

## Sample

The Microsoft.Dynamics.Marketing.SDK.dll uses core Microsoft XRM SDK to process organization requests. The source code of this project can be embedded into a plugin code and executed from inside a CRM plugin. It provides several features that can simplify processing of error check and CRUD operations on Customer Journey entity.Following examples demonstrate how they can be used. 

Example below demonstrates how to invoke ** Check for errors** command programmatically 

```CSharp
using Microsoft.Dynamics.Marketing.SDK; 
    using Microsoft.Dynamics.Marketing.SDK.CustomerJourney.Validation; 
    using Microsoft.Dynamics.Marketing.SDK.Metadata.Entities; 
    using Microsoft.Xrm.Sdk; 
    using Microsoft.Xrm.Sdk.Query; 
    using System; 
 
    public class Snippet 
    { 
        public ValidationResponse CheckForErrors( 
            IOrganizationService organizationService,  
            Guid customerJourneyRecordId) 
        { 
            // Retrieve record 
            var customerJourneyRecord = organizationService.Retrieve( 
                EntityLogicalNames.CustomerJourney,  
                customerJourneyRecordId,  
                new ColumnSet(true)); 
 
            // Call check for errors service 
            var validationRequest = ValidationRequest.FromCustomerJourneyEntity(customerJourneyRecord); 
 
            // Transform the organization response to strongly typed validation response 
            return organizationService.Execute(validationRequest.OrganizationRequest) 
                .ToValidationResponse(); 
        } 
    } 
 ```
 The example below demonstrates how to create a following Customer Journey workflow programmatically
 
 ```Csharp
 using Microsoft.Dynamics.Marketing.SDK.CustomerJourney.Workflow; 
    using System; 
 
    public class Snippet 
    { 
        public CustomerJourneyDesign CreateSimpleCustomerJourney() 
        { 
            var designBuilder = new CustomerJourneyDesignBuilder(); 
            var segmentActivityId = Guid.NewGuid().ToString(); 
            var emailActivityId = Guid.NewGuid().ToString(); 
 
            designBuilder.Root.With( 
                new WorkflowActivityBuilder(ActivityType.Segment, segmentActivityId, "Sample Contacts") 
                .WithParentActivityId(designBuilder.Root.RootActivityId) 
                .WithHeaderItemProperty("SegmentMergeMethod", "Union") 
                .WithSubItem( 
                    new ItemBuilder(ActivityType.SegmentItem, "Sample Segment") 
                    .WithProperty("ContainmentMethod", "Inclusion") 
                    .WithProperty("SegmentSourceType", "Segment")), 
                new WorkflowActivityBuilder(ActivityType.Email, emailActivityId, "Sample Email") 
                .WithParentActivityId(segmentActivityId)); 
 
            return designBuilder.Build(); 
        } 
    } 
```

Example below demonstrate how to invoke **Go live** programmatically
```Csharp
 
    using Microsoft.Dynamics.Marketing.SDK.Metadata.OptionSets; 
    using Microsoft.Dynamics.Marketing.SDK.Wrappers; 
    using Microsoft.Xrm.Sdk; 
    using System; 
 
    public class Snippet 
    { 
        public void PublishCustomerJourney( 
            IOrganizationService organizationService,  
            Guid customerJourneyId) 
        { 
            var customerJourney = new CustomerJourneyEntity(customerJourneyId) 
            { 
                StateCode = new OptionSetValue(CustomerJourneyStatusCode.GoingLive) 
            }; 
 
            organizationService.Update(customerJourney.Entity); 
        } 
    } 
 ```
 
 ## See also
 
 [Create customer journeys using API](basic-operations-on-customer-jounery-using-api.md)
