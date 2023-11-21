---
title: Use FetchXML query to filter records | MicrosoftDocs
description: This article discusses how to download the FetchXML query and edit it in the configuration management tool.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.date: 01/23/2023
ms.custom: bap-template
---

# Use FetchXML query to filter records

This article discusses how to download the FetchXL query and edit it in the Configuration Management tool.

## Generate FetchXML query

1. Use the **ADVANCED FIND** menu to create a personal view. More information: [Create, edit, or save a view using legacy advanced find](/power-apps/user/advanced-find#create-edit-or-save-a-view-using-legacy-advanced-find)

1. Select one or multiple records of the entity to export. More information: [Share a personal view](/power-apps/user/advanced-find#share-a-personal-view). 

1. Select **Download FetchXML**.

1. Edit the XML as follows:

   1. Remove "output-format=xml-platform".

   2. Remove all attribute elements.

   3. Remove the order attribute element.

1. Save and close.

## Edit the FetchXML query in the Configuration Management tool

1. Open the Configuration Migration tool and in the **Tools** menu, select **Configure Import Settings**.

1. Select **Edit FetchXML**. 
   :::image type="content" source="media/edit-fetchxml.png" alt-text="Screenshot of the Edit FetchXML button.":::

1. Enter your FetchXML query in the text box, and select **OK**.


## Next steps

[Migrate configuration data for records](migrate-config-data-for-records.md)  

### See also

[Create a schema to export configuration data](/power-platform/admin/create-schema-export-configuration-data)  
[Overview of data migration for records](migrate-config-data-for-records-overview.md)  
[Verify migration of records](migrate-config-data-verify.md)  
[Troubleshoot migration of records](migrate-config-data-troubleshoot.md)  
[Migrate configuration data for live chat](migrate-config-data-for-live-chat.md)  
[Migrate configuration data for voice channel](migrate-config-data-for-voice-channel.md)   
