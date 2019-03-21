---
title: "Basic Operations on Customer Journey using C#| Microsoft Docs" # Intent and product brand in a unique string of 43-59 chars including spaces
description: This sample shows how to perform basic operations on customer journey using c#."" # 115-145 characters including spaces. This abstract displays in the search result.
ms.custom: ""
ms.date: 03/25/2019
ms.service: "D365CE"
ms.topic: "article"
ms.author: "nabuthuk" # MSFT alias of Microsoft employees only
manager: "kvivek" # MSFT alias of manager or PM counterpart
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---

# CRUD operations on customer journey using code

The Customer Journey SDK  sample is a .NET managed code sample that shows how to use the Customer Journey APIs. The sample focuses on using the Customer Journey SDK from a .NET console aplication. Customer Journey SDK can also be used from a plugin code.

Download the sample: [Customer Journey SDK]() 

When you extract the zip file, you will find 3 projects in it: 

- **Microsoft.Dynamics.Marketing.SDK** that defines the basic reusable functionality which simplifies accessing Customer Journey APIs. It contains: 
   - Organized constants simplifying the reference to metadata elements like entities and option sets. 
   - A builder to simplify the construction of customer journey designs (programmatic equivalent to Customer Journey designer).
   - Encapsulation of data contracts (requests and responses) for most of the important marketing operations like checking for Customer Journey errors.
- **Microsoft.Dynamics.Marketing.SDK.Tests** contains unit tests which assure the quality of **Microsoft.Dynamics.Marketing.SDK**  
- **Microsoft.Dynamics.Marketing.Samples** is an executable which is used to execute the actual samples, it contains: 
   - Creating a customer journey from an existing template record.
   - Creating a sample customer journey with a segment and email.
   - Validating and publishing the existing customer journey record.

> [!NOTE]
> You need to have access to Microsoft Dynamics 365 Customer Engagement for apps organization with Dynamics 365 for Marketing app installed. More information [Install Dynamics 365 for Marketing app](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/trial-signup)

## How to run the sample

1. Download and extract the sample. 
2. Open `Microsoft.Dynamics.Marketing.Samples.sln` in Visual Studio.
3. Implement the `GetConnectionString` method in `Program.cs`. Look in the source code for instructions. This is required to log into a specific Microsoft Dynamics 365 for Customer Engagement apps environment.
4. Select one of the preferred samples in command line parameters for example `customerjourneycreate` for creating a sample customer journey with a segment and email. 
If you don’t specify any parameter, the usage screen will be printed. 
5. Press **F5** to run the sample. 

## What this sample does

The Customer Journey SDK sample shows how to: 

1. Query customer journey data.
2. Create a new customer journey from a customer journey Template.
3. Create a new customer journey with a specific workflow design.
4. Validate an existing customer journey record for any errors.  
5. Publish an existing customer journey record. 

## Examples

The Microsoft.Dynamics.Marketing.SDK.dll uses core Microsoft XRM SDK to process organization requests. The source code of this project can be embedded into a plugin code and executed. Following examples demonstrate how they can be used. 

Example below demonstrates how to invoke command programmatically 

```csharp  
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
        return organizationService.Execute(validationRequest.OrganizationRequest).ToValidationResponse(); 
    } 
} 
```

The example below demonstrates how to create a customer journey workflow programmatically: 
 
```csharp
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
                .WithSubItem(new ItemBuilder(ActivityType.SegmentItem, "Sample Segment") 
                    .WithProperty("ContainmentMethod", "Inclusion") 
                    .WithProperty("SegmentSourceType", "Segment")), 
            new WorkflowActivityBuilder(ActivityType.Email, emailActivityId, "Sample Email") 
                .WithParentActivityId(segmentActivityId)); 
 
            return designBuilder.Build(); 
    } 
} 
```

Example below demonstrate how to invoke programmatically: 

```csharp
using Microsoft.Dynamics.Marketing.SDK.Metadata.OptionSets; 
using Microsoft.Dynamics.Marketing.SDK.Wrappers; 
using Microsoft.Xrm.Sdk; 
using System; 

public class Snippet 
{ 
    public void PublishCustomerJourney(IOrganizationService organizationService, Guid customerJourneyId) 
    { 
        var customerJourney = new CustomerJourneyEntity(customerJourneyId) 
        { 
            StateCode = new OptionSetValue(CustomerJourneyStatusCode.GoingLive) 
        };
        organizationService.Update(customerJourney.Entity); 
    } 
} 
```

### See also

[Extend customer journey using API](basic-operations-on-customer-journey.md)
