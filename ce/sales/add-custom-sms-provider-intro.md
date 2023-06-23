---
title: Add custom SMS channel 
description: Learn how to add a custom SMS channel to Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection: get-started 
ms.date: 06/23/2023
ms.custom: bap-template 
---

# Add custom SMS channel 

Dynamics 365 Sales supports certain SMS channels natively and can add SMS channels that aren't supported natively.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Steps to add custom SMS channel

1. [Define an extended configuration entity for a channel instance](custom-define-sms-instance.md)
1. [Define an extended configuration entity for a channel instance account](custom-define-sms-account.md)
1. [Define the message parts](custom-sms-message-parts.md) (solution-aware component)
1. [(Optional) Define the localization for the admin interface](custom-sms-localization-admin.md) 
1. [Define custom APIs](custom-sms-custom-api.md)
1. [Define the custom channel](custom-define-sms-definition.md) (solution-aware component)

Dynamics 365 Sales provides base components for creating a custom channel, including custom APIs and required entities like msdyn_channeldefinition, msdyn_channelmessagepart, msdyn_channellocale, msdyn_channelinstanceaccount and msdyn_channelinstance.

The following table describes the implementation requirements for SMS channels.

| **Component** | **Required** |
| --- | --- |
| Extended configuration entity for the channel instance | Required |
| Extended configuration entity for the channel instance account | Required |
| Message parts | Required; should contain only a single message part with `msdyn_name` = `text` |
| Localization for admin UI | Optional |
| Custom APIs | Required |
| Channel definition | Required | 

### Sample solutions

The following sample includes unpacked solutions for Dataverse and plugins projects. To pack and import the solutions, first build the plugin project. The project copies the assembly to the solution project. Then, pack the solution using the [Solution Packager tool](/power-platform/alm/solution-packager-tool).

- [SampleSmsChannel.zip](https://download.microsoft.com/download/c/c/6/cc6fed59-f95a-4577-aed5-49daa62b1f66/SampleSmsChannel-2022.12.zip)

### Build the plugins project and pack the solution

1. Build the plugins project with MSBuild or Visual Studio.

    Building the project creates a DLL in the PluginAssemblies folder inside the Dataverse solution folder.

1. Pack the unmanaged folder with the Solution Packager using either:

    - [pac CLI](/power-platform/developer/cli/reference/solution#pac-solution-pack) (**preferred**)
    - [Solution packager](/dynamics365/customerengagement/on-premises/developer/compress-extract-solution-file-solutionpackager)  

    `pac solution pack --zipfile C:\tmp\SampleSmsChannelSolution.zip -f src\Solutions\Samples\SampleSmsChannel\SampleSmsChannel.Solution\unmanaged --packagetype Both`

