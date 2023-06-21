---
title: Define localization for the admin interface
description: Learn how to define the localization for the admin interface.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 06/23/2023
ms.custom: bap-template 
---

# Define localization for the admin interface (optional)

If you want to localize your admin interface for a diverse audience, you need to define a **Channel Definition Locale** entity. When your solution is imported, a new row for every [message part](custom-sms-message-parts.md) is created in the **msdyn_channeldefinitionlocale** table.

## Channel Definition Locale contract

Entity logical name: **msdyn_channeldefinitionlocale**  
Entity set name: **msdyn_channeldefinitionlocales**  
Primary ID attribute name: **msdyn_channeldefinitionlocaleid**

- **msdyn_localeid**: int - Language code ID (for example, English - United States 1033)
- **msdyn_channeldefinitionid**: GUID – Channel definition ID; must match the channel definition ID of the channel.
- **msdyn_localecontent**: string (JSON) - The localized content. The following keys are supported:
  - **ChannelDefinition.DisplayName** - override for msdyn_channeldefinition.msdyn_displayname attribute content in UI.
  - **ChannelDefinition.Description** - override for msdyn_channeldefinition.msdyn_description attribute content in UI.
  - **ChannelDefinition.SpecialConsentLabel** - override for msdyn_channeldefinition.msdyn_specialconsentlabel attribute content in UI.
  - **ChannelMessagePart.%partname%.DisplayName** - override for msdyn_channelmessagepart.msdyn_displayname attribute content in UI for the message part of the channel with name %partname%.
  - **ChannelMessagePart.%partname%.Description** - override for msdyn_channelmessagepart.msdyn_description description content in UI for the message part of the channel with name %partname%.

Channel definition locales are defined in **customizations.xml** as solution components. Place every **msdyn_channeldefinitionlocale** under **ImportExportXml** > **msdyn_channeldefinitionlocales** elements. Each message part element **msdyn_channeldefinitionlocale** must include its own unique ID in the form of the GUID as the XML attribute **msdyn_channeldefinitionlocaleid**.

Example of **customizations.xml** including channel definition locales:

```xml
<ImportExportXml xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"> 
 <msdyn_channeldefinitionlocales>
  <msdyn_channeldefinitionlocale msdyn_channeldefinitionlocaleid="d21815c7-5736-4a95-9b69-253b1e70c0a5">
    <msdyn_channeldefinitionid>e779b91e-02a0-4884-8cbe-f217835b42d9</msdyn_channeldefinitionid>
    <msdyn_localeid>1033</msdyn_localeid>
    <msdyn_localecontent>{
            "ChannelDefinition.DisplayName":  "Twilio",
            "ChannelDefinition.Description":  "Connect an existing Twilio account to send text messages",
            "ChannelDefinition.SpecialConsentLabel":  "To ensure that Twilio provider handle STOP commands properly, you must configure your consent settings with the provider directly.",
            "ChannelMessagePart.Text.DisplayName":  "Text",
            "ChannelMessagePart.Text.Description":  "Text part of SMS"}
    </msdyn_localecontent>
  </msdyn_channeldefinitionlocale>
</ImportExportXml>
```

## Next steps

[Define message editor interface](custom-sms-message-editor.md)
