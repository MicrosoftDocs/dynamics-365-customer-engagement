---
title: "Change custom entity icons in PowerApps | MicrosoftDocs"
definition: "Learn how to change the icon for a custom entity"
ms.custom: ""
ms.date: 05/17/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
  - "powerapps"
author: "Mattp123"
ms.assetid: 477f9792-8207-49ef-8968-45274b5355a8
caps.latest.revision: 19
ms.author: "matp"
manager: "kvivek"
tags: 
 - "Links to topic not migrated"
---
# Change icons for custom entities

When you create a custom entity, it is automatically assigned a default icon. All custom entities use the same icon by default. Use custom icons to differentiate how your custom entities look. You can’t modify the icons assigned to system entities.  
  
 You can upload three types of entity icons for each custom entity. 

> [!NOTE]
> The preferred type of file for all types is a scalable vector graphic (.svg) icon with transparency enabled. 
> 
> All icons must be no more than 10 kilobytes in size.

|Icon Type  |Description  |
|---------|---------|
|**Unified Interface Icon**|Must be a scalable vector graphic (.svg) icon |
|**Icon in Web application**|If not a scalable vector graphic (.svg) icon, it can be a .gif, .png, or .jpg format image, 16x16 pixels in size.|
|**Icon for entity form**s|If not a scalable vector graphic (.svg) icon, it can be a .gif, .png, or .jpg format image, 32x32 pixels in size.|

Each type of icon is stored as a Web Resource. You can create the web resources first and then set the icons to use them, or you can create the new web resource within the **Lookup Record** dialog by selecting **New** while setting the value. More information: [Create or edit web resources to extend an app](create-edit-web-resources.md)

## Set the icons for a custom entity.

You must use solution explorer to set entity icons.

### Navigate to the solution

1. From the PowerApps portal in Model-driven design mode select **Advanced** to open the **Common Data Services Default** solution.
1. Edit the URL, removing everything after `dynamics.com` and refresh the page.
1. In the **Settings** area select **Customization** > **Solutions**.
1. In the  view selector, choose **Unmanaged Solutions**.
1. Open the existing unmanaged solution that contains the entity you want to edit.
1. Select the entity to edit it.

### Set entity icons

1. On the command bar, select **Update Icons**.  
  
1. In the **Select New Icons** dialog box, in the **Web Client** tab, under **Icon in Web application** or **Icon for Entity Forms**, to the right of **New Icon**, select the **Browse** button ![Lookup button](media/lookup-button-4.gif).
2. Select or create the appropriate web resource, and then select **OK**. 
3. In the **Unified Interface** tab, do the same for the **New Icon** field.
4. Select **OK** to close the **Select New Icons** dialog
5. On the command bar, on the **File** menu, select **Save**.  
6. When your changes are complete, publish them. Select **Publish** in the command bar while the entity is selected in solution explorer.
  
## Community tools

**Iconator** is a tool that XrmToolbox community developed for Dynamics 365 Customer Engagement. Please see the [Developer tools for Common Data Service for Apps](../../developer/common-data-service/developer-tools.md) topic for community developed tools.

> [!NOTE]
> The community tools are not a product of Microsoft and does not extend support to the community tools. 
> If you have questions pertaining to the tool, please contact the publisher. More Information: [XrmToolBox](https://www.xrmtoolbox.com).

### See also  
[Create an entity](../common-data-service/create-entities.md)<br />
[Edit an entity](../common-data-service/edit-entities.md)
