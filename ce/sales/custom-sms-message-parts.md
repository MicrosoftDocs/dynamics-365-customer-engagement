---
title: Define the message parts
description: Learn how to define the message parts for the SMS channel in Dynamics 365 Sales. 
author: udaykirang
ms.author: udayg
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 06/23/2023
ms.custom: bap-template 
---

# Define the message parts

When you create a custom SMS channel, you need to define a record in the **Channel Message Part** entity for each message part that the channel operates with (for example, title, subtitle, text). A custom SMS channel requires at least one message part. When your solution is imported, a new row for every message part is created in the **msdyn_channelmessagepart** table.

> [!IMPORTANT]
> - The SMS channel type requires just one message part with the name **text** and type **192350000**, which is used by the default Dynamics 365 Sales SMS editor. No other types of message parts are supported for SMS channels.
> - If you're setting up metadata records directly in the customization file, make sure that the GUIDs are lowercase.

## Message Part contract

Entity logical name: **msdyn_channelmessagepart**

Entity set name: **msdyn_channelmessageparts**

Primary ID attribute name: **msdyn_channelmessagepartid**

- **msdyn_name**: string – Name of the message part. This value is used as a key to map message part information with outbound message content.
- **msdyn_displayname**: string – Display name.
- **msdyn_description**: string – Description.
- **msdyn_channeldefinitionid**: GUID – Channel definition ID. Must match the channel definition ID of the channel.
- **msdyn_type**: OptionSet – Message part type. Supported values:
  - **192350000 plaintext**: The message part is simple text.
  - **192350003 media**: The message part is a file ID of the msdyncrm_file entity.
  - **192350004 image**: The message part is an image ID of the msdyncrm_file entity.
  - **192350005 record**: The message part is a record ID of an external entity.
- **msdyn_isrequired**: bit - Indicates whether the part is required.
- **msdyn_maxlength**: int - Max length of the part.
- **msdyn_order**: int - (Optional) Defines the position of the message part field in the message editor. The larger the number, the higher the position.
- **msdyn_entityname**: string - (Optional) Defines the entity to be used for the record type.
- **msdyn_entityviewid**: string - (Optional) Defines the ID of the view to be used for the record type.

Message parts are defined in **customizations.xml** as solution-aware components. Place every **msdyn_channelmessagepart** under **ImportExportXml** > **msdyn_channelmessageparts** elements. Each message part element **msdyn_channelmessagepart** must include its own unique ID in the form of the GUID as the XML attribute **msdyn_channelmessagepartid**.

Example of **customizations.xml** including message parts:

```XML
<ImportExportXml xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <msdyn_channelmessageparts>
    <msdyn_channelmessagepart msdyn_channelmessagepartid="15d57b1a-ddcd-4bb1-9af6-c691567ab9ef">
      <msdyn_channeldefinitionid>
        <msdyn_channeldefinitionid>b1b25a46-6da0-4c08-9cf3-505e613c8e30</msdyn_channeldefinitionid>
      </msdyn_channeldefinitionid>
      <msdyn_description>Text</msdyn_description>
      <msdyn_displayname>Text</msdyn_displayname>
      <msdyn_isrequired>1</msdyn_isrequired>
      <msdyn_maxlength>1000</msdyn_maxlength>
      <msdyn_name>text</msdyn_name>
      <msdyn_type>192350000</msdyn_type>
      <statecode>0</statecode>
      <statuscode>1</statuscode>
    </msdyn_channelmessagepart>
  </msdyn_channelmessageparts>
</ImportExportXml>
```

## Next step

[Define the localization for the admin interface](custom-sms-localization-admin.md)