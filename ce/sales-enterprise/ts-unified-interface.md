---
title: "Troubleshooting issues with Unified Interface (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with Unified Interface in Dynamics 365 Sales."
ms.date: 06/25/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
---

# Troubleshooting issues with Unified Interface

This article helps you troubleshoot and resolve issues related to Unified Interface.

<a name="read_only"> </a>
## Issue: Out-of-the-box or custom entities appear as read-only in Unified Interface apps

Some out-of-the-box and custom entities are appearing as read-only in the Sales Hub app (Unified Interface). However, these entities are editable in the legacy web client. Some out-of-the-box buttons are also unavailable on the forms in Unified Interface.

**Reason:**

This could happen when an entity is set to be read-only in Unified Client. 

**Resolution:**

To resolve this: 

1. On the navigation bar in your app, select the **Settings** icon and then select **Advanced Settings**.

    > [!div class="mx-imgBorder"]  
    >![Advanced Settings option on the Settings menu](media/advanced-settings-option.png "Advanced Settings option on the Settings menu")

    The **Business Management** page opens in a new browser tab.

2. On the navigation bar, select **Settings** and then select **Customizations**.

    > [!div class="mx-imgBorder"]  
    > ![Select Customizations](media/customization-in-sitemap.png "Select Customizations")
 
3. On the **Customization** page, select **Customize the System**.

4. In the solution explorer, under **Components**, expand **Entities** and then select the specific entity that's appearing as read-only.

5. On the **General** tab, under **Outlook & Mobile**, clear the **Read-only in Unified Client** check box.

    > [!div class="mx-imgBorder"]  
    > ![Setting to make an entity read-only in the Unified Client](media/read-only-in-unified-client-setting.png "Setting to make an entity read-only in Unified Client")
 
6. Save and publish the customizations.

7. In the Sales Hub app, refresh the window. 

All the out-of-the-box actions will be available and entities will be editable. 


### See also

[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]