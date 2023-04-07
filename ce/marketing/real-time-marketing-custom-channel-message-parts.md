---
title: "Define your Message parts (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to define your message parts in the real-time marketing area of Dynamics 365 Marketing."
ms.date: 04/04/2023
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

# Define your Message parts

## Applicable channels: SMS, Custom

### Why you need it:

If you're creating a custom channel and you want to describe the message parts that the channel operates with (for example, title, subtitle, text), then you must define records for the **Channel Message Part** entity. At least one message part is required per custom channel. **At your solution’s import**, a new row for every message part will be created in the **msdyn_channelmessagepart** table.

> [!IMPORTANT]
> The SMS channel type requires only one message part with the name “text” and type 192350000, which will be used by the default Dynamics 365 Marketing SMS editor. No other types of message parts are supported for SMS channels.

> [!IMPORTANT]
> If you are setting up metadata records directly in the customization file, make sure that the GUIDs are defined in lowercase.

#### Message parts contract:

Entity logical name: **msdyn_channelmessagepart**

Entity set name: **msdyn_channelmessageparts**

Primary ID attribute name: **msdyn_channelmessagepartid**

- **msdyn_name**: string – Name for the message part. This value is later used as a key to map message part information with outbound message content.
- **msdyn_displayname**: string – Display name.
- **msdyn_description**: string – Description.
- **msdyn_channeldefinitionid**: GUID – Channel definition ID, must match the channel definition id of the channel.
- **msdyn_type**: OptionSet – Message part type. Currently supported values:
    - **192350000 plaintext**: The message part is simple text.
    - **192350003 media**: the message part is a file ID of the msdyncrm_file entity.
    - **192350004 image**: The message part is an image ID of yhe msdyncrm_file entity.
    - **192350005 record**: The message part is a record ID of an external entity.
- **msdyn_isrequired**: bit - Indicates whether the part is required.
- **msdyn_maxlength**: int - Max length for the part.
- **msdyn_order**: int - (Optional) Defines the position of the message part field within the message editor. The larger the number, the higher the position.
- **msdyn_entityname**: string - (Optional) Defines the entity that will be used for the record type.
- **msdyn_entityviewid**: string - (Optional) Defines the ID of the view that will be used for the record type.

#### How to define it:

Message parts are defined in the **customizations.xml** as solution aware components. Place every **msdyn_channelmessagepart** under **ImportExportXml** > **msdyn_channelmessageparts** elements. Note that each message part element **msdyn_channelmessagepart** must include its own unique id in the form of GUID as XML attribute **msdyn_channelmessagepartid**. 

#### Example of customizations.xml including message parts:

```
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
