---
title: "Use FetchXML query to filter records | MicrosoftDocs"
description: "This article discusses how to download the FetchXL query and edit it in the configuration management tool."
ms.date: 12/16/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.reviewer: nenellim
---

# Use FetchXML query to filter records

This article discusses how to download the FetchXL query and edit it in the configuration management tool.

## Generate FetchXML query using Advanced Find

1. Use Advanced find to create a personal view. More information: [Create and manage personal views on grid page](/power-apps/user/grid-filters-advanced) or [Create, edit, or save a view using legacy advanced find](/power-apps/user/advanced-find#create-edit-or-save-a-view-using-legacy-advanced-find)

1. [Select one or multiple records of the entity to export](/power-apps/user/advanced-find#share-a-personal-view). 

1. Select **Download FetchXML**.

1. Edit the XML as follows:

   1. Remove "output-format=xml-platform".

   2. Remove all attribute elements.

   3. Remove the order attribute element.

1. Save and close.

## Edit the FetchXML query in the configuration management tool

1. Open the Configuration Migration Tool and in the **Tools** menu, select **Configure Import Settings**.

1. Select **Edit FetchXML**. 
   :::image type="content" source="media/edit-fetchxml.png" alt-text="Screenshot of the Edit FetchXML button.":::

1. Enter your FetchXML filter in the text box, and select **OK**.


> [!div class="nextstepaction"]
> [Next step](export-import-config-data-for-records.md)

### See also

[Create a schema to export configuration data](/power-platform/admin/create-schema-export-configuration-data)  
[Export and import configuration for live chat](export-import-config-data-for-live-chat.md)  
