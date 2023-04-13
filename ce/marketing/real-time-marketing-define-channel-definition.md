---
title: "Define your channel definition (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to define your channel definition for real-time marketing custom channels in Dynamics 365 Marketing."
ms.date: 01/23/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Define your Channel Definition

## Applicable channels: SMS, Custom

### Why you need it:

Now that you have defined all the main parts, it’s time to define your channel where you will connect all the previous pieces in one metadata file, which is a record of **Channel Definition** entity (msdyn_channeldefinition).

> [!IMPORTANT]
> If you are setting up metadata records directly in the customization file, make sure that the GUIDs are defined in lowercase. 

### Channel definition Contract:

Entity logical name: **msdyn_channeldefinition**

Entity set name: **msdyn_channeldefinitions**

Primary Id attribute name: **msdyn_channeldefinitionid**

- **msdyn_displayname**: string - Optional. Display name of the channel.
- **msdyn_description**: string - Optional. Description of the channel.
- **msdyn_channeltype**: string - Required.  Supported values: Custom, SMS.
- **msdyn_outboundendpointurltemplate**: string – Required.  Name of the Custom API for the outbound flow. 
- **msdyn_hasinbound**: bit - Required. Boolean value indicating whether the channel supports inbound messages.
- **msdyn_hasdeliveryreceipt**: bit - Required. Boolean value indicating whether the channel supports delivery receipt.
- **msdyn_supportsaccount**: bit - Required. Boolean value indicating whether the channel supports account level configuration. In the case of SMS, it must be true. Otherwise, false.   
- **msdyn_channeldefinitionexternalentity**: string - Required. Name of the CDS entity, representing an extended configuration of the channel instance.
- **msdyn_channeldefinitionexternalformid**: GUID - Required. ID of the form to be rendered to display configuration of the extended channel instance table.
- **msdyn_channeldefinitionaccountexternalentity**: string - Optional. Name of the CDS entity, representing an extended configuration of the channel instance account.
- **msdyn_channeldefinitionaccountexternalformid**: string - Optional. ID of the form to be rendered to display configuration of the extended channel instance account table.
- **msdyn_messageformid**: GUID - Optional. Defines a form representing the message editor for the channel.

### How to define it:

Channel Definitions are defined in the **customizations.xml** as solution components. Place every **msdyn_channeldefinition** under **ImportExportXml** > **msdyn_channeldefinitions** elements. Please note that each message part element msdyn_channeldefinition must include its own unique id in the form of GUID as XML attribute **msdyn_channeldefinitionid**. At your solution’s import, a new row will be created at the **msdyn_channeldefinition** table.

In the example below, you will notice that:

- The **msdyn_channeldefinitionexternalentity** and the **msdyn_channeldefinitionexternalformid** contain the name and the formId of the entity that we created in [step 1](real-time-marketing-define-custom-channel-instance.md).
- The **msdyn_channeldefinitionaccountexternalentity** and the **msdyn_channeldefinitionaccountexternalformid** contain the the name and the formId of the entity that we created in [step 2](real-time-marketing-define-channel-instance-account.md).
- The **msdyn_messageformid** contains the formId that you created in [step 5](real-time-marketing-custom-channel-message-editor.md).
- The **msdyn_outboundendpointurltemplate** contains the Custom API that you created in [step 6](real-time-marketing-custom-channel-custom-api.md).

### Example of customizations.xml including channel definition

```
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

### Sample solutions

The samples below include unpacked solutions for Dataverse and plugins projects. To pack and import these solutions, first build the plugin project. The project will then copy the assembly to the solution project. Then, pack the solution using the [Solution Packager tool](/power-platform/alm/solution-packager-tool).

- [SampleSmsChannel.zip](https://download.microsoft.com/download/c/c/6/cc6fed59-f95a-4577-aed5-49daa62b1f66/SampleSmsChannel-2022.12.zip)
- [SampleCustomChannel.zip](https://download.microsoft.com/download/5/8/6/586e2d47-ac82-48e9-9cc4-066c141e0649/SampleCustomChannel-2022.12.zip)

#### How to build the plugins project and pack the solution

1. Build the plugins project with MSBuild or Visual Studio. Building the project will create a dll in the PluginAssemblies folder inside the Dataverse solution folder.
1. Pack the unmanaged folder with the Solution Packager using either:
    - [pac CLI](/power-platform/developer/cli/reference/solution#pac-solution-pack) (**preferred**)
    - [Solution packager](/dynamics365/customerengagement/on-premises/developer/compress-extract-solution-file-solutionpackager)
    
```
pac solution pack --zipfile C:\tmp\SampleCustomChannelSolution.zip -f src\Solutions\Samples\SampleCustomChannel\SampleCustomChannel.Solution\unmanaged --packagetype Both
```

[!INCLUDE[footer-include](../includes/footer-banner.md)]