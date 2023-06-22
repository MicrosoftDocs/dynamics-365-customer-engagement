---
title: Define the custom SMS channel
description: Learn how to define the custom SMS channel in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 06/23/2023
ms.custom: bap-template 
---

# Define the custom SMS channel

Now that you've defined the parts of your custom SMS channel, it's time to define the channel. This step is where you connect all the previous pieces in one metadata file, which is a record of the **Channel Definition** entity (`msdyn_channeldefinition`).

> [!IMPORTANT]
> If you're configuring metadata records directly in the customization file, make sure that the GUIDs are lowercase.

## Channel Definition contract

Entity logical name: **msdyn_channeldefinition**

Entity set name: **msdyn_channeldefinitions**

Primary ID attribute name: **msdyn_channeldefinitionid**

- **msdyn_displayname**: string - Optional. Display name of the channel.
- **msdyn_description**: string - Optional. Description of the channel.
- **msdyn_channeltype**: string - Required.  Supported values: Custom, SMS.
- **msdyn_outboundendpointurltemplate**: string – Required.  Name of the custom API for the outbound flow.
- **msdyn_hasinbound**: bit - Required. Boolean value indicating whether the channel supports inbound messages.
- **msdyn_hasdeliveryreceipt**: bit - Required. Boolean value indicating whether the channel supports delivery receipt.
- **msdyn_supportsaccount**: bit - Required. Boolean value indicating whether the channel supports account-level configuration. For SMS, it must be true; otherwise, false.
- **msdyn_channeldefinitionexternalentity**: string - Required. Name of the CDS entity, representing an extended configuration of the channel instance.
- **msdyn_channeldefinitionexternalformid**: GUID - Required. ID of the form to be rendered to display configuration of the extended channel instance table.
- **msdyn_channeldefinitionaccountexternalentity**: string - Optional. Name of the CDS entity, representing an extended configuration of the channel instance account.
- **msdyn_channeldefinitionaccountexternalformid**: string - Optional. ID of the form to be rendered to display configuration of the extended channel instance account table.
- **msdyn_messageformid**: GUID - Optional. Defines a form representing the message editor for the channel.

Channels are defined in **customizations.xml** as solution components. Place every **msdyn_channeldefinition** under **ImportExportXml** > **msdyn_channeldefinitions** elements. Each message part element `msdyn_channeldefinition` must include its own unique ID in the form of a GUID as the XML attribute **msdyn_channeldefinitionid**. When your solution is imported, a new row is created in the **msdyn_channeldefinition** table.

In the following example, note that:

- The **msdyn_channeldefinitionexternalentity** and the **msdyn_channeldefinitionexternalformid** contain the name and the form ID of the entity you created when you [defined the channel instance](custom-define-sms-instance.md).
- The **msdyn_channeldefinitionaccountexternalentity** and the **msdyn_channeldefinitionaccountexternalformid** contain the name and the form ID of the entity you created when you [defined the channel instance account](custom-define-sms-account.md).
- The **msdyn_outboundendpointurltemplate** contains the custom API that you created when you [defined custom APIs](custom-sms-custom-api.md).

Example of customizations.xml including channel definition:

```xml
<ImportExportXml xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <msdyn_channeldefinitions>
    <msdyn_channeldefinition msdyn_channeldefinitionid="af0c2a3c-85a5-43b3-84be-2a4a171249f3">
      <msdyn_channeldefinitionaccountexternalentity>cr65f_samplechannelinstanceaccount</msdyn_channeldefinitionaccountexternalentity>
      <msdyn_channeldefinitionaccountexternalformid>3071133f-1208-4dc1-8eba-4d4724961029</msdyn_channeldefinitionaccountexternalformid>
      <msdyn_channeldefinitionexternalentity>cr65f_samplechannelinstance</msdyn_channeldefinitionexternalentity>
      <msdyn_channeldefinitionexternalformid>7d2b885a-80eb-479d-b0c3-600bc41e9789</msdyn_channeldefinitionexternalformid>
      <msdyn_channeltype>Custom</msdyn_channeltype>
      <msdyn_description>Metadata definition for sample custom channel</msdyn_description>
      <msdyn_displayname>Sample custom channel</msdyn_displayname>
      <msdyn_hasdeliveryreceipt>0</msdyn_hasdeliveryreceipt>
      <msdyn_hasinbound>0</msdyn_hasinbound>
      <msdyn_messageformid>69723cfe-3835-4126-ab9a-a82a5b88c21d</msdyn_messageformid>
      <msdyn_outboundendpointurltemplate>/cr65f_OutboundCustomApi</msdyn_outboundendpointurltemplate>
      <msdyn_specialconsentrequired>0</msdyn_specialconsentrequired>
      <msdyn_supportsaccount>0</msdyn_supportsaccount>
      <msdyn_supportsattachment>0</msdyn_supportsattachment>
      <msdyn_supportsbinary>0</msdyn_supportsbinary>
      <statecode>0</statecode>
      <statuscode>1</statuscode>
    </msdyn_channeldefinition>
  </msdyn_channeldefinitions>
</ImportExportXml>
```

## Sample solutions

The following sample includes unpacked solutions for Dataverse and plugins projects. To pack and import these solutions, first build the plugin project. The project copies the assembly to the solution project. Then, pack the solution using the [Solution Packager tool](/power-platform/alm/solution-packager-tool).

- [SampleSmsChannel.zip](https://download.microsoft.com/download/c/c/6/cc6fed59-f95a-4577-aed5-49daa62b1f66/SampleSmsChannel-2022.12.zip)

### How to build the plugins project and pack the solution

1. Build the plugins project with MSBuild or Visual Studio.

    Building the project creates a DLL in the PluginAssemblies folder inside the Dataverse solution folder.

1. Pack the unmanaged folder with the Solution Packager using either:

    - [pac CLI](/power-platform/developer/cli/reference/solution#pac-solution-pack) (**preferred**)
    - [Solution packager](/dynamics365/customerengagement/on-premises/developer/compress-extract-solution-file-solutionpackager)

    `pac solution pack --zipfile C:\tmp\SampleSmsChannelSolution.zip -f src\Solutions\Samples\SampleSmsChannel\SampleSmsChannel.Solution\unmanaged --packagetype Both`

### See also

[Add custom SMS channel](add-custom-sms-provider-intro.md)  
[Configure SMS provider](configure-sms-provider.md)
