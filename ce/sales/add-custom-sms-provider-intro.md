---
title: Add custom SMS channel provider 
description: Learn how to add a custom SMS provider to Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection: get-started 
ms.date: 06/23/2023
ms.custom: bap-template 
---

# Add custom SMS channel provider

Dynamics 365 Sales supports **SMS** channels natively and can add SMS providers that aren't supported natively.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Steps to add custom SMS provider

1. [Define an extended configuration entity for the SMS instance](custom-define-sms-instance.md)
1. [Define an extended configuration entity for the SMS instance account](custom-define-sms-account.md)
1. [Define the message parts](custom-sms-message-parts.md) (solution-aware component)
1. [Define the localization for the admin interface](custom-sms-localization-admin.md) (optional)
1. [Define the message editor interface](custom-sms-message-editor.md) (optional)
1. [Define custom APIs](custom-sms-custom-api.md)
1. [Define the custom channel](custom-define-sms-definition.md) (solution-aware component)

Dynamics 365 Sales provides base components for creating a custom channel, including custom APIs and required entities like msdyn_channeldefinition, msdyn_channelmessagepart, msdyn_channellocale, msdyn_channelinstanceaccount and msdyn_channelinstance.

The following table describes the implementation requirements for SMS and custom channels.

| **Component** | **SMS** | **Custom** |
| --- | --- | --- |
| Extended configuration entity for the channel instance | Required | Required |
| Extended configuration entity for the channel instance account | Required | Not supported |
| Message parts | Required; should contain only a single message part with `msdyn_name` = `text` | Required |
| Localization for admin UI | Optional | Optional |
| Message editor UI | Not allowed; native Marketing SMS editor is used | Optional; generic Marketing editor is used if not defined |
| Custom APIs | Required | Required |
| Channel definition | Required | Required |

## Sample solutions

The following samples include unpacked solutions for Dataverse and plugins projects. To pack and import the solutions, first build the plugin project. The project copies the assembly to the solution project. Then, pack the solution using the [Solution Packager tool](/power-platform/alm/solution-packager-tool).

- [SampleSmsChannel.zip](https://download.microsoft.com/download/c/c/6/cc6fed59-f95a-4577-aed5-49daa62b1f66/SampleSmsChannel-2022.12.zip)
- [SampleCustomChannel.zip](https://download.microsoft.com/download/5/8/6/586e2d47-ac82-48e9-9cc4-066c141e0649/SampleCustomChannel-2022.12.zip)

### How to build the plugins project and pack the solution

1. Build the plugins project with MSBuild or Visual Studio.

    Building the project creates a DLL in the PluginAssemblies folder inside the Dataverse solution folder.

1. Pack the unmanaged folder with the Solution Packager using either:

    - [pac CLI](/power-platform/developer/cli/reference/solution#pac-solution-pack) (**preferred**)
    - [Solution packager](/dynamics365/customerengagement/on-premises/developer/compress-extract-solution-file-solutionpackager)  

    `pac solution pack --zipfile C:\tmp\SampleCustomChannelSolution.zip -f src\Solutions\Samples\SampleCustomChannel\SampleCustomChannel.Solution\unmanaged --packagetype Both`


