---
title: "Sample: Work with activity party records (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to work with activity party records (a letter activity)"
ms.custom: 
ms.reviewer: pehecke
ms.topic: sample
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - sample for using activity party records, activity entities
  - activity entities samples, using activity party records
author: JimDaly
ms.author: nabuthuk
search.audienceType: 
  - developer
---

# Sample: Work with activity party records

Learn how to create a letter activity addressed to multiple contacts. The code sample is located [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/CSharp-NETCore/Activities/ActivityParty).

Related articles: [ActivityParty entity](activityparty-entity.md), [Activity tables](/power-apps/developer/data-platform/activity-entities)

[!include[cc-sample-note](includes/cc-sample-note.md)]

## About the sample code

|Sample|Description|Build target|
|---|---|---|
|ActivityParty|Demonstrates creating a letter activity.|.NET 9|

The code sample demonstrates how to create a letter activity. Specifically, the sample demonstrates how to:

1. Connect to Dataverse using a [connection string](/power-apps/developer/data-platform/xrm-tooling/use-connection-strings-xrm-tooling-connect) that defines required connection information
1. Create a [letter activity](/power-apps/developer/data-platform/reference/entities/letter) to send to multiple [contacts](/power-apps/developer/data-platform/reference/entities/contact)
1. Use the Dataverse [organization service context](/power-apps/developer/data-platform/org-service/organizationservicecontext) to process the data changes
1. Use [early-bound](/power-apps/developer/data-platform/org-service/early-bound-programming#early-bound) entity types

The code being demonstrated can be found in the `Program.CreateLetter()` method and invoked by `Program.Run()`.

The early-bound entity files in the *DataModel* project were generated using the following PAC CLI command:
`pac modelbuilder build`. More information: [pac modelbuilder](/power-platform/developer/cli/reference/modelbuilder)

More general information can be found in [README-code-design](https://github.com/microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/CSharp-NETCore/README-code-design.md) file.

## How to build and run the code sample

1. Clone the [PowerApps-Samples](https://github.com/microsoft/PowerApps-Samples) repository.
1. Locate the sample folder.
1. Open the solution file (*.sln) in Visual Studio.
1. Edit the project's `appsettings.json` file and set the `Url`value as appropriate for your Dataverse test environment.
1. Build and run the project [F5].
1. You are prompted in a browser window for account sign-in credentials to the target environment.

## Expected program output

For a successful run, the program's console output should look similar to the following example.
Otherwise, any errors or exceptions are displayed.

```console
CreateLetter(): letter activity created with ID < >
Press any key to undo environment data changes.
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
