---
title: "Basic Operations on customer journey using C# (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "This sample shows how to perform basic operations on customer journey using C#."
ms.date: 10/19/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# CRUD operations on customer journey using code

The customer journey SDK sample is a .NET managed-code sample that shows how to use the customer journey APIs. The sample focuses on using the customer journey SDK from a .NET console application. The customer journey SDK can be used from plug-in code.

Download the sample: [customer journey SDK](https://go.microsoft.com/fwlink/?linkid=2086553)

When you extract the .zip file, you find three projects in it:

- **Microsoft.Dynamics.Marketing.SDK**, which defines the basic reusable functionality that simplifies accessing customer journey APIs. It contains:
   - Organized constants simplifying the reference to metadata elements like entities and option sets.
   - A builder to simplify the construction of customer journey designs (programmatic equivalent to the customer journey designer).
   - Encapsulation of data contracts (requests and responses) for most of the important marketing operations like checking for customer journey errors.
- **Microsoft.Dynamics.Marketing.SDK.Tests**, which contains unit tests that ensure the quality of **Microsoft.Dynamics.Marketing.SDK**. 
- **Microsoft.Dynamics.Marketing.Samples**, which is an executable program that is used to execute the actual samples. It contains code for:
   - Creating a customer journey from an existing template record.
   - Creating a sample customer journey with a segment and email.
   - Validating and publishing the existing customer journey record.
   - Creating [custom channel activity interaction](create-custom-channel-activity-interaction.md) from customer journey custom channel activity record.

> [!NOTE]
> You need to have access to Microsoft Dynamics 365 Marketing instance. More information: [Install Dynamics 365 Marketing](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/trial-signup).

## How to run the sample

1. Download and extract the sample. 
2. Open `Microsoft.Dynamics.Marketing.Samples.sln` in Visual Studio.
3. Implement the `GetConnectionString` method in `Program.cs`. Look in the source code for instructions. This is required to sign in to a specific Dynamics 365 Marketing instance.
4. Select the sample that you want to run by using command-line parameters; for example, `customerjourneycreate` creates a sample customer journey with a segment and email. 
If you don’t specify a parameter, the usage screen is printed. 
5. Press **F5** to run the sample. 

## What this sample does

The customer journey SDK sample shows how to:

1. Query customer journey data.
2. Create a new customer journey from a customer journey template.
3. Create a new customer journey with a specific workflow design.
4. Validate an existing customer journey record for any errors.  
5. Publish an existing customer journey record. 
6. Creates [custom channel activity interaction](create-custom-channel-activity-interaction.md) from customer journey custom channel activity record.

## Examples

Microsoft.Dynamics.Marketing.SDK.dll uses the core SDK to process organization requests. The source code of this project can be embedded in the plug-in code and executed.

This example demonstrates how to invoke the **Check for Errors** command programmatically:

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
        return organizationService.Execute(validationRequest.OrganizationRequest).ToValidationResponse(); 
    } 
} 
```

This example demonstrates how to create a customer journey workflow programmatically: 
 
```CSharp
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

This example demonstrate how to invoke **Go Live** programmatically: 

```CSharp
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


[!INCLUDE[footer-include](../../includes/footer-banner.md)]