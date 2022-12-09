---
title: "Preview: Define your Channel Definition (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to define your Channel Definition in Dynamics 365 Marketing."
ms.date: 12/09/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---
# Define your Channel Definition

## Applicable channels: SMS, Custom

### Why you need it:

Now that you have defined all the main parts, it’s time to define your channel where you will connect all the previous pieces in one metadata file, which is a record of **Channel Definition** entity (msdyn_channeldefinition).

### Channel definition Contract:

Entity logical name: **msdyn_channeldefinition**

Entity set name: **msdyn_channeldefinitions**

Primary Id attribute name: **msdyn_channeldefinitionid**

• **msdyn_displayname**: string - Optional. Display name of the channel.

• **msdyn_description**: string - Optional. Description of the channel.

• **msdyn_channeltype**: string - Required.  Supported values: Custom, SMS.

• **msdyn_outboundendpointurltemplate**: string – Required.  Name of the Custom API for the outbound flow. 
  
• **msdyn_hasinbound**: bit - Required. Boolean value indicating whether the channel supports inbound messages.

• **msdyn_hasdeliveryreceipt**: bit - Required. Boolean value indicating whether the channel supports delivery receipt.

• **msdyn_supportsaccount**: bit - Required. Boolean value indicating whether the channel supports account level configuration. In the case of SMS, it must be true. Otherwise, false.   

• **msdyn_channeldefinitionexternalentity**: string - Required. Name of the CDS entity, representing an extended configuration of the channel instance.

• **msdyn_channeldefinitionexternalformid**: GUID - Required. ID of the form to be rendered to display configuration of the extended channel instance table.

• **msdyn_channeldefinitionaccountexternalentity**: string - Optional. Name of the CDS entity, representing an extended configuration of the channel instance account.

• **msdyn_channeldefinitionaccountexternalformid**: string - Optional. ID of the form to be rendered to display configuration of the extended channel instance account table.

• **msdyn_messageformid**: GUID - Optional. Defines a form representing the message editor for the channel.

### How to define it:

Channel Definitions are defined in the **customizations.xml** as solution components. Place every **msdyn_channeldefinition** under **ImportExportXml** > **msdyn_channeldefinitions** elements. Please note that each message part element msdyn_channeldefinition must include its own unique id in the form of GUID as XML attribute **msdyn_channeldefinitionid**. At your solution’s import, a new row will be created at the **msdyn_channeldefinition** table.

In the example below, you will notice that:

• the **msdyn_channeldefinitionexternalentity** and the **msdyn_channeldefinitionexternalformid** contain the name and the formId of the entity that we created in **Step 1**<ADD LINK to STEP 1>

• the **msdyn_channeldefinitionaccountexternalentity** and the **msdyn_channeldefinitionaccountexternalformid** contain the the name and the formId of the entity that we created in **Step 2**<ADD LINK to STEP 2>.

• the **msdyn_messageformid** contains the formId that you created in **Step 4** <ADD LINK to STEP 4>

• the **msdyn_outboundendpointurltemplate** contains the Custom API that you created in **Step 5**<ADD LINK to STEP 6>.

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

The samples below include unpacked solutions for Dataverse and plugins projects.
To pack and import these solutions, first build the plugin project. The project will then copy the assembly to the solution project. Then, pack the solution using the [Solution Packager tool](/learn.microsoft.com/power-platform/alm/solution-packager-tool).
SampleSmsChannel.zip
SampleCustomChannel.zip
